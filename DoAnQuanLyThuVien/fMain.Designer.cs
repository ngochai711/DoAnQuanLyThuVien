
namespace DoAnQuanLyThuVien
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAssist = new System.Windows.Forms.Button();
            this.btnL_card_show = new System.Windows.Forms.Button();
            this.bntAcountInfo = new System.Windows.Forms.Button();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SlidingPanel.Controls.Add(this.btnShow);
            this.SlidingPanel.Controls.Add(this.btnExit);
            this.SlidingPanel.Controls.Add(this.btnAssist);
            this.SlidingPanel.Controls.Add(this.btnL_card_show);
            this.SlidingPanel.Controls.Add(this.bntAcountInfo);
            this.SlidingPanel.Controls.Add(this.btnBookManagement);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(304, 653);
            this.SlidingPanel.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(41, 36);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Hien";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(48, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 70);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAssist
            // 
            this.btnAssist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssist.Location = new System.Drawing.Point(48, 400);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(209, 70);
            this.btnAssist.TabIndex = 3;
            this.btnAssist.Text = "Hỗ Trợ";
            this.btnAssist.UseVisualStyleBackColor = true;
            // 
            // btnL_card_show
            // 
            this.btnL_card_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnL_card_show.Location = new System.Drawing.Point(48, 300);
            this.btnL_card_show.Name = "btnL_card_show";
            this.btnL_card_show.Size = new System.Drawing.Size(209, 70);
            this.btnL_card_show.TabIndex = 2;
            this.btnL_card_show.Text = "Mượn Trả Sách";
            this.btnL_card_show.UseVisualStyleBackColor = true;
            // 
            // bntAcountInfo
            // 
            this.bntAcountInfo.Location = new System.Drawing.Point(48, 200);
            this.bntAcountInfo.Name = "bntAcountInfo";
            this.bntAcountInfo.Size = new System.Drawing.Size(209, 70);
            this.bntAcountInfo.TabIndex = 1;
            this.bntAcountInfo.Text = "Thông Tin Tài Khoản";
            this.bntAcountInfo.UseVisualStyleBackColor = true;
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Location = new System.Drawing.Point(48, 100);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Size = new System.Drawing.Size(209, 70);
            this.btnBookManagement.TabIndex = 0;
            this.btnBookManagement.Text = "Quản Lý Sách";
            this.btnBookManagement.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 653);
            this.Controls.Add(this.SlidingPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.Button btnL_card_show;
        private System.Windows.Forms.Button bntAcountInfo;
        private System.Windows.Forms.Button btnBookManagement;
    }
}