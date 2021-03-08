namespace Employee_Info_System
{
    partial class frm_Add_Employee_Info
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Project = new System.Windows.Forms.GroupBox();
            this.chkb_Reliance = new System.Windows.Forms.CheckBox();
            this.chkb_D_Mart = new System.Windows.Forms.CheckBox();
            this.chkb_IPL = new System.Windows.Forms.CheckBox();
            this.chkb_Tata = new System.Windows.Forms.CheckBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Shift_Timing = new System.Windows.Forms.GroupBox();
            this.rbtn_Night = new System.Windows.Forms.RadioButton();
            this.rbtn_Evening = new System.Windows.Forms.RadioButton();
            this.rbtn_Moring = new System.Windows.Forms.RadioButton();
            this.chklb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Other_Hobbies = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.cmb_Manager_Monitor = new System.Windows.Forms.ComboBox();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Other_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Manager_Mentor = new System.Windows.Forms.Label();
            this.lbl_Shift_Timing = new System.Windows.Forms.Label();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Project.SuspendLayout();
            this.gb_Shift_Timing.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1282, 84);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Header.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(464, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(452, 56);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Employee Details";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.100665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.57045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.856915F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.86487F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.102453F));
            this.tableLayoutPanel1.Controls.Add(this.gb_Project, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.gb_Shift_Timing, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.chklb_Hobbies, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_MobNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_Gender, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtp_DOB, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Other_Hobbies, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Department, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Manager_Monitor, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Designation, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Salary, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_MobNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Gender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DOB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Hobbies, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Other_Hobbies, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Department, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Manager_Mentor, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Shift_Timing, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Project, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Salary, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Designation, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.11688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.11688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.49897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.49877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91093F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 683);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gb_Project
            // 
            this.gb_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Project.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Project.Controls.Add(this.chkb_Reliance);
            this.gb_Project.Controls.Add(this.chkb_D_Mart);
            this.gb_Project.Controls.Add(this.chkb_IPL);
            this.gb_Project.Controls.Add(this.chkb_Tata);
            this.gb_Project.Location = new System.Drawing.Point(879, 276);
            this.gb_Project.Name = "gb_Project";
            this.gb_Project.Size = new System.Drawing.Size(322, 96);
            this.gb_Project.TabIndex = 10;
            this.gb_Project.TabStop = false;
            // 
            // chkb_Reliance
            // 
            this.chkb_Reliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Reliance.AutoSize = true;
            this.chkb_Reliance.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.chkb_Reliance.Location = new System.Drawing.Point(193, 62);
            this.chkb_Reliance.Name = "chkb_Reliance";
            this.chkb_Reliance.Size = new System.Drawing.Size(120, 30);
            this.chkb_Reliance.TabIndex = 3;
            this.chkb_Reliance.Text = "Reliance";
            this.chkb_Reliance.UseVisualStyleBackColor = true;
            // 
            // chkb_D_Mart
            // 
            this.chkb_D_Mart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_D_Mart.AutoSize = true;
            this.chkb_D_Mart.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.chkb_D_Mart.Location = new System.Drawing.Point(193, 19);
            this.chkb_D_Mart.Name = "chkb_D_Mart";
            this.chkb_D_Mart.Size = new System.Drawing.Size(107, 30);
            this.chkb_D_Mart.TabIndex = 2;
            this.chkb_D_Mart.Text = "D-Mart";
            this.chkb_D_Mart.UseVisualStyleBackColor = true;
            // 
            // chkb_IPL
            // 
            this.chkb_IPL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_IPL.AutoSize = true;
            this.chkb_IPL.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.chkb_IPL.Location = new System.Drawing.Point(5, 62);
            this.chkb_IPL.Name = "chkb_IPL";
            this.chkb_IPL.Size = new System.Drawing.Size(68, 30);
            this.chkb_IPL.TabIndex = 1;
            this.chkb_IPL.Text = "IPL";
            this.chkb_IPL.UseVisualStyleBackColor = true;
            // 
            // chkb_Tata
            // 
            this.chkb_Tata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_Tata.AutoSize = true;
            this.chkb_Tata.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.chkb_Tata.Location = new System.Drawing.Point(5, 19);
            this.chkb_Tata.Name = "chkb_Tata";
            this.chkb_Tata.Size = new System.Drawing.Size(78, 30);
            this.chkb_Tata.TabIndex = 0;
            this.chkb_Tata.Text = "Tata";
            this.chkb_Tata.UseVisualStyleBackColor = true;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_ID.Location = new System.Drawing.Point(237, 26);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(325, 44);
            this.tb_ID.TabIndex = 23;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(950, 600);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(180, 68);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Shift_Timing
            // 
            this.gb_Shift_Timing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Shift_Timing.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Night);
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Evening);
            this.gb_Shift_Timing.Controls.Add(this.rbtn_Moring);
            this.gb_Shift_Timing.Location = new System.Drawing.Point(879, 189);
            this.gb_Shift_Timing.Name = "gb_Shift_Timing";
            this.gb_Shift_Timing.Size = new System.Drawing.Size(322, 71);
            this.gb_Shift_Timing.TabIndex = 9;
            this.gb_Shift_Timing.TabStop = false;
            // 
            // rbtn_Night
            // 
            this.rbtn_Night.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Night.AutoSize = true;
            this.rbtn_Night.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Night.Location = new System.Drawing.Point(238, 16);
            this.rbtn_Night.Name = "rbtn_Night";
            this.rbtn_Night.Size = new System.Drawing.Size(88, 30);
            this.rbtn_Night.TabIndex = 2;
            this.rbtn_Night.TabStop = true;
            this.rbtn_Night.Text = "Night";
            this.rbtn_Night.UseVisualStyleBackColor = true;
            // 
            // rbtn_Evening
            // 
            this.rbtn_Evening.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Evening.AutoSize = true;
            this.rbtn_Evening.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Evening.Location = new System.Drawing.Point(108, 16);
            this.rbtn_Evening.Name = "rbtn_Evening";
            this.rbtn_Evening.Size = new System.Drawing.Size(113, 30);
            this.rbtn_Evening.TabIndex = 1;
            this.rbtn_Evening.TabStop = true;
            this.rbtn_Evening.Text = "Evening";
            this.rbtn_Evening.UseVisualStyleBackColor = true;
            // 
            // rbtn_Moring
            // 
            this.rbtn_Moring.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Moring.AutoSize = true;
            this.rbtn_Moring.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Moring.Location = new System.Drawing.Point(-12, 16);
            this.rbtn_Moring.Name = "rbtn_Moring";
            this.rbtn_Moring.Size = new System.Drawing.Size(103, 30);
            this.rbtn_Moring.TabIndex = 0;
            this.rbtn_Moring.TabStop = true;
            this.rbtn_Moring.Text = "Moring";
            this.rbtn_Moring.UseVisualStyleBackColor = true;
            // 
            // chklb_Hobbies
            // 
            this.chklb_Hobbies.CheckOnClick = true;
            this.chklb_Hobbies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklb_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklb_Hobbies.FormattingEnabled = true;
            this.chklb_Hobbies.Items.AddRange(new object[] {
            "Reading Books",
            "Cycling",
            "Playing Football",
            "Playing Cricket",
            "Other"});
            this.chklb_Hobbies.Location = new System.Drawing.Point(237, 436);
            this.chklb_Hobbies.Name = "chklb_Hobbies";
            this.chklb_Hobbies.Size = new System.Drawing.Size(325, 147);
            this.chklb_Hobbies.TabIndex = 6;
          
            this.chklb_Hobbies.SelectedIndexChanged += new System.EventHandler(this.chklb_Hobbies_SelectedIndexChanged_1);
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(237, 114);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(325, 44);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MobNo.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_MobNo.Location = new System.Drawing.Point(237, 203);
            this.tb_MobNo.MaxLength = 10;
            this.tb_MobNo.Multiline = true;
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(325, 44);
            this.tb_MobNo.TabIndex = 2;
            this.tb_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MobNo_KeyPress);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Gender.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Gender.Controls.Add(this.rbtn_Female);
            this.gb_Gender.Controls.Add(this.rbtn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(237, 288);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(325, 71);
            this.gb_Gender.TabIndex = 58;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Female.Location = new System.Drawing.Point(158, 21);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(105, 30);
            this.rbtn_Female.TabIndex = 5;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Male.Location = new System.Drawing.Point(62, 21);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(82, 30);
            this.rbtn_Male.TabIndex = 4;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.dtp_DOB.Location = new System.Drawing.Point(237, 380);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(325, 48);
            this.dtp_DOB.TabIndex = 5;
            // 
            // tb_Other_Hobbies
            // 
            this.tb_Other_Hobbies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Other_Hobbies.Enabled = false;
            this.tb_Other_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Other_Hobbies.Location = new System.Drawing.Point(237, 593);
            this.tb_Other_Hobbies.MaxLength = 80;
            this.tb_Other_Hobbies.Multiline = true;
            this.tb_Other_Hobbies.Name = "tb_Other_Hobbies";
            this.tb_Other_Hobbies.Size = new System.Drawing.Size(325, 82);
            this.tb_Other_Hobbies.TabIndex = 7;
            // 
            // cmb_Department
            // 
            this.cmb_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(879, 28);
            this.cmb_Department.MaxLength = 40;
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(322, 40);
            this.cmb_Department.TabIndex = 7;
            // 
            // cmb_Manager_Monitor
            // 
            this.cmb_Manager_Monitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Manager_Monitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Manager_Monitor.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cmb_Manager_Monitor.FormattingEnabled = true;
            this.cmb_Manager_Monitor.Location = new System.Drawing.Point(879, 116);
            this.cmb_Manager_Monitor.MaxLength = 80;
            this.cmb_Manager_Monitor.Name = "cmb_Manager_Monitor";
            this.cmb_Manager_Monitor.Size = new System.Drawing.Size(322, 40);
            this.cmb_Manager_Monitor.TabIndex = 8;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.cmb_Designation.Location = new System.Drawing.Point(879, 384);
            this.cmb_Designation.MaxLength = 80;
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(322, 40);
            this.cmb_Designation.TabIndex = 11;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Salary.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Salary.Location = new System.Drawing.Point(879, 487);
            this.tb_Salary.MaxLength = 20;
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(322, 44);
            this.tb_Salary.TabIndex = 12;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salary_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(77, 28);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(131, 40);
            this.lbl_ID.TabIndex = 37;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(67, 116);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(151, 40);
            this.lbl_Name.TabIndex = 38;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MobNo.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo.Location = new System.Drawing.Point(56, 205);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(173, 40);
            this.lbl_MobNo.TabIndex = 43;
            this.lbl_MobNo.Text = "Mobile No";
            this.lbl_MobNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(56, 304);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(173, 40);
            this.lbl_Gender.TabIndex = 44;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(56, 384);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(173, 40);
            this.lbl_DOB.TabIndex = 45;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.Location = new System.Drawing.Point(56, 489);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(173, 40);
            this.lbl_Hobbies.TabIndex = 46;
            this.lbl_Hobbies.Text = "Hobbies";
            this.lbl_Hobbies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // lbl_Other_Hobbies
            // 
            this.lbl_Other_Hobbies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Other_Hobbies.AutoSize = true;
            this.lbl_Other_Hobbies.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other_Hobbies.Location = new System.Drawing.Point(84, 602);
            this.lbl_Other_Hobbies.Name = "lbl_Other_Hobbies";
            this.lbl_Other_Hobbies.Size = new System.Drawing.Size(117, 64);
            this.lbl_Other_Hobbies.TabIndex = 47;
            this.lbl_Other_Hobbies.Text = "Other Hobbies";
            this.lbl_Other_Hobbies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Department
            // 
            this.lbl_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Department.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(692, 28);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(181, 40);
            this.lbl_Department.TabIndex = 49;
            this.lbl_Department.Text = "Department";
            this.lbl_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Manager_Mentor
            // 
            this.lbl_Manager_Mentor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Manager_Mentor.AutoSize = true;
            this.lbl_Manager_Mentor.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manager_Mentor.Location = new System.Drawing.Point(720, 104);
            this.lbl_Manager_Mentor.Name = "lbl_Manager_Mentor";
            this.lbl_Manager_Mentor.Size = new System.Drawing.Size(125, 64);
            this.lbl_Manager_Mentor.TabIndex = 50;
            this.lbl_Manager_Mentor.Text = "Manager Mentor";
            this.lbl_Manager_Mentor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Shift_Timing
            // 
            this.lbl_Shift_Timing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Shift_Timing.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Timing.Location = new System.Drawing.Point(698, 205);
            this.lbl_Shift_Timing.Name = "lbl_Shift_Timing";
            this.lbl_Shift_Timing.Size = new System.Drawing.Size(168, 40);
            this.lbl_Shift_Timing.TabIndex = 51;
            this.lbl_Shift_Timing.Text = "Shift Timing";
            this.lbl_Shift_Timing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Project
            // 
            this.lbl_Project.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Project.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project.Location = new System.Drawing.Point(698, 304);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(168, 40);
            this.lbl_Project.TabIndex = 52;
            this.lbl_Project.Text = "Project";
            this.lbl_Project.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(698, 489);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(168, 40);
            this.lbl_Salary.TabIndex = 54;
            this.lbl_Salary.Text = "Salary";
            this.lbl_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(698, 600);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(168, 68);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.Location = new System.Drawing.Point(699, 388);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(167, 32);
            this.lbl_Designation.TabIndex = 53;
            this.lbl_Designation.Text = "Designation";
            this.lbl_Designation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.AutoSize = true;
            this.btn_Search.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(572, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(109, 56);
            this.btn_Search.TabIndex = 59;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Add_Employee_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1282, 832);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Header);
            this.MinimumSize = new System.Drawing.Size(1300, 850);
            this.Name = "frm_Add_Employee_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Details";
            this.Load += new System.EventHandler(this.frm_Add_Employee_Info_Load);
            this.pnl_Header.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Project.ResumeLayout(false);
            this.gb_Project.PerformLayout();
            this.gb_Shift_Timing.ResumeLayout(false);
            this.gb_Shift_Timing.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Other_Hobbies;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Manager_Mentor;
        private System.Windows.Forms.Label lbl_Shift_Timing;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.CheckedListBox chklb_Hobbies;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.GroupBox gb_Shift_Timing;
        private System.Windows.Forms.RadioButton rbtn_Night;
        private System.Windows.Forms.RadioButton rbtn_Evening;
        private System.Windows.Forms.RadioButton rbtn_Moring;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Other_Hobbies;
        private System.Windows.Forms.GroupBox gb_Project;
        private System.Windows.Forms.CheckBox chkb_Reliance;
        private System.Windows.Forms.CheckBox chkb_D_Mart;
        private System.Windows.Forms.CheckBox chkb_IPL;
        private System.Windows.Forms.CheckBox chkb_Tata;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.ComboBox cmb_Manager_Monitor;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
    }
}

