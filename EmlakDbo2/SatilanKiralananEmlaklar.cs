using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmlakDbo2
{
    public partial class SatilanKiralananEmlaklar : Form
    {
        public SatilanKiralananEmlaklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        //AnaSayfa anaSayfa = new AnaSayfa();
        //Kullanicilar kullanicilar = new Kullanicilar();
        //EmlakEkle emlakEkle = new EmlakEkle();
        //SilinenEmlaklar silinenEmlaklar = new SilinenEmlaklar();
        //EmlakSorgula emlakSorgula = new EmlakSorgula();
        //DigerIslemler digerIslemler = new DigerIslemler();


        private void SatilanKiralananEmlaklar_Load(object sender, EventArgs e)
        {
            //listele();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from SatılanEmlaklar_Tbl", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //anaSayfa.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //kullanicilar.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //emlakEkle.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //silinenEmlaklar.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //emlakSorgula.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //digerIslemler.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa yeni = new AnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar yeni = new Kullanicilar();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmlakEkle yeni = new EmlakEkle();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SilinenEmlaklar yeni = new SilinenEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmlakSorgula yeni = new EmlakSorgula();
            yeni.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DigerIslemler yeni = new DigerIslemler();
            yeni.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SatılanEmlaklar", bgl.baglanti());
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "SatılanEmlaklar");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("KiralananEmlaklar", bgl.baglanti());
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds, "KiralananEmlaklar");
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Arama yeni = new Arama();
            yeni.Show();
            this.Hide();
        }
    }
}
