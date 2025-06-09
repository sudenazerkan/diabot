namespace DİABOT
{
    partial class FrmKaydol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlUst = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtAdSoyad = new Label();
            txtEmail = new Label();
            txtKullaniciAdi = new Label();
            txtSifre = new Label();
            txtSifreTekrar = new Label();
            txtHbA1c = new Label();
            txtAlerjiler = new Label();
            txtAdiSoyadi = new TextBox();
            txtEmaill = new TextBox();
            txtKullanıcıAdı = new TextBox();
            txtSifreTekrarr = new TextBox();
            cmbAlerji = new TextBox();
            txtHbA1cc = new TextBox();
            txtCinsiyet = new Label();
            txtDiyabetTipi = new Label();
            txtTeshisYili = new Label();
            txtKg = new Label();
            txtKanSekeriBirimi = new Label();
            txtİnsülünTürü = new Label();
            txtteshisYılı = new TextBox();
            txtInsulunTuru = new TextBox();
            txtKilo = new TextBox();
            cmbBazal = new TextBox();
            txtBazal = new Label();
            cmbCinsiyett = new ComboBox();
            cmbDiyabetTipi = new ComboBox();
            cmbKanSekeriBirimi = new ComboBox();
            txtBoy = new TextBox();
            chkSifreGoster = new CheckBox();
            txtSifree = new TextBox();
            chkTekrarGöster = new CheckBox();
            btnKayitOl = new Button();
            pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.AutoScroll = true;
            pnlUst.AutoScrollMinSize = new Size(0, 130);
            pnlUst.BackColor = Color.FromArgb(230, 80, 70);
            pnlUst.Controls.Add(label1);
            pnlUst.Controls.Add(pictureBox1);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(597, 95);
            pnlUst.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 52);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 1;
            label1.Text = "DIABOT";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.raindrop_1561__2_;
            pictureBox1.Location = new Point(211, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.AutoSize = true;
            txtAdSoyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdSoyad.Location = new Point(33, 107);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(95, 23);
            txtAdSoyad.TabIndex = 1;
            txtAdSoyad.Text = "Ad - Soyad";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(34, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(68, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "E-posta";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.AutoSize = true;
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(34, 256);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(103, 23);
            txtKullaniciAdi.TabIndex = 3;
            txtKullaniciAdi.Text = "Kullanıcı Adı";
            txtKullaniciAdi.Click += label4_Click;
            // 
            // txtSifre
            // 
            txtSifre.AutoSize = true;
            txtSifre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(34, 323);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(44, 23);
            txtSifre.TabIndex = 4;
            txtSifre.Text = "Şifre";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.AutoSize = true;
            txtSifreTekrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifreTekrar.Location = new Point(33, 392);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(95, 23);
            txtSifreTekrar.TabIndex = 5;
            txtSifreTekrar.Text = "Şifre Tekrar";
            // 
            // txtHbA1c
            // 
            txtHbA1c.AutoSize = true;
            txtHbA1c.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtHbA1c.Location = new Point(33, 448);
            txtHbA1c.Name = "txtHbA1c";
            txtHbA1c.Size = new Size(85, 23);
            txtHbA1c.TabIndex = 6;
            txtHbA1c.Text = "HbA1c(%)";
            // 
            // txtAlerjiler
            // 
            txtAlerjiler.AutoSize = true;
            txtAlerjiler.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAlerjiler.Location = new Point(33, 513);
            txtAlerjiler.Name = "txtAlerjiler";
            txtAlerjiler.Size = new Size(67, 23);
            txtAlerjiler.TabIndex = 7;
            txtAlerjiler.Text = "Alerjiler";
            // 
            // txtAdiSoyadi
            // 
            txtAdiSoyadi.Location = new Point(34, 133);
            txtAdiSoyadi.Name = "txtAdiSoyadi";
            txtAdiSoyadi.Size = new Size(179, 27);
            txtAdiSoyadi.TabIndex = 8;
            // 
            // txtEmaill
            // 
            txtEmaill.Location = new Point(34, 211);
            txtEmaill.Name = "txtEmaill";
            txtEmaill.Size = new Size(179, 27);
            txtEmaill.TabIndex = 9;
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(33, 282);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(179, 27);
            txtKullanıcıAdı.TabIndex = 10;
            // 
            // txtSifreTekrarr
            // 
            txtSifreTekrarr.Location = new Point(33, 419);
            txtSifreTekrarr.Name = "txtSifreTekrarr";
            txtSifreTekrarr.PasswordChar = '*';
            txtSifreTekrarr.Size = new Size(179, 27);
            txtSifreTekrarr.TabIndex = 12;
            txtSifreTekrarr.UseSystemPasswordChar = true;
            // 
            // cmbAlerji
            // 
            cmbAlerji.Location = new Point(34, 536);
            cmbAlerji.Name = "cmbAlerji";
            cmbAlerji.Size = new Size(179, 27);
            cmbAlerji.TabIndex = 13;
            // 
            // txtHbA1cc
            // 
            txtHbA1cc.Location = new Point(33, 474);
            txtHbA1cc.Name = "txtHbA1cc";
            txtHbA1cc.Size = new Size(179, 27);
            txtHbA1cc.TabIndex = 14;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.AutoSize = true;
            txtCinsiyet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtCinsiyet.Location = new Point(317, 107);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(70, 23);
            txtCinsiyet.TabIndex = 15;
            txtCinsiyet.Text = "Cinsiyet";
            // 
            // txtDiyabetTipi
            // 
            txtDiyabetTipi.AutoSize = true;
            txtDiyabetTipi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtDiyabetTipi.Location = new Point(317, 182);
            txtDiyabetTipi.Name = "txtDiyabetTipi";
            txtDiyabetTipi.Size = new Size(101, 23);
            txtDiyabetTipi.TabIndex = 16;
            txtDiyabetTipi.Text = "Diyabet Tipi";
            // 
            // txtTeshisYili
            // 
            txtTeshisYili.AutoSize = true;
            txtTeshisYili.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTeshisYili.Location = new Point(317, 256);
            txtTeshisYili.Name = "txtTeshisYili";
            txtTeshisYili.Size = new Size(81, 23);
            txtTeshisYili.TabIndex = 17;
            txtTeshisYili.Text = "Teşhis Yılı";
            txtTeshisYili.Click += txtteshisYili_Click;
            // 
            // txtKg
            // 
            txtKg.AutoSize = true;
            txtKg.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKg.Location = new Point(322, 323);
            txtKg.Name = "txtKg";
            txtKg.Size = new Size(76, 23);
            txtKg.TabIndex = 18;
            txtKg.Text = "Kg / Boy";
            // 
            // txtKanSekeriBirimi
            // 
            txtKanSekeriBirimi.AutoSize = true;
            txtKanSekeriBirimi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKanSekeriBirimi.Location = new Point(321, 388);
            txtKanSekeriBirimi.Name = "txtKanSekeriBirimi";
            txtKanSekeriBirimi.Size = new Size(143, 23);
            txtKanSekeriBirimi.TabIndex = 20;
            txtKanSekeriBirimi.Text = "Kan Şekeri Birimi ";
            // 
            // txtİnsülünTürü
            // 
            txtİnsülünTürü.AutoSize = true;
            txtİnsülünTürü.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtİnsülünTürü.Location = new Point(317, 448);
            txtİnsülünTürü.Name = "txtİnsülünTürü";
            txtİnsülünTürü.Size = new Size(105, 23);
            txtİnsülünTürü.TabIndex = 21;
            txtİnsülünTürü.Text = "İnsülün Türü";
            // 
            // txtteshisYılı
            // 
            txtteshisYılı.Location = new Point(317, 282);
            txtteshisYılı.Name = "txtteshisYılı";
            txtteshisYılı.Size = new Size(179, 27);
            txtteshisYılı.TabIndex = 24;
            // 
            // txtInsulunTuru
            // 
            txtInsulunTuru.Location = new Point(317, 474);
            txtInsulunTuru.Name = "txtInsulunTuru";
            txtInsulunTuru.Size = new Size(183, 27);
            txtInsulunTuru.TabIndex = 25;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(317, 349);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(74, 27);
            txtKilo.TabIndex = 26;
            // 
            // cmbBazal
            // 
            cmbBazal.Location = new Point(317, 536);
            cmbBazal.Name = "cmbBazal";
            cmbBazal.Size = new Size(183, 27);
            cmbBazal.TabIndex = 28;
            // 
            // txtBazal
            // 
            txtBazal.AutoSize = true;
            txtBazal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBazal.Location = new Point(313, 510);
            txtBazal.Name = "txtBazal";
            txtBazal.Size = new Size(204, 23);
            txtBazal.TabIndex = 29;
            txtBazal.Text = "Bazal(gece) İnsülün Dozu";
            // 
            // cmbCinsiyett
            // 
            cmbCinsiyett.FormattingEnabled = true;
            cmbCinsiyett.Items.AddRange(new object[] { "Kadın", "Erkek", "Diğer" });
            cmbCinsiyett.Location = new Point(317, 133);
            cmbCinsiyett.Name = "cmbCinsiyett";
            cmbCinsiyett.Size = new Size(179, 28);
            cmbCinsiyett.TabIndex = 31;
            // 
            // cmbDiyabetTipi
            // 
            cmbDiyabetTipi.FormattingEnabled = true;
            cmbDiyabetTipi.Items.AddRange(new object[] { "Tip 1", "Tip 2", "Gestasyonel Diyabet" });
            cmbDiyabetTipi.Location = new Point(317, 208);
            cmbDiyabetTipi.Name = "cmbDiyabetTipi";
            cmbDiyabetTipi.Size = new Size(179, 28);
            cmbDiyabetTipi.TabIndex = 32;
            // 
            // cmbKanSekeriBirimi
            // 
            cmbKanSekeriBirimi.FormattingEnabled = true;
            cmbKanSekeriBirimi.Items.AddRange(new object[] { "mg / dl" });
            cmbKanSekeriBirimi.Location = new Point(317, 418);
            cmbKanSekeriBirimi.Name = "cmbKanSekeriBirimi";
            cmbKanSekeriBirimi.Size = new Size(179, 28);
            cmbKanSekeriBirimi.TabIndex = 33;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(404, 349);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(70, 27);
            txtBoy.TabIndex = 34;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(194, 361);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(18, 17);
            chkSifreGoster.TabIndex = 35;
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged_1;
            // 
            // txtSifree
            // 
            txtSifree.Location = new Point(35, 355);
            txtSifree.Name = "txtSifree";
            txtSifree.Size = new Size(179, 27);
            txtSifree.TabIndex = 36;
            txtSifree.UseSystemPasswordChar = true;
            // 
            // chkTekrarGöster
            // 
            chkTekrarGöster.AutoSize = true;
            chkTekrarGöster.Location = new Point(194, 425);
            chkTekrarGöster.Name = "chkTekrarGöster";
            chkTekrarGöster.Size = new Size(18, 17);
            chkTekrarGöster.TabIndex = 37;
            chkTekrarGöster.UseVisualStyleBackColor = true;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(230, 80, 70);
            btnKayitOl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(205, 593);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(131, 41);
            btnKayitOl.TabIndex = 38;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // FrmKaydol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(597, 688);
            Controls.Add(btnKayitOl);
            Controls.Add(chkTekrarGöster);
            Controls.Add(chkSifreGoster);
            Controls.Add(txtSifree);
            Controls.Add(txtBoy);
            Controls.Add(cmbKanSekeriBirimi);
            Controls.Add(cmbDiyabetTipi);
            Controls.Add(cmbCinsiyett);
            Controls.Add(txtBazal);
            Controls.Add(cmbBazal);
            Controls.Add(txtKilo);
            Controls.Add(txtInsulunTuru);
            Controls.Add(txtteshisYılı);
            Controls.Add(txtİnsülünTürü);
            Controls.Add(txtKanSekeriBirimi);
            Controls.Add(txtKg);
            Controls.Add(txtTeshisYili);
            Controls.Add(txtDiyabetTipi);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtHbA1cc);
            Controls.Add(cmbAlerji);
            Controls.Add(txtSifreTekrarr);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(txtEmaill);
            Controls.Add(txtAdiSoyadi);
            Controls.Add(txtAlerjiler);
            Controls.Add(txtHbA1c);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtEmail);
            Controls.Add(txtAdSoyad);
            Controls.Add(pnlUst);
            Name = "FrmKaydol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKaydol";
            Load += FrmKaydol_Load;
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUst;
        private PictureBox pictureBox1;
        private Label label1;
        private Label txtAdSoyad;
        private Label txtEmail;
        private Label txtKullaniciAdi;
        private Label txtSifre;
        private Label txtSifreTekrar;
        private Label txtHbA1c;
        private Label txtAlerjiler;
        private TextBox txtAdiSoyadi;
        private TextBox txtEmaill;
        private TextBox txtKullanıcıAdı;
        private TextBox txtSifreTekrarr;
        private TextBox cmbAlerji;
        private TextBox txtHbA1cc;
        private Label txtCinsiyet;
        private Label txtDiyabetTipi;
        private Label txtTeshisYili;
        private Label txtKg;
        private Label txtKanSekeriBirimi;
        private Label txtİnsülünTürü;
        private TextBox txtteshisYılı;
        private TextBox txtInsulunTuru;
        private TextBox txtKilo;
        private TextBox cmbBazal;
        private Label txtBazal;
        private ComboBox cmbCinsiyett;
        private ComboBox cmbDiyabetTipi;
        private ComboBox cmbKanSekeriBirimi;
        private TextBox txtBoy;
        private CheckBox chkSifreGoster;
        private TextBox txtSifree;
        private CheckBox chkTekrarGöster;
        private Button btnKayitOl;
    }
}