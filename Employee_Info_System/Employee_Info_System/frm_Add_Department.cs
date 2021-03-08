using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Info_System
{
    public partial class frm_Add_Department : Form
    {

        Global_Function_And_DB_Con GObj = new Global_Function_And_DB_Con();

        public frm_Add_Department()
        {
            InitializeComponent();
        }

        private void frm_Add_Department_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Department", "SELECT MAX(ID) FROM tbl_Add_Department",101));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "")
            {
                GObj.FillTableDB("INSERT INTO tbl_Add_Department VALUES(" + tb_ID.Text + ",'" + tb_Name.Text + "')");

                MessageBox.Show("Record Save Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("1st Fill All The Filleds...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_Name.Text = "";
            tb_ID.Text =  Convert.ToString(GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Department", "SELECT MAX(ID) FROM tbl_Add_Department", 101));
        }
    }
}
