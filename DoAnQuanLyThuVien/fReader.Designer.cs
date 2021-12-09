namespace DoAnQuanLyThuVien
{
    partial class fReader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUserLendingCard = new System.Windows.Forms.Button();
            this.btnEbookReading = new System.Windows.Forms.Button();
            this.btnBookSearching = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Controls.Add(this.btnAccountInfo);
            this.panel1.Controls.Add(this.btnSupport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUserLendingCard);
            this.panel1.Controls.Add(this.btnEbookReading);
            this.panel1.Controls.Add(this.btnBookSearching);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccountInfo.Location = new System.Drawing.Point(3, 244);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(205, 49);
            this.btnAccountInfo.TabIndex = 3;
            this.btnAccountInfo.Text = "Thông tin tài khoản";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            // 
            // btnSupport
            // 
            this.btnSupport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSupport.Location = new System.Drawing.Point(3, 299);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(205, 49);
            this.btnSupport.TabIndex = 2;
            this.btnSupport.Text = "Hỗ trợ";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(3, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUserLendingCard
            // 
            this.btnUserLendingCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUserLendingCard.Location = new System.Drawing.Point(3, 189);
            this.btnUserLendingCard.Name = "btnUserLendingCard";
            this.btnUserLendingCard.Size = new System.Drawing.Size(205, 49);
            this.btnUserLendingCard.TabIndex = 2;
            this.btnUserLendingCard.Text = "Phiếu mượn";
            this.btnUserLendingCard.UseVisualStyleBackColor = true;
            // 
            // btnEbookReading
            // 
            this.btnEbookReading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEbookReading.Location = new System.Drawing.Point(3, 134);
            this.btnEbookReading.Name = "btnEbookReading";
            this.btnEbookReading.Size = new System.Drawing.Size(205, 49);
            this.btnEbookReading.TabIndex = 2;
            this.btnEbookReading.Text = "Sách điện tử";
            this.btnEbookReading.UseVisualStyleBackColor = true;
            this.btnEbookReading.Click += new System.EventHandler(this.btnEbookReading_Click);
            // 
            // btnBookSearching
            // 
            this.btnBookSearching.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBookSearching.Location = new System.Drawing.Point(3, 79);
            this.btnBookSearching.Name = "btnBookSearching";
            this.btnBookSearching.Size = new System.Drawing.Size(205, 49);
            this.btnBookSearching.TabIndex = 1;
            this.btnBookSearching.Text = "Tìm kiếm sách";
            this.btnBookSearching.UseVisualStyleBackColor = true;
            this.btnBookSearching.Click += new System.EventHandler(this.btnBookSearching_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 73);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(161)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.windowsMediaPlayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(211, 575);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 106);
            this.panel3.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(211, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(925, 575);
            this.panelChildForm.TabIndex = 3;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.separatorControl1.LineColor = System.Drawing.Color.Black;
            this.separatorControl1.Location = new System.Drawing.Point(3, 603);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(205, 21);
            this.separatorControl1.TabIndex = 4;
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(520, 44);
            this.windowsMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(157, 58);
            this.windowsMediaPlayer.TabIndex = 24;
            this.windowsMediaPlayer.Visible = false;
            this.windowsMediaPlayer.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.windowsMediaPlayer_CurrentItemChange);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pause_64px.png");
            this.imageList1.Images.SetKeyName(1, "pause_100px.png");
            this.imageList1.Images.SetKeyName(2, "pause_100px.png");
            this.imageList1.Images.SetKeyName(3, "play_60px.png");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnPlay);
            this.panel5.Location = new System.Drawing.Point(690, 55);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 47);
            this.panel5.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.ImageIndex = 1;
            this.btnPlay.ImageList = this.imageList1;
            this.btnPlay.Location = new System.Drawing.Point(2, 6);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 32);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // fReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1136, 681);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1152, 720);
            this.Name = "fReader";
            this.Text = "fReader";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUserLendingCard;
        private System.Windows.Forms.Button btnEbookReading;
        private System.Windows.Forms.Button btnBookSearching;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAccountInfo;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
    }
}