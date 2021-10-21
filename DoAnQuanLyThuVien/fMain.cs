﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // menu data
            oldPanelWidth = 235;
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
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAssist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("           Các thành viên nhóm phát triển:\n                  Nguyễn Hoàng Ngọc Hải\n                             Lê Hoàng Quý\n                              Lâm Tấn Phát\n                      Trần Huyền Anh Thy\n                Phiên bản ứng dụng 1.4.21\nLiên hệ đường dây nóng: 0912345678\nHoặc qua gmail: phattrienpm@gmail.com", "Hỗ trợ");
            
        }

        private void btnL_card_show_Click(object sender, EventArgs e)
        {

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
    }
}
