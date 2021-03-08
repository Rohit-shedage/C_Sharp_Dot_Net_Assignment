using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Info_System
{
    class Global_Function_And_DB_Con
    {

        #region DBConnection
        string Connection = (@"Data Source=.\sqlexpress;Initial Catalog=Employee_Management_Info_DB;Integrated Security=True");

        public SqlConnection con;
        public void ConnectDB()
        {
            con = new SqlConnection(Connection);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void DisConnectDB()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        #endregion

        #region AutoIncrement
        public int AutoIncrement(string Get_Current_ID1, string Get_Current_ID2, int StartNo)
        {
            int cnt = 0;
           
                ConnectDB();

                SqlCommand cmd = new SqlCommand(Get_Current_ID1, con);

                cnt = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                if (cnt > 0)
                {
                    cmd.CommandText = Get_Current_ID2;
                    cmd.Connection = con;

                    cnt = Convert.ToInt32(cmd.ExecuteScalar());

                    cnt += 1;

                    cmd.Dispose();

                    DisConnectDB();

                }
                else
                {
                    cnt += StartNo;
                }
          

            return cnt;

            
        }

        #endregion

        #region Insert_Value_in_DB

        public void FillTableDB(string Get_Query)
        {
            ConnectDB();

           
                SqlDataAdapter sda = new SqlDataAdapter(Get_Query, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sda.Dispose();
                dt.Dispose();
           
            
        }

        #endregion

        #region Fill_ComboBox_Items

        public void FillComboboxItems(string Get_Query,string ColumnName,ComboBox cmb)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand(Get_Query,con);
                var Obj = cmd.ExecuteReader();

                while (Obj.Read())
                {
                    cmb.Items.Add(Obj[ColumnName].ToString());
                }

                cmd.Dispose();
                DisConnectDB();
            }
            catch (Exception ex)
            {

                
            }
        }


        #endregion

        #region FillDataGridView

        public void FillDataGridView(string Query,DataGridView dgv)
        {
            ConnectDB();

            SqlDataAdapter sda = new SqlDataAdapter(Query,con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv.DataSource = dt;

            DisConnectDB();

        }

        #endregion

        #region ExecuteQuery
        public void ExecuteQuery(string Get_Query)
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand(Get_Query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            DisConnectDB();

        }
        #endregion
    }
}
