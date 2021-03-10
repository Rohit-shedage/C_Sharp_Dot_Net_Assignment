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
    public partial class frm_View_Emolyee_Detail_Dynamic : Form
    {
        public frm_View_Emolyee_Detail_Dynamic()
        {
            InitializeComponent();
        }


        private void frm_View_Emolyee_Detail_Dynamic_Load(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT(Name) FROM tbl_Add_Qualification",Global_Function_Varaible.con);

            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Qualification.Items.Add(obj.GetString(obj.GetOrdinal("Name")));
            }

            obj.Dispose();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Add_Emp",Global_Function_Varaible.con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_View_All_Emp.DataSource = dt;

            Global_Function_Varaible.Con_Close();

        }

        private void cmb_Qualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();
 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Add_Emp WHERE Qualification = '" + cmb_Qualification.Text +"'",Global_Function_Varaible.con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_View_All_Emp.DataSource = dt;

            Global_Function_Varaible.Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Global_Function_Varaible.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Add_Emp WHERE Qualification = '" + cmb_Qualification.Text + "' AND ID = " + tb_ID.Text + "", Global_Function_Varaible.con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_View_All_Emp.DataSource = dt;

            

            Global_Function_Varaible.Con_Close();

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            cmb_Qualification.SelectedIndex = -1;

            Global_Function_Varaible.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Add_Emp", Global_Function_Varaible.con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_View_All_Emp.DataSource = dt;

            Global_Function_Varaible.Con_Close();
        }

        
    }
}
