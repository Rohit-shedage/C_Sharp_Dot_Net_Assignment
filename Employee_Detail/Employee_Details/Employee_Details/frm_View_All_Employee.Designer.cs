namespace Employee_Details
{
    partial class frm_View_All_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Add_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_View_All_Emp = new System.Windows.Forms.DataGridView();
            this.pnl_Add_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Add_Header
            // 
            this.pnl_Add_Header.BackColor = System.Drawing.Color.Brown;
            this.pnl_Add_Header.Controls.Add(this.lbl_Header);
            this.pnl_Add_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add_Header.Name = "pnl_Add_Header";
            this.pnl_Add_Header.Size = new System.Drawing.Size(1902, 124);
            this.pnl_Add_Header.TabIndex = 1;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(859, 37);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(504, 45);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "View All Employee Details";
            // 
            // dgv_View_All_Emp
            // 
            this.dgv_View_All_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_All_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_View_All_Emp.Location = new System.Drawing.Point(0, 124);
            this.dgv_View_All_Emp.Name = "dgv_View_All_Emp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Emp.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_All_Emp.RowTemplate.Height = 24;
            this.dgv_View_All_Emp.Size = new System.Drawing.Size(1902, 768);
            this.dgv_View_All_Emp.TabIndex = 2;
            this.dgv_View_All_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_View_All_Emp_CellContentClick);
            // 
            // frm_View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Emp);
            this.Controls.Add(this.pnl_Add_Header);
            this.Name = "frm_View_All_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Employee";
            this.Load += new System.EventHandler(this.frm_View_All_Employee_Load);
            this.pnl_Add_Header.ResumeLayout(false);
            this.pnl_Add_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_View_All_Emp;
    }
}