using WMPLib;

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
using DoAnQuanLyThuVien.DTO;
using System.Drawing.Imaging;


namespace DoAnQuanLyThuVien
{
    public partial class fMain : Form
    {
        private STAFF_INF activeAccount;
        int oldPanelWidth, oldPanelHeight;
        string oldbtnExit, oldbtnAssist, oldbtnAcountInfo, oldbtnL_card_show, oldbtnBookManagement;
       
        bool max_ed = true;
        bool isSetting = false;

        bool hidden;
        public fMain(STAFF_INF acc)
        {
            activeAccount = acc;

            InitializeComponent();
            pre_loading();
        }



        #region form's control

        private void pre_loading()
        {

            if (Properties.Settings.Default.BackImg != "")
            {
                string img = Properties.Settings.Default.BackImg;
                byte[] i = Convert.FromBase64String(img);
                this.BackgroundImage = Image.FromStream(new MemoryStream(i));

            }

            // menu data
            oldPanelWidth = 290;
            oldPanelHeight = SlidingPanel.Height;
            SlidingPanel.Width = btnShow.Width;

            //sliding menu's button properties
            oldbtnExit = btnExit.Text;
            oldbtnAssist = btnAssist.Text;
            oldbtnBookManagement = btnBookManagement.Text;
            oldbtnL_card_show = btnL_card_show.Text;
            oldbtnAcountInfo = btnAcountInfo.Text;

            btnAssist.Text = "";
            btnExit.Text = "";
            btnBookManagement.Text = "";
            btnL_card_show.Text = "";
            btnAcountInfo.Text = "";

            hidden = true;


            SlidingPanel.BackColor = Color.FromArgb(120, 245, 245, 245);
            //set WMP data

            //doi ten duong truyen
            set_Playlist_properties();

        }

        private void save_Personal_Setting()
        {

            // background changes saving
            var base64 = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                this.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                base64 = Convert.ToBase64String(ms.ToArray());
            }
            Properties.Settings.Default.BackImg = base64;
            Properties.Settings.Default.Save();

        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            windowsMediaPlayer.Dispose();
        }
        // minimize, maximize, close button

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            save_Personal_Setting();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            if (!max_ed)
            {
                WindowState = FormWindowState.Maximized;
                
                max_ed = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                max_ed = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region mp3 button and function
        private void set_Playlist_properties()
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.SelectedPath = @"..\..\song";

            tsbClearPlaylist_Click();
            if (Properties.Settings.Default.songPath != "" && Directory.Exists(Properties.Settings.Default.songPath))
                fld.SelectedPath = Properties.Settings.Default.songPath;
            CreatePlayLis(fld, "*.mp3");
            btnPlay.ImageIndex = 1;
            windowsMediaPlayer.Ctlcontrols.pause();
            windowsMediaPlayer.Visible = false;
        }
        private void btnPlay_Click(object sender, EventArgs e)
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

        private void windowsMediaPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            label1.Text = Path.GetFileNameWithoutExtension(windowsMediaPlayer.currentMedia.name);
        }

        #endregion

        #region application's function button
        private void btnSetting_Click(object sender, EventArgs e)
        {

            if (!isSetting)
            {
                settingPanel.BackColor = Color.FromArgb(50, 255, 255, 255);
                btnBackgroundChanging.Visible = true;
                btnPlayListChanging.Visible = true;
                isSetting = true;
            }
            else
            {
                settingPanel.BackColor = Color.FromArgb(0, 255, 255, 255);
                btnBackgroundChanging.Visible = !true;
                btnPlayListChanging.Visible = !true;
                isSetting = !true;

            }
        }
        private void btnPlayListChanging_Click(object sender, EventArgs e)
        {
            //openFileDialog.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            //openFileDialog.Multiselect = true;
            if (songFolder.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.songPath = songFolder.SelectedPath;
                set_Playlist_properties();
            }
        }
        private void btnBackgroundChanging_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.BackgroundImage = new Bitmap(_openFileDialog.FileName);
                Properties.Settings.Default.Save();

            }
        }
        private void btnL_card_show_Click(object sender, EventArgs e)
        {
            fCreateCardLendBook f = new fCreateCardLendBook();
            f.ShowDialog();
        }

   

        private void btnAssist_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("           Các thành viên nhóm phát triển:\n                  Nguyễn Hoàng Ngọc Hải\n                             Lê Hoàng Quý\n                              Lâm Tấn Phát\n                      Trần Huyền Anh Thy\n                Phiên bản ứng dụng 1.4.21\nLiên hệ đường dây nóng: 0912345678\nHoặc qua gmail: phattrienpm@gmail.com", "Hỗ trợ");
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {

            if (this.Name != "fMain")
            {
                this.Close();
            }

            var f = new fBookManager();
            f.ShowDialog();
        }

        FolderBrowserDialog songFolder = new FolderBrowserDialog();

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            save_Personal_Setting();
        }

     

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.Name != "fMain")
            {
                this.Close();
            }
            fEbookList f = new fEbookList();
            f.ShowDialog();
        }




        private void btnAcountInfo_Click(object sender, EventArgs e)
        {
            fPersonalManage f = new fPersonalManage(activeAccount);
            f.ShowDialog();
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            if (SlidingPanel.Height != oldPanelHeight)
            {
                oldPanelHeight = SlidingPanel.Height;
            }
            if (SlidingPanel.Width > oldPanelWidth)
            {
                oldPanelWidth = SlidingPanel.Width;
            }


            if (!hidden)
            {
                SlidingPanel.Width = btnShow.Width;
                hidden = true;
                btnAssist.Text = "";
                btnExit.Text = "";
                btnAcountInfo.Text = "";
                btnBookManagement.Text = "";
                btnL_card_show.Text = "";
               
            }
            else
            {
                SlidingPanel.Width = oldPanelWidth;
                SlidingPanel.Height = oldPanelHeight;
                btnAssist.Text = oldbtnAssist;
                btnExit.Text = oldbtnExit;
                btnAcountInfo.Text = oldbtnAcountInfo;
                btnBookManagement.Text = oldbtnBookManagement;
                btnL_card_show.Text = oldbtnL_card_show;
              
                hidden = false;
            }

        }
        #endregion

   

    }
}
