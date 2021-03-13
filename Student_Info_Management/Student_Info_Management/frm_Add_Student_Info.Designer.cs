namespace Student_Info_Management
{
    partial class frm_Add_Student_Info
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
            this.lbl_Stud_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Stud_Name = new System.Windows.Forms.Label();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.lbl_MobNo = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_City = new System.Windows.Forms.Label();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Student_Info = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1249, 100);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(406, 30);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(451, 41);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Add Student Infromation";
            this.lbl_Header.Click += new System.EventHandler(this.lbl_Header_Click);
            // 
            // lbl_Stud_ID
            // 
            this.lbl_Stud_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Stud_ID.AutoSize = true;
            this.lbl_Stud_ID.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_ID.Location = new System.Drawing.Point(221, 196);
            this.lbl_Stud_ID.Name = "lbl_Stud_ID";
            this.lbl_Stud_ID.Size = new System.Drawing.Size(53, 34);
            this.lbl_Stud_ID.TabIndex = 2;
            this.lbl_Stud_ID.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(723, 190);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(339, 40);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(723, 308);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(339, 40);
            this.tb_Name.TabIndex = 2;
            // 
            // lbl_Stud_Name
            // 
            this.lbl_Stud_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Stud_Name.AutoSize = true;
            this.lbl_Stud_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Name.Location = new System.Drawing.Point(221, 314);
            this.lbl_Stud_Name.Name = "lbl_Stud_Name";
            this.lbl_Stud_Name.Size = new System.Drawing.Size(91, 34);
            this.lbl_Stud_Name.TabIndex = 5;
            this.lbl_Stud_Name.Text = "Name";
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MobNo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo.Location = new System.Drawing.Point(723, 416);
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(339, 40);
            this.tb_MobNo.TabIndex = 3;
            // 
            // lbl_MobNo
            // 
            this.lbl_MobNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MobNo.AutoSize = true;
            this.lbl_MobNo.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo.Location = new System.Drawing.Point(221, 422);
            this.lbl_MobNo.Name = "lbl_MobNo";
            this.lbl_MobNo.Size = new System.Drawing.Size(155, 34);
            this.lbl_MobNo.TabIndex = 7;
            this.lbl_MobNo.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(221, 530);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(84, 34);
            this.lbl_DOB.TabIndex = 9;
            this.lbl_DOB.Text = "DOB";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(723, 519);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(339, 40);
            this.dtp_DOB.TabIndex = 4;
            // 
            // lbl_City
            // 
            this.lbl_City.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(221, 619);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(69, 34);
            this.lbl_City.TabIndex = 11;
            this.lbl_City.Text = "City";
            // 
            // cmb_City
            // 
            this.cmb_City.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_City.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Karad",
            "Sangli",
            "Satara",
            "Patan"});
            this.cmb_City.Location = new System.Drawing.Point(723, 609);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(339, 39);
            this.cmb_City.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(275, 755);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 54);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Student_Info
            // 
            this.btn_View_Student_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_View_Student_Info.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_Info.Location = new System.Drawing.Point(659, 755);
            this.btn_View_Student_Info.Name = "btn_View_Student_Info";
            this.btn_View_Student_Info.Size = new System.Drawing.Size(290, 54);
            this.btn_View_Student_Info.TabIndex = 7;
            this.btn_View_Student_Info.Text = "View Student Info";
            this.btn_View_Student_Info.UseVisualStyleBackColor = true;
            this.btn_View_Student_Info.Click += new System.EventHandler(this.btn_View_Student_Info_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(133, 42);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frm_Add_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 876);
            this.Controls.Add(this.btn_View_Student_Info);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.tb_MobNo);
            this.Controls.Add(this.lbl_MobNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Stud_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Stud_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_Add_Student_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Information";
            this.Load += new System.EventHandler(this.frm_Add_Student_Info_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Stud_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Stud_Name;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.Label lbl_MobNo;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Student_Info;
        private System.Windows.Forms.Button btn_Back;
    }
}