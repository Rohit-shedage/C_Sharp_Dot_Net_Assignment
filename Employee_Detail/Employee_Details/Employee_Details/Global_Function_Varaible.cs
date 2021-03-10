using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Employee_Details
{
    class Global_Function_Varaible
    {

        public static string UName = "";
        public static SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Employee_Details_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void Con_Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
       
    }
}
