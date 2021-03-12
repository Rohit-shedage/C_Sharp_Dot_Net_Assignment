using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_Demo_Pratice
{
    public partial class frm_Picture_Box : Form
    {
        public frm_Picture_Box()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Display Image In Picture Box
                pb_Upload_Image.Image = new Bitmap(open.FileName);
                //Image File Path

            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Picture_Box_DB;Integrated Security=True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
           
            ImageConverter icon = new ImageConverter();

            byte[] imgArray = (byte[])icon.ConvertTo(pb_Upload_Image.Image, typeof(byte[])); //Image Exception Hanling is Requried
            
            string str = "INSERT INTO tbl_Picture (Image) VALUES(@Image)";

            SqlCommand Cmd = new SqlCommand(str,con);

            Cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

            Cmd.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully....!!!!");

            //pb_Upload_Image.Image = null;

        }

        private Image ByteArrayToImage(byte[] vs)
        {
            throw new NotImplementedException();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Picture_Box_DB;Integrated Security=True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

           // SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Picture WHERE Image_ID=" + Convert.ToInt32(tb_Image_Id.Text)+ " ",con);

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Picture WHERE Image_ID = " + tb_Image_Id.Text + " ",con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);

                pb_Show_Image.Image = Image.FromStream(ms);
            }
        }
        
    }
}
