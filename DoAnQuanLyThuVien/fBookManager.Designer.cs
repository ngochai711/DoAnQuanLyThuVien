
namespace DoAnQuanLyThuVien
{
    partial class fBookManager
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
            this.pcListBook = new DevExpress.XtraEditors.PanelControl();
            this.tcLibBook = new DevExpress.XtraTab.XtraTabControl();
            this.tcLibBookS = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pcListBook)).BeginInit();
            this.pcListBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcLibBook)).BeginInit();
            this.tcLibBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcListBook
            // 
            this.pcListBook.Controls.Add(this.tcLibBook);
            this.pcListBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcListBook.Location = new System.Drawing.Point(0, 0);
            this.pcListBook.Name = "pcListBook";
            this.pcListBook.Size = new System.Drawing.Size(1040, 656);
            this.pcListBook.TabIndex = 0;
            // 
            // tcLibBook
            // 
            this.tcLibBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLibBook.Location = new System.Drawing.Point(2, 2);
            this.tcLibBook.Name = "tcLibBook";
            this.tcLibBook.SelectedTabPage = this.xtraTabPage2;
            this.tcLibBook.Size = new System.Drawing.Size(1036, 652);
            this.tcLibBook.TabIndex = 0;
            this.tcLibBook.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tcLibBookS,
            this.xtraTabPage2});
            // 
            // tcLibBookS
            // 
            this.tcLibBookS.Name = "tcLibBookS";
            this.tcLibBookS.Size = new System.Drawing.Size(1034, 621);
            this.tcLibBookS.Text = "Sách thư viện";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1034, 621);
            this.xtraTabPage2.Text = "Tài liệu điện tử";
            // 
            // fBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.pcListBook);
            this.Name = "fBookManager";
            this.Text = "fBookManager";
            ((System.ComponentModel.ISupportInitialize)(this.pcListBook)).EndInit();
            this.pcListBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcLibBook)).EndInit();
            this.tcLibBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcListBook;
        private DevExpress.XtraTab.XtraTabControl tcLibBook;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage tcLibBookS;
    }
}