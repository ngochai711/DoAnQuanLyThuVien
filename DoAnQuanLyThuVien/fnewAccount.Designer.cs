﻿
namespace DoAnQuanLyThuVien
{
    partial class fnewAccount
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
            this.label_formName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.USERNAMETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PASSWORDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.REPASStextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button_signIn = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUSERNAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPASSWORD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPASStextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSERNAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPASSWORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_formName
            // 
            this.label_formName.AutoSize = true;
            this.label_formName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formName.Location = new System.Drawing.Point(36, 79);
            this.label_formName.Name = "label_formName";
            this.label_formName.Size = new System.Drawing.Size(193, 32);
            this.label_formName.TabIndex = 0;
            this.label_formName.Text = "Tài khoản mới";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataLayoutControl1);
            this.panel1.Location = new System.Drawing.Point(31, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 273);
            this.panel1.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.USERNAMETextEdit);
            this.dataLayoutControl1.Controls.Add(this.PASSWORDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.REPASStextEdit);
            this.dataLayoutControl1.Controls.Add(this.button_signIn);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(325, 273);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // USERNAMETextEdit
            // 
            this.USERNAMETextEdit.Location = new System.Drawing.Point(12, 32);
            this.USERNAMETextEdit.Name = "USERNAMETextEdit";
            this.USERNAMETextEdit.Size = new System.Drawing.Size(301, 22);
            this.USERNAMETextEdit.StyleController = this.dataLayoutControl1;
            this.USERNAMETextEdit.TabIndex = 4;
            // 
            // PASSWORDTextEdit
            // 
            this.PASSWORDTextEdit.Location = new System.Drawing.Point(12, 117);
            this.PASSWORDTextEdit.Name = "PASSWORDTextEdit";
            this.PASSWORDTextEdit.Properties.UseSystemPasswordChar = true;
            this.PASSWORDTextEdit.Size = new System.Drawing.Size(301, 22);
            this.PASSWORDTextEdit.StyleController = this.dataLayoutControl1;
            this.PASSWORDTextEdit.TabIndex = 5;
            // 
            // REPASStextEdit
            // 
            this.REPASStextEdit.Location = new System.Drawing.Point(12, 167);
            this.REPASStextEdit.Name = "REPASStextEdit";
            this.REPASStextEdit.Properties.UseSystemPasswordChar = true;
            this.REPASStextEdit.Size = new System.Drawing.Size(301, 22);
            this.REPASStextEdit.StyleController = this.dataLayoutControl1;
            this.REPASStextEdit.TabIndex = 6;
            // 
            // button_signIn
            // 
            this.button_signIn.AllowFocus = false;
            this.button_signIn.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_signIn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.button_signIn.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signIn.Appearance.Options.UseBackColor = true;
            this.button_signIn.Appearance.Options.UseBorderColor = true;
            this.button_signIn.Appearance.Options.UseFont = true;
            this.button_signIn.Location = new System.Drawing.Point(12, 224);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.button_signIn.Size = new System.Drawing.Size(301, 37);
            this.button_signIn.StyleController = this.dataLayoutControl1;
            this.button_signIn.TabIndex = 7;
            this.button_signIn.Text = "Tạo Tài Khoản";
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(325, 273);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUSERNAME,
            this.ItemForPASSWORD,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(305, 253);
            // 
            // ItemForUSERNAME
            // 
            this.ItemForUSERNAME.Control = this.USERNAMETextEdit;
            this.ItemForUSERNAME.Location = new System.Drawing.Point(0, 0);
            this.ItemForUSERNAME.MinSize = new System.Drawing.Size(146, 26);
            this.ItemForUSERNAME.Name = "ItemForUSERNAME";
            this.ItemForUSERNAME.Size = new System.Drawing.Size(305, 85);
            this.ItemForUSERNAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForUSERNAME.Text = "Tên đăng nhập";
            this.ItemForUSERNAME.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForUSERNAME.TextSize = new System.Drawing.Size(109, 17);
            // 
            // ItemForPASSWORD
            // 
            this.ItemForPASSWORD.Control = this.PASSWORDTextEdit;
            this.ItemForPASSWORD.Location = new System.Drawing.Point(0, 85);
            this.ItemForPASSWORD.MinSize = new System.Drawing.Size(146, 26);
            this.ItemForPASSWORD.Name = "ItemForPASSWORD";
            this.ItemForPASSWORD.Size = new System.Drawing.Size(305, 50);
            this.ItemForPASSWORD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForPASSWORD.Text = "Mật Khẩu";
            this.ItemForPASSWORD.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPASSWORD.TextSize = new System.Drawing.Size(109, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.REPASStextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 135);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(186, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(305, 77);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Nhập lại mật khẩu";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.button_signIn;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(91, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(305, 41);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // fnewAccount
            // 
            this.AcceptButton = this.button_signIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_formName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fnewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPASStextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSERNAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPASSWORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_formName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit USERNAMETextEdit;
        private DevExpress.XtraEditors.TextEdit PASSWORDTextEdit;
        private DevExpress.XtraEditors.TextEdit REPASStextEdit;
        private DevExpress.XtraEditors.SimpleButton button_signIn;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUSERNAME;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPASSWORD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}