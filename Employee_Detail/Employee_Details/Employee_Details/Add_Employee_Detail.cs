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
    public partial class Add_Employee_Detail : Form
    {
        public Add_Employee_Detail()
        {
            InitializeComponent();
        }

        int Auto_Increment()
        {
            int iCnt = 0;

            Global_Function_Varaible.Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(ID) FROM tbl_Add_Emp",Global_Function_Varaible.con);

            iCnt = Convert.ToInt32(cmd.ExecuteScalar());

            iCnt = 1001 + iCnt;

            Global_Function_Varaible.Con_Close();

            return iCnt;
        }

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_MobNo.Text = "";
            dtp_DOB.Text = "";
            cmb_Qualification.SelectedIndex = -1;
        }

        private void Is_Not_Digit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.CapsLock) || e.KeyChar == (char)(Keys.Space) || e.KeyChar == (char)(Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        private void Is_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void Add_Employee_Detail_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Increment());

            Global_Function_Varaible.Con_Open();

            SqlCommand cmd = new SqlCommand("SELECT Name FROM tbl_Add_Qualification",Global_Function_Varaible.con);

            var obj = cmd.ExecuteReader();

            while(obj.Read())
            {
                cmb_Qualification.Items.Add(obj.GetString(obj.GetOrdinal("Name")));
            }

            Global_Function_Varaible.Con_Close();

            tb_Name.Focus();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {


            if (tb_Name.Text != "" && tb_MobNo.Text != "" && cmb_Qualification.Text != "")
            {
                Global_Function_Varaible.Con_Open();

                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO tbl_Add_Emp VALUES(" + tb_Employee_ID.Text + ",'" + tb_Name.Text + "'," + tb_MobNo.Text + ",'" + dtp_DOB.Text + "','" + cmb_Qualification.Text + "')", Global_Function_Varaible.con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("Record Filled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Global_Function_Varaible.Con_Close();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Clear_Controls();
            tb_Employee_ID.Text = Convert.ToString(Auto_Increment());
            tb_Name.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

    }
}
