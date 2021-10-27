
namespace DoAnQuanLyThuVien
{
    partial class fAccountManager
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tab_StaffAccount = new DevExpress.XtraTab.XtraTabPage();
            this.tab_Guess = new DevExpress.XtraTab.XtraTabPage();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.gcv_StaffAcc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Return = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tab_StaffAccount.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_StaffAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tab_StaffAccount;
            this.xtraTabControl1.Size = new System.Drawing.Size(1040, 656);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_StaffAccount,
            this.tab_Guess});
            // 
            // tab_StaffAccount
            // 
            this.tab_StaffAccount.Controls.Add(this.pnl_Buttons);
            this.tab_StaffAccount.Controls.Add(this.pnl_Info);
            this.tab_StaffAccount.Controls.Add(this.pnl_Data);
            this.tab_StaffAccount.Name = "tab_StaffAccount";
            this.tab_StaffAccount.Size = new System.Drawing.Size(1038, 625);
            this.tab_StaffAccount.Text = "Nhân viên";
            // 
            // tab_Guess
            // 
            this.tab_Guess.Name = "tab_Guess";
            this.tab_Guess.Size = new System.Drawing.Size(1038, 625);
            this.tab_Guess.Text = "Người đọc";
            // 
            // pnl_Data
            // 
            this.pnl_Data.Controls.Add(this.gcv_StaffAcc);
            this.pnl_Data.Location = new System.Drawing.Point(11, 112);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(520, 502);
            this.pnl_Data.TabIndex = 0;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Location = new System.Drawing.Point(537, 3);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(490, 611);
            this.pnl_Info.TabIndex = 1;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.btn_Edit);
            this.pnl_Buttons.Controls.Add(this.btn_Delete);
            this.pnl_Buttons.Controls.Add(this.btn_Add);
            this.pnl_Buttons.Controls.Add(this.btn_Return);
            this.pnl_Buttons.Controls.Add(this.btn_Refresh);
            this.pnl_Buttons.Location = new System.Drawing.Point(11, 3);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(520, 107);
            this.pnl_Buttons.TabIndex = 2;
            // 
            // gcv_StaffAcc
            // 
            this.gcv_StaffAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcv_StaffAcc.Location = new System.Drawing.Point(0, 0);
            this.gcv_StaffAcc.MainView = this.gridView1;
            this.gcv_StaffAcc.Name = "gcv_StaffAcc";
            this.gcv_StaffAcc.Size = new System.Drawing.Size(520, 502);
            this.gcv_StaffAcc.TabIndex = 0;
            this.gcv_StaffAcc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcv_StaffAcc;
            this.gridView1.Name = "gridView1";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(427, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(90, 100);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "Làm mới";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(3, 3);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(90, 100);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.Text = "Quay lại";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(121, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 100);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(217, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(90, 100);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(311, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(90, 100);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Cập nhật";
            // 
            // fAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "fAccountManager";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tab_StaffAccount.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcv_StaffAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tab_StaffAccount;
        private System.Windows.Forms.Panel pnl_Buttons;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Return;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_Data;
        private DevExpress.XtraGrid.GridControl gcv_StaffAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage tab_Guess;
    }
}