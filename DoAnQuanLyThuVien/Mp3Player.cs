using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*Để tạo playlist thì bạn chỉ cần tạo một class PlayList chứa tên bài hát, đường dẫn file,…. Sau đó dùng một collection để chứa các PlayList này.
Để chương trình chơi bài tiếp theo, bạn hãy kiểm tra trạng thái của Player (xem phần 4 trong bài).
Chúc bạn thành công!*/
namespace DoAnQuanLyThuVien
{
    class Mp3Player : IDisposable
    {
        public enum PlayerStatus { Ready, Playing, Paused, Stopped };
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);
        private bool Repeat { get; set; }
        public string Status

        {
            get
            {
                int length = 128;
                StringBuilder strBuffer = new StringBuilder(length);
                mciSendString("status MediaFile mode", strBuffer, length, 0);
                return strBuffer.ToString();
            }
        }
        public Mp3Player(string File)
        {

            const string Fomart = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Fomart, File);
            mciSendString(command, null, 0, 0);

        }


        public void Play()
        {

            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);

        }

        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Dispose()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, 0);

        }


    }
}
