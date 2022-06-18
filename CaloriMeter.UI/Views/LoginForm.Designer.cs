namespace CaloriMeter.UI.Views
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkKayit = new System.Windows.Forms.LinkLabel();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CaloriMeter.UI.Properties.Resources.caloriemeterlogo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // linkKayit
            // 
            this.linkKayit.AutoSize = true;
            this.linkKayit.BackColor = System.Drawing.Color.Transparent;
            this.linkKayit.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkKayit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.linkKayit.Location = new System.Drawing.Point(156, 372);
            this.linkKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkKayit.Name = "linkKayit";
            this.linkKayit.Size = new System.Drawing.Size(185, 20);
            this.linkKayit.TabIndex = 11;
            this.linkKayit.TabStop = true;
            this.linkKayit.Text = "Kayıt Olmak İçin Tıklayınız";
            this.linkKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayit_LinkClicked);
            // 
            // txtParola
            // 
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(56, 271);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(287, 22);
            this.txtParola.TabIndex = 9;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(55, 207);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(286, 22);
            this.txtKullaniciAd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(52, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(52, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btnGiris
            // 
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGiris.FlatAppearance.BorderSize = 2;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Teal;
            this.btnGiris.Image = global::CaloriMeter.UI.Properties.Resources.login32x32;
            this.btnGiris.Location = new System.Drawing.Point(216, 311);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(127, 41);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::CaloriMeter.UI.Properties.Resources.bggray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkKayit);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Hoşgeldiniz - CalorieMeter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkKayit;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
    }
}