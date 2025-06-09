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
using System.Data.SQLite;
namespace DİABOT
{
    public partial class YeniOlcumEkle : Form
    {
        public YeniOlcumEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Giriş değerlerini al
                string deger = txtDeger.Text;
                string tarihSaat = dtpTarihSaat.Value.ToString("yyyy-MM-dd HH:mm:ss");

                // Veritabanı bağlantı yolu
                string baglantiYolu = @"Data Source=diabot.db;Version=3;";

                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiYolu))
                {
                    baglanti.Open();

                    // SQL sorgusu
                    string sql = "INSERT INTO tblOlcumler (Deger, TarihSaat) VALUES (@Deger, @TarihSaat)";

                    using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Deger", deger);
                        komut.Parameters.AddWithValue("@TarihSaat", tarihSaat);

                        komut.ExecuteNonQuery();

                        // Ana ekranı bul ve tabloyu yenile
                        FrmAnaEkran anaForm = Application.OpenForms["FrmAnaEkran"] as FrmAnaEkran;
                        if (anaForm != null)
                        {
                            anaForm.OlcumleriYenile();
                        }
                    }
                }

                MessageBox.Show("Ölçüm başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kapat formu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
