using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_Details
{
    public partial class frm_View_Stud : Form
    {
        public frm_View_Stud()
        {
            InitializeComponent();
        }

        private void frm_View_Stud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Detail_dbDataSet1.Add_Student_Detail' table. You can move, or remove it, as needed.
            this.add_Student_DetailTableAdapter.Fill(this.student_Detail_dbDataSet1.Add_Student_Detail);

        }
    }
}
