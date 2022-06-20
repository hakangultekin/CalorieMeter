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
            this.btnCatGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbCats = new System.Windows.Forms.ComboBox();
            this.txtYeniCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCatGuncelle
            // 
            this.btnCatGuncelle.Location = new System.Drawing.Point(170, 136);
            this.btnCatGuncelle.Name = "btnCatGuncelle";
            this.btnCatGuncelle.Size = new System.Drawing.Size(105, 42);
            this.btnCatGuncelle.TabIndex = 44;
            this.btnCatGuncelle.Text = "Güncelle";
            this.btnCatGuncelle.UseVisualStyleBackColor = true;
            this.btnCatGuncelle.Click += new System.EventHandler(this.btnCatGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(299, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 42);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbCats
            // 
            this.cbCats.FormattingEnabled = true;
            this.cbCats.Location = new System.Drawing.Point(170, 20);
            this.cbCats.Name = "cbCats";
            this.cbCats.Size = new System.Drawing.Size(243, 24);
            this.cbCats.TabIndex = 42;
            this.cbCats.SelectedIndexChanged += new System.EventHandler(this.cbCats_SelectedIndexChanged);
            // 
            // txtYeniCat
            // 
            this.txtYeniCat.Location = new System.Drawing.Point(170, 79);
            this.txtYeniCat.Name = "txtYeniCat";
            this.txtYeniCat.Size = new System.Drawing.Size(243, 22);
            this.txtYeniCat.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kategori İsmi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kategoriler";
            // 
            // AdminCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 228);
            this.Controls.Add(this.btnCatGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbCats);
            this.Controls.Add(this.txtYeniCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AdminCategoryControl";
            this.Text = "AdminCategoryControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCatGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbCats;
        private System.Windows.Forms.TextBox txtYeniCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}