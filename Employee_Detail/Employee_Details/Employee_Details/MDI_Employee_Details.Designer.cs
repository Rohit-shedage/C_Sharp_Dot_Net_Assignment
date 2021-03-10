namespace Employee_Details
{
    partial class MDI_Employee_Details
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDynamicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDynamicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQualificatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Coral;
            this.menuStrip.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.qualificationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1902, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeeDynamicToolStripMenuItem,
            this.viewEmployeeDynamicToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(82, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewEmployeeDynamicToolStripMenuItem
            // 
            this.viewEmployeeDynamicToolStripMenuItem.Name = "viewEmployeeDynamicToolStripMenuItem";
            this.viewEmployeeDynamicToolStripMenuItem.Size = new System.Drawing.Size(383, 34);
            this.viewEmployeeDynamicToolStripMenuItem.Text = "View All Employee Detail";
            this.viewEmployeeDynamicToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeDynamicToolStripMenuItem_Click);
            // 
            // viewEmployeeDynamicToolStripMenuItem1
            // 
            this.viewEmployeeDynamicToolStripMenuItem1.Name = "viewEmployeeDynamicToolStripMenuItem1";
            this.viewEmployeeDynamicToolStripMenuItem1.Size = new System.Drawing.Size(383, 34);
            this.viewEmployeeDynamicToolStripMenuItem1.Text = "View Employee Dynamic";
            this.viewEmployeeDynamicToolStripMenuItem1.Click += new System.EventHandler(this.viewEmployeeDynamicToolStripMenuItem1_Click);
            // 
            // qualificationToolStripMenuItem
            // 
            this.qualificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQualificatioToolStripMenuItem});
            this.qualificationToolStripMenuItem.Name = "qualificationToolStripMenuItem";
            this.qualificationToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.qualificationToolStripMenuItem.Text = "Qualification";
            // 
            // addQualificatioToolStripMenuItem
            // 
            this.addQualificatioToolStripMenuItem.Name = "addQualificatioToolStripMenuItem";
            this.addQualificatioToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.addQualificatioToolStripMenuItem.Text = "Add Qualification";
            this.addQualificatioToolStripMenuItem.Click += new System.EventHandler(this.addQualificatioToolStripMenuItem_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1753, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(137, 38);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(1564, 4);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(146, 31);
            this.lbl_User.TabIndex = 8;
            this.lbl_User.Text = "User Name";
            // 
            // MDI_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1013);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Employee Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Employee_Details_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDynamicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQualificatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDynamicToolStripMenuItem1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_User;
    }
}



