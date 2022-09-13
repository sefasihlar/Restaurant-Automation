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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void perCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //yeni kullanıcı kayıt işlemleri
        private void perKayit_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=developer;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "insert into users (name,surname,userName,parola,statu) values(@name,@surname,@userName,@parola,@statü)";
            cmd.Parameters.AddWithValue("@name", perName.Text);
            cmd.Parameters.AddWithValue("@surname", perSurname.Text);
            cmd.Parameters.AddWithValue("@userName", PerUserName.Text);
            cmd.Parameters.AddWithValue("@parola", perPassword.Text);
            cmd.Parameters.AddWithValue("@statü", perStatu.Text);

            cmd.ExecuteNonQuery();
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
