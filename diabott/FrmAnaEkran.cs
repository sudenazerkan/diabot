using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DİABOT
{
    public partial class FrmAnaEkran : Form
    {
        string kullaniciAdi;
        public FrmAnaEkran(string ad)
        {
            InitializeComponent();
            kullaniciAdi = ad;
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Merhaba " + kullaniciAdi + "!";


            // Ölçüm verilerini tabloya getiriyoruz
            string baglantiYolu = @"Data Source=diabot.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "SELECT TarihSaat, Deger FROM tblOlcumler ORDER BY TarihSaat DESC";

                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGecmisOlcumler.DataSource = dt; // ← bu senin DataGridView'in (ismi farklıysa düzeltelim)
                }
            }
        }


        public void OlcumleriYenile()
        {
            string yol = @"Data Source=diabot.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(yol))
            {
                baglanti.Open();
                string sql = "SELECT TarihSaat, Deger FROM tblOlcumler ORDER BY TarihSaat DESC";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGecmisOlcumler.DataSource = dt; // ← Bu senin tablona bağlıysa doğru!
                }
            }
        }



        private void dgvGecmisOlcumler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlGrafik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnYeniOlcum_Click(object sender, EventArgs e)
        {
            YeniOlcumEkle yeniForm = new YeniOlcumEkle();
            yeniForm.ShowDialog();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Grafik verisi yüklendi");
        }

        private void btnYeniOlcum_Click_1(object sender, EventArgs e)
        {
            YeniOlcumEkle yeniForm = new YeniOlcumEkle();
            yeniForm.ShowDialog();
        }

        private void dgvGecmisOlcumler_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

        