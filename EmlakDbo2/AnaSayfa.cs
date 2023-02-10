using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakDbo2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(128, Color.Blue);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
       

    
        
        
       

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(170, Color.Gray);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisYap giris = new GirisYap();
            this.Hide();
            giris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmlakEkle emlakEkle = new EmlakEkle();
            this.Hide();
            emlakEkle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmlakSorgula emlakSorgula = new EmlakSorgula();
            this.Hide();
            emlakSorgula.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();
            this.Hide();
            satilanKiralananEmlaklar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();
            this.Hide();
            satilanKiralananEmlaklar.Show();
        }
    }
}
