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

namespace DoAnQuanLyThuVien
{
    public partial class fMain : Form
    {



        int oldPanelWidth, oldPanelHeight;
        string oldbtnExit, oldbtnAssist, oldbtnAcountInfo, oldbtnL_card_show, oldbtnBookManagement, oldbtnBookBorrowing;
        //int oldListWidth, oldListHeight;
        bool max_ed = true;
        bool Wmpstatus;

        bool hidden;
        public fMain()
        {
            InitializeComponent();
            pre_loading();

        }


        private void pre_loading()
        {
            //oldListHeight = musicList.Height;
            //oldListWidth = musicList.Width;

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
            oldbtnBookBorrowing = btnBookBorrowing.Text;
            btnAssist.Text = "";
            btnExit.Text = "";
            btnBookManagement.Text = "";
            btnL_card_show.Text = "";
            btnAcountInfo.Text = "";
            hidden = true;

            //set button colour
            /*.BackColor = Color.FromArgb(0, 208, 241, 247);
            SlidingPanel.BackColor = Color.FromArgb(70, 62, 0, 255);
            //lbTeamName.BackColor = Color.FromArgb(30, 249, 249, 249);
            /*
            btnBookManagement.BackColor = Color.FromArgb(0, 208, 241, 247);
            btnAcountInfo.BackColor = Color.FromArgb(0, 208, 241, 247);
            btnL_card_show.BackColor = Color.FromArgb(0, 208, 241, 247);
            btnExit.BackColor = Color.FromArgb(0, 208, 241, 247);
            btnAssist.BackColor = Color.FromArgb(0, 208, 241, 247);
            panel4.BackColor = Color.FromArgb(0, 208, 241, 247);*/

            //set WMP data

            FolderBrowserDialog fld = new FolderBrowserDialog();
            //doi ten duong truyen
            fld.SelectedPath = @"..\\..\\song";
           
            tsbClearPlaylist_Click();

            CreatePlayLis(fld, "*.mp3");
            windowsMediaPlayer.Visible = false;
            //panel5.Location = new Point(1314, 797);
            //panel5.Location.Y = 714;
        }

        #region form's control
        // minimize, maximize, close button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            //btnPlay.BackColor = Color.LightGray;
            //btnPlay.Show();
            // btnPause.Hide();
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
            // btnPause.BackColor = Color.Transparent;
        }

       
        /* private void tsbClearPlaylist_Click()
         {
             for (int i = 0; i < windowsMediaPlayer.currentPlaylist.count;)
             {
                 IWMPMedia med = windowsMediaPlayer.currentPlaylist.get_Item(i);
                 windowsMediaPlayer.currentPlaylist.removeItem(med);
             }
             musicList.Items.Clear();
         }*/

        private void CreatePlayLis(FolderBrowserDialog folder, string extendsion)
        {
            string myPlaylist = "Sample";
            WMPLib.IWMPPlaylist pl;
            WMPLib.IWMPPlaylistArray plItems;
     
            plItems = windowsMediaPlayer.playlistCollection.getByName(myPlaylist);
            plItems.Item(0).clear();
            if (plItems.count == 0)
                pl = windowsMediaPlayer.playlistCollection.newPlaylist(myPlaylist);
            else
                pl = plItems.Item(0);

            DirectoryInfo dir = new DirectoryInfo(folder.SelectedPath);
            FileInfo[] files = dir.GetFiles(extendsion, SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                
                
                //builder.Append(", ");
                string musicFile01 = file.FullName;

               // string mName = Path.GetFileNameWithoutExtension(file.Name);
                //ListViewItem item = new ListViewItem(mName);
                //musicList.Items.Add(item);
                WMPLib.IWMPMedia m1 = windowsMediaPlayer.newMedia(musicFile01);
                pl.appendItem(m1);
            }

            windowsMediaPlayer.currentPlaylist = pl;
            windowsMediaPlayer.Ctlcontrols.stop();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Wmpstatus == false)
            {
                //musicList.Width = 0;
                //musicList.Height = 0;
                Wmpstatus = true;
            }
            else
            {
                //musicList.Width = oldListWidth;
                //.Height = oldListHeight;
                Wmpstatus = false;
            }

        }

        /*private void musicList_DoubleClick(object sender, EventArgs e)
        {
            
            
            try
            {
                IWMPMedia med = windowsMediaPlayer.currentPlaylist.get_Item(musicList.SelectedIndices[0]);
                ListViewItem sel = musicList.SelectedItems[0];
                windowsMediaPlayer.Ctlcontrols.playItem(med);
            }
            catch (Exception)
            {
            }
        }*/

        private void tsbClearPlaylist_Click()
        {
            for (int i = 0; i < windowsMediaPlayer.currentPlaylist.count;)
            {
                IWMPMedia med = windowsMediaPlayer.currentPlaylist.get_Item(i);
                windowsMediaPlayer.currentPlaylist.removeItem(med);
            }
            //musicList.Items.Clear();
        }

        #endregion

        #region application's function button
        private void btnL_card_show_Click(object sender, EventArgs e)
        {

        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            fBookManager f = new fBookManager();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void windowsMediaPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            label1.Text = Path.GetFileNameWithoutExtension(windowsMediaPlayer.currentMedia.name);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BookList f = new BookList();
            f.Show();
        }

        private void btnAssist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("           Các thành viên nhóm phát triển:\n                  Nguyễn Hoàng Ngọc Hải\n                             Lê Hoàng Quý\n                              Lâm Tấn Phát\n                      Trần Huyền Anh Thy\n                Phiên bản ứng dụng 1.4.21\nLiên hệ đường dây nóng: 0912345678\nHoặc qua gmail: phattrienpm@gmail.com", "Hỗ trợ");

        }
        private void bntAcountInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAcountInfo_Click(object sender, EventArgs e)
        {

        }
        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

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
                btnBookBorrowing.Text = "";
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
                btnBookBorrowing.Text = oldbtnBookBorrowing;
                hidden = false;
            }

        }
        #endregion
    }
}
