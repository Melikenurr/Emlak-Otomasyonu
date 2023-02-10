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
    public partial class EmlakEkle : Form
    {
        public EmlakEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public static bool durum = true;




        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter ("Select * from Emlak_Tbl", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir From Iller_Tbl", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

        }
        

        
        private void label8_Click(object sender, EventArgs e)
        {

        }
       
      
       
        
       
        
        private void Form3_Load(object sender, EventArgs e)
        {
 
            panel2.Visible = false;
            listele();
            sehirlistesi();
            textBox10.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox6.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            SqlCommand komut = new SqlCommand("insert into Satici_Tbl (SaticiAd, SaticiSoyad, SaticiTel) values (@p1,@p2,@p3)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox3.Text);
            komut.Parameters.AddWithValue("@p2", textBox4.Text);
            komut.Parameters.AddWithValue("@p3", textBox8.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand ("insert into Emlak_Tbl (Metrekare, Fiyat, OdaSayisi, KatSayisi, Ilceid, Ilid, Durum, Kategori, Aciklama, Adres, EmlakTipi) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(textBox5.Text));
            komut.Parameters.AddWithValue("@p3", textBox6.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", comboBox3.SelectedIndex);
            komut.Parameters.AddWithValue("@p6", comboBox2.SelectedIndex);
            komut.Parameters.AddWithValue("@p7", textBox7.Text);
            komut.Parameters.AddWithValue("@p8", textBox9.Text);
            komut.Parameters.AddWithValue("@p11", textBox10.Text);
            komut.Parameters.AddWithValue("@p9", richTextBox2.Text);
            komut.Parameters.AddWithValue("@p10",richTextBox1.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();


          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlCommand komut = new SqlCommand ("Select ilce from Ilceler_Tbl where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedIndex +1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }







































        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
        
        
        
        
        
        
  

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //AnaSayfa yeni = new AnaSayfa();
            //yeni.Show();
            //this.Hide();
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Kullanicilar yeni = new Kullanicilar();
            //yeni.Show();
            //this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            //SilinenEmlaklar yeni = new SilinenEmlaklar();
            //yeni.Show();
            //this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
            //EmlakSorgula yeni = new EmlakSorgula();
            //yeni.Show();
            //this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            //SatilanKiralananEmlaklar yeni = new SatilanKiralananEmlaklar();
            //yeni.Show();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            //DigerIslemler yeni = new DigerIslemler();
            //yeni.Show();
            //this.Hide();
        }




        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            //this.Hide();
            //anaSayfa.Show();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            //Kullanicilar kullanicilar = new Kullanicilar();
            //this.Hide();
            //kullanicilar.Show();  
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            //SilinenEmlaklar silinenEmlaklar = new SilinenEmlaklar();
            //this.Hide();
            //silinenEmlaklar.Show();
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            //EmlakSorgula emlakSorgula = new EmlakSorgula();
            //this.Hide();
            //emlakSorgula.Show();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            //SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();
            //this.Hide();
            //satilanKiralananEmlaklar.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //DigerIslemler digerIslemler = new DigerIslemler();
            //this.Hide();
            //digerIslemler.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa yeni = new AnaSayfa();
            yeni.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmlakSorgula yeni = new EmlakSorgula();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kullanici.KullaniciGirisi(textBox1, textBox2);

            //if (Kullanici.durum == true)
            //{
            //    Kullanicilar yeni = new Kullanicilar();
            //    this.Hide();
            //    Kullanicilar.Show();
            //}

            //else if (Kullanici.durum == false)
            //{
            //    MessageBox.Show("Hatalı Giriş!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //if ()
            //{
            //    Kullanicilar yeni = new Kullanicilar();
            //    yeni.Show();
            //    this.Hide();
            //}

            //else 
            //{
            //    MessageBox.Show("Yetkiniz Bulunmamaktadır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}














        }

        private void button5_Click(object sender, EventArgs e)
        {
            SilinenEmlaklar yeni = new SilinenEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar yeni = new SatilanKiralananEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DigerIslemler yeni = new DigerIslemler();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Arama yeni = new Arama();
            yeni.Show();
            this.Hide();
        }
    }
}
