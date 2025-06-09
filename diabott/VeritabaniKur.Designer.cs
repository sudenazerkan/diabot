namespace DİABOT
{
    partial class VeritabaniKur
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
            btnVeritabaniOlustur = new Button();
            btnTabloOlustur = new Button();
            btnAlanlariEkle = new Button();
            btnOlcumTablosuOlustur = new Button();
            SuspendLayout();
            // 
            // btnVeritabaniOlustur
            // 
            btnVeritabaniOlustur.Location = new Point(142, 81);
            btnVeritabaniOlustur.Name = "btnVeritabaniOlustur";
            btnVeritabaniOlustur.Size = new Size(176, 29);
            btnVeritabaniOlustur.TabIndex = 0;
            btnVeritabaniOlustur.Text = "veritabanı oluştur";
            btnVeritabaniOlustur.UseVisualStyleBackColor = true;
            btnVeritabaniOlustur.Click += btnVeritabaniOlustur_Click;
            // 
            // btnTabloOlustur
            // 
            btnTabloOlustur.Location = new Point(142, 145);
            btnTabloOlustur.Name = "btnTabloOlustur";
            btnTabloOlustur.Size = new Size(120, 29);
            btnTabloOlustur.TabIndex = 1;
            btnTabloOlustur.Text = "tablo oluştur";
            btnTabloOlustur.UseVisualStyleBackColor = true;
            btnTabloOlustur.Click += btnTabloOlustur_Click;
            // 
            // btnAlanlariEkle
            // 
            btnAlanlariEkle.Location = new Point(178, 233);
            btnAlanlariEkle.Name = "btnAlanlariEkle";
            btnAlanlariEkle.Size = new Size(184, 29);
            btnAlanlariEkle.TabIndex = 2;
            btnAlanlariEkle.Text = "alanları ekle";
            btnAlanlariEkle.UseVisualStyleBackColor = true;
            btnAlanlariEkle.Click += btnAlanlariEkle_Click;
            // 
            // btnOlcumTablosuOlustur
            // 
            btnOlcumTablosuOlustur.Location = new Point(256, 309);
            btnOlcumTablosuOlustur.Name = "btnOlcumTablosuOlustur";
            btnOlcumTablosuOlustur.Size = new Size(94, 29);
            btnOlcumTablosuOlustur.TabIndex = 3;
            btnOlcumTablosuOlustur.Text = "ölçüm";
            btnOlcumTablosuOlustur.UseVisualStyleBackColor = true;
            btnOlcumTablosuOlustur.Click += btnOlcumTablosuOlustur_Click;
            // 
            // VeritabaniKur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOlcumTablosuOlustur);
            Controls.Add(btnAlanlariEkle);
            Controls.Add(btnTabloOlustur);
            Controls.Add(btnVeritabaniOlustur);
            Name = "VeritabaniKur";
            Text = "VeritabaniKur";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVeritabaniOlustur;
        private Button btnTabloOlustur;
        private Button btnAlanlariEkle;
        private Button btnOlcumTablosuOlustur;
    }
}