namespace CaloriMeter.UI.Views.UserForms
{
    partial class Meals
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOgun = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbYemekler = new System.Windows.Forms.ComboBox();
            this.cbPorsiyonTip = new System.Windows.Forms.ComboBox();
            this.lvListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yemekler :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porsiyon tipi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategoriler :";
            // 
            // cbOgun
            // 
            this.cbOgun.FormattingEnabled = true;
            this.cbOgun.Location = new System.Drawing.Point(332, 69);
            this.cbOgun.Name = "cbOgun";
            this.cbOgun.Size = new System.Drawing.Size(371, 31);
            this.cbOgun.TabIndex = 6;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(332, 142);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(371, 31);
            this.cbKategori.TabIndex = 6;
            // 
            // cbYemekler
            // 
            this.cbYemekler.FormattingEnabled = true;
            this.cbYemekler.Location = new System.Drawing.Point(332, 215);
            this.cbYemekler.Name = "cbYemekler";
            this.cbYemekler.Size = new System.Drawing.Size(371, 31);
            this.cbYemekler.TabIndex = 6;
            // 
            // cbPorsiyonTip
            // 
            this.cbPorsiyonTip.FormattingEnabled = true;
            this.cbPorsiyonTip.Location = new System.Drawing.Point(332, 288);
            this.cbPorsiyonTip.Name = "cbPorsiyonTip";
            this.cbPorsiyonTip.Size = new System.Drawing.Size(371, 31);
            this.cbPorsiyonTip.TabIndex = 6;
            // 
            // lvListe
            // 
            this.lvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvListe.HideSelection = false;
            this.lvListe.Location = new System.Drawing.Point(47, 559);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(770, 289);
            this.lvListe.TabIndex = 7;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            this.lvListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yemekler";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Porsiyon";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategoriler";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalori";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 158;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(528, 440);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 64);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tarih :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(332, 361);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(370, 29);
            this.dtpTarih.TabIndex = 13;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(332, 440);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(175, 64);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(143, 440);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 64);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // Meals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 878);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lvListe);
            this.Controls.Add(this.cbPorsiyonTip);
            this.Controls.Add(this.cbYemekler);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbOgun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Meals";
            this.Text = "Meals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOgun;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbYemekler;
        private System.Windows.Forms.ComboBox cbPorsiyonTip;
        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}