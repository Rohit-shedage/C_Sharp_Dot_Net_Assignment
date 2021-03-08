
namespace Employee_Info_System
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.tb_Other_Hobbies = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_Other_Hobbies = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.153879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.73222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.60251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.99349F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Other_Hobbies, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_MobNo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Other_Hobbies, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_MobNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(214, 38);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(231, 44);
            this.tb_Name.TabIndex = 48;
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MobNo.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_MobNo.Location = new System.Drawing.Point(705, 38);
            this.tb_MobNo.MaxLength = 10;
            this.tb_MobNo.Multiline = true;
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(214, 44);
            this.tb_MobNo.TabIndex = 49;
            this.tb_MobNo.TextChanged += new System.EventHandler(this.tb_MobNo_TextChanged);
            // 
            // tb_Other_Hobbies
            // 
            this.tb_Other_Hobbies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Other_Hobbies.Enabled = false;
            this.tb_Other_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Other_Hobbies.Location = new System.Drawing.Point(214, 129);
            this.tb_Other_Hobbies.MaxLength = 80;
            this.tb_Other_Hobbies.Multiline = true;
            this.tb_Other_Hobbies.Name = "tb_Other_Hobbies";
            this.tb_Other_Hobbies.Size = new System.Drawing.Size(231, 82);
            this.tb_Other_Hobbies.TabIndex = 50;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(53, 40);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(151, 40);
            this.lbl_Name.TabIndex = 51;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MobNo.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo.Location = new System.Drawing.Point(50, 150);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(158, 40);
            this.lbl_MobNo.TabIndex = 52;
            this.lbl_MobNo.Text = "Mobile No";
            this.lbl_MobNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MobNo.Click += new System.EventHandler(this.lbl_MobNo_Click);
            // 
            // lbl_Other_Hobbies
            // 
            this.lbl_Other_Hobbies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Other_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other_Hobbies.Location = new System.Drawing.Point(493, 28);
            this.lbl_Other_Hobbies.Name = "lbl_Other_Hobbies";
            this.lbl_Other_Hobbies.Size = new System.Drawing.Size(206, 64);
            this.lbl_Other_Hobbies.TabIndex = 53;
            this.lbl_Other_Hobbies.Text = "Other Hobbies";
            this.lbl_Other_Hobbies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(705, 148);
            this.textBox1.MaxLength = 10;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 44);
            this.textBox1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 50);
            this.label1.TabIndex = 54;
            this.label1.Text = "Other Hobbies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1002, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.TextBox tb_Other_Hobbies;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_Other_Hobbies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}