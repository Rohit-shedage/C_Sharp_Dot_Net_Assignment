using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Autoincreament()
        {
            using (Student_DBEntities db = new Student_DBEntities())
            {
                var CntID = (from s in db.tbl_Student select s.Id).Count();
                if (CntID != 0)
                {
                    var MaxID = (from s in db.tbl_Student select s.Id).Max();
                    tb_ID.Text = (Convert.ToInt32(MaxID += 1)).ToString();
                }
                else
                {
                    tb_ID.Text = (Convert.ToInt32(CntID = 1001)).ToString();
                }
            }
        }
        void ClearControls()
        {
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            cmb_City.SelectedIndex = -1;
            dtp_DOB.Value = DateTime.Now.Date;
            rbtn_Female.Checked = false;
            rbtn_male.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Autoincreament();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_City.Text != "" && (rbtn_male.Checked || rbtn_Female.Checked))
            {
                using (Student_DBEntities db = new Student_DBEntities())
                {
                    if (rbtn_male.Checked)
                    {
                        gender = rbtn_male.Text;
                    }
                    else
                    {
                        gender = rbtn_Female.Text;
                    }
                    db.tbl_Student.Add(new tbl_Student()
                                          {
                                                Id = Convert.ToInt32(tb_ID.Text),
                                                Name = tb_Name.Text,
                                                Mobile_No = Convert.ToInt64(tb_Mobile_No.Text),
                                                City = cmb_City.Text,
                                                DOB = dtp_DOB.Value,
                                                Gender = gender
                                          }
                                       );
                    db.SaveChanges();
                    MessageBox.Show("Information Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autoincreament();
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_View_Details_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_Details Obj = new frm_View_All_Student_Details();
            Obj.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (Student_DBEntities db = new Student_DBEntities())
            {
                var Stud = db.tbl_Student.Find(Convert.ToInt32(tb_ID.Text));

                if (Stud != null)
                {
                    tb_Name.Text = Stud.Name;
                    tb_Mobile_No.Text = Stud.Mobile_No.ToString();
                    cmb_City.Text = Stud.City.ToString();
                    dtp_DOB.Value = Stud.DOB;
                    if (Stud.Gender.Contains(rbtn_male.Text))
                    {
                        rbtn_male.Checked = true;
                    }
                    else
                    {
                        rbtn_Female.Checked = true;
                    }

                    MessageBox.Show("Information Found Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Student ID", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chb_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ID.Checked == true)
            {
                tb_ID.Enabled = true;
                tb_ID.Clear();
            }
            else
            {
                tb_ID.Enabled = false;
                Autoincreament();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (Student_DBEntities db = new Student_DBEntities())
            {
                var Stud = db.tbl_Student.Find(Convert.ToInt32(tb_ID.Text));

                if (Stud != null)
                {
                    db.tbl_Student.Remove(Stud);
                    db.SaveChanges();

                    MessageBox.Show("Information Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();               
                }
                else
                {
                    MessageBox.Show("Invalid Student ID Can't Delete", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (Student_DBEntities db = new Student_DBEntities())
            {
                var Stud = db.tbl_Student.Find(Convert.ToInt32(tb_ID.Text));

                if (Stud != null)
                {
                    Stud.Name = tb_Name.Text;
                    Stud.Mobile_No = Convert.ToInt64(tb_Mobile_No.Text);
                    Stud.City = cmb_City.Text;
                    Stud.DOB = dtp_DOB.Value;
                    if (rbtn_male.Checked)
                    {
                        Stud.Gender = rbtn_male.Text;
                    }
                    else
                    {
                        Stud.Gender = rbtn_Female.Text;
                    }
                    db.SaveChanges();

                    MessageBox.Show("Information Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Invalid Student ID Can't Delete", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
