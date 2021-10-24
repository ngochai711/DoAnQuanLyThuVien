
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
            this.components = new System.ComponentModel.Container();
            this.pnlDataList = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.dtgStaffList = new System.Windows.Forms.DataGridView();
            this.bOOKSMANAGEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBRARYDATABASEEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fBookManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIBRARYDATABASEEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIBRARYDATABASEEntitiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSMANAGEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBookManageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource2)).BeginInit();
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
            // pnlInfo
            // 
            this.pnlInfo.Location = new System.Drawing.Point(516, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(512, 644);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(12, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(498, 130);
            this.pnlButtons.TabIndex = 1;
            // 
            // dtgStaffList
            // 
            this.dtgStaffList.AutoGenerateColumns = false;
            this.dtgStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
            this.dtgStaffList.DataSource = this.lIBRARYDATABASEEntitiesBindingSource1;
            this.dtgStaffList.Location = new System.Drawing.Point(4, 40);
            this.dtgStaffList.Name = "dtgStaffList";
            this.dtgStaffList.RowHeadersWidth = 51;
            this.dtgStaffList.RowTemplate.Height = 24;
            this.dtgStaffList.Size = new System.Drawing.Size(491, 465);
            this.dtgStaffList.TabIndex = 0;
            // 
            // bOOKSMANAGEMENTBindingSource
            // 
            this.bOOKSMANAGEMENTBindingSource.DataSource = typeof(DoAnQuanLyThuVien.DTO.BOOKS_MANAGEMENT);
            // 
            // lIBRARYDATABASEEntitiesBindingSource
            // 
            this.lIBRARYDATABASEEntitiesBindingSource.DataSource = typeof(DoAnQuanLyThuVien.DTO.LIBRARY_DATABASEEntities);
            // 
            // fBookManageBindingSource
            // 
            this.fBookManageBindingSource.DataSource = typeof(DoAnQuanLyThuVien.fBookManage);
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
            // lIBRARYDATABASEEntitiesBindingSource1
            // 
            this.lIBRARYDATABASEEntitiesBindingSource1.DataSource = typeof(DoAnQuanLyThuVien.DTO.LIBRARY_DATABASEEntities);
            // 
            // bOOKSMANAGEMENTDataGridViewTextBoxColumn
            // 
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_MANAGEMENT";
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn.HeaderText = "BOOKS_MANAGEMENT";
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn.Name = "bOOKSMANAGEMENTDataGridViewTextBoxColumn";
            this.bOOKSMANAGEMENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.databaseDataGridViewTextBoxColumn.Width = 125;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeTrackerDataGridViewTextBoxColumn.Width = 125;
            // 
            // configurationDataGridViewTextBoxColumn
            // 
            this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
            this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
            this.configurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
            this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.configurationDataGridViewTextBoxColumn.Width = 125;
            // 
            // lIBRARYDATABASEEntitiesBindingSource2
            // 
            this.lIBRARYDATABASEEntitiesBindingSource2.DataSource = typeof(DoAnQuanLyThuVien.DTO.LIBRARY_DATABASEEntities);
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
            this.pnlDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSMANAGEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBookManageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDATABASEEntitiesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataList;
        private System.Windows.Forms.DataGridView dtgStaffList;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.BindingSource fBookManageBindingSource;
        private System.Windows.Forms.BindingSource bOOKSMANAGEMENTBindingSource;
        private System.Windows.Forms.BindingSource lIBRARYDATABASEEntitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSMANAGEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lIBRARYDATABASEEntitiesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource lIBRARYDATABASEEntitiesBindingSource2;
    }
}