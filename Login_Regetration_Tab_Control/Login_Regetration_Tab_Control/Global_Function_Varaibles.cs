using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Regetration_Tab_Control
{
    class Global_Function_Varaibles
    {
        string Connectionstring  = (@"Data Source=.\sqlexpress;Initial Catalog=Login_DB;Integrated Security=True");

        public SqlConnection con;
        public void ConnectDB()
        {
            con = new SqlConnection(Connectionstring);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void DisconnectDB()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public string DB_Name_Contain(string CmdString,string ColumnValue)
        {
            string NameString = "";
            ConnectDB();

            SqlCommand cmd = new SqlCommand(CmdString,con);

            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                NameString = Obj.GetString(Obj.GetOrdinal(ColumnValue));
            }

            cmd.Dispose();
            DisconnectDB();

            return NameString;
        }

        public void FillDBTable(string dbstring)
        {
            ConnectDB();

            SqlDataAdapter sda = new SqlDataAdapter(dbstring,con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            sda.Dispose();
            dt.Dispose();
            DisconnectDB();
        }

        
    }
}
