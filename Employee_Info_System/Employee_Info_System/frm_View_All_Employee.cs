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
    public partial class frm_View_All_Employee : Form
    {
        Global_Function_And_DB_Con GObj = new Global_Function_And_DB_Con();
        public frm_View_All_Employee()
        {
            InitializeComponent();
        }

        private void frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            GObj.FillDataGridView("SELECT * FROM tbl_Add_Employee_Info",dgv_View_All_Employee);
        }
    }
}
