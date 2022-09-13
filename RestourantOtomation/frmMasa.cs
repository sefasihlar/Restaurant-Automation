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
    public partial class frmMasa : Form
    {
        public frmMasa()
        {
            InitializeComponent();
        }
        //masaların hangi renkte görülmesi gerektiginin kodlandıgı alan 
        private void frmMasa_Load(object sender, EventArgs e)
        {

            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = " select * from masalar";

            dr = cmd.ExecuteReader();


            cmd.Connection = con;
            
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "masa" + dr["id"].ToString() && dr["durum"].ToString() == "1")
                        {
                            item.BackColor = Color.Red;
                            /*i*//*tem.BackgroundImage = (System.Drawing.Image)(Properties.Resources;*/
                        }
                        else if (item.Name == "masa" + dr["id"].ToString() && dr["durum"].ToString() == "2")
                        {
                            item.BackColor = Color.DarkOrange;
                            
                            
                        }
                    }
                }
                
            }
            


        }

    
        private void masa3_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            //tıklanınılan masanın name ve id sinin geçici olarak tutuldugu alan hangi masaya tıklanıldıgının bulmak için masa 17 ye kadar 
            cGenel._ButtonValue = masa3.Text;
            cGenel._ButtonName = masa3.Name;
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa5.Text;
            cGenel._ButtonName = masa5.Name;
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa6.Text;
            cGenel._ButtonName = masa6.Name;
        }

        private void masa7_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa7.Text;
            cGenel._ButtonName = masa7.Name;
        }

        private void masa8_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa8.Text;
            cGenel._ButtonName = masa8.Name;
        }

        private void masa9_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa9.Text;
            cGenel._ButtonName = masa9.Name;
        }

        private void masa10_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa10.Text;
            cGenel._ButtonName = masa10.Name;
        }

        private void masa11_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa11.Text;
            cGenel._ButtonName = masa11.Name;
        }

        private void masa13_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa13.Text;
            cGenel._ButtonName = masa13.Name;
        }

        private void masa14_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa14.Text;
            cGenel._ButtonName = masa14.Name;
        }

        private void masa15_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa15.Text;
            cGenel._ButtonName = masa15.Name;
        }

        private void masa16_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa16.Text;
            cGenel._ButtonName = masa16.Name;
        }

        private void masa17_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa17.Text;
            cGenel._ButtonName = masa17.Name;
        }

        private void masa18_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa18.Text;
            cGenel._ButtonName = masa18.Name;
        }

        private void masa12_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa12.Text;
            cGenel._ButtonName = masa12.Name;
        }

        private void masa2_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa2.Text;
            cGenel._ButtonName = masa2.Name;




        }

        private void masa1_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            this.Close();
            urunler.Show();
            cGenel._ButtonValue = masa1.Text;
            cGenel._ButtonName = masa1.Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

