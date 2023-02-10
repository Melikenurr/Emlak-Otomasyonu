using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakDbo2
{
    class Kullanici
    {
        public static int KullaniciID = 0;
        //public static string KullaniciAdi = "Admin";
        public static bool durum = false;
        static sqlbaglantisi bgl = new sqlbaglantisi();
        public static SqlDataReader KullaniciGirisi(TextBox KullaniciAdi, TextBox Sifre)
        {

            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar_Tbl where KullaniciAdi='" + KullaniciAdi.Text + "' and KullaniciSifre ='" + Sifre.Text + "'", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                durum = true;
                KullaniciID = int.Parse(dr["KullaniciID"].ToString());
            }

            else
            {
                durum = false;
            }
            bgl.baglanti().Close();
            return dr;
        }
    
}
}
