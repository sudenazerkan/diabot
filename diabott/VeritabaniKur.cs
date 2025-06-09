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
    public partial class VeritabaniKur : Form
    {
        public VeritabaniKur()
        {
            InitializeComponent();
        }

        private void btnVeritabaniOlustur_Click(object sender, EventArgs e)
        {
            string dbYolu = "diabot.db";

            if (!System.IO.File.Exists(dbYolu))
            {
                SQLiteConnection.CreateFile(dbYolu);
                MessageBox.Show("Yeni veritabanı başarıyla oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Veritabanı zaten var.");
            }
        }

        private void btnTabloOlustur_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=diabot.db;Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();

                string query = @"CREATE TABLE IF NOT EXISTS kullanicilar (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        adsoyad TEXT,
                        email TEXT,
                        kullaniciadi TEXT UNIQUE,
                        sifre TEXT
                    )";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tablo oluşturuldu (veya zaten vardı).");
                }

                con.Close();
            }
        }

        private void btnAlanlariEkle_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=diabot.db;Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(conString))
            {
                con.Open();

                string[] alterQueries = {
            "ALTER TABLE kullanicilar ADD COLUMN hba1c TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN alerji TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN cinsiyet TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN diyabetTipi TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN teshisYili TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN kilo TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN boy TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN kanSekeriBirimi TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN insulinTuru TEXT",
            "ALTER TABLE kullanicilar ADD COLUMN bazal TEXT"
        };

                foreach (string query in alterQueries)
                {
                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Zaten var: " + ex.Message);
                    }
                }

                MessageBox.Show("Tüm alanlar başarıyla eklendi.");
                con.Close();
            }
        }

        private void btnOlcumTablosuOlustur_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=diabot.db;Version=3;";
            using (SQLiteConnection baglanti = new SQLiteConnection(conString))
            {
                baglanti.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS tblOlcumler (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    KullaniciAdi TEXT,
                    TarihSaat TEXT,
                    KanSekeri REAL,
                    Notlar TEXT
                )";

                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.ExecuteNonQuery();
                }

                baglanti.Close();
                MessageBox.Show("tblOlcumler tablosu başarıyla oluşturuldu.");
            }
        }
    }
}
