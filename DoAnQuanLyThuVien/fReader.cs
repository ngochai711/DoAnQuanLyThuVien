using DoAnQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DoAnQuanLyThuVien
{
    public partial class fReader : Form
    {
        private activeAccountDTO activeAccount;
        public fReader(activeAccountDTO acc)
        {
            activeAccount = acc;

            InitializeComponent();
            fBookList _bookList = new fBookList();
            _bookList.FormBorderStyle = FormBorderStyle.None;
            //BookList.backcolor = Color.FromArgb(245, 238, 220);
            openChildForm(_bookList);


            FolderBrowserDialog fld = new FolderBrowserDialog();
            //doi ten duong truyen
            fld.SelectedPath = @"..\..\song";

            tsbClearPlaylist_Click();

            CreatePlayLis(fld, "*.mp3");
            windowsMediaPlayer.Visible = false;
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {


            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnEbookReading_Click(object sender, EventArgs e)
        {
            fEbookList _ebookList = new fEbookList();
            _ebookList.FormBorderStyle = FormBorderStyle.None;
            openChildForm(_ebookList);
        }

        private void btnBookSearching_Click(object sender, EventArgs e)
        {
            fBookList _bookList = new fBookList();
            _bookList.FormBorderStyle = FormBorderStyle.None;
            openChildForm(_bookList);
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("           Các thành viên nhóm phát triển:\n                  Nguyễn Hoàng Ngọc Hải\n                             Lê Hoàng Quý\n                              Lâm Tấn Phát\n                      Trần Huyền Anh Thy\n                Phiên bản ứng dụng 1.4.21\nLiên hệ đường dây nóng: 0912345678\nHoặc qua gmail: phattrienpm@gmail.com", "Hỗ trợ");

        }

        #region mp3 button and function

   
        private void CreatePlayLis(FolderBrowserDialog folder, string extendsion)
        {
            string myPlaylist = "Sample1";
            WMPLib.IWMPPlaylist pl;
            WMPLib.IWMPPlaylistArray plItems;

            plItems = windowsMediaPlayer.playlistCollection.getByName(myPlaylist);
            try
            {
                plItems.Item(0).clear();

            }
            catch (Exception)
            {

            }

            if (plItems.count == 0)
                pl = windowsMediaPlayer.playlistCollection.newPlaylist(myPlaylist);
            else
                pl = plItems.Item(0);

            DirectoryInfo dir = new DirectoryInfo(folder.SelectedPath);
            FileInfo[] files = dir.GetFiles(extendsion, SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                string musicFile01 = file.FullName;
                WMPLib.IWMPMedia m1 = windowsMediaPlayer.newMedia(musicFile01);
                pl.appendItem(m1);
            }

            windowsMediaPlayer.currentPlaylist = pl;
            windowsMediaPlayer.Ctlcontrols.stop();

        }

        private void tsbClearPlaylist_Click()
        {
            for (int i = 0; i < windowsMediaPlayer.currentPlaylist.count;)
            {
                IWMPMedia med = windowsMediaPlayer.currentPlaylist.get_Item(i);
                windowsMediaPlayer.currentPlaylist.removeItem(med);
            }
        }

        #endregion

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (windowsMediaPlayer.status == "Stop" || windowsMediaPlayer.status == "Paused" || windowsMediaPlayer.status == "Ready")
            {
                btnPlay.ImageIndex = 0;
                windowsMediaPlayer.Ctlcontrols.play();
            }
            else
            {
                btnPlay.ImageIndex = 1;
                windowsMediaPlayer.Ctlcontrols.pause();

            }
        }
        private void windowsMediaPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            label1.Text = Path.GetFileNameWithoutExtension(windowsMediaPlayer.currentMedia.name);
        }

        private void btnUserLendingCard_Click(object sender, EventArgs e)
        {
            fReaderBorrowedBook _readerBorrowedBook = new fReaderBorrowedBook();
            _readerBorrowedBook.FormBorderStyle = FormBorderStyle.None;
            openChildForm(_readerBorrowedBook);
        }
    }


}
