
namespace DoAnQuanLyThuVien
{
    partial class ucListBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbBookNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBookType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 147);
            this.panel1.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(15, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(149, 141);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbBookNum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbBookType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbBookName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 147);
            this.panel2.TabIndex = 1;
            // 
            // txbBookNum
            // 
            this.txbBookNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbBookNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBookNum.Location = new System.Drawing.Point(359, 22);
            this.txbBookNum.Multiline = true;
            this.txbBookNum.Name = "txbBookNum";
            this.txbBookNum.Size = new System.Drawing.Size(33, 16);
            this.txbBookNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng:";
            // 
            // txbBookType
            // 
            this.txbBookType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbBookType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBookType.Location = new System.Drawing.Point(97, 104);
            this.txbBookType.Multiline = true;
            this.txbBookType.Name = "txbBookType";
            this.txbBookType.Size = new System.Drawing.Size(164, 16);
            this.txbBookType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại sách:";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Location = new System.Drawing.Point(97, 64);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(164, 16);
            this.txbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tác giả:";
            // 
            // txbBookName
            // 
            this.txbBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBookName.Location = new System.Drawing.Point(97, 22);
            this.txbBookName.Multiline = true;
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(164, 16);
            this.txbBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 1);
            this.panel3.TabIndex = 8;
            // 
            // ucListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucListBook";
            this.Size = new System.Drawing.Size(687, 150);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBookNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBookType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Panel panel3;
    }
}
