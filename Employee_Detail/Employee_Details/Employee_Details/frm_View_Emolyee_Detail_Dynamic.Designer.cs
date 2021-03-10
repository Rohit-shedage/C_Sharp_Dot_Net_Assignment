namespace Employee_Details
{
    partial class frm_View_Emolyee_Detail_Dynamic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Add_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.cmb_Qualification = new System.Windows.Forms.ComboBox();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
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
            this.pnl_Add_Header.TabIndex = 2;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(859, 37);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(617, 45);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "View  Employee Details Dynamic";
            // 
            // cmb_Qualification
            // 
            this.cmb_Qualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.cmb_Qualification.FormattingEnabled = true;
            this.cmb_Qualification.Location = new System.Drawing.Point(828, 156);
            this.cmb_Qualification.Name = "cmb_Qualification";
            this.cmb_Qualification.Size = new System.Drawing.Size(419, 46);
            this.cmb_Qualification.TabIndex = 1;
            this.cmb_Qualification.SelectedIndexChanged += new System.EventHandler(this.cmb_Qualification_SelectedIndexChanged);
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Qualification.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.Location = new System.Drawing.Point(422, 160);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(223, 40);
            this.lbl_Qualification.TabIndex = 6;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(828, 302);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(419, 45);
            this.tb_ID.TabIndex = 2;
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.Location = new System.Drawing.Point(422, 303);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(219, 40);
            this.lbl_Employee_ID.TabIndex = 9;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1370, 299);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 50);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(1583, 301);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(137, 46);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // dgv_View_All_Emp
            // 
            this.dgv_View_All_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Emp.BackgroundColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View_All_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Emp.Location = new System.Drawing.Point(12, 450);
            this.dgv_View_All_Emp.Name = "dgv_View_All_Emp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_All_Emp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_View_All_Emp.RowTemplate.Height = 24;
            this.dgv_View_All_Emp.Size = new System.Drawing.Size(1878, 497);
            this.dgv_View_All_Emp.TabIndex = 10;
            // 
            // frm_View_Emolyee_Detail_Dynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1902, 973);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_All_Emp);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Employee_ID);
            this.Controls.Add(this.cmb_Qualification);
            this.Controls.Add(this.lbl_Qualification);
            this.Controls.Add(this.pnl_Add_Header);
            this.Name = "frm_View_Emolyee_Detail_Dynamic";
            this.Text = "View Emolyee Detail Dynamic";
            this.Load += new System.EventHandler(this.frm_View_Emolyee_Detail_Dynamic_Load);
            this.pnl_Add_Header.ResumeLayout(false);
            this.pnl_Add_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.ComboBox cmb_Qualification;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridView dgv_View_All_Emp;
    }
}