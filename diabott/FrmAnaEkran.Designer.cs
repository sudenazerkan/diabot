namespace DİABOT
{
    partial class FrmAnaEkran
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
            lblHosgeldin = new Label();
            pnlSonDeger = new Panel();
            lblTarih = new Label();
            lblBirim = new Label();
            lblDeger = new Label();
            pnlGrafik = new Panel();
            formsPlot2 = new ScottPlot.FormsPlot();
            label1 = new Label();
            dgvGecmisOlcumler = new DataGridView();
            lblUyari = new Label();
            btnYeniOlcum = new Button();
            pnlSonDeger.SuspendLayout();
            pnlGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmisOlcumler).BeginInit();
            SuspendLayout();
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHosgeldin.ForeColor = Color.White;
            lblHosgeldin.Location = new Point(167, 27);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(0, 46);
            lblHosgeldin.TabIndex = 0;
            // 
            // pnlSonDeger
            // 
            pnlSonDeger.BackColor = Color.White;
            pnlSonDeger.BorderStyle = BorderStyle.FixedSingle;
            pnlSonDeger.Controls.Add(lblTarih);
            pnlSonDeger.Controls.Add(lblBirim);
            pnlSonDeger.Controls.Add(lblDeger);
            pnlSonDeger.Location = new Point(76, 86);
            pnlSonDeger.Name = "pnlSonDeger";
            pnlSonDeger.Size = new Size(255, 147);
            pnlSonDeger.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTarih.ForeColor = Color.DimGray;
            lblTarih.Location = new Point(17, 102);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(187, 25);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "12 Mayıs 2025 – 21:35";
            // 
            // lblBirim
            // 
            lblBirim.AutoSize = true;
            lblBirim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBirim.ForeColor = Color.DimGray;
            lblBirim.Location = new Point(72, 59);
            lblBirim.Name = "lblBirim";
            lblBirim.Size = new Size(72, 28);
            lblBirim.TabIndex = 1;
            lblBirim.Text = "mg/dL";
            // 
            // lblDeger
            // 
            lblDeger.AutoSize = true;
            lblDeger.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDeger.ForeColor = Color.DimGray;
            lblDeger.Location = new Point(59, 0);
            lblDeger.Name = "lblDeger";
            lblDeger.Size = new Size(100, 60);
            lblDeger.TabIndex = 0;
            lblDeger.Text = "145";
            // 
            // pnlGrafik
            // 
            pnlGrafik.BackColor = Color.White;
            pnlGrafik.BorderStyle = BorderStyle.FixedSingle;
            pnlGrafik.Controls.Add(formsPlot2);
            pnlGrafik.Controls.Add(label1);
            pnlGrafik.Location = new Point(337, 86);
            pnlGrafik.Name = "pnlGrafik";
            pnlGrafik.Size = new Size(242, 147);
            pnlGrafik.TabIndex = 2;
            // 
            // formsPlot2
            // 
            formsPlot2.Location = new Point(47, -21);
            formsPlot2.Margin = new Padding(5, 4, 5, 4);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(142, 108);
            formsPlot2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(77, 89);
            label1.Name = "label1";
            label1.Size = new Size(88, 56);
            label1.TabIndex = 0;
            label1.Text = "Haftalık \r\n Grafik";
            // 
            // dgvGecmisOlcumler
            // 
            dgvGecmisOlcumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGecmisOlcumler.BackgroundColor = Color.White;
            dgvGecmisOlcumler.BorderStyle = BorderStyle.None;
            dgvGecmisOlcumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGecmisOlcumler.Location = new Point(76, 239);
            dgvGecmisOlcumler.Name = "dgvGecmisOlcumler";
            dgvGecmisOlcumler.RowHeadersWidth = 51;
            dgvGecmisOlcumler.Size = new Size(503, 135);
            dgvGecmisOlcumler.TabIndex = 3;
            dgvGecmisOlcumler.CellContentClick += dgvGecmisOlcumler_CellContentClick_1;
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.BackColor = Color.FromArgb(255, 111, 97);
            lblUyari.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUyari.ForeColor = Color.White;
            lblUyari.Location = new Point(205, 389);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(258, 28);
            lblUyari.TabIndex = 4;
            lblUyari.Text = "Bugün geç ölçüm yaptınız";
            lblUyari.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYeniOlcum
            // 
            btnYeniOlcum.BackColor = Color.FromArgb(255, 111, 97);
            btnYeniOlcum.FlatStyle = FlatStyle.Flat;
            btnYeniOlcum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeniOlcum.ForeColor = Color.White;
            btnYeniOlcum.Location = new Point(192, 431);
            btnYeniOlcum.Name = "btnYeniOlcum";
            btnYeniOlcum.Size = new Size(271, 72);
            btnYeniOlcum.TabIndex = 5;
            btnYeniOlcum.Text = "+ Yeni Ölçüm Ekle";
            btnYeniOlcum.UseVisualStyleBackColor = false;
            btnYeniOlcum.Click += btnYeniOlcum_Click_1;
            // 
            // FrmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 111, 97);
            ClientSize = new Size(702, 615);
            Controls.Add(btnYeniOlcum);
            Controls.Add(lblUyari);
            Controls.Add(dgvGecmisOlcumler);
            Controls.Add(pnlGrafik);
            Controls.Add(pnlSonDeger);
            Controls.Add(lblHosgeldin);
            Name = "FrmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAnaEkran";
            Load += FrmAnaEkran_Load;
            pnlSonDeger.ResumeLayout(false);
            pnlSonDeger.PerformLayout();
            pnlGrafik.ResumeLayout(false);
            pnlGrafik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGecmisOlcumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHosgeldin;
        private Panel pnlSonDeger;
        private Label lblBirim;
        private Label lblDeger;
        private Label lblTarih;
        private Panel pnlGrafik;
        private Label label1;
        private DataGridView dgvGecmisOlcumler;
        private Label lblUyari;
        private Button btnYeniOlcum;
        private ScottPlot.FormsPlot formsPlot2;
    }
}