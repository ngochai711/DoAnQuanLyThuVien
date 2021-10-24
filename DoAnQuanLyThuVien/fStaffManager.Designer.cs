
namespace DoAnQuanLyThuVien
{
    partial class fStaffManager
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
            this.pnlDataList = new System.Windows.Forms.Panel();
            this.dtgStaffList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataList
            // 
            this.pnlDataList.Controls.Add(this.dtgStaffList);
            this.pnlDataList.Location = new System.Drawing.Point(12, 136);
            this.pnlDataList.Name = "pnlDataList";
            this.pnlDataList.Size = new System.Drawing.Size(498, 508);
            this.pnlDataList.TabIndex = 0;
            // 
            // dtgStaffList
            // 
            this.AutoScroll = true;
            this.dtgStaffList.AllowDrop = true;
            this.dtgStaffList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtgStaffList.Location = new System.Drawing.Point(4, 4);
            this.dtgStaffList.MainView = this.gridView1;
            this.dtgStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgStaffList.Name = "dtgStaffList";
            this.dtgStaffList.Size = new System.Drawing.Size(490, 500);
            this.dtgStaffList.TabIndex = 0;
            this.dtgStaffList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.dtgStaffList;
            this.gridView1.Name = "gridView1";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Location = new System.Drawing.Point(516, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(512, 644);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.simpleButton1);
            this.pnlButtons.Location = new System.Drawing.Point(12, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(498, 111);
            this.pnlButtons.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(369, 4);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HtmlImages";
            this.dataGridViewTextBoxColumn1.HeaderText = "HtmlImages";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // fStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlDataList);
            this.Name = "fStaffManager";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.fStaffManager_Load);
            this.pnlDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataList;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraGrid.GridControl dtgStaffList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}