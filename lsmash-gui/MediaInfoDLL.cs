// MediaInfoDLL - All info about media files, for DLL
// Copyright (C) 2002-2012 MediaArea.net SARL, Info@MediaArea.net
//
// This library is free software: you can redistribute it and/or modify it
// under the terms of the GNU Library General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Library General Public License for more details.
//
// You should have received a copy of the GNU Library General Public License
// along with this library. If not, see <http://www.gnu.org/licenses/>.
//
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//
// Microsoft Visual C# wrapper for MediaInfo Library
// See MediaInfo.h for help
//
// To make it working, you must put MediaInfo.Dll
// in the executable folder
//
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

#pragma warning disable 1591 // Disable XML documentation warnings

namespace MediaInfoLib
{
    public enum StreamKind
    {
        None = -1,
        General,
        Video,
        Audio,
        Text,
        Other,
        Image,
        Menu,
    }

    public enum InfoKind
    {
        Name,
        Text,
        Measure,
        Options,
        NameText,
        MeasureText,
        Info,
        HowTo
    }

    public enum InfoOptions
    {
        ShowInInform,
        Support,
        ShowInSupported,
        TypeOfValue
    }

    [FlagsAttribute]
    public enum InfoFileOptions
    {
        FileOption_Nothing = 0x00,
        FileOption_NoRecursive = 0x01,
        FileOption_CloseAll = 0x02,
        FileOption_Max = 0x04
    };

	/// <summary>
	/// Status returned by <see cref="MediaInfo.Open_Buffer_Continue"/>
	/// bit 0: Is Accepted (format is known)
	/// bit 1: Is Filled (main data is collected)
	/// bit 2: Is Updated (some data have beed updated, example: duration for a real time MPEG-TS stream)
	/// bit 3: Is Finalized (No more data is needed, will not use further data)
	/// bit 4-15: Reserved bit 16-31: User defined
	/// </summary>
	[FlagsAttribute]
	public enum Status
	{
		None = 0x00,
		/// <summary>Is Accepted (format is known) </summary>
		Accepted = 0x01,
		/// <summary> Is Filled (main data is collected) </summary>
		Filled = 0x02,
		/// <summary>Is Updated (some data have beed updated, example: duration for a real time MPEG-TS stream)</summary>
		Updated = 0x04,
		/// <summary>Is Finalized (No more data is needed, will not use further data)</summary>
		Finalized = 0x08,
	};


