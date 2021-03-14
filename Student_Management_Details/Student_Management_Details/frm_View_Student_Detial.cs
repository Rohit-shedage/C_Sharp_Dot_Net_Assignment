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
    public partial class frm_View_Student_Detial : Form
    {
        public frm_View_Student_Detial()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Detial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Detail_dbDataSet.Add_Student_Detail' table. You can move, or remove it, as needed.
            this.add_Student_DetailTableAdapter.Fill(this.student_Detail_dbDataSet.Add_Student_Detail);

        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Information ASobj = new frm_Add_Student_Information();

            ASobj.Show();
            this.Hide();
        }
    }
}
