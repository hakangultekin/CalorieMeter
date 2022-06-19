namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminLogin
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
            this.btnKullaniciKontrol = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnkategoriEkle = new System.Windows.Forms.Button();
            this.btnPortionSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciKontrol
            // 
            this.btnKullaniciKontrol.Location = new System.Drawing.Point(41, 49);
            this.btnKullaniciKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciKontrol.Name = "btnKullaniciKontrol";
            this.btnKullaniciKontrol.Size = new System.Drawing.Size(245, 77);
            this.btnKullaniciKontrol.TabIndex = 0;
            this.btnKullaniciKontrol.Text = "Kullanıcı Kontrol";
            this.btnKullaniciKontrol.UseVisualStyleBackColor = true;
            this.btnKullaniciKontrol.Click += new System.EventHandler(this.btnKullaniciKontrol_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(315, 49);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(245, 77);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Ürün Kontrol";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(595, 49);
            this.btnIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(245, 77);
            this.btnIstatistik.TabIndex = 0;
            this.btnIstatistik.Text = "İstatistik Kontrol";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnkategoriEkle
            // 
            this.btnkategoriEkle.Location = new System.Drawing.Point(41, 189);
            this.btnkategoriEkle.Name = "btnkategoriEkle";
            this.btnkategoriEkle.Size = new System.Drawing.Size(245, 71);
            this.btnkategoriEkle.TabIndex = 1;
            this.btnkategoriEkle.Text = "Kategori Kontrol";
            this.btnkategoriEkle.UseVisualStyleBackColor = true;
            this.btnkategoriEkle.Click += new System.EventHandler(this.btnkategoriEkle_Click);
            // 
            // btnPortionSize
            // 
            this.btnPortionSize.Location = new System.Drawing.Point(315, 189);
            this.btnPortionSize.Name = "btnPortionSize";
            this.btnPortionSize.Size = new System.Drawing.Size(245, 71);
            this.btnPortionSize.TabIndex = 1;
            this.btnPortionSize.Text = "Porsiyon Kontrol";
            this.btnPortionSize.UseVisualStyleBackColor = true;
            this.btnPortionSize.Click += new System.EventHandler(this.btnPortionSize_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 548);
            this.Controls.Add(this.btnPortionSize);
            this.Controls.Add(this.btnkategoriEkle);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnKullaniciKontrol);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciKontrol;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnkategoriEkle;
        private System.Windows.Forms.Button btnPortionSize;
    }
}