namespace DİABOT
{
    partial class YeniOlcumEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniOlcumEkle));
            label1 = new Label();
            txtDeger = new TextBox();
            label2 = new Label();
            dtpTarihSaat = new DateTimePicker();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 136);
            label1.Name = "label1";
            label1.Size = new Size(204, 62);
            label1.TabIndex = 0;
            label1.Text = "Kan Şekeri Değeri\r\n(mg / dL}";
            // 
            // txtDeger
            // 
            txtDeger.Location = new Point(106, 207);
            txtDeger.Name = "txtDeger";
            txtDeger.Size = new Size(231, 27);
            txtDeger.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 252);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 2;
            label2.Text = "Tarih ve Saat";
            // 
            // dtpTarihSaat
            // 
            dtpTarihSaat.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpTarihSaat.Format = DateTimePickerFormat.Custom;
            dtpTarihSaat.Location = new Point(106, 293);
            dtpTarihSaat.Name = "dtpTarihSaat";
            dtpTarihSaat.Size = new Size(231, 27);
            dtpTarihSaat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 53);
            label3.Name = "label3";
            label3.Size = new Size(147, 46);
            label3.TabIndex = 4;
            label3.Text = "DIABOT";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(230, 92, 78);
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(154, 344);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(156, 59);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += button1_Click;
            // 
            // YeniOlcumEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 111, 97);
            ClientSize = new Size(532, 483);
            Controls.Add(btnKaydet);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dtpTarihSaat);
            Controls.Add(label2);
            Controls.Add(txtDeger);
            Controls.Add(label1);
            Name = "YeniOlcumEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YeniOlcumEkle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDeger;
        private Label label2;
        private DateTimePicker dtpTarihSaat;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnKaydet;
    }
}