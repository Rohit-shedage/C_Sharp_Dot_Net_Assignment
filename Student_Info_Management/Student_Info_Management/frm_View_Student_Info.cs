using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info_Management
{
    public partial class frm_View_Student_Info : Form
    {
        public frm_View_Student_Info()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stud_Info_DBDataSet.tbl_Add_Stud_Info' table. You can move, or remove it, as needed.
            this.tbl_Add_Stud_InfoTableAdapter.Fill(this.stud_Info_DBDataSet.tbl_Add_Stud_Info);

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Info AObj = new frm_Add_Student_Info();
            this.Close();
            AObj.Show();
        }
    }
}
