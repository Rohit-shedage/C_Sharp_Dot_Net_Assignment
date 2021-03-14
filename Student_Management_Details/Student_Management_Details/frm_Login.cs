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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Sumit.Enabled = true;
        }

        private void btn_Sumit_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfull....!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_Student_Information ASobj = new frm_Add_Student_Information();
                ASobj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password..!!","Failure",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
