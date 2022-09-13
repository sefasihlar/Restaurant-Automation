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

namespace RestourantOtomation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con;
            SqlDataReader rd;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from users where name = '" + textBox1.Text + "' and surname = '" + textBox2.Text + "'";

            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                rd.Close();
                String datetime = Convert.ToString(DateTime.Now);

                cmd.CommandText = "insert into PersonelHareketleri (userName,surname,datetime)values (@userName,@surname,@datetime)";
                cmd.Parameters.AddWithValue("@userName",textBox1.Text);
                cmd.Parameters.AddWithValue("@surname",textBox2.Text);
                cmd.Parameters.AddWithValue("@datetime",DateTime.Parse(datetime));
                cmd.ExecuteNonQuery();

                frmMenu form2 = new frmMenu();
                form2.Show();

                textBox1.Text = "";
                textBox2.Text = "";

            }

            else
            {
                MessageBox.Show("üzgünüz giriş bilgilerinizi kontrol edinizzz");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            



            

          
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void password_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayit kayit = new frmKayit();
            
            kayit.Show();
        }
    }
}
