
namespace EF_Demo_2
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.chb_ID = new System.Windows.Forms.CheckBox();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.btn_View_Details = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.FlatAppearance.BorderSize = 4;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(382, 734);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 45);
            this.btn_Delete.TabIndex = 57;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(266, 35);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(357, 34);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "CRUD Operation By EF DF";
            // 
            // chb_ID
            // 
            this.chb_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_ID.AutoSize = true;
            this.chb_ID.Location = new System.Drawing.Point(390, 122);
            this.chb_ID.Name = "chb_ID";
            this.chb_ID.Size = new System.Drawing.Size(155, 21);
            this.chb_ID.TabIndex = 56;
            this.chb_ID.Text = "Search Student Info";
            this.chb_ID.UseVisualStyleBackColor = true;
            this.chb_ID.CheckedChanged += new System.EventHandler(this.chb_ID_CheckedChanged);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rbtn_male.Location = new System.Drawing.Point(32, 7);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(82, 31);
            this.rbtn_male.TabIndex = 0;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // btn_View_Details
            // 
            this.btn_View_Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_View_Details.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_View_Details.FlatAppearance.BorderSize = 4;
            this.btn_View_Details.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Details.Location = new System.Drawing.Point(205, 734);
            this.btn_View_Details.Name = "btn_View_Details";
            this.btn_View_Details.Size = new System.Drawing.Size(160, 45);
            this.btn_View_Details.TabIndex = 55;
            this.btn_View_Details.Text = "View Details";
            this.btn_View_Details.UseVisualStyleBackColor = true;
            this.btn_View_Details.Click += new System.EventHandler(this.btn_View_Details_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatAppearance.BorderSize = 4;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(52, 734);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 45);
            this.btn_Clear.TabIndex = 53;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Update.FlatAppearance.BorderSize = 4;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(533, 734);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 45);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.FlatAppearance.BorderSize = 4;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(703, 734);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 45);
            this.btn_Save.TabIndex = 51;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.FlatAppearance.BorderSize = 4;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(735, 149);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 45);
            this.btn_Search.TabIndex = 54;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(390, 340);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(320, 34);
            this.dtp_DOB.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.rbtn_Female);
            this.groupBox1.Controls.Add(this.rbtn_male);
            this.groupBox1.Location = new System.Drawing.Point(390, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 44);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rbtn_Female.Location = new System.Drawing.Point(188, 7);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(103, 31);
            this.rbtn_Female.TabIndex = 1;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // cmb_City
            // 
            this.cmb_City.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_City.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Karad",
            "Satara",
            "Patan",
            "Sangli",
            "Kolhapur"});
            this.cmb_City.Location = new System.Drawing.Point(390, 662);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(320, 34);
            this.cmb_City.TabIndex = 48;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Mobile_No.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(390, 556);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(320, 34);
            this.tb_Mobile_No.TabIndex = 47;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(390, 149);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(320, 34);
            this.tb_ID.TabIndex = 45;
            // 
            // City
            // 
            this.City.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(128, 661);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(63, 33);
            this.City.TabIndex = 44;
            this.City.Text = "City";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(128, 445);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(95, 33);
            this.lbl_Gender.TabIndex = 42;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(128, 342);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(74, 33);
            this.lbl_DOB.TabIndex = 41;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(128, 246);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 33);
            this.lbl_Name.TabIndex = 40;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(128, 148);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(43, 33);
            this.lbl_ID.TabIndex = 39;
            this.lbl_ID.Text = "ID";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(390, 247);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(320, 34);
            this.tb_Name.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 107);
            this.panel1.TabIndex = 38;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(128, 555);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(137, 33);
            this.lbl_Mobile_No.TabIndex = 43;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(881, 791);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.chb_ID);
            this.Controls.Add(this.btn_View_Details);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.City);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Mobile_No);
            this.MinimumSize = new System.Drawing.Size(899, 838);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.CheckBox chb_ID;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.Button btn_View_Details;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Mobile_No;
    }
}

