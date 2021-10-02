
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
            this.ucListBook1 = new DoAnQuanLyThuVien.ucListBook();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnInfoBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnSearchBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnEditBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnDeleteBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.btnAddBook = new DoAnQuanLyThuVien.DAO.RoundedButton();
            this.panel1.SuspendLayout();
            this.flpListBook.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpListBook);
            this.panel1.Location = new System.Drawing.Point(204, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 606);
            this.panel1.TabIndex = 2;
            // 
            // flpListBook
            // 
            this.flpListBook.AutoScroll = true;
            this.flpListBook.Controls.Add(this.ucListBook1);
            this.flpListBook.Location = new System.Drawing.Point(0, 0);
            this.flpListBook.Name = "flpListBook";
            this.flpListBook.Size = new System.Drawing.Size(713, 606);
            this.flpListBook.TabIndex = 3;
            // 
            // ucListBook1
            // 
            this.ucListBook1.Location = new System.Drawing.Point(3, 3);
            this.ucListBook1.Name = "ucListBook1";
            this.ucListBook1.Size = new System.Drawing.Size(707, 150);
            this.ucListBook1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnInfoBook);
            this.panel2.Controls.Add(this.btnSearchBook);
            this.panel2.Controls.Add(this.btnEditBook);
            this.panel2.Controls.Add(this.btnDeleteBook);
            this.panel2.Controls.Add(this.btnAddBook);
            this.panel2.Location = new System.Drawing.Point(2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 603);
            this.panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(3, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 95);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfoBook
            // 
            this.btnInfoBook.BackColor = System.Drawing.Color.White;
            this.btnInfoBook.Location = new System.Drawing.Point(3, 407);
            this.btnInfoBook.Name = "btnInfoBook";
            this.btnInfoBook.Size = new System.Drawing.Size(196, 95);
            this.btnInfoBook.TabIndex = 9;
            this.btnInfoBook.Text = "Thông tin chi tiết";
            this.btnInfoBook.UseVisualStyleBackColor = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(3, 306);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(196, 95);
            this.btnSearchBook.TabIndex = 8;
            this.btnSearchBook.Text = "Tìm kiếm sách";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.White;
            this.btnEditBook.Location = new System.Drawing.Point(3, 205);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(196, 95);
            this.btnEditBook.TabIndex = 7;
            this.btnEditBook.Text = "Sửa thông tin sách";
            this.btnEditBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(3, 104);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(196, 95);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Xóa sách";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(3, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(196, 95);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.UseVisualStyleBackColor = false;
            // 
            // fBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(920, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fBookManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.panel1.ResumeLayout(false);
            this.flpListBook.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private ucListBook ucListBook1;
    }
}