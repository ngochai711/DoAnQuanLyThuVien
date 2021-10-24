
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
            this.dtgStaffList = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDataList
            // 
            this.pnlDataList.Controls.Add(this.btnSearch);
            this.pnlDataList.Controls.Add(this.txbSearch);
            this.pnlDataList.Controls.Add(this.dtgStaffList);
            this.pnlDataList.Location = new System.Drawing.Point(12, 136);
            this.pnlDataList.Name = "pnlDataList";
            this.pnlDataList.Size = new System.Drawing.Size(498, 508);
            this.pnlDataList.TabIndex = 0;
            // 
            // dtgStaffList
            // 
            this.dtgStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStaffList.Location = new System.Drawing.Point(5, 38);
            this.dtgStaffList.Name = "dtgStaffList";
            this.dtgStaffList.RowHeadersWidth = 51;
            this.dtgStaffList.RowTemplate.Height = 24;
            this.dtgStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStaffList.Size = new System.Drawing.Size(487, 467);
            this.dtgStaffList.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackgroundImage = global::DoAnQuanLyThuVien.Properties.Resources.Background;
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.Location = new System.Drawing.Point(515, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(546, 681);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnReturn);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDel);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(498, 111);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(5, 6);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(8);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 90);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(402, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 90);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(300, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 90);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Cập nhật";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(206, 6);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 90);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 90);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(3, 5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(422, 30);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.Text = "Nhập họ tên...";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(432, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            // 
            // fStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1061, 677);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlDataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaffManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.fStaffManager_Load);
            this.pnlDataList.ResumeLayout(false);
            this.pnlDataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataList;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private System.Windows.Forms.DataGridView dtgStaffList;
        private System.Windows.Forms.TextBox txbSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}