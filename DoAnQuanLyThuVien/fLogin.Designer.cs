
namespace DoAnQuanLyThuVien
{
    partial class fLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.USERNAMEtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PASSWORDtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_Login = new DevExpress.XtraEditors.SimpleButton();
            this.ISTAFFcheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem_Username = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_isStaff = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMEtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISTAFFcheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_isStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.layoutControl1);
            this.panel2.Location = new System.Drawing.Point(64, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 228);
            this.panel2.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.USERNAMEtextEdit);
            this.layoutControl1.Controls.Add(this.PASSWORDtextEdit);
            this.layoutControl1.Controls.Add(this.simpleButton_Login);
            this.layoutControl1.Controls.Add(this.ISTAFFcheckEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(432, 138, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(331, 228);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // USERNAMEtextEdit
            // 
            this.USERNAMEtextEdit.Location = new System.Drawing.Point(12, 32);
            this.USERNAMEtextEdit.Name = "USERNAMEtextEdit";
            this.USERNAMEtextEdit.Size = new System.Drawing.Size(307, 22);
            this.USERNAMEtextEdit.StyleController = this.layoutControl1;
            this.USERNAMEtextEdit.TabIndex = 4;
            // 
            // PASSWORDtextEdit
            // 
            this.PASSWORDtextEdit.Location = new System.Drawing.Point(12, 86);
            this.PASSWORDtextEdit.Name = "PASSWORDtextEdit";
            this.PASSWORDtextEdit.Properties.UseSystemPasswordChar = true;
            this.PASSWORDtextEdit.Size = new System.Drawing.Size(307, 22);
            this.PASSWORDtextEdit.StyleController = this.layoutControl1;
            this.PASSWORDtextEdit.TabIndex = 5;
            // 
            // simpleButton_Login
            // 
            this.simpleButton_Login.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.simpleButton_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_Login.Appearance.Options.UseBackColor = true;
            this.simpleButton_Login.Appearance.Options.UseFont = true;
            this.simpleButton_Login.Location = new System.Drawing.Point(12, 166);
            this.simpleButton_Login.Name = "simpleButton_Login";
            this.simpleButton_Login.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton_Login.Size = new System.Drawing.Size(307, 50);
            this.simpleButton_Login.StyleController = this.layoutControl1;
            this.simpleButton_Login.TabIndex = 6;
            this.simpleButton_Login.Text = "Đăng nhập";
            this.simpleButton_Login.Click += new System.EventHandler(this.simpleButton_Login_Click);
            // 
            // ISTAFFcheckEdit
            // 
            this.ISTAFFcheckEdit.EnterMoveNextControl = true;
            this.ISTAFFcheckEdit.Location = new System.Drawing.Point(12, 116);
            this.ISTAFFcheckEdit.Name = "ISTAFFcheckEdit";
            this.ISTAFFcheckEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ISTAFFcheckEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ISTAFFcheckEdit.Properties.Caption = "Nhân viên";
            this.ISTAFFcheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ISTAFFcheckEdit.Size = new System.Drawing.Size(307, 24);
            this.ISTAFFcheckEdit.StyleController = this.layoutControl1;
            this.ISTAFFcheckEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem_Username,
            this.layoutControlItem_Password,
            this.layoutControlItem3,
            this.layoutControlItem_isStaff});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(331, 228);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem_Username
            // 
            this.layoutControlItem_Username.Control = this.USERNAMEtextEdit;
            this.layoutControlItem_Username.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem_Username.MinSize = new System.Drawing.Size(112, 45);
            this.layoutControlItem_Username.Name = "layoutControlItem_Username";
            this.layoutControlItem_Username.Size = new System.Drawing.Size(311, 54);
            this.layoutControlItem_Username.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_Username.Text = "Tên đăng nhập";
            this.layoutControlItem_Username.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem_Username.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem_Password
            // 
            this.layoutControlItem_Password.Control = this.PASSWORDtextEdit;
            this.layoutControlItem_Password.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem_Password.MinSize = new System.Drawing.Size(112, 45);
            this.layoutControlItem_Password.Name = "layoutControlItem_Password";
            this.layoutControlItem_Password.Size = new System.Drawing.Size(311, 50);
            this.layoutControlItem_Password.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_Password.Text = "Mật khẩu";
            this.layoutControlItem_Password.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem_Password.TextSize = new System.Drawing.Size(93, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_Login;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 154);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(91, 31);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(311, 54);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem_isStaff
            // 
            this.layoutControlItem_isStaff.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem_isStaff.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem_isStaff.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem_isStaff.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem_isStaff.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem_isStaff.Control = this.ISTAFFcheckEdit;
            this.layoutControlItem_isStaff.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem_isStaff.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem_isStaff.MinSize = new System.Drawing.Size(91, 28);
            this.layoutControlItem_isStaff.Name = "layoutControlItem_isStaff";
            this.layoutControlItem_isStaff.Size = new System.Drawing.Size(311, 50);
            this.layoutControlItem_isStaff.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem_isStaff.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem_isStaff.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem_isStaff.TextVisible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnQuanLyThuVien.Properties.Resources.Library_Icon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(151, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pandealine";
            // 
            // fLogin
            // 
            this.AcceptButton = this.simpleButton_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(463, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMEtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISTAFFcheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_isStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit USERNAMEtextEdit;
        private DevExpress.XtraEditors.TextEdit PASSWORDtextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Login;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Username;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_Password;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_isStaff;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.CheckEdit ISTAFFcheckEdit;
    }
}