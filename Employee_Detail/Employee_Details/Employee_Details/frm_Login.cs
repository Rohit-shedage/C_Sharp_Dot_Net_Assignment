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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Login_Emp WHERE Username = '" + tb_Username.Text + "' AND Password = '" + tb_Password.Text + "'",Global_Function_Varaible.con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Global_Function_Varaible.UName = tb_Username.Text;

                MDI_Employee_Details MObj = new MDI_Employee_Details();
                MObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Global_Function_Varaible.Con_Close();

            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
                
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
