using System;
using System.ComponentModel;
using System.IO;
using MediaInfoLib;

namespace lsmash_gui_2
{
    public partial class LsmashViewModel : INotifyPropertyChanged
    {
        private string videoPath;

        public string VideoPath
        {
            get { return videoPath; }
            set {
                videoPath = value;
                OnPropertyChanged("VideoPath");

                if (string.IsNullOrEmpty(videoPath))
                {
                    outputPath = string.Empty;
                }
                else
                {
                        OutputPath = GetOutputFileName(videoPath);
                }
            }
        }

        private string audioPath;

        public string AudioPath
        {
            get { return audioPath; }
            set {
                audioPath = value;
                OnPropertyChanged("AudioPath");
                OutputPath = GetOutputFileName(videoPath);
            }
        }

        private string chapterPath;

        public string ChapterPath
        {
            get { return chapterPath; }
            set {
                chapterPath = value;
                OnPropertyChanged("ChapterPath");
                OutputPath = GetOutputFileName(videoPath);
            }
        }

        private string timecodePath;
        public bool timecodeMode = false;

        public string TimecodePath
        {
            get { return timecodePath; }
            set {
                timecodePath = value;
                OnPropertyChanged("TimecodePath");

                if (!string.IsNullOrEmpty(VideoPath))
                {
                    timecodeMode = true;
                    OutputPath = GetOutputFileName(videoPath, "tcfix");
                }
            }
        }

        private string outputPath;

        public string OutputPath
        {
            get { return outputPath; }
            set {
                outputPath = value;
                OnPropertyChanged("OutputPath");
            }
        }

        private string videoTrackName;

        public string VideoTrackName
        {
            get { return videoTrackName; }
            set {
                videoTrackName = value;
                OnPropertyChanged("VideoTrackName");
            }
        }

        private string audioTrackName;

        public string AudioTrackName
        {
            get { return audioTrackName; }
            set {
                audioTrackName = value;
                OnPropertyChanged("AudioTrackName");
            }
        }

        private string fps;

        public string vTrackFPS
        {
            get { return fps; }
            set {
                fps = value;
                OnPropertyChanged("vTrackFPS");
            }
        }

        private string parNum, parDen;

        public string PARNum
        {
            get { return parNum; }
            set {
                parNum = value;
                OnPropertyChanged("PARNum");
            }
        }

        public string PARDen
        {
            get { return parDen; }
            set {
                parDen = value;
                OnPropertyChanged("PARDen");
            }
        }

        public string audioDelayStr;

        public string AudioDelayStr
        {
            get { return audioDelayStr; }
            set {
                audioDelayStr = value;
                OnPropertyChanged("AudioDelayStr");
            }
        }

        public int AudioDelay
        {
            get {
                int delay;
                if (int.TryParse(AudioDelayStr, out delay))
                {
                    return delay;
                }

                return 0;
            }

            set {
                AudioDelayStr = value.ToString();
            }
        }

        public string langCode;

        public string LanguageCode
        {
            get { return langCode; }
            set {
                langCode = value;
                OnPropertyChanged("LanguageCode");
            }
        }

