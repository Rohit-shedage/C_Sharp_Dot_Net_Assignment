namespace Employee_Info_System
{
    partial class frm_Add_Manager_Mentor
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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Join_Date = new System.Windows.Forms.Label();
            this.dtp_Join_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.pnl_Header.TabIndex = 1;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Header.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(464, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(452, 56);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Manager Mentor";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.967442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.04133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.79383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.39007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.71906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.00669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.969173F));
            this.tableLayoutPanel1.Controls.Add(this.tb_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_MobNo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_Gender, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_MobNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Gender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DOB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_DOB, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Salary, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Salary, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Department, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Department, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Join_Date, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Join_Date, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Refresh, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1196, 623);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_ID.Location = new System.Drawing.Point(230, 40);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(326, 44);
            this.tb_ID.TabIndex = 23;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(230, 164);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(326, 44);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Name_KeyDown);
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MobNo.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_MobNo.Location = new System.Drawing.Point(230, 288);
            this.tb_MobNo.MaxLength = 10;
            this.tb_MobNo.Multiline = true;
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(326, 44);
            this.tb_MobNo.TabIndex = 2;
            this.tb_MobNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_MobNo_KeyDown);
            this.tb_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MobNo_KeyPress);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Gender.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Gender.Controls.Add(this.rbtn_Female);
            this.gb_Gender.Controls.Add(this.rbtn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(230, 398);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(326, 71);
            this.gb_Gender.TabIndex = 58;
            this.gb_Gender.TabStop = false;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Female.Location = new System.Drawing.Point(159, 21);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(105, 30);
            this.rbtn_Female.TabIndex = 4;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Female";
            this.rbtn_Female.UseVisualStyleBackColor = true;
            this.rbtn_Female.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtn_Female_KeyDown);
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Male.Location = new System.Drawing.Point(63, 21);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(82, 30);
            this.rbtn_Male.TabIndex = 3;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Male";
            this.rbtn_Male.UseVisualStyleBackColor = true;
            this.rbtn_Male.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtn_Male_KeyDown);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(71, 42);
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
            this.lbl_Name.Location = new System.Drawing.Point(61, 166);
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
            this.lbl_MobNo.Location = new System.Drawing.Point(50, 290);
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
            this.lbl_Gender.Location = new System.Drawing.Point(50, 414);
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
            this.lbl_DOB.Location = new System.Drawing.Point(642, 42);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(173, 40);
            this.lbl_DOB.TabIndex = 45;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.dtp_DOB.Location = new System.Drawing.Point(826, 38);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(317, 48);
            this.dtp_DOB.TabIndex = 5;
            this.dtp_DOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_DOB_KeyDown);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(642, 414);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(173, 40);
            this.lbl_Salary.TabIndex = 54;
            this.lbl_Salary.Text = "Salary";
            this.lbl_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Salary.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.tb_Salary.Location = new System.Drawing.Point(826, 412);
            this.tb_Salary.MaxLength = 20;
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(317, 44);
            this.tb_Salary.TabIndex = 8;
            this.tb_Salary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Salary_KeyDown);
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salary_KeyPress);
            // 
            // lbl_Department
            // 
            this.lbl_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(647, 294);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(164, 32);
            this.lbl_Department.TabIndex = 49;
            this.lbl_Department.Text = "Department";
            this.lbl_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Department
            // 
            this.cmb_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Department.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(826, 290);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(317, 40);
            this.cmb_Department.TabIndex = 7;
            this.cmb_Department.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Department_KeyDown);
            // 
            // lbl_Join_Date
            // 
            this.lbl_Join_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Join_Date.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Join_Date.Location = new System.Drawing.Point(653, 166);
            this.lbl_Join_Date.Name = "lbl_Join_Date";
            this.lbl_Join_Date.Size = new System.Drawing.Size(151, 40);
            this.lbl_Join_Date.TabIndex = 65;
            this.lbl_Join_Date.Text = "Join Date";
            this.lbl_Join_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Join_Date
            // 
            this.dtp_Join_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Join_Date.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.dtp_Join_Date.Location = new System.Drawing.Point(826, 162);
            this.dtp_Join_Date.Name = "dtp_Join_Date";
            this.dtp_Join_Date.Size = new System.Drawing.Size(317, 48);
            this.dtp_Join_Date.TabIndex = 6;
            this.dtp_Join_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_Join_Date_KeyDown);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(303, 525);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 68);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
          
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(639, 525);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(180, 68);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
          
            // 
            // frm_Add_Manager_Mentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 832);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 850);
            this.Name = "frm_Add_Manager_Mentor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Manager_Mentor";
            this.Load += new System.EventHandler(this.frm_Add_Manager_Mentor_Load);
            this.pnl_Header.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Join_Date;
        private System.Windows.Forms.DateTimePicker dtp_Join_Date;
    }
}