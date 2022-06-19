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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lvListe = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriler = new System.Windows.Forms.TextBox();
            this.txtYemekler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorsTip = new System.Windows.Forms.TextBox();
            this.cbPorsTip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(254, 340);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 64);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(443, 340);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(175, 64);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(639, 340);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 64);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // lvListe
            // 
            this.lvListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2});
            this.lvListe.HideSelection = false;
            this.lvListe.Location = new System.Drawing.Point(49, 455);
            this.lvListe.Name = "lvListe";
            this.lvListe.Size = new System.Drawing.Size(765, 262);
            this.lvListe.TabIndex = 23;
            this.lvListe.UseCompatibleStateImageBehavior = false;
            this.lvListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategoriler";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yemekler";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalori";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Porsiyon tipi";
            this.columnHeader2.Width = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kategoriler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yemekler :";
            // 
            // txtKategoriler
            // 
            this.txtKategoriler.Location = new System.Drawing.Point(443, 65);
            this.txtKategoriler.Name = "txtKategoriler";
            this.txtKategoriler.Size = new System.Drawing.Size(371, 29);
            this.txtKategoriler.TabIndex = 28;
            // 
            // txtYemekler
            // 
            this.txtYemekler.Location = new System.Drawing.Point(442, 131);
            this.txtYemekler.Name = "txtYemekler";
            this.txtYemekler.Size = new System.Drawing.Size(371, 29);
            this.txtYemekler.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kalori:";
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(442, 197);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(371, 29);
            this.txtKalori.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Porsiyon tipi :";
            // 
            // txtPorsTip
            // 
            this.txtPorsTip.Location = new System.Drawing.Point(639, 264);
            this.txtPorsTip.Name = "txtPorsTip";
            this.txtPorsTip.Size = new System.Drawing.Size(175, 29);
            this.txtPorsTip.TabIndex = 28;
            // 
            // cbPorsTip
            // 
            this.cbPorsTip.FormattingEnabled = true;
            this.cbPorsTip.Location = new System.Drawing.Point(442, 263);
            this.cbPorsTip.Name = "cbPorsTip";
            this.cbPorsTip.Size = new System.Drawing.Size(176, 31);
            this.cbPorsTip.TabIndex = 29;
            // 
            // AdminCategoriesandFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 772);
            this.Controls.Add(this.cbPorsTip);
            this.Controls.Add(this.txtPorsTip);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtYemekler);
            this.Controls.Add(this.txtKategoriler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lvListe);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView lvListe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriler;
        private System.Windows.Forms.TextBox txtYemekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorsTip;
        private System.Windows.Forms.ComboBox cbPorsTip;
    }
}