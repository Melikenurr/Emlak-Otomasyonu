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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace EmlakDbo2
{
    public partial class EmlakSorgula : Form
    {
        public EmlakSorgula()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        //void goster(string veriler)
        // {
        //     //DataTable dt = new DataTable();
        //DataSet ds = new DataSet();
        //     SqlDataAdapter da = new SqlDataAdapter(veriler, bgl.baglanti());
        //     //da.Fill(dt);
        //     da.Fill(ds);
        //     dataGridView1.DataSource = ds.Tables[0];
        // }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Emlak_Tbl", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sehirlistesi()
        {
            //SqlCommand komut = new SqlCommand("Select sehir From Iller_Tbl", bgl.baglanti());
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox2.Items.Add(dr[0]);

            //}
            //bgl.baglanti().Close();

        }
        private void label10_Click(object sender, EventArgs e)
        {
            
        }

       // AnaSayfa anaSayfa = new AnaSayfa();
       // Kullanicilar kullanicilar = new Kullanicilar();
       // EmlakEkle emlakEkle = new EmlakEkle();
       // SilinenEmlaklar silinenEmlaklar = new SilinenEmlaklar();
       //SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();
       // DigerIslemler digerIslemler = new DigerIslemler();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           // this.Hide();
           //anaSayfa.Show();
        }

     
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //kullanicilar.Show();
        }


         
        private void EmlakSorgula_Load (object sender, EventArgs e)
        {
          
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
            //emlakSorgula
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //satilanKiralananEmlaklar.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Kullanicilar yeni = new Kullanicilar();
            yeni.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmlakEkle yeni = new EmlakEkle();
            yeni.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SilinenEmlaklar yeni = new SilinenEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar yeni = new SatilanKiralananEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DigerIslemler yeni = new DigerIslemler();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            SqlCommand komut = new SqlCommand("Delete from Emlak_Tbl where emlakID=@emlakID", bgl.baglanti());

            komut.Parameters.AddWithValue("@emlakID", Convert.ToInt32(textBox10.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //comboBox2.SelectedItem= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //comboBox3.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richTextBox1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            //dateTimePicker1.Value = System.Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[12].Value);
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();





        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox3.Items.Clear();
            //SqlCommand komut = new SqlCommand("Select ilce from Ilceler_Tbl where sehir=@p1", bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", comboBox2.SelectedIndex + 1);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox3.Items.Add(dr[0]);
            //}
           

            //bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Update Emlak_Tbl SET Durum=@Durum, " +
        "EmlakTipi=@EmlakTipi, Kategori=@Kategori, Fiyat=@Fiyat, Aciklama=@Aciklama, Adres=@Adres, Metrekare=@Metrekare, KatSayisi=@KatSayisi, OdaSayisi=@OdaSayisi where emlakID=@emlakID", bgl.baglanti());

            komut.Parameters.AddWithValue("@emlakID", Convert.ToInt32(textBox10.Text));
            komut.Parameters.AddWithValue("@Durum", textBox7.Text);
            komut.Parameters.AddWithValue("@EmlakTipi", textBox9.Text);
            komut.Parameters.AddWithValue("@Kategori", textBox8.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox5.Text);
            komut.Parameters.AddWithValue("@Aciklama", richTextBox1.Text);
            komut.Parameters.AddWithValue("@Adres", richTextBox2.Text);
            komut.Parameters.AddWithValue("@Metrekare", textBox2.Text);
            komut.Parameters.AddWithValue("@KatSayisi", textBox1.Text);
            komut.Parameters.AddWithValue("@OdaSayisi", textBox6.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Delete from Emlak_Tbl where emlakID=@emlakID", bgl.baglanti());

            //komut.Parameters.AddWithValue("@emlakID", Convert.ToInt32(textBox10.Text));
            //komut.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //listele();


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Arama yeni = new Arama();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = " PDF file | *.pdf", ValidateNames = true })
            //{
            //    if (sfd.ShowDialog()== DialogResult.OK)
            //    {
            //        iTextSharp.text.Document dosya = new iTextSharp.text.Document(PageSize.A4.Rotate());
            //        PdfWriter.GetInstance(dosya, new FileStream(sfd.FileName, FileMode.Create));
            //        dosya.Open();
            //        dosya.
            //    }
            //}

        }
    }
}
