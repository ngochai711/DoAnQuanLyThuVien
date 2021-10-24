
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dtgStaffList = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txbID = new DevExpress.XtraEditors.TextEdit();
            this.txbNAME = new DevExpress.XtraEditors.TextEdit();
            this.txbSEX = new DevExpress.XtraEditors.TextEdit();
            this.txbBIRTHDATE = new DevExpress.XtraEditors.DateEdit();
            this.txbAGE = new DevExpress.XtraEditors.TextEdit();
            this.txbADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.txbPHONE_NUMBER = new DevExpress.XtraEditors.TextEdit();
            this.txbEMAIL = new DevExpress.XtraEditors.TextEdit();
            this.chkbPosition = new DevExpress.XtraEditors.CheckEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPOSITION = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemAddr = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemBirthdate = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemAge = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemSex = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffList)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSEX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBIRTHDATE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBIRTHDATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAGE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPHONE_NUMBER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbEMAIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPOSITION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataList
            // 
            this.pnlDataList.Controls.Add(this.btnSearch);
            this.pnlDataList.Controls.Add(this.txbSearch);
            this.pnlDataList.Controls.Add(this.dtgStaffList);
            this.pnlDataList.Location = new System.Drawing.Point(12, 136);
            this.pnlDataList.Name = "pnlDataList";
            this.pnlDataList.Size = new System.Drawing.Size(498, 541);
            this.pnlDataList.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(432, 5);
            this.btnSearch.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearch.LookAndFeel.UseWindowsXPTheme = true;
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(3, 5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(422, 30);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.Text = "Nhập họ tên...";
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // dtgStaffList
            // 
            this.dtgStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStaffList.Location = new System.Drawing.Point(5, 38);
            this.dtgStaffList.Name = "dtgStaffList";
            this.dtgStaffList.RowHeadersWidth = 51;
            this.dtgStaffList.RowTemplate.Height = 24;
            this.dtgStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStaffList.Size = new System.Drawing.Size(487, 500);
            this.dtgStaffList.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnReturn);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDel);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(498, 118);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(8, 15);
            this.btnReturn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnReturn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnReturn.LookAndFeel.UseWindowsXPTheme = true;
            this.btnReturn.Margin = new System.Windows.Forms.Padding(8);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 90);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(402, 15);
            this.btnRefresh.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnRefresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRefresh.LookAndFeel.UseWindowsXPTheme = true;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 90);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Location = new System.Drawing.Point(300, 15);
            this.btnEdit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.LookAndFeel.UseWindowsXPTheme = true;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 90);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(205, 15);
            this.btnDel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnDel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDel.LookAndFeel.UseWindowsXPTheme = true;
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 90);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 15);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.LookAndFeel.UseWindowsXPTheme = true;
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
            // pnlInfo
            // 
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInfo.Controls.Add(this.dataLayoutControl1);
            this.pnlInfo.Location = new System.Drawing.Point(515, 12);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(534, 662);
            this.pnlInfo.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txbID);
            this.dataLayoutControl1.Controls.Add(this.txbNAME);
            this.dataLayoutControl1.Controls.Add(this.txbSEX);
            this.dataLayoutControl1.Controls.Add(this.txbBIRTHDATE);
            this.dataLayoutControl1.Controls.Add(this.txbAGE);
            this.dataLayoutControl1.Controls.Add(this.txbADDRESS);
            this.dataLayoutControl1.Controls.Add(this.txbPHONE_NUMBER);
            this.dataLayoutControl1.Controls.Add(this.txbEMAIL);
            this.dataLayoutControl1.Controls.Add(this.chkbPosition);
            this.dataLayoutControl1.Controls.Add(this.pictureEdit1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1077, 327, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(534, 662);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(123, 161);
            this.txbID.Name = "txbID";
            this.txbID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Properties.Appearance.Options.UseFont = true;
            this.txbID.Size = new System.Drawing.Size(204, 38);
            this.txbID.StyleController = this.dataLayoutControl1;
            this.txbID.TabIndex = 4;
            // 
            // txbNAME
            // 
            this.txbNAME.AllowDrop = true;
            this.txbNAME.Location = new System.Drawing.Point(123, 12);
            this.txbNAME.Name = "txbNAME";
            this.txbNAME.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNAME.Properties.Appearance.Options.UseFont = true;
            this.txbNAME.Size = new System.Drawing.Size(204, 56);
            this.txbNAME.StyleController = this.dataLayoutControl1;
            this.txbNAME.TabIndex = 5;
            // 
            // txbSEX
            // 
            this.txbSEX.Location = new System.Drawing.Point(123, 219);
            this.txbSEX.Name = "txbSEX";
            this.txbSEX.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSEX.Properties.Appearance.Options.UseFont = true;
            this.txbSEX.Size = new System.Drawing.Size(399, 22);
            this.txbSEX.StyleController = this.dataLayoutControl1;
            this.txbSEX.TabIndex = 6;
            // 
            // txbBIRTHDATE
            // 
            this.txbBIRTHDATE.EditValue = null;
            this.txbBIRTHDATE.Location = new System.Drawing.Point(123, 271);
            this.txbBIRTHDATE.Name = "txbBIRTHDATE";
            this.txbBIRTHDATE.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txbBIRTHDATE.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBIRTHDATE.Properties.Appearance.Options.UseFont = true;
            this.txbBIRTHDATE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txbBIRTHDATE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txbBIRTHDATE.Size = new System.Drawing.Size(399, 22);
            this.txbBIRTHDATE.StyleController = this.dataLayoutControl1;
            this.txbBIRTHDATE.TabIndex = 7;
            // 
            // txbAGE
            // 
            this.txbAGE.Location = new System.Drawing.Point(123, 245);
            this.txbAGE.Name = "txbAGE";
            this.txbAGE.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txbAGE.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAGE.Properties.Appearance.Options.UseFont = true;
            this.txbAGE.Properties.Appearance.Options.UseTextOptions = true;
            this.txbAGE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txbAGE.Properties.Mask.EditMask = "N0";
            this.txbAGE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txbAGE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txbAGE.Size = new System.Drawing.Size(399, 22);
            this.txbAGE.StyleController = this.dataLayoutControl1;
            this.txbAGE.TabIndex = 8;
            // 
            // txbADDRESS
            // 
            this.txbADDRESS.Location = new System.Drawing.Point(123, 323);
            this.txbADDRESS.Name = "txbADDRESS";
            this.txbADDRESS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txbADDRESS.Size = new System.Drawing.Size(399, 22);
            this.txbADDRESS.StyleController = this.dataLayoutControl1;
            this.txbADDRESS.TabIndex = 9;
            // 
            // txbPHONE_NUMBER
            // 
            this.txbPHONE_NUMBER.Location = new System.Drawing.Point(123, 297);
            this.txbPHONE_NUMBER.Name = "txbPHONE_NUMBER";
            this.txbPHONE_NUMBER.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPHONE_NUMBER.Properties.Appearance.Options.UseFont = true;
            this.txbPHONE_NUMBER.Size = new System.Drawing.Size(399, 22);
            this.txbPHONE_NUMBER.StyleController = this.dataLayoutControl1;
            this.txbPHONE_NUMBER.TabIndex = 10;
            // 
            // txbEMAIL
            // 
            this.txbEMAIL.Location = new System.Drawing.Point(123, 349);
            this.txbEMAIL.Name = "txbEMAIL";
            this.txbEMAIL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEMAIL.Properties.Appearance.Options.UseFont = true;
            this.txbEMAIL.Size = new System.Drawing.Size(399, 22);
            this.txbEMAIL.StyleController = this.dataLayoutControl1;
            this.txbEMAIL.TabIndex = 11;
            // 
            // chkbPosition
            // 
            this.chkbPosition.Location = new System.Drawing.Point(12, 375);
            this.chkbPosition.Name = "chkbPosition";
            this.chkbPosition.Properties.Caption = "Vị trí";
            this.chkbPosition.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkbPosition.Size = new System.Drawing.Size(510, 24);
            this.chkbPosition.StyleController = this.dataLayoutControl1;
            this.chkbPosition.TabIndex = 12;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(331, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(191, 184);
            this.pictureEdit1.StyleController = this.dataLayoutControl1;
            this.pictureEdit1.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(534, 662);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemID,
            this.ItemForPOSITION,
            this.itemAddr,
            this.itemBirthdate,
            this.itemAge,
            this.itemSex,
            this.layoutControlItem1,
            this.itemEmail,
            this.itemPhone,
            this.itemName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(514, 642);
            // 
            // itemID
            // 
            this.itemID.Control = this.txbID;
            this.itemID.Location = new System.Drawing.Point(0, 149);
            this.itemID.MinSize = new System.Drawing.Size(186, 26);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(319, 58);
            this.itemID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemID.Text = "ID";
            this.itemID.TextSize = new System.Drawing.Size(108, 16);
            // 
            // ItemForPOSITION
            // 
            this.ItemForPOSITION.Control = this.chkbPosition;
            this.ItemForPOSITION.Location = new System.Drawing.Point(0, 363);
            this.ItemForPOSITION.MinSize = new System.Drawing.Size(88, 28);
            this.ItemForPOSITION.Name = "ItemForPOSITION";
            this.ItemForPOSITION.Size = new System.Drawing.Size(514, 279);
            this.ItemForPOSITION.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForPOSITION.Text = "POSITION";
            this.ItemForPOSITION.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPOSITION.TextVisible = false;
            // 
            // itemAddr
            // 
            this.itemAddr.AllowHide = false;
            this.itemAddr.Control = this.txbADDRESS;
            this.itemAddr.Location = new System.Drawing.Point(0, 311);
            this.itemAddr.Name = "itemAddr";
            this.itemAddr.Size = new System.Drawing.Size(514, 26);
            this.itemAddr.Text = "Địa chỉ";
            this.itemAddr.TextSize = new System.Drawing.Size(108, 17);
            // 
            // itemBirthdate
            // 
            this.itemBirthdate.Control = this.txbBIRTHDATE;
            this.itemBirthdate.Location = new System.Drawing.Point(0, 259);
            this.itemBirthdate.Name = "itemBirthdate";
            this.itemBirthdate.Size = new System.Drawing.Size(514, 26);
            this.itemBirthdate.Text = "Ngày sinh";
            this.itemBirthdate.TextSize = new System.Drawing.Size(108, 16);
            // 
            // itemAge
            // 
            this.itemAge.Control = this.txbAGE;
            this.itemAge.Location = new System.Drawing.Point(0, 233);
            this.itemAge.Name = "itemAge";
            this.itemAge.Size = new System.Drawing.Size(514, 26);
            this.itemAge.Text = "Tuổi";
            this.itemAge.TextSize = new System.Drawing.Size(108, 17);
            // 
            // itemSex
            // 
            this.itemSex.Control = this.txbSEX;
            this.itemSex.Location = new System.Drawing.Point(0, 207);
            this.itemSex.Name = "itemSex";
            this.itemSex.Size = new System.Drawing.Size(514, 26);
            this.itemSex.Text = "Giới Tính";
            this.itemSex.TextSize = new System.Drawing.Size(108, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(319, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(144, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(195, 207);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 16);
            // 
            // itemEmail
            // 
            this.itemEmail.Control = this.txbEMAIL;
            this.itemEmail.Location = new System.Drawing.Point(0, 337);
            this.itemEmail.Name = "itemEmail";
            this.itemEmail.Size = new System.Drawing.Size(514, 26);
            this.itemEmail.Text = "EMAIL";
            this.itemEmail.TextSize = new System.Drawing.Size(108, 16);
            // 
            // itemPhone
            // 
            this.itemPhone.Control = this.txbPHONE_NUMBER;
            this.itemPhone.Location = new System.Drawing.Point(0, 285);
            this.itemPhone.Name = "itemPhone";
            this.itemPhone.Size = new System.Drawing.Size(514, 26);
            this.itemPhone.Text = "Số điện thoại";
            this.itemPhone.TextSize = new System.Drawing.Size(108, 17);
            // 
            // itemName
            // 
            this.itemName.Control = this.txbNAME;
            this.itemName.Location = new System.Drawing.Point(0, 0);
            this.itemName.MinSize = new System.Drawing.Size(186, 26);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(319, 149);
            this.itemName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemName.Text = "Tên";
            this.itemName.TextSize = new System.Drawing.Size(108, 16);
            // 
            // fStaffManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
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
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSEX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBIRTHDATE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBIRTHDATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAGE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPHONE_NUMBER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbEMAIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPOSITION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemName)).EndInit();
            this.ResumeLayout(false);

        }

        private void TxbSearch_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txbSEX;
        private DevExpress.XtraEditors.DateEdit txbBIRTHDATE;
        private DevExpress.XtraEditors.TextEdit txbADDRESS;
        private DevExpress.XtraEditors.TextEdit txbPHONE_NUMBER;
        private DevExpress.XtraEditors.TextEdit txbEMAIL;
        private DevExpress.XtraEditors.CheckEdit chkbPosition;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem itemID;
        private DevExpress.XtraLayout.LayoutControlItem itemName;
        private DevExpress.XtraLayout.LayoutControlItem itemSex;
        private DevExpress.XtraLayout.LayoutControlItem itemAge;
        private DevExpress.XtraLayout.LayoutControlItem itemAddr;
        private DevExpress.XtraLayout.LayoutControlItem itemPhone;
        private DevExpress.XtraLayout.LayoutControlItem itemEmail;
        private DevExpress.XtraLayout.LayoutControlItem itemBirthdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPOSITION;
        public DevExpress.XtraEditors.TextEdit txbID;
        public DevExpress.XtraEditors.TextEdit txbNAME;
        public DevExpress.XtraEditors.TextEdit txbAGE;
    }
}