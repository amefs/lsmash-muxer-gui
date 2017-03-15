using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using MediaInfoLib;


namespace lsmash_gui
{


    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            //about
            MessageBox.Show("L-SMASH Muxer GUI\n\nThis is a GUI which use l-smash to mux video and audio");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private static string GetOutputFileName(string fullPath)
        {
            string directory = Path.GetDirectoryName(fullPath) ?? "";
            string fileName = Path.GetFileNameWithoutExtension(fullPath) ?? "";
            string path = Path.Combine(directory, fileName + "_muxed" + ".mp4");
            int index = 1;
            while (File.Exists(path))
            {
                path = Path.Combine(directory, fileName + "_muxed" + $"_{index++}.mp4");
            }
            return path;
        }

        private void openvideo_Click(object sender, EventArgs e)
        {
            //open video file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "RAW MPEG-4 AVC|*.264;*.h264;*.avc|RAW MPEG-4 HEVC|*.265;*.hevc|MP4 File|*.mp4|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Videopath.Text = openFileDialog1.FileName;
                bool mediainfo = false;
                mediainfo = File.Exists(Application.StartupPath + "\\MediaInfo.dll");
                if (mediainfo)
                {
                    lsmash_gui.comm.vparameter = "";
                    bool ifmp4 = Path.GetExtension(Videopath.Text)?.ToLower() == ".mp4";
                    MediaInfo vfile = new MediaInfo();
                    vfile.Open(Videopath.Text);
                    int vtracksum = 0;
                    int atracksum = 0;
                    if (ifmp4)
                    {
                        if (vfile.Get(StreamKind.General, 0, "VideoCount") != "")
                            vtracksum = (int)Convert.ToSingle(vfile.Get(StreamKind.General, 0, "VideoCount"));
                        if (vfile.Get(StreamKind.General, 0, "AudioCount") != "")
                            atracksum = (int)Convert.ToSingle(vfile.Get(StreamKind.General, 0, "AudioCount"));
                        if (vtracksum > 1)
                            for (int i = 1; i < vtracksum; i++)
                            {
                                lsmash_gui.comm.vparameter += ("?" + vfile.Get(StreamKind.Video, i, "ID") + ":remove");
                            }
                        if (atracksum > 0)
                            for (int i = 0; i < atracksum; i++)
                            {
                                lsmash_gui.comm.vparameter += ("?" + vfile.Get(StreamKind.Audio, i, "ID") + ":remove");
                            }
                        if (vtracksum == 0)
                        {
                            Videopath.Text = "";
                            MessageBox.Show("Not a Video File!");
                        }
                    }
                    if (vtracksum != 0 || !ifmp4)
                    {
                        string FPS = vfile.Get(StreamKind.Video, 0, "FrameRate_Num") + "/" + vfile.Get(StreamKind.Video, 0, "FrameRate_Den");
                        if (FPS == "/")
                            FPS = (((int)Convert.ToSingle(vfile.Get(StreamKind.Video, 0, "FrameRate")) * 1000).ToString() + "/" + "1000");
                        FPS_Value.SelectedItem = FPS;
                    }
                    vfile.Close();
                }
                outputpath.Text = GetOutputFileName(openFileDialog1.FileName);
            }
        }
        private static readonly HashSet<string> AcceptableVideoExtension = new HashSet<string> { ".avc", ".h264", ".264", ".hevc", ".265", ".mp4" };

        private void Videopath_DragDrop(object sender, DragEventArgs e)
        {
            //drag video file and confirm format
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            //confirm if path is a directort
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (System.IO.Directory.Exists(path))
            {
                MessageBox.Show("Not a File!");
            }
            else
            {
                if (AcceptableVideoExtension.Contains(Path.GetExtension(fileName)?.ToLower()))
                {
                    Videopath.Text = fileName;
                    bool mediainfo = false;
                    mediainfo = File.Exists(Application.StartupPath + "\\MediaInfo.dll");
                    if (mediainfo)
                    {
                        lsmash_gui.comm.vparameter = "";
                        bool ifmp4 = Path.GetExtension(Videopath.Text)?.ToLower() == ".mp4";
                        MediaInfo vfile = new MediaInfo();
                        vfile.Open(Videopath.Text);
                        int vtracksum = 0;
                        int atracksum = 0;
                        if (ifmp4)
                        {
                            if (vfile.Get(StreamKind.General, 0, "VideoCount") != "")
                                vtracksum = (int)Convert.ToSingle(vfile.Get(StreamKind.General, 0, "VideoCount"));
                            if (vfile.Get(StreamKind.General, 0, "AudioCount") != "")
                                atracksum = (int)Convert.ToSingle(vfile.Get(StreamKind.General, 0, "AudioCount"));
                            if (vtracksum > 1)
                                for (int i = 1; i < vtracksum; i++)
                                {
                                    lsmash_gui.comm.vparameter += ("?" + vfile.Get(StreamKind.Video, i, "ID") + ":remove");
                                }
                            if (atracksum > 0)
                                for (int i = 0; i < atracksum; i++)
                                {
                                    lsmash_gui.comm.vparameter += ("?" + vfile.Get(StreamKind.Audio, i, "ID") + ":remove");
                                }
                            if (vtracksum == 0)
                            {
                                Videopath.Text = "";
                                MessageBox.Show("Not a Video File!");
                            }
                        }
                        if (vtracksum != 0 || !ifmp4)
                        {
                            string FPS = vfile.Get(StreamKind.Video, 0, "FrameRate_Num") + "/" + vfile.Get(StreamKind.Video, 0, "FrameRate_Den");
                            if (FPS == "/")
                                FPS = (((int)Convert.ToSingle(vfile.Get(StreamKind.Video, 0, "FrameRate")) * 1000).ToString() + "/" + "1000");
                            FPS_Value.SelectedItem = FPS;
                        }
                        vfile.Close();
                    }
                    outputpath.Text = GetOutputFileName(fileName);
                }
                else
                {
                    MessageBox.Show("Unsupport Format!");
                }
            }
        }

        private void FPS_Value_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vtrack_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_vtrack_name_Click(object sender, EventArgs e)
        {
            Videopath.Clear();
            vtrack_name.Clear();
            FPS_Value.SelectedItem = null;
        }

        private static readonly HashSet<string> AcceptableAudioExtension = new HashSet<string> { ".aac", ".m4a", ".mp3", ".mp4" };
        private void Audiopath_DragDrop(object sender, DragEventArgs e)
        {
            //drag video file and confirm format
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            //confirm if path is a directort
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (System.IO.Directory.Exists(path))
            {
                MessageBox.Show("Not a File!");
            }
            else
            {
                if (AcceptableAudioExtension.Contains(Path.GetExtension(fileName)?.ToLower()))
                {
                    Audiopath.Text = fileName;
                    lsmash_gui.comm.aparameter = "";
                    bool ifmp4 = Path.GetExtension(Audiopath.Text)?.ToLower() == ".mp4";
                    if (ifmp4)
                    {
                        MediaInfo afile = new MediaInfo();
                        afile.Open(Audiopath.Text);
                        int vtracksum = 0;
                        int atracksum = 0;
                        if (afile.Get(StreamKind.General, 0, "VideoCount") != "")
                            vtracksum = (int)Convert.ToSingle(afile.Get(StreamKind.General, 0, "VideoCount"));
                        if (afile.Get(StreamKind.General, 0, "AudioCount") != "")
                            atracksum = (int)Convert.ToSingle(afile.Get(StreamKind.General, 0, "AudioCount"));
                        lsmash_gui.comm.atrackID = afile.Get(StreamKind.Audio, 0, "ID");
                        if (atracksum > 1)
                            for (int i = 1; i < atracksum; i++)
                            {
                                lsmash_gui.comm.aparameter += ("?" + afile.Get(StreamKind.Audio, i, "ID") + ":remove");
                            }
                        if (vtracksum > 0)
                            for (int i = 0; i < vtracksum; i++)
                            {
                                lsmash_gui.comm.aparameter += ("?" + afile.Get(StreamKind.Video, i, "ID") + ":remove");
                            }
                        if (atracksum == 0)
                        {
                            Audiopath.Text = "";
                            MessageBox.Show("Not a Audio File!");
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Unsupport Format!");
                }
            }
        }

        private void openaudio_Click(object sender, EventArgs e)
        {
            //open audio file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "AAC|*.aac;*.m4a|MP3|*.mp3|MP4 File|*.mp4|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Audiopath.Text = openFileDialog1.FileName;
                lsmash_gui.comm.aparameter = "";
                bool ifmp4 = Path.GetExtension(Audiopath.Text)?.ToLower() == ".mp4";
                if (ifmp4)
                {
                    MediaInfo afile = new MediaInfo();
                    afile.Open(Audiopath.Text);
                    int vtracksum = 0;
                    int atracksum = 0;
                    if (afile.Get(StreamKind.General, 0, "VideoCount") != "")
                        vtracksum = (int)Convert.ToSingle(afile.Get(StreamKind.General, 0, "VideoCount"));
                    if (afile.Get(StreamKind.General, 0, "AudioCount") != "")
                        atracksum = (int)Convert.ToSingle(afile.Get(StreamKind.General, 0, "AudioCount"));
                    lsmash_gui.comm.atrackID = afile.Get(StreamKind.Audio, 0, "ID");
                    if (atracksum > 1)
                        for (int i = 1; i < atracksum; i++)
                        {
                            lsmash_gui.comm.aparameter += ("?" + afile.Get(StreamKind.Audio, i, "ID") + ":remove");
                        }
                    if (vtracksum > 0)
                        for (int i = 0; i < vtracksum; i++)
                        {
                            lsmash_gui.comm.aparameter += ("?" + afile.Get(StreamKind.Video, i, "ID") + ":remove");
                        }
                    if (atracksum == 0)
                    {
                        Audiopath.Text = "";
                        MessageBox.Show("Not a Audio File!");
                    }
                }
            }
        }

        private void Clear_atrack_name_Click(object sender, EventArgs e)
        {
            Audiopath.Clear();
            atrack_name.Clear();
            Lang_Value.SelectedItem = null;
            ADelay_Value.Value = 0;
        }

        private void Chapterpath_DragDrop(object sender, DragEventArgs e)
        {
            //drag chapter file and confirm format
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            //confirm if path is a directort
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (System.IO.Directory.Exists(path))
            {
                MessageBox.Show("Not a File!");
            }
            else
            {
                if (Path.GetExtension(fileName).ToLower() == (".txt"))
                {
                    Chapterpath.Text = fileName;
                }
                else
                {
                    MessageBox.Show("Unsupport Format!");
                }
            }
        }

        private void openchapter_Click(object sender, EventArgs e)
        {
            //open chapter file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Chapter File|*.txt|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Chapterpath.Text = openFileDialog1.FileName;

            }
        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void outputpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectpath_Click(object sender, EventArgs e)
        {
            //save file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Muxed File|*.mp4|All Files|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FilterIndex = 1;
            if (outputpath.Text != "")
            {
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(outputpath.Text);
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(outputpath.Text);
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputpath.Text = saveFileDialog1.FileName;

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            bool vtrack_flag = false;
            bool atrack_flag = false;
            bool vfps_flag = false;
            bool vhandler_flag = false;
            bool ifvmp4 = Path.GetExtension(Videopath.Text)?.ToLower() == ".mp4";
            bool ifamp4 = Path.GetExtension(Audiopath.Text)?.ToLower() == ".mp4";
            bool ifmp4 = ifvmp4 || ifamp4;
            string arg_muxer = "";
            if (outputpath.Text == "")
            {
                MessageBox.Show("Output not set!");
            }
            else
            {
                arg_muxer = ("");
                //main tracks
                if (Chapterpath.Text != "")
                {
                    arg_muxer = (arg_muxer + " --chapter \"" + Chapterpath.Text + "\"");
                    if (ifmp4)
                        arg_muxer = (arg_muxer + " --chapter-track 10");
                }
                if (Videopath.Text != "")
                {
                    arg_muxer = (arg_muxer + " -i \"" + Videopath.Text + "\"");
                    vtrack_flag = true;
                }
                //remove extra tracks
                if (vtrack_flag && ifmp4)
                {
                    arg_muxer = (arg_muxer + lsmash_gui.comm.vparameter);
                }
                //video track additions
                if (vtrack_flag && FPS_Value.SelectedItem != null && !ifmp4)
                {
                    arg_muxer = (arg_muxer + "?fps=" + FPS_Value.SelectedItem);
                    vfps_flag = true;
                }
                if (vtrack_flag && vtrack_name.Text != "")
                {
                    if (vfps_flag == true)
                        arg_muxer = (arg_muxer + ",handler=" + vtrack_name.Text);
                    else if (ifmp4)
                        arg_muxer = (arg_muxer + "?1:handler=" + vtrack_name.Text);
                    else
                        arg_muxer = (arg_muxer + "?handler=" + vtrack_name.Text);
                    vhandler_flag = true;
                }
                if (vtrack_flag && PAR_denominator.Text != "" && PAR_numerator.Text !="" && !ifmp4)
                {
                    if (vfps_flag == true || vhandler_flag == true)
                        arg_muxer = (arg_muxer + ",par=" + PAR_numerator.Text + ":" + PAR_denominator.Text);
                    else
                        arg_muxer = (arg_muxer + "?par=" + PAR_numerator.Text + ":" + PAR_denominator.Text);
                }
                if (Audiopath.Text != "")
                {
                    arg_muxer = (arg_muxer + " -i \"" + Audiopath.Text + "\"");
                    atrack_flag = true;
                }
                //remove extra tracks
                if (vtrack_flag && ifmp4)
                {
                    arg_muxer = (arg_muxer + lsmash_gui.comm.aparameter);
                }
                //audio track additions
                if (atrack_flag && Lang_Value.SelectedItem != null)
                {
                    if (ifamp4)
                        arg_muxer = (arg_muxer + "?" + lsmash_gui.comm.atrackID + ":language=" + Lang_Value.SelectedItem);
                    else
                        arg_muxer = (arg_muxer + "?1:language=" + Lang_Value.SelectedItem);
                }
                if (atrack_flag && atrack_name.Text != "")
                {
                    arg_muxer = (arg_muxer + ",handler=" + atrack_name.Text);
                }
                if (atrack_flag && ADelay_Value.Value != 0 && !ifmp4)
                {
                    arg_muxer = (arg_muxer + ",encoder-delay=" + ADelay_Value.Value.ToString());
                }
                //output
                if (vtrack_flag || atrack_flag)
                {
                    if (!ifvmp4 && ifamp4)
                        MessageBox.Show("Can't remux RAW Video with mp4 Audio File!");
                    else
                    {
                        arg_muxer = (arg_muxer + " -o \"" + outputpath.Text + "\"");
                        logs.Text = ("Processing....");
                        //logs.Text += ("\n\r" + arg_muxer);
                        Start.Enabled = false;
                        ExcuteDosCommand(arg_muxer);
                        Start.Enabled = true;
                        logs.Text = ("Finished.");
                    }
                }
                else
                    MessageBox.Show("Nothing to mux!");
            }

        }

        private void Lang_Value_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADelay_Value_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ExcuteDosCommand(string cmd)
        {
            bool ifmp4 = Path.GetExtension(Videopath.Text)?.ToLower() == ".mp4";
            string Excutable = "";
            if (ifmp4)
                Excutable = "remuxer";
            else
                Excutable = "muxer";
            logs.Text += ("\r\n\"" + Application.StartupPath + "\\" + Excutable + "\"" + cmd);
            try
            {
                Process p = new Process
                {
                    StartInfo =
                    {
                        FileName = Application.StartupPath + "\\"+ Excutable,
                        Arguments = cmd,
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    }
                };
                p.OutputDataReceived += sortProcess_OutputDataReceived;
                p.ErrorDataReceived += sortProcess_OutputDataReceived;
                p.Start();
                p.BeginErrorReadLine();
                p.BeginOutputReadLine();
                p.WaitForExit();
                p.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Mission failed Please Check the Command！");
            }
        }
        private void sortProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            StringBuilder outputBuilder;
            outputBuilder = new StringBuilder();
            if (!String.IsNullOrEmpty(e.Data))
            {
                //this.BeginInvoke(new Action(() => { this.logs.Text= e.Data; }));
                //logs.Text = e.Data;
                //outputBuilder.Append(e.Data);
                //logs.Text += "\r" + outputBuilder.ToString();
            }
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
            Videopath.Clear();
            Audiopath.Clear();
            Chapterpath.Clear();
            outputpath.Clear();
            vtrack_name.Clear();
            atrack_name.Clear();
            FPS_Value.SelectedItem = null;
            Lang_Value.SelectedItem = null;
            ADelay_Value.Value = 0;
            logs.Text = "";
        }

        private void PAR_numerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;
                }
            }
        }

        private void PAR_denominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;
                }
            }
        }
    }
    public static class comm
    {
        public static string vparameter;
        public static string vtrackID;
        public static string aparameter;
        public static string atrackID;
    }
}
