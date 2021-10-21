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
        string oldbtnExit, oldbtnAssist, oldbtnAcountInfo, oldbtnL_card_show, oldbtnBookManagement;
        int oldListWidth, oldListHeight;
        bool max_ed = false;
        bool Wmpstatus;

        bool hidden;
        public fMain()
        {
            InitializeComponent();
            pre_loading();

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void pre_loading()
        {
            oldListHeight = musicList.Height;
            oldListWidth = musicList.Width;

            // menu data
            oldPanelWidth = 270;
            oldPanelHeight = SlidingPanel.Height;
            SlidingPanel.Width = btnShow.Width;

            //button data
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
            //set button colour
            SlidingPanel.BackColor = Color.FromArgb(70, 255, 255, 255);
            //lbTeamName.BackColor = Color.FromArgb(30, 249, 249, 249);
            btnShow.BackColor = Color.FromArgb(30, 208, 241, 247);
            btnBookManagement.BackColor = Color.FromArgb(30, 208, 241, 247);
            btnAcountInfo.BackColor = Color.FromArgb(30, 208, 241, 247);
            btnL_card_show.BackColor = Color.FromArgb(30, 208, 241, 247);
            btnExit.BackColor = Color.FromArgb(30, 208, 241, 247);
            btnAssist.BackColor = Color.FromArgb(30, 208, 241, 247);
            panel4.BackColor = Color.FromArgb(30, 208, 241, 247);

            //set WMP data

            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.SelectedPath = @"C:\Users\USER\Music\mp3";
            tsbClearPlaylist_Click();

            CreatePlayLis(fld, "*.mp3");
            windowsMediaPlayer.Visible = false;

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
        #endregion

        #region mp3 button and function

        private void btnPlay_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.play();
            btnPlay.BackColor = Color.LightGray;
            btnPause.BackColor = Color.Transparent;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.pause();
            btnPause.BackColor = Color.LightGray;
            btnPlay.BackColor = Color.Transparent;
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
            /*int i = windowsMediaPlayer.playlistCollection.getAll().count;
            while (i-- > 0)
            {
                IWMPPlaylistArray plCollection = windowsMediaPlayer.playlistCollection.getByName(myPlaylist);

                IWMPPlaylist pll = plCollection.Item(0);
                windowsMediaPlayer.playlistCollection.remove(pll);
            }*/
            
            plItems = windowsMediaPlayer.playlistCollection.getByName(myPlaylist);
            if (plItems.count == 0)
                pl = windowsMediaPlayer.playlistCollection.newPlaylist(myPlaylist);
            else
                pl = plItems.Item(0);

            DirectoryInfo dir = new DirectoryInfo(folder.SelectedPath);
            FileInfo[] files = dir.GetFiles(extendsion, SearchOption.AllDirectories);

            foreach (FileInfo file in files)
             {
                 string musicFile01 = file.FullName;
                 string mName = file.Name;
                 ListViewItem item = new ListViewItem(mName);
                 musicList.Items.Add(item);
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
                musicList.Width = 0;
                musicList.Height = 0;
                Wmpstatus = true;
            }
            else
            {
                musicList.Width = oldListWidth;
                musicList.Height = oldListHeight;
                Wmpstatus = false;
            }

        }

        private void musicList_DoubleClick(object sender, EventArgs e)
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
        }

        private void tsbClearPlaylist_Click()
        {
            for (int i = 0; i < windowsMediaPlayer.currentPlaylist.count; )
            {
                IWMPMedia med = windowsMediaPlayer.currentPlaylist.get_Item(i);
                windowsMediaPlayer.currentPlaylist.removeItem(med);
            }
            musicList.Items.Clear();
        }

        #endregion

        #region application's function button
        private void btnL_card_show_Click(object sender, EventArgs e)
        {

        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            fBookManage f = new fBookManage();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            
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
