using System;
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
        int oldPanelWidth,oldPanelHeight;
        
        bool hidden;
        public fMain()
        {
            InitializeComponent();
            oldPanelWidth = SlidingPanel.Width;
            oldPanelHeight = SlidingPanel.Height;
            SlidingPanel.Width = btnShow.Width;
            hidden = true;

        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnAssist_Click(object sender, EventArgs e)
        {

        }

        private void btnL_card_show_Click(object sender, EventArgs e)
        {

        }

        private void bntAcountInfo_Click(object sender, EventArgs e)
        {

        }

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBookManagement_MouseHover(object sender, EventArgs e)
        {
            if (SlidingPanel.Width == btnShow.Width)
                extralabel1.Visible = true;
        }

        private void btnBookManagement_MouseLeave(object sender, EventArgs e)
        {
            extralabel1.Visible = false ;
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
            }
            else
            {   
                SlidingPanel.Width = oldPanelWidth;
                SlidingPanel.Height = oldPanelHeight;
                hidden = false;
            }
                
        }
    }
}
