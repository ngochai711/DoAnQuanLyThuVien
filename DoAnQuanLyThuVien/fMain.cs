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
        int panelWidth;
        bool hidden;
        public fMain()
        {
            InitializeComponent();
            panelWidth = SlidingPanel.Width;
            hidden = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!hidden)
            {
                SlidingPanel.Width = 41;
                hidden = true;
            }
            else
            {
                SlidingPanel.Width = 304;
                hidden = false;
            }
                
        }
    }
}
