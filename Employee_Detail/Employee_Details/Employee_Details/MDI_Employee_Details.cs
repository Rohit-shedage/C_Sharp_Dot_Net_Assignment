using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class MDI_Employee_Details : Form
    {
        private int childFormNumber = 0;

        public MDI_Employee_Details()
        {
            InitializeComponent();
        }

        
        private void MDI_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_User.Text = "Welcome " + Global_Function_Varaible.UName;
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Employee_Detail AObj = new Add_Employee_Detail();
            AObj.MdiParent = this;
            AObj.WindowState = FormWindowState.Maximized;
            AObj.Show();
        }

        private void addQualificatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Qualification AObj = new frm_Add_Qualification();
            AObj.Show();
        }

        private void viewEmployeeDynamicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Employee VObj = new frm_View_All_Employee();
            VObj.MdiParent = this;
            VObj.WindowState = FormWindowState.Maximized;
            VObj.Show();
        }

        private void viewEmployeeDynamicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Emolyee_Detail_Dynamic Obj = new frm_View_Emolyee_Detail_Dynamic();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            this.Hide();
            obj.Show();
        }
    }
}
