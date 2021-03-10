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
    public partial class frm_Add_Qualification : Form
    {
        public frm_Add_Qualification()
        {
            InitializeComponent();
        }

        int Auto_Increment()
        {
            int iCnt = 0;

            Global_Function_Varaible.Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(ID) FROM tbl_Add_Qualification",Global_Function_Varaible.con);

            iCnt = Convert.ToInt32(cmd.ExecuteScalar());

            iCnt = 101 + iCnt;

            Global_Function_Varaible.Con_Close();

            return iCnt;
        }

        private void frm_Add_Qualification_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            tb_ID.Text = Convert.ToString(Auto_Increment());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO tbl_Add_Qualification VALUES(" + tb_ID.Text + ",'" + tb_Name.Text + "')", Global_Function_Varaible.con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
 
                MessageBox.Show("Data Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("1st Fill All The Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Global_Function_Varaible.Con_Close();
            tb_ID.Text = Convert.ToString(Auto_Increment());
            tb_Name.Text = "";
            tb_Name.Focus();
        }
    }
}
