using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Regetration_Tab_Control
{
    public partial class frm_Login : Form
    {
        Global_Function_Varaibles GFVObj = new Global_Function_Varaibles();
        public frm_Login()
        {
            InitializeComponent();
        }

        string AdminKey = "";
        private void frm_Login_Load(object sender, EventArgs e)
        {

            AdminKey = Convert.ToString(GFVObj.DB_Name_Contain("SELECT * FROM tbl_Add_User WHERE ID = 1 ","Admin_Key"));
           
        }

        void ClearControlsOfAddUser()
        {
            tb_Add_Username.Clear();
            tb_Add_Password.Clear();
            tb_Add_Confirm.Clear();
            tb_Add_Admin_Hint.Clear();
            lbl_Error.Visible = false;
            lbl_Password_Error.Visible = false;
            btn_Save.Enabled = false;
            chb_Add_Admin_Key_Show.Checked = false;
            chb_Add_Confirm_Password.Checked = false;
            chb_Add_Show_Password.Checked = false;

        }

        void ClearControlsOfForgotPassword()
        {
            tb_Forgot_Username.Clear();
            tb_Forgot_Admin_Hint.Clear();
            tb_Forgot_New_Password.Clear();
            tb_Forgot_New_Password.Enabled = false;
            tb_Forgot_Confirm_Password.Clear();
            tb_Forgot_Confirm_Password.Enabled = false;
            lbl_Forgot_Error_AdminKey.Visible = false;
            lbl_Forgot_Error_Password.Visible = false;
            lbl_Forgot_Error_Username.Visible = false;
            btn_Forgot_Save.Enabled = false;
            chb_Forgot_AdminKey_Show.Checked = false;
            chb_Forgot_ConfirmPassword_Show.Checked = false;
            chb_Forgot_NewPassword_Show.Checked = false;
        }

        private void tabPage_Forgot_Password_Click(object sender, EventArgs e)
        {
            tb_Forgot_Username.Focus();
            ClearControlsOfForgotPassword();
        }

        private void tabPage_Add_New_User_Click(object sender, EventArgs e)
        {
            tb_Add_Username.Focus();
            ClearControlsOfAddUser();
        }

        //Show Password

        private void chb_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Show_Password.Checked)
            {
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Password.PasswordChar = '*';
            }
        }

        private void chb_Add_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Add_Show_Password.Checked)
            {
                tb_Add_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Add_Password.PasswordChar = '*';
            }
        }

        private void chb_Add_Confirm_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Add_Confirm_Password.Checked)
            {
                tb_Add_Confirm.PasswordChar = '\0';
            }
            else
            {
                tb_Add_Confirm.PasswordChar = '*';
            }
        }

        private void chb_Add_Admin_Key_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Add_Admin_Key_Show.Checked)
            {
                tb_Add_Admin_Hint.PasswordChar = '\0';
            }
            else
            {
                tb_Add_Admin_Hint.PasswordChar = '*';
            }
        }

        private void chb_Forgot_AdminKey_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Forgot_AdminKey_Show.Checked)
            {
                tb_Forgot_Admin_Hint.PasswordChar = '\0';
            }
            else
            {
                tb_Forgot_Admin_Hint.PasswordChar = '*';
            }
        }

        private void chb_Forgot_NewPassword_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Forgot_NewPassword_Show.Checked)
            {
                tb_Forgot_New_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Forgot_New_Password.PasswordChar = '*';
            }
        }

        private void chb_Forgot_ConfirmPassword_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Forgot_ConfirmPassword_Show.Checked)
            {
                tb_Forgot_Confirm_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Forgot_Confirm_Password.PasswordChar = '*';
            }
        }

        private void tb_Forgot_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Forgot_Error_Username.Visible = false;
        }

        private void tb_Forgot_Admin_Hint_TextChanged(object sender, EventArgs e)
        {
            lbl_Forgot_Error_AdminKey.Visible = false;
        }

        private void tabpage_Login_Click(object sender, EventArgs e)
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

        private void tb_Forgot_Username_Leave(object sender, EventArgs e)
        {
            string Forgot_Username = "";
            GFVObj.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT Username FROM tbl_Add_User WHERE Username = '" + tb_Forgot_Username.Text + "'", GFVObj.con);
            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                Forgot_Username = Obj.GetString(Obj.GetOrdinal("Username"));
            }
            cmd.Dispose();
            GFVObj.DisconnectDB();

            if (tb_Forgot_Username.Text == Forgot_Username)
            {
                lbl_Forgot_Error_Username.Visible = true;
                lbl_Forgot_Error_Username.Text = "Matched Username";
                lbl_Forgot_Error_Username.ForeColor = Color.Green;
                tb_Forgot_New_Password.Enabled = true;
                tb_Forgot_Confirm_Password.Enabled = true;
               
            }
            else
            {

                lbl_Forgot_Error_Username.Visible = true;
                lbl_Forgot_Error_Username.Text = "UnMatched Username";
                lbl_Forgot_Error_Username.ForeColor = Color.Red;
                tb_Forgot_Username.Focus();
            }
        }

        private void tb_Forgot_Admin_Hint_Leave(object sender, EventArgs e)
        {
            string Forgot_Username = "";
            string Forgot_Admin_Key = "";
            GFVObj.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT Username,Admin_Key FROM tbl_Add_User WHERE Username = '" + tb_Forgot_Username.Text + "' AND Admin_Key = '" +  tb_Forgot_Admin_Hint.Text + "'", GFVObj.con);
            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                Forgot_Username = Obj.GetString(Obj.GetOrdinal("Username"));
                Forgot_Admin_Key = Obj.GetString(Obj.GetOrdinal("Admin_Key"));
            }
            cmd.Dispose();
            GFVObj.DisconnectDB();

            if (tb_Forgot_Username.Text == Forgot_Username && tb_Forgot_Admin_Hint.Text == Forgot_Admin_Key)
            {
                lbl_Forgot_Error_AdminKey.Visible = true;
                lbl_Forgot_Error_AdminKey.Text = "Matched Username";
                lbl_Forgot_Error_AdminKey.ForeColor = Color.Green;
                
            }
            else
            {

                lbl_Forgot_Error_AdminKey.Visible = true;
                lbl_Forgot_Error_AdminKey.Text = "UnMatched Username";
                lbl_Forgot_Error_AdminKey.ForeColor = Color.Red;
                tb_Forgot_Username.Focus();
            }
        }

        private void tb_Forgot_Confirm_Password_TextChanged(object sender, EventArgs e)
        {
            if (tb_Forgot_New_Password.Text == tb_Forgot_Confirm_Password.Text)
            {
                lbl_Forgot_Error_Password.Visible = true;
                lbl_Forgot_Error_Password.Text = "Matched Confirm Password";
                lbl_Forgot_Error_Password.ForeColor = Color.Green;
                btn_Forgot_Save.Enabled = true;
            }
            else
            {
                lbl_Forgot_Error_Password.Visible = true;
                lbl_Forgot_Error_Password.Text = "Invalid Confirm Password";
                lbl_Forgot_Error_Password.ForeColor = Color.Red;

            }
        }

        private void tb_Add_Admin_Hint_TextChanged(object sender, EventArgs e)
        {
            if (AdminKey == tb_Add_Admin_Hint.Text)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "Matched Admin Key";
                lbl_Error.ForeColor = Color.Green;
                btn_Save.Enabled = true;
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "Invalid Admin Key";
                lbl_Error.ForeColor = Color.Red;

            }
        }

       

        private void tb_Add_Confirm_TextChanged(object sender, EventArgs e)
        {
            if (tb_Add_Password.Text == tb_Add_Confirm.Text)
            {
                lbl_Password_Error.Visible = true;
                lbl_Password_Error.Text = "Matched Confirm Password";
                lbl_Password_Error.ForeColor = Color.Green;
                tb_Add_Admin_Hint.Enabled = true;
            }
            else
            {
                lbl_Password_Error.Visible = true;
                lbl_Password_Error.Text = "Invalid Confirm Password";
                lbl_Password_Error.ForeColor = Color.Red;

            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            GFVObj.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_Add_User WHERE Username = '" + tb_Username.Text + "' AND Password = '" + tb_Password.Text + "'", GFVObj.con);
          
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                //MessageBox.Show("Login Successfully....!!!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Not Matched Username or Password....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            chb_Show_Password.Checked = false;
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string UserKey = "";
            string CurrentYear = DateTime.Now.Year.ToString();

            UserKey = tb_Add_Username.Text + "_" + CurrentYear;

            if (tb_Add_Username.Text != "" && tb_Add_Password.Text != "" && tb_Add_Confirm.Text != "" && tb_Add_Admin_Hint.Text != "")
            {
                GFVObj.FillDBTable("INSERT INTO tbl_Add_User VALUES('" + tb_Add_Username.Text + "','" + tb_Add_Confirm.Text + "','" + UserKey + "')");
                MessageBox.Show("Add User Successfully....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControlsOfAddUser();
                UserKey = "";
            }
            else
            {
                MessageBox.Show("1st Fill All Fields....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_Forgot_Save_Click(object sender, EventArgs e)
        {
            if (tb_Forgot_Username.Text != "" &&  tb_Forgot_Admin_Hint.Text != ""  && tb_Forgot_New_Password.Text != "" && tb_Forgot_Confirm_Password.Text != "")
            {
                GFVObj.FillDBTable("UPDATE tbl_Add_User SET Password = '" +  tb_Forgot_Confirm_Password.Text  + "' WHERE Username = '" +  tb_Forgot_Username.Text  + "' AND Admin_Key = '" +  tb_Forgot_Admin_Hint.Text + "'");

                MessageBox.Show("Password Change Successfully....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControlsOfForgotPassword();

                tb_Forgot_Username.Focus();
            }
            else
            {
                MessageBox.Show("1st Fill All Fiels....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

       
    }
}
