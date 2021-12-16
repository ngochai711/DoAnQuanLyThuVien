
namespace DoAnQuanLyThuVien
{
    partial class fReaderBorrowedBook
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQUEST_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rEQUESTFORMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSMANAGEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTFORMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSMANAGEMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colSTATUS,
            this.colREQUEST_DATE,
            this.colDUE_DATE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Book ID";
            this.gridColumn1.FieldName = "REQUEST_INFO.BOOKS_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Title";
            this.gridColumn2.FieldName = "REQUEST_INFO.BOOKS_MANAGEMENT.TITLE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colSTATUS
            // 
            this.colSTATUS.FieldName = "STATUS";
            this.colSTATUS.Name = "colSTATUS";
            this.colSTATUS.Visible = true;
            this.colSTATUS.VisibleIndex = 2;
            // 
            // colREQUEST_DATE
            // 
            this.colREQUEST_DATE.FieldName = "REQUEST_DATE";
            this.colREQUEST_DATE.Name = "colREQUEST_DATE";
            this.colREQUEST_DATE.Visible = true;
            this.colREQUEST_DATE.VisibleIndex = 3;
            // 
            // colDUE_DATE
            // 
            this.colDUE_DATE.FieldName = "DUE_DATE";
            this.colDUE_DATE.Name = "colDUE_DATE";
            this.colDUE_DATE.Visible = true;
            this.colDUE_DATE.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.rEQUESTFORMBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(32, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(739, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rEQUESTFORMBindingSource
            // 
            this.rEQUESTFORMBindingSource.DataSource = typeof(DoAnQuanLyThuVien.DTO.REQUEST_FORM);
            // 
            // bOOKSMANAGEMENTBindingSource
            // 
            this.bOOKSMANAGEMENTBindingSource.DataSource = typeof(DoAnQuanLyThuVien.DTO.BOOKS_MANAGEMENT);
            // 
            // fReaderBorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "fReaderBorrowedBook";
            this.Text = "fReaderBorrowedBook";
            this.Load += new System.EventHandler(this.fReaderBorrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTFORMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSMANAGEMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colREQUEST_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colDUE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUS;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource rEQUESTFORMBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bOOKSMANAGEMENTBindingSource;
    }
}