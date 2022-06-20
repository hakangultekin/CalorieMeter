namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnKullaniciKontrol = new System.Windows.Forms.Button();
            this.btn_aktiflestir = new System.Windows.Forms.Button();
            this.btn_getPassives = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lst_users = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(322, 127);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(292, 25);
            this.txtAra.TabIndex = 2;
            // 
            // btnKullaniciKontrol
            // 
            this.btnKullaniciKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btnKullaniciKontrol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btnKullaniciKontrol.FlatAppearance.BorderSize = 2;
            this.btnKullaniciKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciKontrol.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciKontrol.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciKontrol.Location = new System.Drawing.Point(226, 622);
            this.btnKullaniciKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciKontrol.Name = "btnKullaniciKontrol";
            this.btnKullaniciKontrol.Size = new System.Drawing.Size(182, 44);
            this.btnKullaniciKontrol.TabIndex = 5;
            this.btnKullaniciKontrol.Text = "Tümünü Görüntüle";
            this.btnKullaniciKontrol.UseVisualStyleBackColor = false;
            this.btnKullaniciKontrol.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btn_aktiflestir
            // 
            this.btn_aktiflestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_aktiflestir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_aktiflestir.FlatAppearance.BorderSize = 2;
            this.btn_aktiflestir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aktiflestir.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktiflestir.ForeColor = System.Drawing.Color.White;
            this.btn_aktiflestir.Location = new System.Drawing.Point(621, 622);
            this.btn_aktiflestir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aktiflestir.Name = "btn_aktiflestir";
            this.btn_aktiflestir.Size = new System.Drawing.Size(182, 44);
            this.btn_aktiflestir.TabIndex = 5;
            this.btn_aktiflestir.Text = "Aktifleştir";
            this.btn_aktiflestir.UseVisualStyleBackColor = false;
            this.btn_aktiflestir.Click += new System.EventHandler(this.btn_aktiflestir_Click);
            // 
            // btn_getPassives
            // 
            this.btn_getPassives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_getPassives.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_getPassives.FlatAppearance.BorderSize = 2;
            this.btn_getPassives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getPassives.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getPassives.ForeColor = System.Drawing.Color.White;
            this.btn_getPassives.Location = new System.Drawing.Point(36, 622);
            this.btn_getPassives.Margin = new System.Windows.Forms.Padding(4);
            this.btn_getPassives.Name = "btn_getPassives";
            this.btn_getPassives.Size = new System.Drawing.Size(182, 44);
            this.btn_getPassives.TabIndex = 5;
            this.btn_getPassives.Text = "Pasif Kullanıcılar";
            this.btn_getPassives.UseVisualStyleBackColor = false;
            this.btn_getPassives.Click += new System.EventHandler(this.btn_getPassives_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(621, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bul";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 89);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaloriMeter.UI.Properties.Resources.caloriemeterlogowhite;
            this.pictureBox1.Location = new System.Drawing.Point(648, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lst_users
            // 
            this.lst_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader4});
            this.lst_users.FullRowSelect = true;
            this.lst_users.HideSelection = false;
            this.lst_users.Location = new System.Drawing.Point(36, 170);
            this.lst_users.MultiSelect = false;
            this.lst_users.Name = "lst_users";
            this.lst_users.Size = new System.Drawing.Size(767, 445);
            this.lst_users.TabIndex = 48;
            this.lst_users.UseCompatibleStateImageBehavior = false;
            this.lst_users.View = System.Windows.Forms.View.Details;
            this.lst_users.DoubleClick += new System.EventHandler(this.lst_users_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mail";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aktiflik Durumu";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cinsiyet";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doğum Tarihi";
            this.columnHeader6.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(36, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "Önceki Sayfa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 701);
            this.Controls.Add(this.lst_users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_aktiflestir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_getPassives);
            this.Controls.Add(this.btnKullaniciKontrol);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kontrol Paneli";
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnKullaniciKontrol;
        private System.Windows.Forms.Button btn_aktiflestir;
        private System.Windows.Forms.Button btn_getPassives;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lst_users;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}