        private static string GetOutputFileName(string fullPath, string postfix = "muxed")
        {
            string directory = Path.GetDirectoryName(fullPath) ?? "";
            string fileName = Path.GetFileNameWithoutExtension(fullPath) ?? "";
            string path = Path.Combine(directory, fileName + "_" + postfix + ".mp4");
            int index = 1;
            while (File.Exists(path))
            {
                path = Path.Combine(directory, fileName + "_" + postfix + $"_{index++}.mp4");
            }
            return path;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void OnAllPropertyChanged() => OnPropertyChanged(null);

        public struct param
        {
            public string vParameter;
            public string vTrackID;
            public string aParameter;
            public string aTrackID;
            public ulong vSize;
            public ulong aSize;
        }

        public param comm;

        private bool enableMi = false;

        public LsmashViewModel()
        {
            enableMi = File.Exists(".\\MediaInfo.dll");
        }

        public bool OpenAudioFile(string fileName)
        {
            if (enableMi)
            {
                MediaInfo mi = new MediaInfo();
                mi.Open(fileName);
                int vTrackSum = 0;
                int aTrackSum = 0;
                if (mi.Get(StreamKind.General, 0, "VideoCount") != "")
                    vTrackSum = (int)Convert.ToSingle(mi.Get(StreamKind.General, 0, "VideoCount"));
                if (mi.Get(StreamKind.General, 0, "AudioCount") != "")
                    aTrackSum = (int)Convert.ToSingle(mi.Get(StreamKind.General, 0, "AudioCount"));
                this.comm.aTrackID = mi.Get(StreamKind.Audio, 0, "ID");
                if (mi.Get(StreamKind.Audio, 0, "StreamSize") != "")
                    this.comm.aSize = (ulong)Convert.ToSingle(mi.Get(StreamKind.Audio, 0, "StreamSize"));
                else
                    this.comm.aSize = (ulong)Convert.ToSingle(mi.Get(StreamKind.General, 0, "FileSize"));
                if (aTrackSum > 1)
                {
                    for (int i = 1; i < aTrackSum; i++)
                    {
                        this.comm.aParameter += ("?" + mi.Get(StreamKind.Audio, i, "ID") + ":remove");
                    }
                }

                if (vTrackSum > 0)
                {
                    for (int i = 0; i < vTrackSum; i++)
                    {
                        this.comm.aParameter += ("?" + mi.Get(StreamKind.Video, i, "ID") + ":remove");
                    }
                }

                mi.Close();

                if (aTrackSum == 0)
                {
                    this.AudioPath = string.Empty;
                    return false;
                }
            }

            this.AudioPath = fileName;
            return true;
        }

        public bool OpenVideoFile(string fileName)
        {
            if (enableMi)
            {
                MediaInfo mi = new MediaInfo();
                mi.Open(fileName);

                int vTrackSum = 0;
                int aTrackSum = 0;

                if (mi.Get(StreamKind.General, 0, "VideoCount") != "")
                    vTrackSum = (int)Convert.ToSingle(mi.Get(StreamKind.General, 0, "VideoCount"));
                if (mi.Get(StreamKind.General, 0, "AudioCount") != "")
                    aTrackSum = (int)Convert.ToSingle(mi.Get(StreamKind.General, 0, "AudioCount"));
                if (mi.Get(StreamKind.Video, 0, "StreamSize") != "")
                    this.comm.vSize = (ulong)Convert.ToSingle(mi.Get(StreamKind.Video, 0, "StreamSize"));
                else
                    this.comm.vSize = (ulong)Convert.ToSingle(mi.Get(StreamKind.General, 0, "FileSize"));
                if (vTrackSum > 1)
                    for (int i = 1; i < vTrackSum; i++)
                    {
                        this.comm.vParameter += ("?" + mi.Get(StreamKind.Video, i, "ID") + ":remove");
                    }
                if (aTrackSum > 0)
                    for (int i = 0; i < aTrackSum; i++)
                    {
                        this.comm.vParameter += ("?" + mi.Get(StreamKind.Audio, i, "ID") + ":remove");
                    }
                if (vTrackSum == 0)
                {
                    this.VideoPath = string.Empty;
                    mi.Close();
                    return false;
                }
                string vTrackFPS = mi.Get(StreamKind.Video, 0, "FrameRate_Num") + "/" + mi.Get(StreamKind.Video, 0, "FrameRate_Den");
                //if (vTrackFPS == "/")
                //    vTrackFPS = (((int)Convert.ToSingle(mi.Get(StreamKind.Video, 0, "FrameRate")) * 1000).ToString() + "/" + "1000");
                int vTrackFrameRate = (int)Convert.ToSingle(mi.Get(StreamKind.Video, 0, "FrameRate"));
                switch (vTrackFrameRate)
                {
                    case 23: vTrackFPS = "24000/1001"; break;
                    case 24: vTrackFPS = "24000/1000"; break;
                    case 25: vTrackFPS = "25000/1000"; break;
                    case 29: vTrackFPS = "30000/1001"; break;
                    case 30: vTrackFPS = "30000/1000"; break;
                    case 50: vTrackFPS = "50000/1000"; break;
                    case 59: vTrackFPS = "60000/1001"; break;
                    case 60: vTrackFPS = "60000/1000"; break;
                    default: vTrackFPS = "24000/1001"; break;
                }
                this.vTrackFPS = vTrackFPS;
                mi.Close();
            }

            this.VideoPath = fileName;
            return true;
        }
    }
}
