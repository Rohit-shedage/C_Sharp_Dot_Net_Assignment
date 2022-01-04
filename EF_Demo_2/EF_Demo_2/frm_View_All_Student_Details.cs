using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Demo_2
{
    public partial class frm_View_All_Student_Details : Form
    {
        public frm_View_All_Student_Details()
        {
            InitializeComponent();
        }
        int ID = 0;
        public frm_View_All_Student_Details(int iNo)
        {
            InitializeComponent();
            if (iNo == 1)
            {
                lbl_Header.Text = "Updated";

            }
            if (iNo == 2)
            {
                lbl_Header.Text = "Deleted";
            }
        }

        private void frm_View_All_Student_Details_Load(object sender, EventArgs e)
        {
            //lbl_Header.Text = "Update";
            using (Student_DBEntities db = new Student_DBEntities())
            {
                dgv_Student_Details.DataSource = (from s in db.tbl_Student select s).ToList();
            }
        }
    }
}
