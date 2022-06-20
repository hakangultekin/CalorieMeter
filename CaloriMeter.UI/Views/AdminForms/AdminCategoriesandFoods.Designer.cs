namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminCategoriesandFoods
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
            this.btnAra = new System.Windows.Forms.Button();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.txtYemekler = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lvListe = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(722, 123);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(91, 29);
            this.btnAra.TabIndex = 46;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(445, 260);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(371, 25);
            this.txtGram.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Porsiyon Gram:";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(442, 62);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(371, 27);
            this.cbCategories.TabIndex = 43;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(442, 193);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(371, 25);
            this.txtKalori.TabIndex = 41;
            // 
            // txtYemekler
            // 
            this.txtYemekler.Location = new System.Drawing.Point(442, 127);
            this.txtYemekler.Name = "txtYemekler";
            this.txtYemekler.Size = new System.Drawing.Size(263, 25);
            this.txtYemekler.TabIndex = 42;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(257, 334);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 64);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(446, 334);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(175, 64);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(642, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 64);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lvListe
            // 
            this.lvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2});
            this.lvListe.FullRowSelect = true;
            this.lvListe.HideSelection = false;
            this.lvListe.Location = new System.Drawing.Point(52, 449);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(765, 262);
            this.lvListe.TabIndex = 37;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            this.lvListe.View = System.Windows.Forms.View.Details;
            this.lvListe.SelectedIndexChanged += new System.EventHandler(this.lvListe_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yemek Adı";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "100 Birim Kalori";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Porsiyon Gram";
            this.columnHeader2.Width = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Kategoriler :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "100 birim Kalori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Yemekler :";
            // 
            // AdminCategoriesandFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 772);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtYemekler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lvListe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminCategoriesandFoods";
            this.Text = "AdminCategoriesandFoods";
            this.Load += new System.EventHandler(this.AdminCategoriesandFoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.TextBox txtYemekler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}