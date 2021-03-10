using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Details
{
    public partial class frm_View_All_Employee : Form
    {
        public frm_View_All_Employee()
        {
            InitializeComponent();
        }

        private void frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();

           SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Add_Emp",Global_Function_Varaible.con);

           DataTable dt = new DataTable();
           sda.Fill(dt);
           dgv_View_All_Emp.DataSource = dt;

             Global_Function_Varaible.Con_Close();
        }

        private void dgv_View_All_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
