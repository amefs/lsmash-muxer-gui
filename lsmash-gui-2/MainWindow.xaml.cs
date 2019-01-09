using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using MediaInfoLib;

namespace lsmash_gui_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private LsmashViewModel model;

        private static readonly HashSet<string> AcceptableVideoExtension = new HashSet<string> { ".avc", ".h264", ".264", ".hevc", ".265", ".mp4", ".vc1" };
        private static readonly HashSet<string> AcceptableAudioExtension = new HashSet<string> { ".aac", ".ac3", ".amr", ".dts", ".eac3", ".m4a", ".mp3", ".mp4" };

        public MainWindow()
        {
            InitializeComponent();

            model = new LsmashViewModel();
            DataContext = model;
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            StartBtn.IsEnabled = false;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = false;
            worker.WorkerReportsProgress = false;
            worker.DoWork += new DoWorkEventHandler(WorkerDoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerCompleted);

            worker.RunWorkerAsync();
        }

        private void UpdateLog(TextBlock tb, string text)
        {
            tb.Text = text;
        }

        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // System.Windows.MessageBox.Show("Work Finished!");
            StartBtn.IsEnabled = true;
        }

        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            bool vTrackFlag = false;
            bool aTrackFlag = false;
            bool vFPSFlag = false;
            bool vHandlerFlag = false;
            bool aHandlerFlag = false;
            bool aDelayFlag = false;
            bool vTrackMP4 = false;
            bool aTrackMP4 = Path.GetExtension(model.AudioPath)?.ToLower() == ".mp4";
            string argMuxer = "";
            string Excutable = "";
            string directory = "";
            string fileName = "";
            string vTrackMP4Path = "";
            string aTrackMP4Path = "";

            Action<TextBlock, string> logAct = new Action<TextBlock, string>(UpdateLog);
            if (string.IsNullOrEmpty(model.OutputPath))
            {
                System.Windows.MessageBox.Show("Output not set!");
                return;
            }

            if (!string.IsNullOrEmpty(model.VideoPath))
            {
                vTrackFlag = true;
                vTrackMP4 = Path.GetExtension(model.VideoPath)?.ToLower() == ".mp4";
            }
            if (!string.IsNullOrEmpty(model.AudioPath))
            {
                aTrackFlag = true;
                aTrackMP4 = Path.GetExtension(model.AudioPath)?.ToLower() == ".mp4";
            }

            if (!vTrackFlag)
            {
                System.Windows.MessageBox.Show("Input video not exist");
                return;
            }
            else
            {
                directory = Path.GetDirectoryName(model.VideoPath);
                fileName = Path.GetFileNameWithoutExtension(model.VideoPath);
                vTrackMP4Path = Path.Combine(directory, "_vTmp_" + fileName + ".mp4");
                // vTrack Mux
                if (!vTrackMP4)
                {
                    if (aTrackFlag)
                    {
                        directory = Path.GetDirectoryName(model.AudioPath);
                        fileName = Path.GetFileNameWithoutExtension(model.AudioPath);
                        aTrackMP4Path = Path.Combine(directory, "_aTmp_" + fileName + ".mp4");
                        if (!aTrackMP4)
                        {
                            // RAW Video with RAW Audio
                            argMuxer = " -i \"" + model.VideoPath + "\"";
                            // vtrack additions
                            // FPS
                            if (model.vTrackFPS != null)
                            {
                                argMuxer += "?fps=" + model.vTrackFPS;
                                vFPSFlag = true;
                            }
                            else vFPSFlag = false;
                            // vTrack Name
                            if (!string.IsNullOrEmpty(model.VideoTrackName))
                            {
                                if (vFPSFlag)
                                    argMuxer += ",handler=" + model.VideoTrackName;
                                else
                                    argMuxer += "?handler=" + model.VideoTrackName;
                                vHandlerFlag = true;
                            }
                            // vTrack PAR
                            if (!string.IsNullOrEmpty(model.PARDen) && !string.IsNullOrEmpty(model.PARNum))
                            {
                                if (vFPSFlag || vHandlerFlag)
                                    argMuxer += ",par=" + model.PARNum + ":" + model.PARDen;
                                else
                                    argMuxer += "?par=" + model.PARNum + ":" + model.PARDen;
                            }
                            argMuxer += " -i \"" + model.AudioPath + "\"";
                            // atrack additions
                            if (!string.IsNullOrEmpty(model.AudioTrackName))
                            {
                                argMuxer += "?handler=" + model.AudioTrackName;
                                aHandlerFlag = true;
                            }
                            if (!string.IsNullOrEmpty(model.LanguageCode))
                                if (aHandlerFlag)
                                {
                                    argMuxer += ",language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                                else
                                {
                                    argMuxer += "?language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                            if (model.AudioDelay != 0)
                                if (aHandlerFlag || aDelayFlag) argMuxer += ",encoder-delay=" + model.AudioDelay.ToString();
                                else argMuxer += "?encoder-delay=" + model.AudioDelay.ToString();
                            // chapter
                            if (!string.IsNullOrEmpty(model.ChapterPath)) argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                            // excute command
                            argMuxer += " -o \"" + model.OutputPath + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "muxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing RAW video with RAW audio....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing finished.");
                        }
                        else
                        {
                            // RAW Video with MP4 Audio
                            argMuxer = " -i \"" + model.VideoPath + "\"";
                            // vtrack additions
                            // FPS
                            if (model.vTrackFPS != null)
                            {
                                argMuxer += "?fps=" + model.vTrackFPS;
                                vFPSFlag = true;
                            }
                            else vFPSFlag = false;
                            // vTrack Name
                            if (!string.IsNullOrEmpty(model.VideoTrackName))
                            {
                                if (vFPSFlag)
                                    argMuxer += ",handler=" + model.VideoTrackName;
                                else
                                    argMuxer += "?handler=" + model.VideoTrackName;
                                vHandlerFlag = true;
                            }
                            // vTrack PAR
                            if (!string.IsNullOrEmpty(model.PARDen) && !string.IsNullOrEmpty(model.PARNum))
                            {
                                if (vFPSFlag || vHandlerFlag)
                                    argMuxer += ",par=" + model.PARNum + ":" + model.PARDen;
                                else
                                    argMuxer += "?par=" + model.PARNum + ":" + model.PARDen;
                            }
                            // excute command
                            argMuxer += " -o \"" + vTrackMP4Path + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "muxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing RAW video....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing finished.");

                            // Track Remux
                            argMuxer = " -i \"" + vTrackMP4Path + "\"";
                            // vtrack remux additions
                            // vTrack Name
                            argMuxer += " -i \"" + model.AudioPath + "\"";
                            argMuxer += model.comm.aParameter;
                            // aTrack Name
                            if (!string.IsNullOrEmpty(model.AudioTrackName)) argMuxer += "?" + model.comm.aTrackID + ":handler=" + model.AudioTrackName;
                            // aTrack Lang
                            if (!string.IsNullOrEmpty(model.LanguageCode))
                                if (aHandlerFlag)
                                {
                                    argMuxer += ",language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                                else
                                {
                                    argMuxer += "?" + model.comm.aTrackID + ":language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                            // chapter
                            if (!string.IsNullOrEmpty(model.ChapterPath))
                            {
                                argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                                argMuxer += " --chapter-track 10";
                            }
                            // excute command
                            argMuxer += " -o \"" + model.OutputPath + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "remuxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing video and audio....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing finished.");
                            System.IO.File.Delete(@vTrackMP4Path);
                        }
                    }
                    else
                    {
                        // RAW video mux only
                        argMuxer = " -i \"" + model.VideoPath + "\"";
                        // vtrack additions
                        // FPS
                        if (model.vTrackFPS != null)
                        {
                            argMuxer += "?fps=" + model.vTrackFPS;
                            vFPSFlag = true;
                        }
                        else vFPSFlag = false;
                        // vTrack Name
                        if (!string.IsNullOrEmpty(model.VideoTrackName))
                        {
                            if (vFPSFlag)
                                argMuxer += ",handler=" + model.VideoTrackName;
                            else
                                argMuxer += "?handler=" + model.VideoTrackName;
                            vHandlerFlag = true;
                        }
                        // vTrack PAR
                        if (!string.IsNullOrEmpty(model.PARDen) && !string.IsNullOrEmpty(model.PARNum))
                        {
                            if (vFPSFlag || vHandlerFlag)
                                argMuxer += ",par=" + model.PARNum + ":" + model.PARDen;
                            else
                                argMuxer += "?par=" + model.PARNum + ":" + model.PARDen;
                        }
                        // chapter
                        if (!string.IsNullOrEmpty(model.ChapterPath)) argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                        // excute command
                        argMuxer += " -o \"" + model.OutputPath + "\"";
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }));
                        Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "muxer.exe" + "\"";
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing RAW video....");
                        ExcuteDosCommand(Excutable + argMuxer);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing finished.");
                    }
                }
                else
                {
                    if (aTrackFlag)
                    {
                        directory = Path.GetDirectoryName(model.AudioPath);
                        fileName = Path.GetFileNameWithoutExtension(model.AudioPath);
                        aTrackMP4Path = Path.Combine(directory, "_aTmp_" + fileName + ".mp4");
                        if (!aTrackMP4)
                        {
                            // MP4 Video with RAW audio
                            argMuxer = " -i \"" + model.AudioPath + "\"";
                            // atrack additions
                            if (!string.IsNullOrEmpty(model.AudioTrackName))
                            {
                                argMuxer += "?handler=" + model.AudioTrackName;
                                aHandlerFlag = true;
                            }
                            if (!string.IsNullOrEmpty(model.LanguageCode))
                                if (aHandlerFlag)
                                {
                                    argMuxer += ",language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                                else
                                {
                                    argMuxer += "?language=" + model.LanguageCode;
                                    aDelayFlag = true;
                                }
                            if (model.AudioDelay != 0)
                                if (aHandlerFlag || aDelayFlag) argMuxer += ",encoder-delay=" + model.AudioDelay.ToString();
                                else argMuxer += "?encoder-delay=" + model.AudioDelay.ToString();
                            // excute command
                            argMuxer += " -o \"" + aTrackMP4Path + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "muxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing RAW aideo....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Muxing finished.");

                            // Track Remux
                            argMuxer = " -i \"" + model.VideoPath + "\"";
                            argMuxer += model.comm.vParameter;
                            // vTrack Name
                            if (!string.IsNullOrEmpty(model.VideoTrackName)) argMuxer += "?" + "1:handler=" + model.VideoTrackName;
                            // vtrack remux additions
                            // vTrack Name
                            argMuxer += " -i \"" + aTrackMP4Path + "\"";
                            // chapter
                            if (!string.IsNullOrEmpty(model.ChapterPath))
                            {
                                argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                                argMuxer += " --chapter-track 10";
                            }
                            // excute command
                            argMuxer += " -o \"" + model.OutputPath + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "remuxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing video and audio....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing finished.");
                            System.IO.File.Delete(@aTrackMP4Path);
                        }
                        else
                        {
                            // MP4 video and video
                            argMuxer = " -i \"" + model.VideoPath + "\"";
                            argMuxer += model.comm.vParameter;
                            // vTrack Name
                            if (!string.IsNullOrEmpty(model.VideoTrackName)) argMuxer += "?" + "1:handler=" + model.VideoTrackName;
                            // vtrack remux additions
                            // vTrack Name
                            argMuxer += " -i \"" + model.AudioPath + "\"";
                            argMuxer += model.comm.aParameter;
                            // aTrack Name
                            if (!string.IsNullOrEmpty(model.AudioTrackName))
                            {
                                argMuxer += "?" + model.comm.aTrackID + ":handler=" + model.AudioTrackName;
                                aHandlerFlag = true;
                            }
                            // aTrack Lang
                            if (!string.IsNullOrEmpty(model.LanguageCode))
                                if (aHandlerFlag) argMuxer += ",language=" + model.LanguageCode;
                                else argMuxer += "?" + model.comm.aTrackID + ":language=" + model.LanguageCode;
                            // chapter
                            if (!string.IsNullOrEmpty(model.ChapterPath))
                            {
                                argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                                argMuxer += " --chapter-track 10";
                            }
                            // excute command
                            argMuxer += " -o \"" + model.OutputPath + "\"";
                            Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "remuxer.exe" + "\"";
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                this.ProcessBar.Value = 0;
                                this.ProcessBar.IsIndeterminate = true;
                            }));
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing video and audio....");
                            ExcuteDosCommand(Excutable + argMuxer);
                            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing finished.");
                        }
                    }
                    else
                    {
                        // MP4 Video Track Remux
                        argMuxer = " -i \"" + model.VideoPath + "\"";
                        // chapter
                        if (!string.IsNullOrEmpty(model.ChapterPath))
                        {
                            argMuxer += " --chapter \"" + model.ChapterPath + "\"";
                            argMuxer += " --chapter-track 10";
                        }
                        // excute command
                        argMuxer += " -o \"" + model.OutputPath + "\"";
                        Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "remuxer.exe" + "\"";
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }));
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing video....");
                        ExcuteDosCommand(Excutable + argMuxer);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing finished.");
                    }
                }

                // timecode fix
                if (!string.IsNullOrEmpty(model.TimecodePath))
                {
                    directory = Path.GetDirectoryName(model.OutputPath);
                    fileName = Path.GetFileNameWithoutExtension(model.OutputPath);
                    string timecodeTmp = Path.Combine(directory, "_tcTmp_" + fileName + ".mp4");
                    System.IO.Directory.Move(model.OutputPath, timecodeTmp);
                    // check chapter
                    MediaInfo mi = new MediaInfo();
                    mi.Open(timecodeTmp);
                    bool existChapter = mi.Get(StreamKind.General, 0, "MenuCount") != "";
                    mi.Close();
                    if (existChapter)
                    {
                        string timecodeTmpAdd = Path.Combine(directory, "_noChTmp_" + fileName + ".mp4");
                        string chapterTmp = Path.Combine(directory, "_TmpChapter_" + fileName + ".txt");
                        // extract chapter
                        string boxdumperArgs = " --chapter \"" + timecodeTmp + "\" > \"" + chapterTmp + "\"";
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }), DispatcherPriority.Background);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "extract Chapter...");
                        ExcuteDosCommand("\"" + AppDomain.CurrentDomain.BaseDirectory + "boxdumper.exe\"" + boxdumperArgs);
                        string timecodeArgs = " --track 1 --timecode \"" + model.TimecodePath +
                                "\" \"" + timecodeTmp + "\" \"" + timecodeTmpAdd + "\"";
                        // excute timelineeditor
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }), DispatcherPriority.Background);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Editing Timecode...");
                        ExcuteDosCommand("\"" + AppDomain.CurrentDomain.BaseDirectory + "timelineeditor.exe\"" + timecodeArgs);
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }));
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Adding Chapter...");
                        // remux chapter
                        argMuxer = " -i \"" + timecodeTmpAdd + "\"";
                        argMuxer += " --chapter \"" + chapterTmp + "\"";
                        argMuxer += " --chapter-track 10";
                        argMuxer += " -o \"" + model.OutputPath + "\"";
                        Excutable = "\"" + AppDomain.CurrentDomain.BaseDirectory + "remuxer.exe" + "\"";
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }), DispatcherPriority.Background);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Reuxing video....");
                        ExcuteDosCommand(Excutable + argMuxer);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Timecode editing finished.");
                        System.IO.File.Delete(@chapterTmp);
                        System.IO.File.Delete(@timecodeTmpAdd);
                        System.IO.File.Delete(@timecodeTmp);
                    }
                    else
                    {
                        string timecodeArgs = " --track 1 --timecode \"" + model.TimecodePath +
                                "\" \"" + timecodeTmp + "\" \"" + model.OutputPath + "\"";
                        // excute command
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.Value = 0;
                            this.ProcessBar.IsIndeterminate = true;
                        }));
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Editing Timecode...");
                        ExcuteDosCommand("\"" + AppDomain.CurrentDomain.BaseDirectory + "timelineeditor.exe\"" + timecodeArgs);
                        LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "Timecode editing finished.");
                        System.IO.File.Delete(@timecodeTmp);
                    }
                }
            }

        }

        private void ExcuteDosCommand(string args)
        {
            try
            {
                Process p = new Process
                {
                    StartInfo =
                    {
                        FileName = Path.Combine(Environment.SystemDirectory, "cmd.exe"),
                        Arguments = "/c \"" + args + "\"",
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    }
                };
                p.OutputDataReceived += pOutputDataReceived;
                p.ErrorDataReceived += pOutputDataReceived;
                p.Start();
                p.BeginErrorReadLine();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }

            catch (Exception)
            {
                System.Windows.MessageBox.Show("Error, unknown command");
            }
        }

        private void pOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Action<TextBlock, string> logAct = new Action<TextBlock, string>(UpdateLog);
            string outputMsg = "";
            string processedByte = @"Importing:\s*([\d\.]+)\s*(bytes)*";
            double totalSize = model.comm.aSize + model.comm.vSize;
            double pBarValue = 0;
            if (!string.IsNullOrEmpty(e.Data))
            {
                outputMsg = e.Data;
                foreach (Match match in Regex.Matches(outputMsg, processedByte))
                {
                    if (!string.IsNullOrEmpty(match.Value))
                    {
                        pBarValue = Math.Min(Math.Ceiling((double)Convert.ToSingle(match.Groups[1].Value) / totalSize * 100), 100.00);
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.ProcessBar.IsIndeterminate = false;
                            this.ProcessBar.Value = pBarValue;
                        }), DispatcherPriority.Background);
                    }
                    //LogBox.Dispatcher.BeginInvoke(logAct, LogBox, match.Groups[1].Value);
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    this.LogBox.Text = outputMsg;
                }), DispatcherPriority.Send);
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Action<TextBlock, string> logAct = new Action<TextBlock, string>(UpdateLog);
            model = new LsmashViewModel();
            LogBox.Dispatcher.BeginInvoke(logAct, LogBox, "");
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.ProcessBar.Value = 0;
            }));
            DataContext = model;
        }

        private void VideoFileBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "All Support Video Files|*.264;*.h264;*.avc;*.265;*.hevc;*.mp4;*.vc1|RAW MPEG-4 AVC|*.264;*.h264;*.avc|RAW MPEG-4 HEVC|*.265;*.hevc|RAW VC-1|*.vc1|MP4 File|*.mp4|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                if (!model.OpenVideoFile(ofd.FileName))
                {
                    System.Windows.MessageBox.Show("Not a Video File!");
                }
            }
        }

        private void ClearVNameBtn_Click(object sender, RoutedEventArgs e)
        {
            model.VideoTrackName = string.Empty;
        }

        private void AudioFileBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "All Support Audio Files|*.aac;*.ac3;*.amr;*.dts;*.eac3;*.m4a;*.mp3;*.mp4|AAC|*.aac;*.m4a|AC3|*.ac3;*.eac3|AMR|*.amr|DTS|*.dts|MP3|*.mp3|MP4 File|*.mp4|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                if (!model.OpenAudioFile(ofd.FileName))
                {
                    System.Windows.MessageBox.Show("Not a Audio File!");
                }
            }
        }

        private void ClearANameBtn_Click(object sender, RoutedEventArgs e)
        {
            model.AudioTrackName = string.Empty;
        }

        private void ChapterFileBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "Chapter File|*.txt|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                model.ChapterPath = ofd.FileName;
            }
        }

        private void TimecodeFileBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "Timecode File|*.txt|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                model.TimecodePath = ofd.FileName;
            }
        }

        private void OutputFileBtn_Click(object sender, RoutedEventArgs e)
        {
            //save file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Muxed File|*.mp4|All Files|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FilterIndex = 1;
            if (model.OutputPath != "")
            {
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(model.OutputPath);
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(model.OutputPath);
            }
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                model.OutputPath = saveFileDialog1.FileName;
            }
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            //about
            System.Windows.MessageBox.Show("L-SMASH Muxer GUI 2\n\nThis is a GUI which use l-smash to mux video and audio");
        }

        private string IsSingleFile(System.Windows.DragEventArgs args)
        {
            if (args.Data.GetDataPresent(System.Windows.DataFormats.FileDrop, true))
            {
                string[] fileNames = args.Data.GetData(System.Windows.DataFormats.FileDrop, true) as string[];
                if (fileNames.Length == 1)
                {
                    if (File.Exists(fileNames[0]))
                    {
                        return fileNames[0];
                    }
                }
            }
            return null;
        }

        private void TextBox_PreviewDragOver(object sender, System.Windows.DragEventArgs e)
        {
            if (IsSingleFile(e) != null)
            {
                e.Effects = System.Windows.DragDropEffects.Copy;
                e.Handled = true;
            }
        }

        private void VideoPath_PreviewDrop(object sender, System.Windows.DragEventArgs e)
        {
            e.Handled = true;

            string fileName = IsSingleFile(e);
            if (fileName == null)
            {
                return;
            }

            if (!AcceptableVideoExtension.Contains(Path.GetExtension(fileName)?.ToLower()))
            {
                return;
            }

            if (!model.OpenVideoFile(fileName))
            {
                System.Windows.MessageBox.Show("Not a Video File!");
            }
        }

        private void AudioPath_PreviewDrop(object sender, System.Windows.DragEventArgs e)
        {
            e.Handled = true;

            string fileName = IsSingleFile(e);
            if (fileName == null)
            {
                return;
            }

            if (!AcceptableAudioExtension.Contains(Path.GetExtension(fileName)?.ToLower()))
            {
                return;
            }

            if (!model.OpenAudioFile(fileName))
            {
                System.Windows.MessageBox.Show("Not a Audio File!");
            }
        }

        private void ChapterPath_PreviewDrop(object sender, System.Windows.DragEventArgs e)
        {
            e.Handled = true;

            string fileName = IsSingleFile(e);
            if (fileName == null)
            {
                return;
            }

            if (Path.GetExtension(fileName).ToLower() == (".txt"))
            {
                model.ChapterPath = fileName;
            }
            else
            {
                System.Windows.MessageBox.Show("Unsupport Format!");
            }
        }

        private void TimecodePath_PreviewDrop(object sender, System.Windows.DragEventArgs e)
        {
            e.Handled = true;

            string fileName = IsSingleFile(e);
            if (fileName == null)
            {
                return;
            }

            if (Path.GetExtension(fileName).ToLower() == (".txt"))
            {
                model.TimecodePath = fileName;
            }
            else
            {
                System.Windows.MessageBox.Show("Unsupport Format!");
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);
        }

        private void NumberValidationPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                Regex reg = new Regex("[^0-9]+");
                if (reg.IsMatch(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void IncButton_Click(object sender, RoutedEventArgs e)
        {
            model.AudioDelay++;
        }

        private void DecButton_Click(object sender, RoutedEventArgs e)
        {
            model.AudioDelay--;
        }
    }
}
