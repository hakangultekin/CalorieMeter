namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminCategoryControl
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
            this.cbCats = new System.Windows.Forms.ComboBox();
            this.txt_catguncelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newCatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCats
            // 
            this.cbCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCats.FormattingEnabled = true;
            this.cbCats.Location = new System.Drawing.Point(145, 51);
            this.cbCats.Name = "cbCats";
            this.cbCats.Size = new System.Drawing.Size(243, 27);
            this.cbCats.TabIndex = 42;
            this.cbCats.SelectedIndexChanged += new System.EventHandler(this.cbCats_SelectedIndexChanged);
            // 
            // txt_catguncelName
            // 
            this.txt_catguncelName.Location = new System.Drawing.Point(145, 90);
            this.txt_catguncelName.Name = "txt_catguncelName";
            this.txt_catguncelName.Size = new System.Drawing.Size(243, 25);
            this.txt_catguncelName.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kategori İsmi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kategoriler :";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_guncelle.FlatAppearance.BorderSize = 2;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(294, 122);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(94, 41);
            this.btn_guncelle.TabIndex = 60;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btnCatGuncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_ekle.FlatAppearance.BorderSize = 2;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(294, 259);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 41);
            this.btn_ekle.TabIndex = 60;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kategori İsmi :";
            // 
            // txt_newCatName
            // 
            this.txt_newCatName.Location = new System.Drawing.Point(145, 227);
            this.txt_newCatName.Name = "txt_newCatName";
            this.txt_newCatName.Size = new System.Drawing.Size(243, 25);
            this.txt_newCatName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 2);
            this.label4.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Yeni Kategori Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Kategori Bilgisi Güncelle";
            // 
            // AdminCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 312);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cbCats);
            this.Controls.Add(this.txt_newCatName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_catguncelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Name = "AdminCategoryControl";
            this.Text = "Kategori Kontrol Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCats;
        private System.Windows.Forms.TextBox txt_catguncelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newCatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}