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
    public partial class frm_Add_Manager_Mentor : Form
    {

        Global_Function_And_DB_Con GObj = new Global_Function_And_DB_Con();
        public frm_Add_Manager_Mentor()
        {
            InitializeComponent();
        }

        private void ClearControls()
        {
            tb_Name.Clear();
            tb_MobNo.Clear();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            dtp_DOB.Text = "";
            dtp_Join_Date.Text = "";
            cmb_Department.Text = "";
            tb_Salary.Clear();
        }
        

       
        private void frm_Add_Manager_Mentor_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Manager_Mentor","SELECT MAX(ID) FROM tbl_Add_Manager_Mentor",101));

            GObj.FillComboboxItems("SELECT DISTINCT(Name) FROM tbl_Add_Department","Name",cmb_Department);
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }

        private void tb_MobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_MobNo.Focus();
            }
        }

        private void tb_MobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtn_Male.Focus();
            }
        }

        private void rbtn_Male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtn_Female.Focus();
            }
        }

        private void rbtn_Female_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_DOB.Focus();
            }
        }

        private void dtp_DOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Join_Date.Focus();
            }
        }

        private void dtp_Join_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Department.Focus();
            }
        }

        private void cmb_Department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_Salary.Focus();
            }
        }

        private void tb_Salary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Save.Focus();
            }
        }

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.NumLock))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = "";

            if (rbtn_Male.Checked)
            {
                Gender = rbtn_Male.Text;
            }
            if (rbtn_Female.Checked)
            {
                Gender = rbtn_Female.Text;
            }

            if (tb_Name.Text != "" && tb_MobNo.Text != "" && (rbtn_Male.Checked || rbtn_Female.Checked) && cmb_Department.Text != "" && tb_Salary.Text != "")
            {
                GObj.FillTableDB("INSERT INTO tbl_Add_Manager_Mentor VALUES(" + tb_ID.Text + ",'" + tb_Name.Text + "'," + tb_MobNo.Text + ",'" + Gender + "','" + dtp_DOB.Text + "','" + dtp_Join_Date.Text + "','" + cmb_Department.Text + "'," + tb_Salary.Text + ")");
                MessageBox.Show("Record Save Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                
                ClearControls();
                tb_ID.Text = Convert.ToString(GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Manager_Mentor", "SELECT MAX(ID) FROM tbl_Add_Manager_Mentor", 101));

            }
            else
            {
                MessageBox.Show("1st Fill All The Filleds...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

      
        

        
    }
}
