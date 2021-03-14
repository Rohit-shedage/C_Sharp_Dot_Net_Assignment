namespace Student_Management_Details
{
    partial class frm_Add_Student_Information
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
            this.lbl_Add_Header = new System.Windows.Forms.Label();
            this.pl_Add_Student = new System.Windows.Forms.Panel();
            this.btn_Stud_Logout = new System.Windows.Forms.Button();
            this.lbl_Stud_ID = new System.Windows.Forms.Label();
            this.lbl_Stud_City = new System.Windows.Forms.Label();
            this.lbl_Stud_DOB = new System.Windows.Forms.Label();
            this.lbl_Stud_MobNo = new System.Windows.Forms.Label();
            this.lbl_Stud_Name = new System.Windows.Forms.Label();
            this.tb_Stud_ID = new System.Windows.Forms.TextBox();
            this.tb_Stud_Name = new System.Windows.Forms.TextBox();
            this.tb_Stud_MobNo = new System.Windows.Forms.TextBox();
            this.dtp_Stud_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Stud_Save = new System.Windows.Forms.Button();
            this.btn_Stud_View_Detail = new System.Windows.Forms.Button();
            this.cb_Add_Karad = new System.Windows.Forms.CheckBox();
            this.cb_Add_Sangli = new System.Windows.Forms.CheckBox();
            this.cb_Add_Mumbai = new System.Windows.Forms.CheckBox();
            this.cb_Add_Pune = new System.Windows.Forms.CheckBox();
            this.gb_Add = new System.Windows.Forms.GroupBox();
            this.pl_Add_Student.SuspendLayout();
            this.gb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Header
            // 
            this.lbl_Add_Header.AutoSize = true;
            this.lbl_Add_Header.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Add_Header.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Header.Location = new System.Drawing.Point(762, 68);
            this.lbl_Add_Header.Name = "lbl_Add_Header";
            this.lbl_Add_Header.Size = new System.Drawing.Size(376, 57);
            this.lbl_Add_Header.TabIndex = 0;
            this.lbl_Add_Header.Text = "Add Student Detail";
            // 
            // pl_Add_Student
            // 
            this.pl_Add_Student.BackColor = System.Drawing.Color.DarkRed;
            this.pl_Add_Student.Controls.Add(this.btn_Stud_Logout);
            this.pl_Add_Student.Controls.Add(this.lbl_Add_Header);
            this.pl_Add_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Add_Student.Location = new System.Drawing.Point(0, 0);
            this.pl_Add_Student.Name = "pl_Add_Student";
            this.pl_Add_Student.Size = new System.Drawing.Size(1662, 197);
            this.pl_Add_Student.TabIndex = 1;
            // 
            // btn_Stud_Logout
            // 
            this.btn_Stud_Logout.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Stud_Logout.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stud_Logout.Location = new System.Drawing.Point(3, 3);
            this.btn_Stud_Logout.Name = "btn_Stud_Logout";
            this.btn_Stud_Logout.Size = new System.Drawing.Size(128, 43);
            this.btn_Stud_Logout.TabIndex = 9;
            this.btn_Stud_Logout.Text = "Logout";
            this.btn_Stud_Logout.UseVisualStyleBackColor = false;
            this.btn_Stud_Logout.Click += new System.EventHandler(this.btn_Stud_Logout_Click);
            // 
            // lbl_Stud_ID
            // 
            this.lbl_Stud_ID.AutoSize = true;
            this.lbl_Stud_ID.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_ID.Location = new System.Drawing.Point(217, 280);
            this.lbl_Stud_ID.Name = "lbl_Stud_ID";
            this.lbl_Stud_ID.Size = new System.Drawing.Size(155, 40);
            this.lbl_Stud_ID.TabIndex = 2;
            this.lbl_Stud_ID.Text = "Student ID";
            // 
            // lbl_Stud_City
            // 
            this.lbl_Stud_City.AutoSize = true;
            this.lbl_Stud_City.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_City.Location = new System.Drawing.Point(217, 790);
            this.lbl_Stud_City.Name = "lbl_Stud_City";
            this.lbl_Stud_City.Size = new System.Drawing.Size(179, 40);
            this.lbl_Stud_City.TabIndex = 3;
            this.lbl_Stud_City.Text = "Student City";
            // 
            // lbl_Stud_DOB
            // 
            this.lbl_Stud_DOB.AutoSize = true;
            this.lbl_Stud_DOB.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_DOB.Location = new System.Drawing.Point(217, 651);
            this.lbl_Stud_DOB.Name = "lbl_Stud_DOB";
            this.lbl_Stud_DOB.Size = new System.Drawing.Size(188, 40);
            this.lbl_Stud_DOB.TabIndex = 4;
            this.lbl_Stud_DOB.Text = "Student DOB";
            // 
            // lbl_Stud_MobNo
            // 
            this.lbl_Stud_MobNo.AutoSize = true;
            this.lbl_Stud_MobNo.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_MobNo.Location = new System.Drawing.Point(217, 525);
            this.lbl_Stud_MobNo.Name = "lbl_Stud_MobNo";
            this.lbl_Stud_MobNo.Size = new System.Drawing.Size(221, 40);
            this.lbl_Stud_MobNo.TabIndex = 5;
            this.lbl_Stud_MobNo.Text = "Student MobNo";
            // 
            // lbl_Stud_Name
            // 
            this.lbl_Stud_Name.AutoSize = true;
            this.lbl_Stud_Name.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Name.Location = new System.Drawing.Point(217, 406);
            this.lbl_Stud_Name.Name = "lbl_Stud_Name";
            this.lbl_Stud_Name.Size = new System.Drawing.Size(201, 40);
            this.lbl_Stud_Name.TabIndex = 6;
            this.lbl_Stud_Name.Text = "Student Name";
            // 
            // tb_Stud_ID
            // 
            this.tb_Stud_ID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_ID.Location = new System.Drawing.Point(976, 282);
            this.tb_Stud_ID.Name = "tb_Stud_ID";
            this.tb_Stud_ID.Size = new System.Drawing.Size(446, 42);
            this.tb_Stud_ID.TabIndex = 1;
            // 
            // tb_Stud_Name
            // 
            this.tb_Stud_Name.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_Name.Location = new System.Drawing.Point(976, 404);
            this.tb_Stud_Name.Name = "tb_Stud_Name";
            this.tb_Stud_Name.Size = new System.Drawing.Size(446, 42);
            this.tb_Stud_Name.TabIndex = 2;
            // 
            // tb_Stud_MobNo
            // 
            this.tb_Stud_MobNo.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_MobNo.Location = new System.Drawing.Point(976, 523);
            this.tb_Stud_MobNo.MaxLength = 10;
            this.tb_Stud_MobNo.Name = "tb_Stud_MobNo";
            this.tb_Stud_MobNo.Size = new System.Drawing.Size(446, 42);
            this.tb_Stud_MobNo.TabIndex = 3;
            this.tb_Stud_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNUmeric);
            // 
            // dtp_Stud_DOB
            // 
            this.dtp_Stud_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Stud_DOB.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.dtp_Stud_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Stud_DOB.Location = new System.Drawing.Point(976, 649);
            this.dtp_Stud_DOB.Name = "dtp_Stud_DOB";
            this.dtp_Stud_DOB.Size = new System.Drawing.Size(446, 42);
            this.dtp_Stud_DOB.TabIndex = 4;
            // 
            // btn_Stud_Save
            // 
            this.btn_Stud_Save.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stud_Save.Location = new System.Drawing.Point(440, 901);
            this.btn_Stud_Save.Name = "btn_Stud_Save";
            this.btn_Stud_Save.Size = new System.Drawing.Size(145, 61);
            this.btn_Stud_Save.TabIndex = 7;
            this.btn_Stud_Save.Text = "Save";
            this.btn_Stud_Save.UseVisualStyleBackColor = true;
            this.btn_Stud_Save.Click += new System.EventHandler(this.btn_Stud_Save_Click);
            // 
            // btn_Stud_View_Detail
            // 
            this.btn_Stud_View_Detail.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stud_View_Detail.Location = new System.Drawing.Point(842, 901);
            this.btn_Stud_View_Detail.Name = "btn_Stud_View_Detail";
            this.btn_Stud_View_Detail.Size = new System.Drawing.Size(285, 61);
            this.btn_Stud_View_Detail.TabIndex = 8;
            this.btn_Stud_View_Detail.Text = "View All Detail";
            this.btn_Stud_View_Detail.UseVisualStyleBackColor = true;
            this.btn_Stud_View_Detail.Click += new System.EventHandler(this.btn_Stud_View_Detail_Click);
            // 
            // cb_Add_Karad
            // 
            this.cb_Add_Karad.AutoSize = true;
            this.cb_Add_Karad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Add_Karad.Location = new System.Drawing.Point(17, 10);
            this.cb_Add_Karad.Name = "cb_Add_Karad";
            this.cb_Add_Karad.Size = new System.Drawing.Size(116, 40);
            this.cb_Add_Karad.TabIndex = 5;
            this.cb_Add_Karad.Text = "Karad";
            this.cb_Add_Karad.UseVisualStyleBackColor = true;
            this.cb_Add_Karad.CheckedChanged += new System.EventHandler(this.cb_Add_Karad_CheckedChanged);
            // 
            // cb_Add_Sangli
            // 
            this.cb_Add_Sangli.AutoSize = true;
            this.cb_Add_Sangli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Add_Sangli.Location = new System.Drawing.Point(299, 0);
            this.cb_Add_Sangli.Name = "cb_Add_Sangli";
            this.cb_Add_Sangli.Size = new System.Drawing.Size(121, 40);
            this.cb_Add_Sangli.TabIndex = 7;
            this.cb_Add_Sangli.Text = "Sangli";
            this.cb_Add_Sangli.UseVisualStyleBackColor = true;
            this.cb_Add_Sangli.CheckedChanged += new System.EventHandler(this.cb_Add_Sangli_CheckedChanged);
            // 
            // cb_Add_Mumbai
            // 
            this.cb_Add_Mumbai.AutoSize = true;
            this.cb_Add_Mumbai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Add_Mumbai.Location = new System.Drawing.Point(17, 63);
            this.cb_Add_Mumbai.Name = "cb_Add_Mumbai";
            this.cb_Add_Mumbai.Size = new System.Drawing.Size(142, 40);
            this.cb_Add_Mumbai.TabIndex = 6;
            this.cb_Add_Mumbai.Text = "Mumbai";
            this.cb_Add_Mumbai.UseVisualStyleBackColor = true;
            this.cb_Add_Mumbai.CheckedChanged += new System.EventHandler(this.cb_Add_Mumbai_CheckedChanged);
            // 
            // cb_Add_Pune
            // 
            this.cb_Add_Pune.AutoSize = true;
            this.cb_Add_Pune.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Add_Pune.Location = new System.Drawing.Point(299, 63);
            this.cb_Add_Pune.Name = "cb_Add_Pune";
            this.cb_Add_Pune.Size = new System.Drawing.Size(107, 40);
            this.cb_Add_Pune.TabIndex = 9;
            this.cb_Add_Pune.Text = "Pune";
            this.cb_Add_Pune.UseVisualStyleBackColor = true;
            this.cb_Add_Pune.CheckedChanged += new System.EventHandler(this.cb_Add_Pune_CheckedChanged);
            // 
            // gb_Add
            // 
            this.gb_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Add.Controls.Add(this.cb_Add_Mumbai);
            this.gb_Add.Controls.Add(this.cb_Add_Pune);
            this.gb_Add.Controls.Add(this.cb_Add_Karad);
            this.gb_Add.Controls.Add(this.cb_Add_Sangli);
            this.gb_Add.Location = new System.Drawing.Point(976, 758);
            this.gb_Add.Name = "gb_Add";
            this.gb_Add.Size = new System.Drawing.Size(446, 109);
            this.gb_Add.TabIndex = 13;
            this.gb_Add.TabStop = false;
            // 
            // frm_Add_Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Stud_View_Detail);
            this.Controls.Add(this.btn_Stud_Save);
            this.Controls.Add(this.dtp_Stud_DOB);
            this.Controls.Add(this.tb_Stud_MobNo);
            this.Controls.Add(this.tb_Stud_Name);
            this.Controls.Add(this.tb_Stud_ID);
            this.Controls.Add(this.lbl_Stud_Name);
            this.Controls.Add(this.lbl_Stud_MobNo);
            this.Controls.Add(this.lbl_Stud_DOB);
            this.Controls.Add(this.lbl_Stud_City);
            this.Controls.Add(this.lbl_Stud_ID);
            this.Controls.Add(this.pl_Add_Student);
            this.Controls.Add(this.gb_Add);
            this.Name = "frm_Add_Student_Information";
            this.Text = "Add Student Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_Add_Student.ResumeLayout(false);
            this.pl_Add_Student.PerformLayout();
            this.gb_Add.ResumeLayout(false);
            this.gb_Add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Header;
        private System.Windows.Forms.Panel pl_Add_Student;
        private System.Windows.Forms.Label lbl_Stud_ID;
        private System.Windows.Forms.Label lbl_Stud_City;
        private System.Windows.Forms.Label lbl_Stud_DOB;
        private System.Windows.Forms.Label lbl_Stud_MobNo;
        private System.Windows.Forms.Label lbl_Stud_Name;
        private System.Windows.Forms.TextBox tb_Stud_ID;
        private System.Windows.Forms.TextBox tb_Stud_Name;
        private System.Windows.Forms.TextBox tb_Stud_MobNo;
        private System.Windows.Forms.DateTimePicker dtp_Stud_DOB;
        private System.Windows.Forms.Button btn_Stud_Logout;
        private System.Windows.Forms.Button btn_Stud_Save;
        private System.Windows.Forms.Button btn_Stud_View_Detail;
        private System.Windows.Forms.CheckBox cb_Add_Karad;
        private System.Windows.Forms.CheckBox cb_Add_Sangli;
        private System.Windows.Forms.CheckBox cb_Add_Mumbai;
        private System.Windows.Forms.CheckBox cb_Add_Pune;
        private System.Windows.Forms.GroupBox gb_Add;
    }
}