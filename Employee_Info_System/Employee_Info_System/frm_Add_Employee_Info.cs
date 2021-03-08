using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Info_System
{
    public partial class frm_Add_Employee_Info : Form
    {
        int j = 0;
        
        Global_Function_And_DB_Con GObj = new Global_Function_And_DB_Con();

        #region Paramerterized_Constructor
        public frm_Add_Employee_Info(int iNo)
        {
            InitializeComponent();

            j = iNo;

            if (j == 1)
            {
                foreach (Control controll1 in this.Controls)
                {
                    foreach (Control control2 in controll1.Controls)
                    {
                        control2.Enabled = false;
                    }
                }

                tb_ID.Enabled = true;
                lbl_Header.Text = "View Single Employee";
                btn_Search.Visible = true;
                btn_Save.Visible = false;
                btn_Search.Enabled = true;
                btn_Refresh.Enabled = true;
                chklb_Hobbies.Items.Clear();
                lbl_Other_Hobbies.Visible = false;
                tb_Other_Hobbies.Visible = false;
                chklb_Hobbies.Enabled = true;
                cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                cmb_Manager_Monitor.DropDownStyle = ComboBoxStyle.DropDown;

              
            }
            else if (j == 2 || j == 3)
            {
                foreach (Control controll1 in this.Controls)
                {
                    foreach (Control control2 in controll1.Controls)
                    {
                        control2.Enabled = false;
                    }
                }

                tb_ID.Enabled = true;
                lbl_Header.Text = "Update Employee Details";
                btn_Search.Visible = true;
                btn_Save.Text = "Update";
                btn_Search.Enabled = true;
                btn_Refresh.Enabled = true;
                chklb_Hobbies.Items.Clear();
                lbl_Other_Hobbies.Visible = false;
                tb_Other_Hobbies.Visible = false;
                chklb_Hobbies.Enabled = true;
                cmb_Department.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_Manager_Monitor.DropDownStyle = ComboBoxStyle.DropDown;
                lbl_Other_Hobbies.Visible = true;
                tb_Other_Hobbies.Visible = true;

                if (j == 3)
                {
                    btn_Save.Text = "Delete";
                    lbl_Header.Text = "Delete Single Employee Details";
                    lbl_Other_Hobbies.Visible = false;
                    tb_Other_Hobbies.Visible = false;
                }
            }
        }
        #endregion

        #region Default_Constructor
        public frm_Add_Employee_Info()
        {
            InitializeComponent();
        }
        #endregion

        #region From_Load
        private void frm_Add_Employee_Info_Load(object sender, EventArgs e)
        {

            if (j == 1 || j == 2 || j == 3)
            {

                tb_ID.Focus();

                GObj.FillComboboxItems("SELECT DISTINCT(Name) FROM tbl_Add_Department", "Name", cmb_Department);
                GObj.FillComboboxItems("SELECT DISTINCT(Name) FROM tbl_Add_Manager_Mentor", "Name", cmb_Manager_Monitor);

            }
            else
            {

                tb_ID.Text = GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Employee_Info", "SELECT MAX(ID) FROM tbl_Add_Employee_Info", 1001).ToString();

                GObj.FillComboboxItems("SELECT DISTINCT(Name) FROM tbl_Add_Department", "Name", cmb_Department);
                GObj.FillComboboxItems("SELECT DISTINCT(Name) FROM tbl_Add_Manager_Mentor", "Name", cmb_Manager_Monitor);

                tb_Name.Focus();
            }

           
        }
        #endregion

        #region Clear_Controls_Function
        private void ClearControls()
        {
            int Cnt = chklb_Hobbies.Items.Count;

            tb_Name.Clear();
            tb_MobNo.Clear();
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            for (int i = 0; i < Cnt; i++)
            {
                chklb_Hobbies.SetItemChecked(i,false);
            }
            tb_Other_Hobbies.Clear();
            dtp_DOB.Text = "";
            cmb_Department.Text = "";
            cmb_Designation.SelectedIndex = -1;
            cmb_Manager_Monitor.Text = "";
            rbtn_Moring.Checked = false;
            rbtn_Evening.Checked = false;
            rbtn_Night.Checked = false;
            chkb_D_Mart.Checked = false;
            chkb_IPL.Checked = false;
            chkb_Reliance.Checked = false;
            chkb_Tata.Checked = false;
            tb_Salary.Clear();

        }
        #endregion
       

        #region KeyPress_Event

        private void tb_MobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Button_Refresh
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (j == 1 || j == 2 || j == 3)
            {
                ClearControls();
                tb_ID.Text = "";
                tb_ID.Enabled = true;
                tb_ID.Focus();
                chklb_Hobbies.Items.Clear();
            }
            else
            {
                ClearControls();
            }
               
        }
        #endregion

        #region Button_Save_And_Update_And_Delete
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = "", Hobbies = "", Shift_Timing = "", Project = "";
            if (j == 0)
            {
                if (rbtn_Male.Checked)
                {
                    Gender = rbtn_Male.Text;
                }

                if (rbtn_Female.Checked)
                {
                    Gender = rbtn_Female.Text;
                }

                if (rbtn_Moring.Checked)
                {
                    Shift_Timing = rbtn_Moring.Text;
                }

                if (rbtn_Evening.Checked)
                {
                    Shift_Timing = rbtn_Evening.Text;
                }

                if (rbtn_Night.Checked)
                {
                    Shift_Timing = rbtn_Night.Text;
                }

                if (chkb_Tata.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_Tata.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Tata.Text;
                    }

                }

                if (chkb_Reliance.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_Reliance.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Reliance.Text;
                    }

                }

                if (chkb_IPL.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_IPL.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_IPL.Text;
                    }

                }

                if (chkb_D_Mart.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_D_Mart.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_D_Mart.Text;
                    }

                }

                int Cnt = chklb_Hobbies.Items.Count;

                for (int i = 0; i <= Cnt - 1; i++)
                {
                    if (chklb_Hobbies.GetItemChecked(i))
                    {
                        if (i == Cnt - 1 && tb_Other_Hobbies.Text != "")
                        {
                            if (Hobbies == "")
                            {
                                Hobbies = tb_Other_Hobbies.Text;
                            }
                            else
                            {
                                Hobbies += " , " + tb_Other_Hobbies.Text; ;
                            }
                        }
                        else if (Hobbies == "")
                        {
                            Hobbies = chklb_Hobbies.Items[i].ToString();
                        }
                        else
                        {
                            Hobbies += " , " + chklb_Hobbies.Items[i].ToString();
                        }
                    }
                   
                }

                if (tb_Name.Text != "" && tb_MobNo.Text != "" && (rbtn_Male.Checked || rbtn_Female.Checked) && Hobbies != "" && cmb_Department.Text != "" && cmb_Designation.Text != "" && cmb_Manager_Monitor.Text != "" && (rbtn_Moring.Checked || rbtn_Evening.Checked || rbtn_Night.Checked) && Project != "" && tb_Salary.Text != "")
                {
                    GObj.FillTableDB("INSERT INTO tbl_Add_Employee_Info VALUES(" + tb_ID.Text + ",'" + tb_Name.Text + "'," + tb_MobNo.Text + ",'" + Gender + "','" + dtp_DOB.Text + "','" + Hobbies + "','" + cmb_Department.Text + "','" + cmb_Manager_Monitor.Text + "','" + Shift_Timing + "','" + Project + "','" + cmb_Designation.Text + "'," + tb_Salary.Text + ")");
                    MessageBox.Show("Record Save Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                    Gender = "";
                    Hobbies = "";
                    Project = "";
                    Shift_Timing = "";

                    tb_ID.Text = GObj.AutoIncrement("SELECT COUNT(ID) FROM tbl_Add_Employee_Info", "SELECT MAX(ID) FROM tbl_Add_Employee_Info", 1001).ToString();
                }
                else
                {
                    MessageBox.Show("!st Fill All The Fields...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (j == 2)
            {
                if (rbtn_Male.Checked)
                {
                    Gender = rbtn_Male.Text;
                }

                if (rbtn_Female.Checked)
                {
                    Gender = rbtn_Female.Text;
                }

                if (rbtn_Moring.Checked)
                {
                    Shift_Timing = rbtn_Moring.Text;
                }

                if (rbtn_Evening.Checked)
                {
                    Shift_Timing = rbtn_Evening.Text;
                }

                if (rbtn_Night.Checked)
                {
                    Shift_Timing = rbtn_Night.Text;
                }

                if (chkb_Tata.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_Tata.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Tata.Text;
                    }

                }

                if (chkb_Reliance.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_Reliance.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_Reliance.Text;
                    }

                }

                if (chkb_IPL.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_IPL.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_IPL.Text;
                    }

                }

                if (chkb_D_Mart.Checked)
                {
                    if (Project == "")
                    {
                        Project = chkb_D_Mart.Text;
                    }
                    else
                    {
                        Project += " , " + chkb_D_Mart.Text;
                    }

                }

                int Cnt = chklb_Hobbies.Items.Count;

                for (int i = 0; i <= Cnt - 1; i++)
                {
                    if (chklb_Hobbies.GetItemChecked(i))
                    {
                        if (i == Cnt - 1 && tb_Other_Hobbies.Text != "")
                        {
                            if (Hobbies == "")
                            {
                                Hobbies = tb_Other_Hobbies.Text;
                            }
                            else
                            {
                                Hobbies += " , " + tb_Other_Hobbies.Text; ;
                            }
                        }
                        else if (Hobbies == "")
                        {
                            Hobbies = chklb_Hobbies.Items[i].ToString();
                        }
                        else
                        {
                            Hobbies += " , " + chklb_Hobbies.Items[i].ToString();
                        }
                    }

                }

                if (tb_Name.Text != "" && tb_MobNo.Text != "" && (rbtn_Male.Checked || rbtn_Female.Checked) && Hobbies != "" && cmb_Department.Text != "" && cmb_Designation.Text != "" && cmb_Manager_Monitor.Text != "" && (rbtn_Moring.Checked || rbtn_Evening.Checked || rbtn_Night.Checked) && Project != "" && tb_Salary.Text != "")
                {
                    GObj.FillTableDB("UPDATE tbl_Add_Employee_Info SET Name ='" + tb_Name.Text + "', Mobile_No=" + tb_MobNo.Text + ", Gender = '" + Gender + "', DOB ='" + dtp_DOB.Text + "',Hobbies = '" + Hobbies + "',Department = '" + cmb_Department.Text + "', Manager_Mentor ='" + cmb_Manager_Monitor.Text + "',Shift_Timing='" + Shift_Timing + "',Project = '" + Project + "',Designation='" + cmb_Designation.Text + "',Salary=" + tb_Salary.Text + " WHERE ID=" + tb_ID.Text + "");
                    MessageBox.Show("Record Updated Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                    Gender = "";
                    Hobbies = "";
                    Project = "";
                    Shift_Timing = "";

                    tb_ID.Enabled = true;
                    tb_ID.Focus();
                  
                }
                else
                {
                    MessageBox.Show("!st Fill All The Fields...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (j == 3)
            {
                GObj.ExecuteQuery("DELETE FROM tbl_Add_Employee_Info WHERE ID=" + tb_ID.Text + "");

                MessageBox.Show("Record Deleted Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls();
                Gender = "";
                Hobbies = "";
                Project = "";
                Shift_Timing = "";

                tb_ID.Enabled = true;
                tb_ID.Text = "";
                tb_ID.Focus();
                chklb_Hobbies.Items.Clear();
            }
           
        }
        #endregion

        #region ComboBox_Envent
        private void chklb_Hobbies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            int Count = chklb_Hobbies.Items.Count;
          
            if (chklb_Hobbies.GetItemChecked(Count-1))
            {
                tb_Other_Hobbies.Enabled = true;
            }
            else if(!chklb_Hobbies.GetItemChecked(Count - 1))
            {
                tb_Other_Hobbies.Enabled = false;
            }
            
        }
        #endregion

        #region Button_Search

        private void btn_Search_Click(object sender, EventArgs e)
        {
            GObj.ConnectDB();

            string Gender = "", Hobbies = "", Project = "", Shift_Timming = "";
            bool bRet = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Add_Employee_Info WHERE ID =" + tb_ID.Text + "",GObj.con);

            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_Name.Text = Obj["Name"].ToString();
                tb_MobNo.Text = Obj["Mobile_No"].ToString();
                Gender = Obj["Gender"].ToString();
                dtp_DOB.Text = Obj["DOB"].ToString();
                Hobbies = Obj.GetString(Obj.GetOrdinal("Hobbies"));
                cmb_Department.Text = Obj.GetString(Obj.GetOrdinal("Department"));
                cmb_Manager_Monitor.Text = Obj.GetString(Obj.GetOrdinal("Manager_Mentor"));
                Shift_Timming = Obj["Shift_Timing"].ToString();
                Project = Obj["Project"].ToString();
                cmb_Designation.Text = Obj["Designation"].ToString();
                tb_Salary.Text = Obj["Salary"].ToString();

                bRet = Gender.Contains(rbtn_Male.Text);
                if (bRet)
                {
                    rbtn_Male.Checked = true;
                }

                bRet = Gender.Contains(rbtn_Female.Text);
                if (bRet)
                {
                    rbtn_Female.Checked = true;
                }

                bRet = Shift_Timming.Contains(rbtn_Moring.Text);
                if (bRet)
                {
                    rbtn_Moring.Checked = true;
                }

                bRet = Shift_Timming.Contains(rbtn_Evening.Text);
                if (bRet)
                {
                    rbtn_Evening.Checked = true;
                }

                bRet = Shift_Timming.Contains(rbtn_Night.Text);
                if (bRet)
                {
                    rbtn_Night.Checked = true;
                }

                bRet = Project.Contains(chkb_D_Mart.Text);
                if (bRet)
                {
                    chkb_D_Mart.Checked = true;
                }

                bRet = Project.Contains(chkb_IPL.Text);
                if (bRet)
                {
                    chkb_IPL.Checked = true;
                }

                bRet = Project.Contains(chkb_Reliance.Text);
                if (bRet)
                {
                    chkb_Reliance.Checked = true;
                }

                bRet = Project.Contains(chkb_Tata.Text);
                if (bRet)
                {
                    chkb_Tata.Checked = true;
                }

                string[] HobbiesSplit = Hobbies.Split(',');

                foreach (string item in HobbiesSplit)
                {
                    chklb_Hobbies.Items.Add(item, true);
                }

                if (j == 2)
                {
                    chklb_Hobbies.Items.Add("Other");

                    foreach (Control Control1 in this.Controls)
                    {
                        foreach (Control Control2 in Control1.Controls)
                        {
                            Control2.Enabled = true;
                        }
                    }

                    tb_ID.Enabled = false;
                    cmb_Department.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb_Manager_Monitor.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                if (j == 3)
                {
                    btn_Save.Enabled = true;
                }
                MessageBox.Show("Record Search Successfully...!!!", "Failue", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("Invalid Id Please Enter Correct ID...!!!","Failue",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_ID.Text = "";
                tb_ID.Focus();
            }

            
        }

        #endregion
    }
}
