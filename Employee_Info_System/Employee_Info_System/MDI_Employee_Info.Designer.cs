namespace Employee_Info_System
{
    partial class MDI_Employee_Info
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
            this.ms_MDI_Emp = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSingleEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addManagerMentorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSingleEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MDI_Emp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MDI_Emp
            // 
            this.ms_MDI_Emp.Font = new System.Drawing.Font("Yu Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_MDI_Emp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_MDI_Emp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.viewEmployeeToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.ms_MDI_Emp.Location = new System.Drawing.Point(0, 0);
            this.ms_MDI_Emp.Name = "ms_MDI_Emp";
            this.ms_MDI_Emp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.ms_MDI_Emp.Size = new System.Drawing.Size(1282, 44);
            this.ms_MDI_Emp.TabIndex = 0;
            this.ms_MDI_Emp.Text = "MenuStrip";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeDetailsToolStripMenuItem,
            this.updateEmployeeDetailsToolStripMenuItem,
            this.deleteSingleEmployeeDetailsToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(163, 40);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeDetailsToolStripMenuItem
            // 
            this.addEmployeeDetailsToolStripMenuItem.Name = "addEmployeeDetailsToolStripMenuItem";
            this.addEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(455, 40);
            this.addEmployeeDetailsToolStripMenuItem.Text = "Add Employee Details";
            this.addEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewEmployeeToolStripMenuItem
            // 
            this.viewEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllEmployeeToolStripMenuItem,
            this.viewSingleEmployeeToolStripMenuItem});
            this.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem";
            this.viewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(209, 40);
            this.viewEmployeeToolStripMenuItem.Text = "View Employee";
            // 
            // viewAllEmployeeToolStripMenuItem
            // 
            this.viewAllEmployeeToolStripMenuItem.Name = "viewAllEmployeeToolStripMenuItem";
            this.viewAllEmployeeToolStripMenuItem.Size = new System.Drawing.Size(364, 36);
            this.viewAllEmployeeToolStripMenuItem.Text = "View All Employee";
            this.viewAllEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewAllEmployeeToolStripMenuItem_Click);
            // 
            // viewSingleEmployeeToolStripMenuItem
            // 
            this.viewSingleEmployeeToolStripMenuItem.Name = "viewSingleEmployeeToolStripMenuItem";
            this.viewSingleEmployeeToolStripMenuItem.Size = new System.Drawing.Size(364, 36);
            this.viewSingleEmployeeToolStripMenuItem.Text = "View Single Employee";
            this.viewSingleEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewSingleEmployeeToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem1,
            this.addManagerMentorToolStripMenuItem1});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(246, 40);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addDepartmentToolStripMenuItem1
            // 
            this.addDepartmentToolStripMenuItem1.Name = "addDepartmentToolStripMenuItem1";
            this.addDepartmentToolStripMenuItem1.Size = new System.Drawing.Size(354, 36);
            this.addDepartmentToolStripMenuItem1.Text = "Add Department";
            this.addDepartmentToolStripMenuItem1.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem1_Click);
            // 
            // addManagerMentorToolStripMenuItem1
            // 
            this.addManagerMentorToolStripMenuItem1.Name = "addManagerMentorToolStripMenuItem1";
            this.addManagerMentorToolStripMenuItem1.Size = new System.Drawing.Size(354, 36);
            this.addManagerMentorToolStripMenuItem1.Text = "Add Manager Mentor";
            this.addManagerMentorToolStripMenuItem1.Click += new System.EventHandler(this.addManagerMentorToolStripMenuItem1_Click);
            // 
            // updateEmployeeDetailsToolStripMenuItem
            // 
            this.updateEmployeeDetailsToolStripMenuItem.Name = "updateEmployeeDetailsToolStripMenuItem";
            this.updateEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(455, 40);
            this.updateEmployeeDetailsToolStripMenuItem.Text = "Update Employee Details";
            this.updateEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeDetailsToolStripMenuItem_Click);
            // 
            // deleteSingleEmployeeDetailsToolStripMenuItem
            // 
            this.deleteSingleEmployeeDetailsToolStripMenuItem.Name = "deleteSingleEmployeeDetailsToolStripMenuItem";
            this.deleteSingleEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(540, 40);
            this.deleteSingleEmployeeDetailsToolStripMenuItem.Text = "Delete Single Employee Details";
            this.deleteSingleEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.deleteSingleEmployeeDetailsToolStripMenuItem_Click);
            // 
            // MDI_Employee_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 823);
            this.Controls.Add(this.ms_MDI_Emp);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_MDI_Emp;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1300, 870);
            this.Name = "MDI_Employee_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MDI Employee Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Employee_Info_Load);
            this.ms_MDI_Emp.ResumeLayout(false);
            this.ms_MDI_Emp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip ms_MDI_Emp;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addManagerMentorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSingleEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSingleEmployeeDetailsToolStripMenuItem;
    }
}



