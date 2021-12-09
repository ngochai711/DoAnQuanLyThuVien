
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREQUEST_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOOKS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRETURN_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQUEST_FORM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(770, 420);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREQUEST_ID,
            this.colBOOKS_ID,
            this.colRETURN_DATE,
            this.colNUMBER,
            this.colREQUEST_FORM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colREQUEST_ID
            // 
            this.colREQUEST_ID.FieldName = "REQUEST_ID";
            this.colREQUEST_ID.Name = "colREQUEST_ID";
            this.colREQUEST_ID.Visible = true;
            this.colREQUEST_ID.VisibleIndex = 0;
            // 
            // colBOOKS_ID
            // 
            this.colBOOKS_ID.FieldName = "BOOKS_ID";
            this.colBOOKS_ID.Name = "colBOOKS_ID";
            this.colBOOKS_ID.Visible = true;
            this.colBOOKS_ID.VisibleIndex = 1;
            // 
            // colRETURN_DATE
            // 
            this.colRETURN_DATE.FieldName = "RETURN_DATE";
            this.colRETURN_DATE.Name = "colRETURN_DATE";
            this.colRETURN_DATE.Visible = true;
            this.colRETURN_DATE.VisibleIndex = 2;
            // 
            // colNUMBER
            // 
            this.colNUMBER.FieldName = "NUMBER";
            this.colNUMBER.Name = "colNUMBER";
            this.colNUMBER.Visible = true;
            this.colNUMBER.VisibleIndex = 3;
            // 
            // colREQUEST_FORM
            // 
            this.colREQUEST_FORM.FieldName = "REQUEST_FORM";
            this.colREQUEST_FORM.Name = "colREQUEST_FORM";
            this.colREQUEST_FORM.Visible = true;
            this.colREQUEST_FORM.VisibleIndex = 4;
            // 
            // fReaderBorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fReaderBorrowedBook";
            this.Text = "fReaderBorrowedBook";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colREQUEST_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBOOKS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRETURN_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colNUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colREQUEST_FORM;
    }
}