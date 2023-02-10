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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void verilerigöster()
        {
           
            //DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter("Select * from Emlak_Tbl", bgl.baglanti());
            SqlCommand komut = new SqlCommand("Select EmlakID, Kategori,EmlakTipi,Durum From Emlak_Tbl", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmlakID"].ToString();
                ekle.SubItems.Add(dr["Kategori"].ToString());
                ekle.SubItems.Add(dr["EmlakTipi"].ToString());
                ekle.SubItems.Add(dr["Durum"].ToString());

                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
            // da.Fill(dt);
            //listView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            listView1.Items.Clear();
            //SqlCommand komut = new SqlCommand("Select EmlakID,Kategori,EmlakTipi,Durum From Emlak_Tbl where Durum like '%"+textBox1.Text+"%'", bgl.baglanti());
            SqlCommand komut = new SqlCommand ("Select * From Emlak_Tbl where Durum like '%" + textBox1.Text + "%' and EmlakTipi like '%" + textBox2.Text + "%'and Kategori like '%" + textBox3.Text + "%' ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmlakID"].ToString();
                ekle.SubItems.Add(dr["Kategori"].ToString());
                ekle.SubItems.Add(dr["EmlakTipi"].ToString());
                ekle.SubItems.Add(dr["Durum"].ToString());

                listView1.Items.Add(ekle);
                
                
            }
            bgl.baglanti().Close();
        }

        private void Arama_Load(object sender, EventArgs e)
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
            Kullanicilar yeni = new Kullanicilar();
            yeni.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmlakEkle yeni = new EmlakEkle();
            yeni.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SilinenEmlaklar yeni = new SilinenEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar yeni = new SatilanKiralananEmlaklar();
            yeni.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmlakSorgula yeni = new EmlakSorgula();
            yeni.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DigerIslemler yeni = new DigerIslemler();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("Select * From Emlak_Tbl where EmlakTipi like '%" + textBox2.Text + "%'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Clear();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmlakID"].ToString();
                ekle.SubItems.Add(dr["Kategori"].ToString());
                ekle.SubItems.Add(dr["EmlakTipi"].ToString());
                ekle.SubItems.Add(dr["Durum"].ToString());

                listView1.Items.Add(ekle);
                
            }
            bgl.baglanti().Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("Select * From Emlak_Tbl where Kategori like '%" + textBox3.Text + "%'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["EmlakID"].ToString();
                ekle.SubItems.Add(dr["Kategori"].ToString());
                ekle.SubItems.Add(dr["EmlakTipi"].ToString());
                ekle.SubItems.Add(dr["Durum"].ToString());

                listView1.Items.Add(ekle);
            
            }
            bgl.baglanti().Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            //DısaAktarmalar.PDF_Disa_Aktar(dataGridView1);
        }
    }
    }

