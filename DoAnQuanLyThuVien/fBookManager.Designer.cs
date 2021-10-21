
namespace DoAnQuanLyThuVien
{
    partial class fBookManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpListBook = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnInfoBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnSearchBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnEditBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnDeleteBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnAddBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.roundedButton1 = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.panel1.SuspendLayout();
            this.flpListBook.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.roundedButton1);
            this.panel1.Controls.Add(this.btnSearchBook);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.flpListBook);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnEditBook);
            this.panel1.Controls.Add(this.btnDeleteBook);
            this.panel1.Location = new System.Drawing.Point(174, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 685);
            this.panel1.TabIndex = 2;
            // 
            // flpListBook
            // 
            this.flpListBook.AutoScroll = true;
            this.flpListBook.Location = new System.Drawing.Point(5, 138);
            this.flpListBook.Margin = new System.Windows.Forms.Padding(4);
            this.flpListBook.Name = "flpListBook";
            this.flpListBook.Size = new System.Drawing.Size(926, 675);
            this.flpListBook.TabIndex = 3;
            // 
            // ucListBook1
            // 
       
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnInfoBook);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 748);
            this.panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1103, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 59);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfoBook
            // 
            this.btnInfoBook.BackColor = System.Drawing.Color.White;
            this.btnInfoBook.Location = new System.Drawing.Point(1045, 160);
            this.btnInfoBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoBook.Name = "btnInfoBook";
            this.btnInfoBook.Size = new System.Drawing.Size(162, 59);
            this.btnInfoBook.TabIndex = 9;
            this.btnInfoBook.Text = "Thông tin chi tiết";
            this.btnInfoBook.UseVisualStyleBackColor = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(656, 59);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(127, 36);
            this.btnSearchBook.TabIndex = 8;
            this.btnSearchBook.Text = "Tìm kiếm sách";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.White;
            this.btnEditBook.Location = new System.Drawing.Point(340, 4);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(162, 59);
            this.btnEditBook.TabIndex = 7;
            this.btnEditBook.Text = "Sửa thông tin sách";
            this.btnEditBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(170, 4);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(162, 59);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Xóa sách";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(162, 59);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.UseVisualStyleBackColor = false;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(152, 70);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(477, 22);
            this.searchControl1.TabIndex = 4;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(10, 67);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(135, 28);
            this.roundedButton1.TabIndex = 9;
            this.roundedButton1.Text = "Tìm kiếm sách";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // fBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1227, 753);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.panel1.ResumeLayout(false);
            this.flpListBook.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DAO.RoundedButton btnAddBook;
        private DAO.RoundedButton btnExit;
        private DAO.RoundedButton btnInfoBook;
        private DAO.RoundedButton btnSearchBook;
        private DAO.RoundedButton btnEditBook;
        private DAO.RoundedButton btnDeleteBook;
        private System.Windows.Forms.FlowLayoutPanel flpListBook;
        
        private DAO.RoundedButton roundedButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}