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

namespace Student_Info_Management
{
    public partial class frm_Add_Student_Info : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Stud_Info_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public frm_Add_Student_Info()
        {
            InitializeComponent();
        }

        void ClearControl()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_MobNo.Clear();
            dtp_DOB.Text = "";
            cmb_City.SelectedIndex = 0;
            tb_ID.Focus();
        }

        private void lbl_Header_Click(object sender, EventArgs e)
        {

        }

        private void frm_Add_Student_Info_Load(object sender, EventArgs e)
        {
            tb_ID.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_MobNo.Text != "" && cmb_City.Text != "")
            {
                Con_Open();

                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO tbl_Add_Stud_Info(ID,Name,Mob_No,DOB,City) VALUES(" + tb_ID.Text + ",'" + tb_Name.Text + "'," +tb_MobNo.Text + ",'" + dtp_DOB.Text + "','" + cmb_City.Text + "')",Con);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                sda.Dispose();
                dt.Dispose();
                Con_Close();

                MessageBox.Show("Record Save Successfully....!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControl();
            }
            else
            {
                MessageBox.Show("1st Fill All the Fields...!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_View_Student_Info_Click(object sender, EventArgs e)
        {
            frm_View_Student_Info VObj = new frm_View_Student_Info();

            this.Hide();
            VObj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            
            frm_Student_Login Obj = new frm_Student_Login();

            this.Hide();
            Obj.Show();

            //Application.Exit();

            
        }
    }
}
