namespace Picture_Box_Demo_Pratice
{
    partial class frm_Picture_Box
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
            this.pb_Upload_Image = new System.Windows.Forms.PictureBox();
            this.pb_Show_Image = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.tb_Image_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Upload_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Upload_Image
            // 
            this.pb_Upload_Image.BackColor = System.Drawing.Color.CadetBlue;
            this.pb_Upload_Image.Location = new System.Drawing.Point(39, 57);
            this.pb_Upload_Image.Name = "pb_Upload_Image";
            this.pb_Upload_Image.Size = new System.Drawing.Size(205, 234);
            this.pb_Upload_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Upload_Image.TabIndex = 0;
            this.pb_Upload_Image.TabStop = false;
            // 
            // pb_Show_Image
            // 
            this.pb_Show_Image.BackColor = System.Drawing.Color.CadetBlue;
            this.pb_Show_Image.Location = new System.Drawing.Point(517, 57);
            this.pb_Show_Image.Name = "pb_Show_Image";
            this.pb_Show_Image.Size = new System.Drawing.Size(205, 234);
            this.pb_Show_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Show_Image.TabIndex = 1;
            this.pb_Show_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Browse.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(70, 339);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(140, 47);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Upload.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(293, 139);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(140, 47);
            this.btn_Upload.TabIndex = 3;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Show.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(551, 339);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(140, 47);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tb_Image_Id
            // 
            this.tb_Image_Id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Id.Location = new System.Drawing.Point(373, 350);
            this.tb_Image_Id.Name = "tb_Image_Id";
            this.tb_Image_Id.Size = new System.Drawing.Size(154, 36);
            this.tb_Image_Id.TabIndex = 5;
            // 
            // frm_Picture_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.tb_Image_Id);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.pb_Show_Image);
            this.Controls.Add(this.pb_Upload_Image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Picture_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Upload_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Upload_Image;
        private System.Windows.Forms.PictureBox pb_Show_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.TextBox tb_Image_Id;
    }
}

