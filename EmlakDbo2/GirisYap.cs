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
    public partial class GirisYap : Form
    {
        //Kullanici db = new Kullanici();
        public GirisYap()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        //SqlCommand komut;
        //SqlDataReader read;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        AnaSayfa anaSayfa = new AnaSayfa();
        private void Giris_Load(object sender, EventArgs e)
        {

        }

        ////public SqlDataReader Kullanıcı ()





        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    using (db.komut)
            //    {
            //        SqlCommand komut = new SqlCommand(" sp_role_login", bgl.baglanti().);
            //        komut.CommandType = CommandType.StoredProcedure;
            //        db.komut.Open();
            //        komut.Parameters.AddWithValue("@uname", textBox1.Text);
            //        komut.Parameters.AddWithValue("@upass", textBox2.Text);
            //        SqlDataReader rd = komut.ExecuteReader();
            //        if (rd.HasRows)
            //        {
            //            GirisYap d = new GirisYap();
            //            d.Show();
            //            this.Hide();
            //        }

            //        else
            //        {
            //            MessageBox.Show("Hatalı Giriş");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}


            //bgl.baglanti().Close();






            Kullanici.KullaniciGirisi(textBox1, textBox2);

            if (Kullanici.durum == true)
            {
                this.Hide();
                anaSayfa.Show();
            }

            else if (Kullanici.durum == false)
            {
                MessageBox.Show("Hatalı Giriş!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



















            //string user;
            //string password;
            //user = textBox1.Text;
            //password = textBox2.Text;

            //SqlCommand komut = new SqlCommand("select * from Kullanicilar_Tbl  where KullaniciAdi='" + user + "' and KullaniciSifre ='" + password + "'", bgl.baglanti());
            //SqlDataReader oku = komut.ExecuteReader();
            //if (oku.Read())
            //{
            //    MessageBox.Show("Hoşgeldiniz " + user + "");
            //    this.Hide();
            //    anaSayfa.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Hatalı kullanıcı adı veya şifre...");
            //}

            //bgl.baglanti().Close();













        }
    }
}
