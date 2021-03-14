using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_Details
{
    public partial class frm_Add_Student_Information : Form
    {
        string meat = " ";
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Detail_db;Integrated Security=True");

        void Con_Close()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public frm_Add_Student_Information()
        {
            InitializeComponent();
        }

        private void btn_Stud_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Lobj = new frm_Login();
            Lobj.Show();
            this.Hide();
        }

        private void btn_Stud_Save_Click(object sender, EventArgs e)
        {
            if (tb_Stud_ID.Text != "" && tb_Stud_Name.Text != "" && tb_Stud_ID.Text != "" && (cb_Add_Karad.Checked || cb_Add_Mumbai.Checked || cb_Add_Pune.Checked || cb_Add_Sangli.Checked ))
            {
                Con_Close();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Add_Student_Detail VALUES(" + tb_Stud_ID.Text + ",'" + tb_Stud_Name.Text + "'," + tb_Stud_MobNo.Text + ",'" + dtp_Stud_DOB.Text + "','" + meat + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Save Successfully...!!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Stud_ID.Text = "";
                tb_Stud_Name.Text = "";
                tb_Stud_MobNo.Text = "";
                
            }
            else
            {
                MessageBox.Show("1st Fill All Data..!!","Empty",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Stud_View_Detail_Click(object sender, EventArgs e)
        {
            frm_View_Stud obj = new frm_View_Stud();
            obj.Show();
            this.Hide();
        }

        private void IsNUmeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void cb_Add_Karad_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Add_Karad.CheckState == CheckState.Checked)
            {
                meat += "Karad";
            }
        }

        private void cb_Add_Sangli_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_Add_Sangli.CheckState == CheckState.Checked)
            {
                meat += "Sangli";
            }
        }

        private void cb_Add_Mumbai_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Add_Mumbai.CheckState == CheckState.Checked)
            {
                meat += "Mumbai";
            }
        }

        private void cb_Add_Pune_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Add_Pune.CheckState == CheckState.Checked)
            {
                meat += "Pune";
            }
        }
        /*
        private void tb_Stud_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }*/

     
    }
}
