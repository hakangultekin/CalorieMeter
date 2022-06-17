namespace CaloriMeter.UI.Views.UserForms
{
    partial class Statistics
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
            this.cbRaporlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.dtbBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRaporlar
            // 
            this.cbRaporlar.FormattingEnabled = true;
            this.cbRaporlar.Location = new System.Drawing.Point(254, 52);
            this.cbRaporlar.Name = "cbRaporlar";
            this.cbRaporlar.Size = new System.Drawing.Size(323, 31);
            this.cbRaporlar.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rapor Görüntüle :";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(55, 167);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 62;
            this.dgvListe.RowTemplate.Height = 28;
            this.dgvListe.Size = new System.Drawing.Size(747, 453);
            this.dgvListe.TabIndex = 19;
            // 
            // dtbBaslangıc
            // 
            this.dtbBaslangıc.Location = new System.Drawing.Point(226, 106);
            this.dtbBaslangıc.Name = "dtbBaslangıc";
            this.dtbBaslangıc.Size = new System.Drawing.Size(200, 29);
            this.dtbBaslangıc.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(602, 106);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 29);
            this.dtpBitis.TabIndex = 20;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(602, 47);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(199, 42);
            this.btnGoruntule.TabIndex = 21;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 678);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtbBaslangıc);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRaporlar);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRaporlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.DateTimePicker dtbBaslangıc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnGoruntule;
    }
}