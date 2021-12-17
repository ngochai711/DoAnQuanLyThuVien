
namespace DoAnQuanLyThuVien
{
    partial class fSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetting));
            this.btnBackgroundChanging = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPlayListChanging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackgroundChanging
            // 
            this.btnBackgroundChanging.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackgroundChanging.ImageKey = "icons8_laptop_settings_32.png";
            this.btnBackgroundChanging.ImageList = this.imageList1;
            this.btnBackgroundChanging.Location = new System.Drawing.Point(24, 12);
            this.btnBackgroundChanging.Name = "btnBackgroundChanging";
            this.btnBackgroundChanging.Size = new System.Drawing.Size(168, 48);
            this.btnBackgroundChanging.TabIndex = 0;
            this.btnBackgroundChanging.Text = "Cài đặt ảnh nền";
            this.btnBackgroundChanging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackgroundChanging.UseVisualStyleBackColor = true;
            this.btnBackgroundChanging.Click += new System.EventHandler(this.btnBackgroundChanging_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_audio_file_32.png");
            this.imageList1.Images.SetKeyName(1, "icons8_laptop_settings_32.png");
            // 
            // btnPlayListChanging
            // 
            this.btnPlayListChanging.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayListChanging.ImageKey = "icons8_audio_file_32.png";
            this.btnPlayListChanging.ImageList = this.imageList1;
            this.btnPlayListChanging.Location = new System.Drawing.Point(24, 66);
            this.btnPlayListChanging.Name = "btnPlayListChanging";
            this.btnPlayListChanging.Size = new System.Drawing.Size(168, 48);
            this.btnPlayListChanging.TabIndex = 1;
            this.btnPlayListChanging.Text = "Cài đặt danh sách nhạc";
            this.btnPlayListChanging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlayListChanging.UseVisualStyleBackColor = true;
            this.btnPlayListChanging.Click += new System.EventHandler(this.btnPlayListChanging_Click);
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 123);
            this.Controls.Add(this.btnPlayListChanging);
            this.Controls.Add(this.btnBackgroundChanging);
            this.Name = "fSetting";
            this.Text = "fSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackgroundChanging;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPlayListChanging;
    }
}