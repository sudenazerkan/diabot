namespace DİABOT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBaslik = new Label();
            lblKullaniciAdi = new Label();
            txtKullanıcıAdı = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            txtGiris = new Button();
            lblHataMesaji = new Label();
            label1 = new Label();
            txtKaydol = new Button();
            yeniLogo = new PictureBox();
            chkSifreGoster = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)yeniLogo).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.ImageAlign = ContentAlignment.TopCenter;
            lblBaslik.Location = new Point(466, 91);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(202, 62);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "DIABOT\r\n";
            lblBaslik.Click += label1_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.White;
            lblKullaniciAdi.Location = new Point(427, 196);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(154, 31);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            lblKullaniciAdi.Click += label2_Click;
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.BackColor = Color.White;
            txtKullanıcıAdı.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullanıcıAdı.Location = new Point(376, 230);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(249, 34);
            txtKullanıcıAdı.TabIndex = 2;
            txtKullanıcıAdı.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(466, 267);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(74, 31);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(376, 301);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(249, 34);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtGiris
            // 
            txtGiris.BackColor = Color.FromArgb(230, 80, 70);
            txtGiris.FlatAppearance.BorderColor = Color.FromArgb(230, 80, 70);
            txtGiris.FlatAppearance.BorderSize = 0;
            txtGiris.FlatStyle = FlatStyle.Flat;
            txtGiris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtGiris.ForeColor = Color.White;
            txtGiris.Location = new Point(532, 368);
            txtGiris.Name = "txtGiris";
            txtGiris.Size = new Size(150, 57);
            txtGiris.TabIndex = 5;
            txtGiris.Text = "Giriş Yap";
            txtGiris.UseVisualStyleBackColor = false;
            txtGiris.Click += txtGirisYap_Click;
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.AutoSize = true;
            lblHataMesaji.FlatStyle = FlatStyle.Flat;
            lblHataMesaji.Location = new Point(449, 478);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(101, 20);
            lblHataMesaji.TabIndex = 6;
            lblHataMesaji.Text = "IblHataMesaji";
            lblHataMesaji.Visible = false;
            lblHataMesaji.Click += lblHataMesaji_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(478, 153);
            label1.Name = "label1";
            label1.Size = new Size(273, 23);
            label1.TabIndex = 8;
            label1.Text = "KAN ŞEKERİ TAKİP UYGULAMASI";
            // 
            // txtKaydol
            // 
            txtKaydol.BackColor = Color.FromArgb(230, 80, 70);
            txtKaydol.FlatAppearance.BorderColor = Color.FromArgb(230, 80, 70);
            txtKaydol.FlatAppearance.BorderSize = 0;
            txtKaydol.FlatStyle = FlatStyle.Flat;
            txtKaydol.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKaydol.ForeColor = Color.White;
            txtKaydol.Location = new Point(341, 368);
            txtKaydol.Name = "txtKaydol";
            txtKaydol.Size = new Size(150, 57);
            txtKaydol.TabIndex = 9;
            txtKaydol.Text = "Kayıt Ol";
            txtKaydol.UseVisualStyleBackColor = false;
            txtKaydol.Click += txtKaydol_Click;
            // 
            // yeniLogo
            // 
            yeniLogo.Image = Properties.Resources.raindrop_1561__2_1;
            yeniLogo.Location = new Point(359, 91);
            yeniLogo.Name = "yeniLogo";
            yeniLogo.Size = new Size(100, 100);
            yeniLogo.SizeMode = PictureBoxSizeMode.Zoom;
            yeniLogo.TabIndex = 10;
            yeniLogo.TabStop = false;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.BackColor = Color.White;
            chkSifreGoster.Location = new Point(598, 314);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(18, 17);
            chkSifreGoster.TabIndex = 11;
            chkSifreGoster.UseVisualStyleBackColor = false;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = txtGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 111, 97);
            ClientSize = new Size(1035, 528);
            Controls.Add(chkSifreGoster);
            Controls.Add(yeniLogo);
            Controls.Add(txtKaydol);
            Controls.Add(label1);
            Controls.Add(lblHataMesaji);
            Controls.Add(txtGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DIABOT";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)yeniLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblKullaniciAdi;
        private TextBox txtKullanıcıAdı;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button txtGiris;
        private Label lblHataMesaji;
        private Label label1;
        private Button txtKaydol;
        private PictureBox yeniLogo;
        private CheckBox chkSifreGoster;
    }
}
