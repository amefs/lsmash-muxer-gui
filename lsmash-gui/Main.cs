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
                Filter = "RAW MPEG-4 AVC|*.264;*.h264;*.avc|RAW MPEG-4 HEVC|*.265;*.hevc|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Videopath.Text = openFileDialog1.FileName;
                MediaInfo vfile = new MediaInfo();
                vfile.Open(Videopath.Text);
                string FPS = vfile.Get(StreamKind.Video, 0, "FrameRate_Num") + "/" + vfile.Get(StreamKind.Video, 0, "FrameRate_Den");
                if (FPS =="/")
                    FPS = (((int)Convert.ToSingle(vfile.Get(StreamKind.Video, 0, "FrameRate"))*1000).ToString() + "/" + "1000");
                vfile.Close();
                FPS_Value.SelectedItem = FPS;
                outputpath.Text = GetOutputFileName(openFileDialog1.FileName);
            }
        }

        private static readonly HashSet<string> AcceptableVideoExtension = new HashSet<string> { ".avc", ".h264", ".264", ".hevc", ".265" };

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
                    MediaInfo vfile = new MediaInfo();
                    vfile.Open(Videopath.Text);
                    string FPS = vfile.Get(StreamKind.Video, 0, "FrameRate_Num") + "/" + vfile.Get(StreamKind.Video, 0, "FrameRate_Den");
                    if (FPS == "/")
                        FPS = (((int)Convert.ToSingle(vfile.Get(StreamKind.Video, 0, "FrameRate")) * 1000).ToString() + "/" + "1000");
                    vfile.Close();
                    FPS_Value.SelectedItem = FPS;
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

        private static readonly HashSet<string> AcceptableAudioExtension = new HashSet<string> { ".aac", ".m4a", ".mp3" };
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
                Filter = "AAC|*.aac;*.m4a|mp3|*.mp3|All Files|*.*",
                RestoreDirectory = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Audiopath.Text = openFileDialog1.FileName;
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
                    arg_muxer = (arg_muxer + " --chapter \"" + Chapterpath.Text + "\"");
                if (Videopath.Text != "")
                {
                    arg_muxer = (arg_muxer + " -i \"" + Videopath.Text + "\"");
                    vtrack_flag = true;
                }
                //video track additions
                if (vtrack_flag && FPS_Value.SelectedItem != null)
                {
                    arg_muxer = (arg_muxer + "?1:fps=" + FPS_Value.SelectedItem);
                    vfps_flag = true;
                }
                if (vtrack_flag && vtrack_name.Text != "")
                {
                    if (vfps_flag == true)
                        arg_muxer = (arg_muxer + ",handler=" + vtrack_name.Text);
                    else
                        arg_muxer = (arg_muxer + "?1:handler=" + vtrack_name.Text);
                }
                if (Audiopath.Text != "")
                {
                    arg_muxer = (arg_muxer + " -i \"" + Audiopath.Text + "\"");
                    atrack_flag = true;
                }
                //audio track additions
                if (atrack_flag && Lang_Value.SelectedItem != null)
                {
                    arg_muxer = (arg_muxer + "?1:language=" + Lang_Value.SelectedItem);
                }
                else if (atrack_flag)
                {
                    arg_muxer = (arg_muxer + "?1:language=jpn");
                }
                if (atrack_flag && atrack_name.Text != "")
                {
                    arg_muxer = (arg_muxer + ",handler=" + atrack_name.Text);
                }
                if (atrack_flag && ADelay_Value.Value != 0)
                {
                    arg_muxer = (arg_muxer + ",encoder-delay=" + ADelay_Value.Value.ToString());
                }
                //output
                if (vtrack_flag || atrack_flag)
                {
                    arg_muxer = (arg_muxer + " -o \"" + outputpath.Text + "\"");
                    //logs.Text = arg_muxer;
                    logs.Text = ("Processing....");
                    ExcuteDosCommand(arg_muxer);
                    logs.Text = ("Finished.");
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
            try
            {
                Process p = new Process
                {
                    StartInfo =
                    {
                        FileName = Application.StartupPath + "\\muxer.exe",
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
                MessageBox.Show("执行命令失败，请检查输入的命令是否正确！");
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
    }
}
