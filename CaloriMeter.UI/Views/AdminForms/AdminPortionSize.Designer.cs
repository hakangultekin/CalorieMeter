namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminPortionSize
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
            this.cbPorsTip = new System.Windows.Forms.ComboBox();
            this.txtYeniPors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPorGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPorsTip
            // 
            this.cbPorsTip.FormattingEnabled = true;
            this.cbPorsTip.Location = new System.Drawing.Point(227, 47);
            this.cbPorsTip.Name = "cbPorsTip";
            this.cbPorsTip.Size = new System.Drawing.Size(262, 24);
            this.cbPorsTip.TabIndex = 32;
            // 
            // txtYeniPors
            // 
            this.txtYeniPors.Location = new System.Drawing.Point(227, 106);
            this.txtYeniPors.Name = "txtYeniPors";
            this.txtYeniPors.Size = new System.Drawing.Size(262, 22);
            this.txtYeniPors.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Porsiyon tipi :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(360, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 42);
            this.btnEkle.TabIndex = 33;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Yeni porsiyon İsmi :";
            // 
            // btnPorGuncelle
            // 
            this.btnPorGuncelle.Location = new System.Drawing.Point(227, 152);
            this.btnPorGuncelle.Name = "btnPorGuncelle";
            this.btnPorGuncelle.Size = new System.Drawing.Size(127, 42);
            this.btnPorGuncelle.TabIndex = 34;
            this.btnPorGuncelle.Text = "Güncelle";
            this.btnPorGuncelle.UseVisualStyleBackColor = true;
            // 
            // AdminPortionSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 259);
            this.Controls.Add(this.btnPorGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbPorsTip);
            this.Controls.Add(this.txtYeniPors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AdminPortionSize";
            this.Text = "AdminPortionSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPorsTip;
        private System.Windows.Forms.TextBox txtYeniPors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPorGuncelle;
    }
}