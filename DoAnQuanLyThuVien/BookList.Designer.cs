
namespace DoAnQuanLyThuVien
{
    partial class BookList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.eBOOKSMANAGEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSERIAL_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCATEGORY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANGUAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTITLE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTHOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUBLISHER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYEAROFPUB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOOK_URL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMAGES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TITLETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AUTHORTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IMAGESPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.NOTETextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.PUBLISHERTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.YEAROFPUBTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTITLE = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAUTHOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIMAGES = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNOTE = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPUBLISHER = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForYEAROFPUB = new DevExpress.XtraLayout.LayoutControlItem();
            this.colTITLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBOOKSMANAGEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TITLETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUTHORTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGESPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUBLISHERTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YEAROFPUBTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTITLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAUTHOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIMAGES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNOTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPUBLISHER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYEAROFPUB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 537);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.eBOOKSMANAGEMENTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(633, 537);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eBOOKSMANAGEMENTBindingSource
            // 
            this.eBOOKSMANAGEMENTBindingSource.DataSource = typeof(DoAnQuanLyThuVien.DTO.EBOOKS_MANAGEMENT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSERIAL_NUMBER,
            this.colCATEGORY,
            this.colLANGUAGE,
            this.colTITLE1,
            this.colAUTHOR,
            this.colPUBLISHER,
            this.colYEAROFPUB,
            this.colNOTE,
            this.colBOOK_URL,
            this.colIMAGES});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSERIAL_NUMBER
            // 
            this.colSERIAL_NUMBER.FieldName = "SERIAL_NUMBER";
            this.colSERIAL_NUMBER.MinWidth = 25;
            this.colSERIAL_NUMBER.Name = "colSERIAL_NUMBER";
            this.colSERIAL_NUMBER.Width = 94;
            // 
            // colCATEGORY
            // 
            this.colCATEGORY.FieldName = "CATEGORY";
            this.colCATEGORY.MinWidth = 25;
            this.colCATEGORY.Name = "colCATEGORY";
            this.colCATEGORY.Width = 94;
            // 
            // colLANGUAGE
            // 
            this.colLANGUAGE.FieldName = "LANGUAGE";
            this.colLANGUAGE.MinWidth = 25;
            this.colLANGUAGE.Name = "colLANGUAGE";
            this.colLANGUAGE.Width = 94;
            // 
            // colTITLE1
            // 
            this.colTITLE1.Caption = "Tên sách";
            this.colTITLE1.FieldName = "TITLE";
            this.colTITLE1.MinWidth = 25;
            this.colTITLE1.Name = "colTITLE1";
            this.colTITLE1.Visible = true;
            this.colTITLE1.VisibleIndex = 0;
            this.colTITLE1.Width = 94;
            // 
            // colAUTHOR
            // 
            this.colAUTHOR.Caption = "Tác giả";
            this.colAUTHOR.FieldName = "AUTHOR";
            this.colAUTHOR.MinWidth = 25;
            this.colAUTHOR.Name = "colAUTHOR";
            this.colAUTHOR.Visible = true;
            this.colAUTHOR.VisibleIndex = 1;
            this.colAUTHOR.Width = 94;
            // 
            // colPUBLISHER
            // 
            this.colPUBLISHER.Caption = "Nhà xuât bản";
            this.colPUBLISHER.FieldName = "PUBLISHER";
            this.colPUBLISHER.MinWidth = 25;
            this.colPUBLISHER.Name = "colPUBLISHER";
            this.colPUBLISHER.Visible = true;
            this.colPUBLISHER.VisibleIndex = 2;
            this.colPUBLISHER.Width = 94;
            // 
            // colYEAROFPUB
            // 
            this.colYEAROFPUB.Caption = "Năm Xuất Bản";
            this.colYEAROFPUB.FieldName = "YEAROFPUB";
            this.colYEAROFPUB.MinWidth = 25;
            this.colYEAROFPUB.Name = "colYEAROFPUB";
            this.colYEAROFPUB.Visible = true;
            this.colYEAROFPUB.VisibleIndex = 3;
            this.colYEAROFPUB.Width = 94;
            // 
            // colNOTE
            // 
            this.colNOTE.FieldName = "NOTE";
            this.colNOTE.MinWidth = 25;
            this.colNOTE.Name = "colNOTE";
            this.colNOTE.Width = 94;
            // 
            // colBOOK_URL
            // 
            this.colBOOK_URL.FieldName = "BOOK_URL";
            this.colBOOK_URL.MinWidth = 25;
            this.colBOOK_URL.Name = "colBOOK_URL";
            this.colBOOK_URL.Width = 94;
            // 
            // colIMAGES
            // 
            this.colIMAGES.FieldName = "IMAGES";
            this.colIMAGES.MinWidth = 25;
            this.colIMAGES.Name = "colIMAGES";
            this.colIMAGES.Width = 94;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.dataLayoutControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(632, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 347);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.TITLETextEdit);
            this.dataLayoutControl1.Controls.Add(this.AUTHORTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IMAGESPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.NOTETextEdit);
            this.dataLayoutControl1.Controls.Add(this.PUBLISHERTextEdit);
            this.dataLayoutControl1.Controls.Add(this.YEAROFPUBTextEdit);
            this.dataLayoutControl1.DataSource = this.eBOOKSMANAGEMENTBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(343, 340);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TITLETextEdit
            // 
            this.TITLETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "TITLE", true));
            this.TITLETextEdit.Location = new System.Drawing.Point(194, 12);
            this.TITLETextEdit.Name = "TITLETextEdit";
            this.TITLETextEdit.Properties.ReadOnly = true;
            this.TITLETextEdit.Size = new System.Drawing.Size(137, 22);
            this.TITLETextEdit.StyleController = this.dataLayoutControl1;
            this.TITLETextEdit.TabIndex = 0;
            // 
            // AUTHORTextEdit
            // 
            this.AUTHORTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "AUTHOR", true));
            this.AUTHORTextEdit.Location = new System.Drawing.Point(194, 38);
            this.AUTHORTextEdit.Name = "AUTHORTextEdit";
            this.AUTHORTextEdit.Properties.ReadOnly = true;
            this.AUTHORTextEdit.Size = new System.Drawing.Size(137, 22);
            this.AUTHORTextEdit.StyleController = this.dataLayoutControl1;
            this.AUTHORTextEdit.TabIndex = 2;
            // 
            // IMAGESPictureEdit
            // 
            this.IMAGESPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "IMAGES", true));
            this.IMAGESPictureEdit.Location = new System.Drawing.Point(12, 12);
            this.IMAGESPictureEdit.Name = "IMAGESPictureEdit";
            this.IMAGESPictureEdit.Properties.ReadOnly = true;
            this.IMAGESPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.IMAGESPictureEdit.Size = new System.Drawing.Size(88, 100);
            this.IMAGESPictureEdit.StyleController = this.dataLayoutControl1;
            this.IMAGESPictureEdit.TabIndex = 1;
            // 
            // NOTETextEdit
            // 
            this.NOTETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "NOTE", true));
            this.NOTETextEdit.Location = new System.Drawing.Point(12, 137);
            this.NOTETextEdit.Name = "NOTETextEdit";
            this.NOTETextEdit.Properties.ReadOnly = true;
            this.NOTETextEdit.Size = new System.Drawing.Size(319, 191);
            this.NOTETextEdit.StyleController = this.dataLayoutControl1;
            this.NOTETextEdit.TabIndex = 5;
            // 
            // PUBLISHERTextEdit
            // 
            this.PUBLISHERTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "PUBLISHER", true));
            this.PUBLISHERTextEdit.Location = new System.Drawing.Point(194, 64);
            this.PUBLISHERTextEdit.Name = "PUBLISHERTextEdit";
            this.PUBLISHERTextEdit.Properties.ReadOnly = true;
            this.PUBLISHERTextEdit.Size = new System.Drawing.Size(137, 22);
            this.PUBLISHERTextEdit.StyleController = this.dataLayoutControl1;
            this.PUBLISHERTextEdit.TabIndex = 3;
            // 
            // YEAROFPUBTextEdit
            // 
            this.YEAROFPUBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eBOOKSMANAGEMENTBindingSource, "YEAROFPUB", true));
            this.YEAROFPUBTextEdit.Location = new System.Drawing.Point(194, 90);
            this.YEAROFPUBTextEdit.Name = "YEAROFPUBTextEdit";
            this.YEAROFPUBTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.YEAROFPUBTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.YEAROFPUBTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.YEAROFPUBTextEdit.Properties.Mask.EditMask = "N0";
            this.YEAROFPUBTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.YEAROFPUBTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.YEAROFPUBTextEdit.Properties.ReadOnly = true;
            this.YEAROFPUBTextEdit.Size = new System.Drawing.Size(137, 22);
            this.YEAROFPUBTextEdit.StyleController = this.dataLayoutControl1;
            this.YEAROFPUBTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(343, 340);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTITLE,
            this.ItemForAUTHOR,
            this.ItemForIMAGES,
            this.ItemForNOTE,
            this.ItemForPUBLISHER,
            this.ItemForYEAROFPUB});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(323, 320);
            // 
            // ItemForTITLE
            // 
            this.ItemForTITLE.Control = this.TITLETextEdit;
            this.ItemForTITLE.Location = new System.Drawing.Point(92, 0);
            this.ItemForTITLE.Name = "ItemForTITLE";
            this.ItemForTITLE.Size = new System.Drawing.Size(231, 26);
            this.ItemForTITLE.Text = "Tên sách";
            this.ItemForTITLE.TextSize = new System.Drawing.Size(87, 16);
            // 
            // ItemForAUTHOR
            // 
            this.ItemForAUTHOR.Control = this.AUTHORTextEdit;
            this.ItemForAUTHOR.Location = new System.Drawing.Point(92, 26);
            this.ItemForAUTHOR.Name = "ItemForAUTHOR";
            this.ItemForAUTHOR.Size = new System.Drawing.Size(231, 26);
            this.ItemForAUTHOR.Text = "Tác giả";
            this.ItemForAUTHOR.TextSize = new System.Drawing.Size(87, 17);
            // 
            // ItemForIMAGES
            // 
            this.ItemForIMAGES.Control = this.IMAGESPictureEdit;
            this.ItemForIMAGES.Location = new System.Drawing.Point(0, 0);
            this.ItemForIMAGES.Name = "ItemForIMAGES";
            this.ItemForIMAGES.Size = new System.Drawing.Size(92, 104);
            this.ItemForIMAGES.StartNewLine = true;
            this.ItemForIMAGES.Text = "IMAGES";
            this.ItemForIMAGES.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIMAGES.TextVisible = false;
            // 
            // ItemForNOTE
            // 
            this.ItemForNOTE.Control = this.NOTETextEdit;
            this.ItemForNOTE.Location = new System.Drawing.Point(0, 104);
            this.ItemForNOTE.Name = "ItemForNOTE";
            this.ItemForNOTE.Size = new System.Drawing.Size(323, 216);
            this.ItemForNOTE.Text = "NOTE";
            this.ItemForNOTE.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForNOTE.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForNOTE.TextSize = new System.Drawing.Size(32, 16);
            this.ItemForNOTE.TextToControlDistance = 5;
            // 
            // ItemForPUBLISHER
            // 
            this.ItemForPUBLISHER.Control = this.PUBLISHERTextEdit;
            this.ItemForPUBLISHER.Location = new System.Drawing.Point(92, 52);
            this.ItemForPUBLISHER.Name = "ItemForPUBLISHER";
            this.ItemForPUBLISHER.Size = new System.Drawing.Size(231, 26);
            this.ItemForPUBLISHER.Text = "Nhà xuất bản";
            this.ItemForPUBLISHER.TextSize = new System.Drawing.Size(87, 17);
            // 
            // ItemForYEAROFPUB
            // 
            this.ItemForYEAROFPUB.Control = this.YEAROFPUBTextEdit;
            this.ItemForYEAROFPUB.Location = new System.Drawing.Point(92, 78);
            this.ItemForYEAROFPUB.Name = "ItemForYEAROFPUB";
            this.ItemForYEAROFPUB.Size = new System.Drawing.Size(231, 26);
            this.ItemForYEAROFPUB.Text = "Năm xuất bản";
            this.ItemForYEAROFPUB.TextSize = new System.Drawing.Size(87, 17);
            // 
            // colTITLE
            // 
            this.colTITLE.FieldName = "Tên sách";
            this.colTITLE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTITLE.MinWidth = 25;
            this.colTITLE.Name = "colTITLE";
            this.colTITLE.Visible = true;
            this.colTITLE.VisibleIndex = 0;
            this.colTITLE.Width = 94;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(647, 353);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 29);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Đọc sách";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 540);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBOOKSMANAGEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TITLETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUTHORTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGESPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOTETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PUBLISHERTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YEAROFPUBTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTITLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAUTHOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIMAGES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNOTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPUBLISHER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYEAROFPUB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource eBOOKSMANAGEMENTBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit TITLETextEdit;
        private DevExpress.XtraEditors.TextEdit AUTHORTextEdit;
        private DevExpress.XtraEditors.PictureEdit IMAGESPictureEdit;
        private DevExpress.XtraEditors.MemoEdit NOTETextEdit;
        private DevExpress.XtraEditors.TextEdit PUBLISHERTextEdit;
        private DevExpress.XtraEditors.TextEdit YEAROFPUBTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTITLE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAUTHOR;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIMAGES;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNOTE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPUBLISHER;
        private DevExpress.XtraLayout.LayoutControlItem ItemForYEAROFPUB;
        private DevExpress.XtraGrid.Columns.GridColumn colTITLE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSERIAL_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colCATEGORY;
        private DevExpress.XtraGrid.Columns.GridColumn colLANGUAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colTITLE1;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTHOR;
        private DevExpress.XtraGrid.Columns.GridColumn colPUBLISHER;
        private DevExpress.XtraGrid.Columns.GridColumn colYEAROFPUB;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colBOOK_URL;
        private DevExpress.XtraGrid.Columns.GridColumn colIMAGES;
        private DevExpress.XtraEditors.SimpleButton btnRead;
    }
}