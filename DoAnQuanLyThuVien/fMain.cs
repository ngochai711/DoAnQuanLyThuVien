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
        private activeAccountDTO activeAccount;


        int oldPanelWidth, oldPanelHeight;
        string oldbtnExit, oldbtnAssist, oldbtnAcountInfo, oldbtnL_card_show, oldbtnBookManagement, oldbtnBookBorrowing;
        //int oldListWidth, oldListHeight;
        bool max_ed = true;
        bool isSetting = false;

        bool hidden;
        public fMain(activeAccountDTO acc)
        {
            activeAccount = acc;

            InitializeComponent();
            pre_loading();
        }


        private void pre_loading()
        {
           if(Properties.Settings.Default.BackImg != null)
            {
                string img = Properties.Settings.Default.BackImg;
                byte[] i = Convert.FromBase64String(img);
                this.BackgroundImage = Image.FromStream(new MemoryStream(i));

            }
            // menu data
            oldPanelWidth = 290;
            oldPanelHeight = SlidingPanel.Height;
            SlidingPanel.Width = btnShow.Width;

            //button data
            oldbtnExit = btnExit.Text;
            oldbtnAssist = btnAssist.Text;
            oldbtnBookManagement = btnBookManagement.Text;
            oldbtnL_card_show = btnL_card_show.Text;
            oldbtnAcountInfo = btnAcountInfo.Text;
            oldbtnBookBorrowing = btnEbookReading.Text;
            btnAssist.Text = "";
            btnExit.Text = "";
            btnBookManagement.Text = "";
            btnL_card_show.Text = "";
            btnAcountInfo.Text = "";
            btnEbookReading.Text = "";
            hidden = true;
            

            SlidingPanel.BackColor = Color.FromArgb(120, 245, 245, 245);
            //set WMP data

            FolderBrowserDialog fld = new FolderBrowserDialog();
            //doi ten duong truyen
            fld.SelectedPath = @"..\..\song";

            tsbClearPlaylist_Click();

            CreatePlayLis(fld, "*.mp3");
            windowsMediaPlayer.Visible = false;

        }

        #region form's control


        // minimize, maximize, close button

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
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
        private void btnBackgroundChanging_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.BackgroundImage = new Bitmap(_openFileDialog.FileName);
                Properties.Settings.Default.Save();
                //parentForm.BackgroundImage.Save(_openFileDialog.FileName,System.Drawing.Imaging.ImageFormat.Jpeg);

            }
        }
        private void btnL_card_show_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //fSetting _fSetting = new fSetting(this);
            //_fSetting.FormBorderStyle = FormBorderStyle.None;
            //openChildForm(_fSetting);
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

            fBookManager f = new fBookManager();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            fPersonalManage f = new fPersonalManage();
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
                btnEbookReading.Text = "";
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
                btnEbookReading.Text = oldbtnBookBorrowing;
                hidden = false;
            }

        }
        #endregion

        #region openfChild region
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
            settingPanel.Controls.Add(childForm);
            settingPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion

    }
}