    public class MediaInfo : IDisposable
    {
        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class UnsafeNativeMethods
        {
            //Import some stuff for module loading from kernel32.dll
            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern IntPtr LoadLibrary(string lpFileName);
            [System.Flags]
            internal enum LoadLibraryFlags : uint
            {
                DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
                LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
                LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
                LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
                LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
                LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008
            }
            [DllImport("kernel32.dll")]
            internal static extern IntPtr LoadLibraryEx (string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FreeLibrary(IntPtr hModule);

            //Import of DLL functions. DO NOT USE until you know what you do (MediaInfo DLL do NOT use CoTaskMemAlloc to allocate memory)
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_New();
            [DllImport("MediaInfo.dll")]
            internal static extern void MediaInfo_Delete(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Open(IntPtr Handle, [MarshalAs(UnmanagedType.LPWStr)] string FileName);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Open(IntPtr Handle, IntPtr FileName);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Open_Buffer_Init(IntPtr Handle, Int64 File_Size, Int64 File_Offset);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Open(IntPtr Handle, Int64 File_Size, Int64 File_Offset);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Open_Buffer_Continue(IntPtr Handle, IntPtr Buffer, IntPtr Buffer_Size);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Open_Buffer_Continue(IntPtr Handle, Int64 File_Size, byte[] Buffer, IntPtr Buffer_Size);
            [DllImport("MediaInfo.dll")]
            internal static extern Int64 MediaInfo_Open_Buffer_Continue_GoTo_Get(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern Int64 MediaInfoA_Open_Buffer_Continue_GoTo_Get(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Open_Buffer_Finalize(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Open_Buffer_Finalize(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern void MediaInfo_Close(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Inform(IntPtr Handle, IntPtr Reserved);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Inform(IntPtr Handle, IntPtr Reserved);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_GetI(IntPtr Handle, IntPtr StreamKind, IntPtr streamNumber, IntPtr Parameter, IntPtr kindOfInfo);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_GetI(IntPtr Handle, IntPtr StreamKind, IntPtr streamNumber, IntPtr Parameter, IntPtr kindOfInfo);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Get(IntPtr Handle, IntPtr StreamKind, IntPtr streamNumber, [MarshalAs(UnmanagedType.LPWStr)] string Parameter, IntPtr kindOfInfo, IntPtr kindOfSearch);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Get(IntPtr Handle, IntPtr StreamKind, IntPtr streamNumber, IntPtr Parameter, IntPtr kindOfInfo, IntPtr kindOfSearch);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Option(IntPtr Handle, [MarshalAs(UnmanagedType.LPWStr)] string Option, [MarshalAs(UnmanagedType.LPWStr)] string Value);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoA_Option(IntPtr Handle, IntPtr Option, IntPtr Value);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_State_Get(IntPtr Handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfo_Count_Get(IntPtr Handle, IntPtr StreamKind, IntPtr streamNumber);
        }
        //MediaInfo class
        private bool disposed = false;
        private static System.IntPtr moduleHandle = IntPtr.Zero;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (Handle != IntPtr.Zero)
                {
                    UnsafeNativeMethods.MediaInfo_Delete(Handle);
                    Handle = IntPtr.Zero;
                }
                if (moduleHandle == IntPtr.Zero)
                {
                    UnsafeNativeMethods.FreeLibrary(moduleHandle);
                    moduleHandle = IntPtr.Zero;
                }
            }
        }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
        ~MediaInfo() { Dispose(false); }

        public MediaInfo()
        {
            // from old branches of upstream this looks like a basic .NET/mono check
            // why you would split Unicode/Ansi support depending on Windows/non-Windows...no idea
            if (Environment.OSVersion.ToString().IndexOf("Windows") == -1)
            {
                // this is saying non-Windows environments are using the ANSI version of calls in mediainfo.dll
                // should this even be here anymore? doesn't everyone pretty much have support for unicode?
                MustUseAnsi = true;
            }
            else
            {
                // this is saying non-Windows environments are using the Unicode version of calls in mediainfo.dll
                // we definitely want to load Unicode media files on Windows...it has supported Unicode filenames for a long time
                // as well as any metadata which may be in Unicode
                MustUseAnsi = false;
            }

            // Determine bitness of system and pre-load appropriate library
            if (moduleHandle == IntPtr.Zero)
            {
                string baseDir;
                if (System.Reflection.Assembly.GetEntryAssembly() == null)
                {
                    // asp.net hosting
                    baseDir = AppDomain.CurrentDomain.RelativeSearchPath;
                }
                else
                {
                    // other C# app
                    string fullexepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    FileInfo fi = new FileInfo(fullexepath);
                    baseDir = fi.Directory.FullName;
                }
                var mediaInfoDllPath = Path.Combine(baseDir, Environment.Is64BitProcess ? "x64" : "x86", "MediaInfo.dll");
                moduleHandle = UnsafeNativeMethods.LoadLibraryEx(mediaInfoDllPath, IntPtr.Zero, 0);
            }

            // Open the loaded DLL for operation
            Handle = UnsafeNativeMethods.MediaInfo_New();
        }

        public int Open(String fileName)
        {
            if (MustUseAnsi)
            {
                IntPtr FileName_Ptr = Marshal.StringToHGlobalAnsi(fileName);
                int ToReturn = (int)UnsafeNativeMethods.MediaInfoA_Open(Handle, FileName_Ptr);
                Marshal.FreeHGlobal(FileName_Ptr);
                return ToReturn;
            }
            else
                return (int)UnsafeNativeMethods.MediaInfo_Open(Handle, fileName);
        }
        public int Open_Buffer_Init(Int64 fileSize, Int64 fileOffset)
        {
            return (int)UnsafeNativeMethods.MediaInfo_Open_Buffer_Init(Handle, fileSize, fileOffset);
        }
        public Status Open_Buffer_Continue(IntPtr buffer, IntPtr bufferSize)
        {
            return (Status)((int)UnsafeNativeMethods.MediaInfo_Open_Buffer_Continue(Handle, buffer, bufferSize));
        }
        public Int64 Open_Buffer_Continue_GoTo_Get()
        {
            return UnsafeNativeMethods.MediaInfo_Open_Buffer_Continue_GoTo_Get(Handle);
        }
        public int Open_Buffer_Finalize()
        {
            return (int)UnsafeNativeMethods.MediaInfo_Open_Buffer_Finalize(Handle);
        }
        public void Close() { UnsafeNativeMethods.MediaInfo_Close(Handle); Handle = IntPtr.Zero; }
        public String Inform()
        {
            if (MustUseAnsi)
                return Marshal.PtrToStringAnsi(UnsafeNativeMethods.MediaInfoA_Inform(Handle, (IntPtr)0));
            else
                return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfo_Inform(Handle, (IntPtr)0));
        }
        public String Get(StreamKind StreamKind, int streamNumber, String Parameter, InfoKind kindOfInfo = InfoKind.Text, InfoKind kindOfSearch = InfoKind.Name)
        {
            if (MustUseAnsi)
            {
                IntPtr Parameter_Ptr = Marshal.StringToHGlobalAnsi(Parameter);
                String ToReturn = Marshal.PtrToStringAnsi(UnsafeNativeMethods.MediaInfoA_Get(Handle, (IntPtr)StreamKind, (IntPtr)streamNumber, Parameter_Ptr, (IntPtr)kindOfInfo, (IntPtr)kindOfSearch));
                Marshal.FreeHGlobal(Parameter_Ptr);
                return ToReturn;
            }
            else
                return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfo_Get(Handle, (IntPtr)StreamKind, (IntPtr)streamNumber, Parameter, (IntPtr)kindOfInfo, (IntPtr)kindOfSearch));
        }
        public String Get(StreamKind StreamKind, int streamNumber, int Parameter, InfoKind kindOfInfo = InfoKind.Text)
        {
            if (MustUseAnsi)
                return Marshal.PtrToStringAnsi(UnsafeNativeMethods.MediaInfoA_GetI(Handle, (IntPtr)StreamKind, (IntPtr)streamNumber, (IntPtr)Parameter, (IntPtr)kindOfInfo));
            else
                return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfo_GetI(Handle, (IntPtr)StreamKind, (IntPtr)streamNumber, (IntPtr)Parameter, (IntPtr)kindOfInfo));
        }
        public String Option(String option = "", String Value = "")
        {
            if (MustUseAnsi)
            {
                IntPtr Option_Ptr = Marshal.StringToHGlobalAnsi(option);
                IntPtr Value_Ptr = Marshal.StringToHGlobalAnsi(Value);
                String ToReturn = Marshal.PtrToStringAnsi(UnsafeNativeMethods.MediaInfoA_Option(Handle, Option_Ptr, Value_Ptr));
                Marshal.FreeHGlobal(Option_Ptr);
                Marshal.FreeHGlobal(Value_Ptr);
                return ToReturn;
            }
            else
                return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfo_Option(Handle, option, Value));
        }
        public int State_Get() { return (int)UnsafeNativeMethods.MediaInfo_State_Get(Handle); }
        public int Count_Get(StreamKind streamKind, int streamNumber = -1) { return (int)UnsafeNativeMethods.MediaInfo_Count_Get(Handle, (IntPtr)streamKind, (IntPtr)streamNumber); }
        private IntPtr Handle;
        private bool MustUseAnsi;
    }

    public class MediaInfoList : IDisposable
    {
        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class UnsafeNativeMethods
        {
            //Import of DLL functions. DO NOT USE until you know what you do (MediaInfo DLL do NOT use CoTaskMemAlloc to allocate memory)
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_New();
            [DllImport("MediaInfo.dll")]
            internal static extern void MediaInfoList_Delete(IntPtr handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_Open(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] string FileName, IntPtr Options);
            [DllImport("MediaInfo.dll")]
            internal static extern void MediaInfoList_Close(IntPtr handle, IntPtr filePosition);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_Inform(IntPtr handle, IntPtr filePosition, IntPtr Reserved);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_GetI(IntPtr handle, IntPtr filePosition, IntPtr streamKind, IntPtr streamNumber, IntPtr parameter, IntPtr kindOfInfo);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_Get(IntPtr handle, IntPtr filePosition, IntPtr streamKind, IntPtr streamNumber, [MarshalAs(UnmanagedType.LPWStr)] string parameter, IntPtr kindOfInfo, IntPtr kindOfSearch);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_Option(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] string option, [MarshalAs(UnmanagedType.LPWStr)] string value);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_State_Get(IntPtr handle);
            [DllImport("MediaInfo.dll")]
            internal static extern IntPtr MediaInfoList_Count_Get(IntPtr handle, IntPtr filePosition, IntPtr StreamKind, IntPtr streamNumber);
        }
        //MediaInfo class
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (Handle != IntPtr.Zero)
                {
                    UnsafeNativeMethods.MediaInfoList_Delete(Handle); Handle = IntPtr.Zero;
                }
            }
        }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
        ~MediaInfoList() { Dispose(false); }
        public MediaInfoList() { Handle = UnsafeNativeMethods.MediaInfoList_New(); }
        public int Open(String fileName, InfoFileOptions options = InfoFileOptions.FileOption_Nothing) { return (int)UnsafeNativeMethods.MediaInfoList_Open(Handle, fileName, (IntPtr)options); }
        public void Close(int filePosition = -1) { UnsafeNativeMethods.MediaInfoList_Close(Handle, (IntPtr)filePosition); Handle = IntPtr.Zero; }
        public String Inform(int filePosition) { return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfoList_Inform(Handle, (IntPtr)filePosition, (IntPtr)0)); }
        public String Get(int filePosition, StreamKind streamKind, int streamNumber, String parameter, InfoKind kindOfInfo = InfoKind.Text, InfoKind kindOfSearch = InfoKind.Name) { return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfoList_Get(Handle, (IntPtr)filePosition, (IntPtr)streamKind, (IntPtr)streamNumber, parameter, (IntPtr)kindOfInfo, (IntPtr)kindOfSearch)); }
        public String Get(int filePosition, StreamKind streamKind, int streamNumber, int parameter, InfoKind kindOfInfo) { return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfoList_GetI(Handle, (IntPtr)filePosition, (IntPtr)streamKind, (IntPtr)streamNumber, (IntPtr)parameter, (IntPtr)kindOfInfo)); }
        public String Get(int filePosition, StreamKind streamKind, int streamNumber, int parameter) { return Get(filePosition, streamKind, streamNumber, parameter, InfoKind.Text); }
        public String Option(String optionName, String optionValue) { return Marshal.PtrToStringUni(UnsafeNativeMethods.MediaInfoList_Option(Handle, optionName, optionValue)); }
        public String Option(String optionName) { return Option(optionName, ""); }
        public int State_Get() { return (int)UnsafeNativeMethods.MediaInfoList_State_Get(Handle); }
        public int Count_Get(int filePosition, StreamKind streamKind, int streamNumber) { return (int)UnsafeNativeMethods.MediaInfoList_Count_Get(Handle, (IntPtr)filePosition, (IntPtr)streamKind, (IntPtr)streamNumber); }
        public int Count_Get(int filePosition, StreamKind streamKind) { return Count_Get(filePosition, streamKind, (int)StreamKind.None); }
        private IntPtr Handle;

    }

} //NameSpace
