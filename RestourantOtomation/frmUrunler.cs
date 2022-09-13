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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();

        

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            
            //hesap makinesi text boş oldugunda 
            if (textAdet.Text == "")
            {
                textAdet.Text = "1";
            }
            tablo.Columns.Add("No");
            tablo.Columns.Add("Ürün");
            tablo.Columns.Add("Fiyat");
            tablo.Columns.Add("Adet");




            //hesap makinesindelki butonların aktif edilmesi 

            Button btn = sender as Button;
            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
            btnC.Click += new EventHandler(islem);

            // kategorilerilerin çagrılması sadece salatalar aktif 

            salatalar.Click += new EventHandler(urunleriGetir);

        }

        //hesap makinesine ait buttonların işlevleri
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {

                case "btn1":
                    textAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    textAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    textAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    textAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    textAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    textAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    textAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    textAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    textAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    textAdet.Text += (0).ToString();
                    break;
                case "btnC":
                    textAdet.Text = "";
                    break;

                default:
                    MessageBox.Show("Lütfen bir sayı giriniz ! ");
                    break;

            }

           
        }
        //ana sayfada duracak olan ürünler
        void urunleriGetir(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            switch (btn.Name)
            {

                case "salatalar":
                    s1.Image = (System.Drawing.Image)(Properties.Resources.skarışıksalata);


                    s2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.skaşarlısalata);

                    s3.BackgroundImage = (System.Drawing.Image)(Properties.Resources.smantarsalata);

                    s4.BackgroundImage = (System.Drawing.Image)(Properties.Resources.sPeynirlisalata);

                    s5.BackgroundImage = (System.Drawing.Image)(Properties.Resources.stavuksalata);

                    s5.BackgroundImage = (System.Drawing.Image)(Properties.Resources.sçileklisalata);

                    s6.BackgroundImage = (System.Drawing.Image)(Properties.Resources.savakadosalata);

                    s7.BackgroundImage = (System.Drawing.Image)(Properties.Resources.salata);

                    s8.Image = (System.Drawing.Image)(Properties.Resources.sPeynirlisalata);

                    s9.Image = (System.Drawing.Image)(Properties.Resources.smozerallasalata);

                    s10.Image = (System.Drawing.Image)(Properties.Resources.s17);
                    s17.Image = (System.Drawing.Image)(Properties.Resources.s18);
                    s18.Image = (System.Drawing.Image)(Properties.Resources.s19);
                    s11.Image = (System.Drawing.Image)(Properties.Resources.yıldızsalata);
                    s12.Image = (System.Drawing.Image)(Properties.Resources.sparbunyasalata);

                    break;

                default:
                    MessageBox.Show("Lütfen bir sayı giriniz ! ");
                    break;

            }


        }
        //veritabanından ürünlerin salata kategorisindeki ürünlerin getirilmesi

        void toplamTutar()
        {
            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            string toplamalar = cmd.CommandText = "select sum(tutar) from siparisler";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int sonuc = Convert.ToInt32(dr[0]);
                Console.WriteLine(sonuc);

            }
            
            dr.Close();
        }
        void urunguncelle()
        {

            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
           
  
            cmd.CommandText = " select * from urunler ";

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "s1" && dr["Id"].ToString() == "1")
                        {

                            s1.Text = dr["Name"].ToString();
                            f1.Text = dr["Fiyat"].ToString();

                        }
                        if (item.Name == "s2" && dr["Id"].ToString() == "2")
                        {

                            s2.Text = dr["Name"].ToString();
                            f2.Text = dr["Fiyat"].ToString();



                        }
                        else if (item.Name == "s3" && dr["Id"].ToString() == "3")
                        {

                            s3.Text = dr["Name"].ToString();
                            f3.Text = (dr["Fiyat"].ToString());


                        }
                        else if (item.Name == "s4" && dr["Id"].ToString() == "4")
                        {

                            s4.Text = dr["Name"].ToString();
                            f4.Text = dr["Fiyat"].ToString();

                        }
                        else if (item.Name == "s5" && dr["Id"].ToString() == "5")
                        {

                            s5.Text = dr["Name"].ToString();
                            f5.Text = dr["Fiyat"].ToString();


                        }
                        else if (item.Name == "s6" && dr["Id"].ToString() == "6")
                        {

                            s6.Text = dr["Name"].ToString();
                            f6.Text = dr["Fiyat"].ToString();


                        }
                        else if (item.Name == "s7" && dr["Id"].ToString() == "7")
                        {

                            s7.Text = dr["Name"].ToString();
                            f7.Text = dr["Fiyat"].ToString();


                        }
                        else if (item.Name == "s8" && dr["Id"].ToString() == "8")
                        {

                            s8.Text = dr["Name"].ToString();
                            f8.Text = dr["Fiyat"].ToString();


                        }
                        else if (item.Name == "s9" && dr["Id"].ToString() == "9")
                        {

                            s9.Text = dr["Name"].ToString();
                            f9.Text = dr["Fiyat"].ToString();

                        }
                        else if (item.Name == "s10" && dr["Id"].ToString() == "10")
                        {

                            s10.Text = dr["Name"].ToString();
                            f10.Text = dr["Fiyat"].ToString();

                        }
                        else if (item.Name == "s11" && dr["Id"].ToString() == "11")
                        {

                            s11.Text = dr["Name"].ToString();
                            f11.Text = dr["Fiyat"].ToString();

                        }

                    }


                }

            }


        }

        
        private void user_Click(object sender, EventArgs e)
        {
            //masaların durumunun belirlenmesi ve güncellenmesi
            string userid = cGenel._ButtonValue;

            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = " select * from masalar";

            dr = cmd.ExecuteReader();
            dr.Close();
           

            cmd.Connection = con;

            cmd.CommandText = "update masalar set durum = '1' where id='" + userid + "'";

            cmd.ExecuteNonQuery();
            dr.Close();
            
            //datagridview daki seçilen ürünlerin veritabanınan kayıt işlemleri(siparis kayıt)
            String datetime = Convert.ToString(DateTime.Now);
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                int Id = Convert.ToInt32(dataGridView1.Rows[i].Cells["No"].Value.ToString());
                int fiyat = Convert.ToInt32(dataGridView1.Rows[i].Cells["Fiyat"].Value.ToString());
                
                int adet = Convert.ToInt32(dataGridView1.Rows[i].Cells["Adet"].Value.ToString());
                int tutar = adet * fiyat;
                string masano = cGenel._ButtonValue;
                
                toplam = tutar + toplam;
              
                
                cmd.CommandText = "insert into   siparisler (urunlerId,adet,tutar,masaNo,toplamT) values (@urunlerId,@adet,@tutar,@masaNo,@toplamT)";

                cmd.Parameters.AddWithValue("@urunlerId", Id);
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@masaNo", masano);
                cmd.Parameters.AddWithValue("@toplamT", toplam);


                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "insert into   adisyonlar (UrunlerId,Adet,Tutar,MasaNo,ToplamT)values (@urunId,@sayi,@tutarlar,@masanumarası,@toplamf)";

                cmd.Parameters.AddWithValue("@urunId", Id);
                cmd.Parameters.AddWithValue("@sayi", adet);
                cmd.Parameters.AddWithValue("@tutarlar", tutar);
                cmd.Parameters.AddWithValue("@masanumarası", masano);
                cmd.Parameters.AddWithValue("@toplamf", toplam);

                cmd.ExecuteNonQuery();


                cmd.Parameters.Clear();

            }

             
            frmMasa masalar = new frmMasa();
            this.Close();
            masalar.Show();

        }

        
        private void password_Click(object sender, EventArgs e)
        {
            //masaların durumunun belirlenmesi ve güncellenmesi
            string userid = cGenel._ButtonValue;
            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = " select * from masalar";

            dr = cmd.ExecuteReader();
            dr.Close();

            cmd.Connection = con;
            cmd.CommandText = "update masalar set durum = '2' where id='" + userid + "'";
            cmd.ExecuteNonQuery();
            frmMasa masalar = new frmMasa();
            this.Close();
            masalar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //masaların durumunun belirlenmesi ve güncellenmesi
            string userid = cGenel._ButtonValue;
            
            SqlConnection con;
            SqlDataReader dr;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = " select * from masalar";
            dr = cmd.ExecuteReader();
            dr.Close();

            
           
            

            cmd.Connection = con;
            //masaların durumunun belirlenmesi(acık-kapalı-rezerve)
            cmd.CommandText = "update masalar set durum = '3' where id='" + userid + "'";
            
            cmd.ExecuteNonQuery();
            //kapatılan masanin sipariş bilgilerinin sisilinmesi
            cmd.CommandText = "delete from siparisler where masaNo='" + userid + "'";

            cmd.ExecuteNonQuery();

            frmMasa masalar = new frmMasa();
            this.Close();
            masalar.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //kategorinin çagrilması 
        private void salatalar_Click(object sender, EventArgs e)
        {
            urunguncelle();
        }
        //datagrid deki seçilen ürünlerin özelleklerinin görülmesi s20 ye kadar 

        
        private void s1_Click(object sender, EventArgs e)
        {
            
            tablo.Rows.Add(lbl1.Text, s1.Text, f1.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;



        }

        private void s2_Click(object sender, EventArgs e)
        {

            tablo.Rows.Add(lbl2.Text, s2.Text, f2.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;



        }

        private void s3_Click(object sender, EventArgs e)
        {

            tablo.Rows.Add(lbl3.Text, s3.Text, f3.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s4_Click(object sender, EventArgs e)
        {

            tablo.Rows.Add(lbl4.Text, s4.Text, f4.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s5_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl5.Text, s5.Text, f5.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s6_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl6.Text, s6.Text, f6.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s7_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl7.Text, s7.Text, f7.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s8_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl8.Text, s8.Text, f8.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s9_Click(object sender, EventArgs e)
        {

            tablo.Rows.Add(lbl9.Text, s9.Text, f9.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s10_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl10.Text, s10.Text, f10.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s11_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl11.Text, s11.Text, f11.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;

        }

        private void s12_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl12.Text, s12.Text, f12.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s13_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl13.Text, s13.Text, f13.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s14_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl14.Text, s14.Text, f14.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s15_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl15.Text, s15.Text, f15.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void s16_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(lbl16.Text, s16.Text, f16.Text, textAdet.Text);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void icecekler_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       //siparisi verilen ürünlerin (adisyonun çagrılması )
        void adisyonGetir()
        {
            SqlConnection con;
            SqlDataReader dr;
            SqlDataAdapter da;
            SqlCommand cmd;
            string masano = cGenel._ButtonValue;

            cmd = new SqlCommand();
            
            con = new SqlConnection(@"Data Source=CodeCyber\SQLEXPRESS;Initial Catalog=developer;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select sum(tutar) from siparisler";
            
            da = new SqlDataAdapter("select  masaNo,urunler.Name,adet,tutar,toplamT from siparisler inner join urunler on siparisler.urunlerId = urunler.Id where masaNo='" + masano + "'", con);
            DataTable tablo3 = new DataTable();
            da.Fill(tablo3);
            adisyonlar.DataSource = tablo3;

            cmd.CommandText = "select sum(tutar) from siparisler";
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                int toplamPara =Convert.ToInt32( dr[0]);
                toplamP.Text =Convert.ToString("Toplam Tutar: "+toplamPara+" ₺");
                Console.WriteLine(toplamPara);
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {

            
        }

        private void hackedBy_Click(object sender, EventArgs e)
        {
            adisyonGetir();
        }

        private void f4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toplamP_Click(object sender, EventArgs e)
        {

        }
    }
}
