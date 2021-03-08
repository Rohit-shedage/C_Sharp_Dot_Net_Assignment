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
    public partial class MDI_Employee_Info : Form
    {

        private void DisplayForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            
        }
        public MDI_Employee_Info()
        {
            InitializeComponent();
        }

        private void addEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new frm_Add_Employee_Info());
        }

        private void MDI_Employee_Info_Load(object sender, EventArgs e)
        {
          
        }

        private void addManagerMentorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(new frm_Add_Manager_Mentor());
        }

       
        private void addDepartmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
                frm_Add_Department Obj = new frm_Add_Department();
               // Obj.MdiParent = this;
                Obj.Show();
          
            

        }

        private void viewSingleEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Employee_Info AObj = new frm_Add_Employee_Info(1);
            AObj.MdiParent = this;
            AObj.WindowState = FormWindowState.Maximized;
            AObj.Show();
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new frm_View_All_Employee());
        }

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new frm_Add_Employee_Info(2));
        }

        private void deleteSingleEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new frm_Add_Employee_Info(3));
        }
    }
}
