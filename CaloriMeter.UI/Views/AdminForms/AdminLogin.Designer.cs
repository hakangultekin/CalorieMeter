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
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(315, 49);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(245, 77);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori ve Ürün Kontrol";
            this.btnKategori.UseVisualStyleBackColor = true;
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
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 548);
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
    }
}