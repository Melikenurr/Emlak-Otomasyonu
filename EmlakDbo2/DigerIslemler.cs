using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
using System.IO;
using ExcelDataReader;

namespace EmlakDbo2
{
    public partial class DigerIslemler : Form
    {
        public DigerIslemler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        //AnaSayfa anaSayfa = new AnaSayfa();
        //Kullanicilar kullanicilar = new Kullanicilar();
        //EmlakEkle emlakEkle = new EmlakEkle();
        //SilinenEmlaklar silinenEmlaklar = new SilinenEmlaklar();
        //EmlakSorgula emlakSorgula = new EmlakSorgula();
        //SatilanKiralananEmlaklar satilanKiralananEmlaklar = new SatilanKiralananEmlaklar();

        private void DigerIslemler_Load(object sender, EventArgs e)
        {

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //satilanKiralananEmlaklar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmlakEkle yeni = new EmlakEkle();
            yeni.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa yeni = new AnaSayfa();
            yeni.Show();
            this.Hide();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        ////    Kullanicilar yeni = new Kullanicilar();
        ////    yeni.Show();
        ////    this.Hide();

        //}

    private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Kullanicilar yeni = new Kullanicilar();
            yeni.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e) //yedekleme
        {
            saveFileDialog1.Title = "Yedeklenecek Yolu Belirtiniz";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak) | *.bak | Tüm Dosyalar (*.*) |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e) // yedekleme
        {
            Server dbServer = new Server(new ServerConnection(textBox2.Text));
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = textBox3.Text;
            dbBackup.Devices.AddDevice(textBox1.Text, DeviceType.File);
            dbBackup.Initialize = false;
            dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackup(dbServer);
            
        }
        private void DbBackup_Complete(object sender, ServerMessageEventArgs e) //yedekleme
        {
            try
            {
                MessageBox.Show("Yedekleme işlemi başaralı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e) //listeleme
        {
            SqlCommand komut = new SqlCommand ("Select * from Emlak_Tbl", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) //export işlemi
        {
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        DataTableCollection tableCollection;


        private void button13_Click(object sender, EventArgs e) //import işlemi
        {
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog() { Filter = "Excel 97 - 2003 Workbook |*.xls|Excel Workbook|* .xlsx" })
            {
                if (OpenFileDialog.ShowDialog()== DialogResult.OK)
                {
                    textBox4.Text = OpenFileDialog.FileName;
                    using (var stream = File.Open(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_)=> new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName); // sheet i comboboxa ekleme
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arama yeni = new Arama();
            yeni.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Restore Files (*.bak )| *.bak";
            openFileDialog1.ShowDialog();
            textBox5.Text = openFileDialog1.FileName;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //    sqlbaglantisi.DB_General obj = new sqlbaglantisi.DB_General();
            //    obj.general_query("use master; restore database emlakdbo from disk='" + textBox5.Text + "'");
            //    MessageBox.Show("Yedekten Dönme Başarılı");
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HD11C8A\SQLEXPRESS;Initial Catalog=yeni;Integrated Security=True; Persist Security Info = False");
            baglan.Open();
            SqlCommand komut = new SqlCommand("EXEC sp_yedektendon", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Yedekten Dön Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
