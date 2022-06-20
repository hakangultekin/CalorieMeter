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
            this.btnkategoriEkle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKullaniciKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkategoriEkle
            // 
            this.btnkategoriEkle.Location = new System.Drawing.Point(41, 161);
            this.btnkategoriEkle.Name = "btnkategoriEkle";
            this.btnkategoriEkle.Size = new System.Drawing.Size(245, 71);
            this.btnkategoriEkle.TabIndex = 5;
            this.btnkategoriEkle.Text = "Kategori Kontrol";
            this.btnkategoriEkle.UseVisualStyleBackColor = true;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(371, 31);
            this.btnIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(245, 77);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İstatistik Kontrol";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(371, 155);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(245, 77);
            this.btnKategori.TabIndex = 3;
            this.btnKategori.Text = "Ürün Kontrol";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciKontrol
            // 
            this.btnKullaniciKontrol.Location = new System.Drawing.Point(41, 31);
            this.btnKullaniciKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciKontrol.Name = "btnKullaniciKontrol";
            this.btnKullaniciKontrol.Size = new System.Drawing.Size(245, 77);
            this.btnKullaniciKontrol.TabIndex = 4;
            this.btnKullaniciKontrol.Text = "Kullanıcı Kontrol";
            this.btnKullaniciKontrol.UseVisualStyleBackColor = true;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 281);
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

        private System.Windows.Forms.Button btnkategoriEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnKullaniciKontrol;
    }
}