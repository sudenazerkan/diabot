using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Data.SQLite;


namespace DİABOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanıcıAdı.Text;
            string sifre = txtSifre.Text;

            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source=diabot.db"))
            {
                baglanti.Open();
                string sql = "SELECT COUNT(*) FROM kullanicilar WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre";

                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        FrmAnaEkran anaEkran = new FrmAnaEkran("test");
                        anaEkran.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
            }
        }

            private void lblHataMesaji_Click(object sender, EventArgs e)
        {
            lblHataMesaji.Text = "Kullanıcı adı veya şifre yanlış!";
            lblHataMesaji.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, 20, 20, 180, 90);
            gp.AddArc(txtGiris.Width - 20, 0, 20, 20, 270, 90);
            gp.AddArc(txtGiris.Width - 20, txtGiris.Height - 20, 20, 20, 0, 90);
            gp.AddArc(0, txtGiris.Height - 20, 20, 20, 90, 90);
            gp.CloseFigure();
            txtGiris.Region = new Region(gp);
        }


        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            GraphicsPath yol = new GraphicsPath();
            yol.AddArc(0, 0, 20, 20, 180, 90);
            yol.AddArc(txtKullanıcıAdı.Width - 20, 0, 20, 20, 270, 90);
            yol.AddArc(txtKullanıcıAdı.Width - 20, txtKullanıcıAdı.Height - 20, 20, 20, 0, 90);
            yol.AddArc(0, txtKullanıcıAdı.Height - 20, 20, 20, 90, 90);
            yol.CloseFigure();
            txtKullanıcıAdı.Region = new Region(yol);
        }

        private void txtKaydol_Click(object sender, EventArgs e)
        {
            GraphicsPath yol = new GraphicsPath();
            yol.AddArc(0, 0, 20, 20, 180, 90);
            yol.AddArc(txtKaydol.Width - 20, 0, 20, 20, 270, 90);
            yol.AddArc(txtKaydol.Width - 20, txtKaydol.Height - 20, 20, 20, 0, 90);
            yol.AddArc(0, txtKaydol.Height - 20, 20, 20, 90, 90);
            yol.CloseFigure();
            txtKaydol.Region = new Region(yol);

            FrmKaydol kaydolFormu = new FrmKaydol();
            kaydolFormu.Show();

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            GraphicsPath yol = new GraphicsPath();
            yol.AddArc(0, 0, 20, 20, 180, 90);
            yol.AddArc(txtSifre.Width - 20, 0, 20, 20, 270, 90);
            yol.AddArc(txtSifre.Width - 20, txtSifre.Height - 20, 20, 20, 0, 90);
            yol.AddArc(0, txtSifre.Height - 20, 20, 20, 90, 90);
            yol.CloseFigure();
            txtSifre.Region = new Region(yol);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !chkSifreGoster.Checked;
        }
    }
}