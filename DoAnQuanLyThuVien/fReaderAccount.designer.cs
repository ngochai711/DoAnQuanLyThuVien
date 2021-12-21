
namespace DoAnQuanLyThuVien
{
    partial class fReaderAccount
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUSERNAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPASSWORD = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSERNAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPASSWORD)).BeginInit();
            this.SuspendLayout();
            // 
            // label_formName
            // 
            this.label_formName.AutoSize = true;
            this.label_formName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formName.Location = new System.Drawing.Point(16, 24);
            this.label_formName.Name = "label_formName";
            this.label_formName.Size = new System.Drawing.Size(137, 32);
            this.label_formName.TabIndex = 0;
            this.label_formName.Text = "Tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataLayoutControl1);
            this.panel1.Location = new System.Drawing.Point(148, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 131);
            this.panel1.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.USERNAMETextEdit);
            this.dataLayoutControl1.Controls.Add(this.PASSWORDTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(510, 0, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(325, 131);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // USERNAMETextEdit
            // 
            this.USERNAMETextEdit.Location = new System.Drawing.Point(12, 32);
            this.USERNAMETextEdit.Name = "USERNAMETextEdit";
            this.USERNAMETextEdit.Properties.ReadOnly = true;
            this.USERNAMETextEdit.Size = new System.Drawing.Size(301, 22);
            this.USERNAMETextEdit.StyleController = this.dataLayoutControl1;
            this.USERNAMETextEdit.TabIndex = 4;
            // 
            // PASSWORDTextEdit
            // 
            this.PASSWORDTextEdit.Location = new System.Drawing.Point(12, 78);
            this.PASSWORDTextEdit.Name = "PASSWORDTextEdit";
            this.PASSWORDTextEdit.Properties.ReadOnly = true;
            this.PASSWORDTextEdit.Properties.UseSystemPasswordChar = true;
            this.PASSWORDTextEdit.Size = new System.Drawing.Size(301, 22);
            this.PASSWORDTextEdit.StyleController = this.dataLayoutControl1;
            this.PASSWORDTextEdit.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(325, 131);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUSERNAME,
            this.ItemForPASSWORD});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(305, 111);
            // 
            // ItemForUSERNAME
            // 
            this.ItemForUSERNAME.Control = this.USERNAMETextEdit;
            this.ItemForUSERNAME.Location = new System.Drawing.Point(0, 0);
            this.ItemForUSERNAME.MinSize = new System.Drawing.Size(97, 46);
            this.ItemForUSERNAME.Name = "ItemForUSERNAME";
            this.ItemForUSERNAME.Size = new System.Drawing.Size(305, 46);
            this.ItemForUSERNAME.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForUSERNAME.Text = "Tên đăng nhập";
            this.ItemForUSERNAME.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForUSERNAME.TextSize = new System.Drawing.Size(93, 17);
            // 
            // ItemForPASSWORD
            // 
            this.ItemForPASSWORD.Control = this.PASSWORDTextEdit;
            this.ItemForPASSWORD.Location = new System.Drawing.Point(0, 46);
            this.ItemForPASSWORD.MinSize = new System.Drawing.Size(97, 46);
            this.ItemForPASSWORD.Name = "ItemForPASSWORD";
            this.ItemForPASSWORD.Size = new System.Drawing.Size(305, 65);
            this.ItemForPASSWORD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForPASSWORD.Text = "Mật Khẩu";
            this.ItemForPASSWORD.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPASSWORD.TextSize = new System.Drawing.Size(93, 17);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DoAnQuanLyThuVien.Properties.Resources.reader;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(22, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 120);
            this.panel2.TabIndex = 2;
            // 
            // fReaderAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 193);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_formName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fReaderAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin tài khoản";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USERNAMETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PASSWORDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSERNAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPASSWORD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_formName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit USERNAMETextEdit;
        private DevExpress.XtraEditors.TextEdit PASSWORDTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUSERNAME;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPASSWORD;
        private System.Windows.Forms.Panel panel2;
    }
}