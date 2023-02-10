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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kullanicilar_Tbl", bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }


        //AnaSayfa anaSayfa = new AnaSayfa();
        //EmlakEkle emlakEkle = new EmlakEkle();
        //SilinenEmlaklar silinenEmlaklar = new SilinenEmlaklar();
        //EmlakSorgula emlakSorgula = new EmlakSorgula();
        //SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();
        //DigerIslemler digerIslemler = new DigerIslemler();




        private void Form6_Load(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            //panel3.Visible = false;
            listele();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //panel3.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanicilar_Tbl (KullaniciAdi, KullaniciSifre, AdSoyad,KullaniciTur, KullaniciTel) values (@p1, @p2, @p3,@p4,@p5)", bgl.baglanti());



            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox4.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();

        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox12.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlCommand komut = new SqlCommand("Delete from Kullanicilar_Tbl where KullaniciID=@KullaniciID", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(textBox8.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Kullanicilar_Tbl SET AdSoyad=@AdSoyad, " +
        "KullaniciAdi=@KullaniciAdi, KullaniciSifre=@KullaniciSifre,KullaniciTel=@KullaniciTel,KullaniciTur=@KullaniciTur where KullaniciID=@KullaniciID", bgl.baglanti());

            komut.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(textBox8.Text));
            komut.Parameters.AddWithValue("@AdSoyad", textBox6.Text);
            komut.Parameters.AddWithValue("@KullaniciAdi", textBox12.Text);
            komut.Parameters.AddWithValue("@KullaniciSifre", textBox10.Text);
            komut.Parameters.AddWithValue("@KullaniciTel", textBox9.Text);
            komut.Parameters.AddWithValue("@KullaniciTur ", textBox11.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //emlakEkle.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //anaSayfa.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //kullanıcılar
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           // this.Hide();
           //silinenEmlaklar.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //emlakSorgula.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //    this.Hide();
            //    satilanKiralananEmlaklar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //digerIslemler.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnaSayfa yeni = new AnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            EmlakEkle yeni = new EmlakEkle();
            yeni.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SilinenEmlaklar yeni = new SilinenEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmlakSorgula yeni = new EmlakSorgula();
            yeni.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar yeni = new SatilanKiralananEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DigerIslemler yeni = new DigerIslemler();
            yeni.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Arama yeni = new Arama();
            yeni.Show();
            this.Hide();
        }
    }
}
