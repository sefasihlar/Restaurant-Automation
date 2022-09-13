using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestourantOtomation
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMasa masa = new frmMasa();
            this.Close();
            masa.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPaketServis paket = new frmPaketServis();
            this.Close();
            paket.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRezervasyon rezervasyon = new frmRezervasyon();
            this.Close();
            rezervasyon.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMusteriler musteri = new frmMusteriler();
            this.Close();
            musteri.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmKasa kasa = new frmKasa();
            this.Close();
            kasa.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmMutfak mutfak = new frmMutfak();
            this.Close();
            mutfak.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmRaporlar rapor = new frmRaporlar();
            this.Close();
            rapor.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmAyarlar ayar = new frmAyarlar();
            this.Close();
            ayar.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmKilitle kilitle = new frmKilitle();
            this.Close();
            kilitle.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
