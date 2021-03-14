namespace Student_Management_Details
{
    partial class frm_View_Student_Detial
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_View_Student = new System.Windows.Forms.Panel();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.lbl_View_Header = new System.Windows.Forms.Label();
            this.dgv_View_Student = new System.Windows.Forms.DataGridView();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStudentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Detail_dbDataSet = new Student_Management_Details.Student_Detail_dbDataSet();
            this.add_Student_DetailTableAdapter = new Student_Management_Details.Student_Detail_dbDataSetTableAdapters.Add_Student_DetailTableAdapter();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pl_View_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Detail_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_View_Student
            // 
            this.pl_View_Student.BackColor = System.Drawing.Color.DarkRed;
            this.pl_View_Student.Controls.Add(this.btn_GoBack);
            this.pl_View_Student.Controls.Add(this.lbl_View_Header);
            this.pl_View_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_View_Student.Location = new System.Drawing.Point(0, 0);
            this.pl_View_Student.Name = "pl_View_Student";
            this.pl_View_Student.Size = new System.Drawing.Size(1662, 155);
            this.pl_View_Student.TabIndex = 0;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_GoBack.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(3, 3);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(149, 35);
            this.btn_GoBack.TabIndex = 1;
            this.btn_GoBack.Text = "GoBack";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // lbl_View_Header
            // 
            this.lbl_View_Header.AutoSize = true;
            this.lbl_View_Header.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_View_Header.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Header.Location = new System.Drawing.Point(687, 47);
            this.lbl_View_Header.Name = "lbl_View_Header";
            this.lbl_View_Header.Size = new System.Drawing.Size(313, 52);
            this.lbl_View_Header.TabIndex = 0;
            this.lbl_View_Header.Text = "View All Student ";
            // 
            // dgv_View_Student
            // 
            this.dgv_View_Student.AllowUserToAddRows = false;
            this.dgv_View_Student.AllowUserToDeleteRows = false;
            this.dgv_View_Student.AutoGenerateColumns = false;
            this.dgv_View_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgv_View_Student.DataSource = this.addStudentDetailBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Student.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_View_Student.Location = new System.Drawing.Point(0, 155);
            this.dgv_View_Student.Name = "dgv_View_Student";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Student.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_View_Student.RowTemplate.Height = 24;
            this.dgv_View_Student.Size = new System.Drawing.Size(1662, 559);
            this.dgv_View_Student.TabIndex = 1;
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "Stud_ID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "Stud_ID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // addStudentDetailBindingSource
            // 
            this.addStudentDetailBindingSource.DataMember = "Add_Student_Detail";
            this.addStudentDetailBindingSource.DataSource = this.student_Detail_dbDataSet;
            // 
            // student_Detail_dbDataSet
            // 
            this.student_Detail_dbDataSet.DataSetName = "Student_Detail_dbDataSet";
            this.student_Detail_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_Student_DetailTableAdapter
            // 
            this.add_Student_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(739, 811);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(123, 60);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // frm_View_Student_Detial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.dgv_View_Student);
            this.Controls.Add(this.pl_View_Student);
            this.Name = "frm_View_Student_Detial";
            this.Text = "View Student Detial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Student_Detial_Load);
            this.pl_View_Student.ResumeLayout(false);
            this.pl_View_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Detail_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_View_Student;
        private System.Windows.Forms.Label lbl_View_Header;
        private System.Windows.Forms.DataGridView dgv_View_Student;
        private Student_Detail_dbDataSet student_Detail_dbDataSet;
        private System.Windows.Forms.BindingSource addStudentDetailBindingSource;
        private Student_Detail_dbDataSetTableAdapters.Add_Student_DetailTableAdapter add_Student_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Next;
    }
}