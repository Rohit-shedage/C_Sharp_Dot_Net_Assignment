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
    public partial class frm_Student_Login : Form
    {
        public frm_Student_Login()
        {
            InitializeComponent();
        }

        private void frm_Student_Login_Load(object sender, EventArgs e)
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
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfull...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_Student_Info ASObj = new frm_Add_Student_Info();
                this.Hide();
                ASObj.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password..!!","Failure",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
            tb_Username.Focus();
        }

       
    }
}
