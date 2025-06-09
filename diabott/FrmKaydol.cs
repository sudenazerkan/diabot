using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // veritabanını ekledik




namespace DİABOT
{
    public partial class FrmKaydol : Form
    {
        public FrmKaydol()
        {
            InitializeComponent();
        }
        private void FrmKaydol_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFDF9");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtteshisYili_Click(object sender, EventArgs e)
        {

        }


        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkSifreGoster.Checked)
                {
                    txtSifree.PasswordChar = '\0';
                    txtSifreTekrarr.PasswordChar = '\0';
                }
                else
                {
                    txtSifree.PasswordChar = '*';
                    txtSifreTekrarr.PasswordChar = '*';
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTekrarGöster.Checked)
            {
                txtSifreTekrarr.PasswordChar = '\0'; // şifreyi açık göster
            }
            else
            {
                txtSifreTekrarr.PasswordChar = '*'; // şifreyi gizle
            }
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=diabot.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(conString))
            {
                baglanti.Open();

                string sql = @"INSERT INTO kullanicilar 
    (adsoyad, email, kullaniciadi, sifre, hba1c, alerji, cinsiyet, 
     diyabetTipi, teshisYili, kilo, boy, kanSekeriBirimi, insulinTuru, bazal) 
    VALUES 
    (@adsoyad, @email, @kullaniciadi, @sifre, @hba1c, @alerji, @cinsiyet, 
     @diyabetTipi, @teshisYili, @kilo, @boy, @kanSekeriBirimi, @insulinTuru, @bazal)";

                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@adsoyad", txtAdiSoyadi.Text);
                    komut.Parameters.AddWithValue("@email", txtEmaill.Text);
                    komut.Parameters.AddWithValue("@kullaniciadi", txtKullanıcıAdı.Text);
                    komut.Parameters.AddWithValue("@sifre", txtSifree.Text);
                    komut.Parameters.AddWithValue("@hba1c", txtHbA1cc.Text);
                    komut.Parameters.AddWithValue("@alerji", cmbAlerji.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyett.Text);
                    komut.Parameters.AddWithValue("@diyabetTipi", cmbDiyabetTipi.Text);
                    komut.Parameters.AddWithValue("@teshisYili", txtteshisYılı.Text);
                    komut.Parameters.AddWithValue("@kilo", txtKilo.Text);
                    komut.Parameters.AddWithValue("@boy", txtBoy.Text);
                    komut.Parameters.AddWithValue("@kanSekeriBirimi", cmbKanSekeriBirimi.Text);
                    komut.Parameters.AddWithValue("@insulinTuru", txtInsulunTuru.Text);
                    komut.Parameters.AddWithValue("@bazal", cmbBazal.Text);

                    komut.ExecuteNonQuery();
                }

                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla eklendi!");
            }
        }

        private void chkSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
//private void chkTekrarGöster_CheckedChanged(object sender, EventArgs e)
//{
//    bool goster = chkSifreGoster.Checked;

//    txtSifree.UseSystemPasswordChar = !goster;
//    txtSifreTekrarr.UseSystemPasswordChar = !goster;
//}

//private void chkSifreGoster_CheckedChanged_1(object sender, EventArgs e)
//{
//    txtSifree.UseSystemPasswordChar = !chkSifreGoster.Checked;
//}
//}





