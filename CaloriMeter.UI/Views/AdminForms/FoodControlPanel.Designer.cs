namespace CaloriMeter.UI.Views.AdminForms
{
    partial class FoodControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodControlPanel));
            this.nud_portionSize = new System.Windows.Forms.NumericUpDown();
            this.nud_calPer100 = new System.Windows.Forms.NumericUpDown();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_kategoriler = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_sec = new System.Windows.Forms.Button();
            this.ch_listede = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_portionSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_calPer100)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_portionSize
            // 
            this.nud_portionSize.Location = new System.Drawing.Point(269, 127);
            this.nud_portionSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_portionSize.Name = "nud_portionSize";
            this.nud_portionSize.Size = new System.Drawing.Size(104, 25);
            this.nud_portionSize.TabIndex = 55;
            // 
            // nud_calPer100
            // 
            this.nud_calPer100.Location = new System.Drawing.Point(43, 127);
            this.nud_calPer100.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_calPer100.Name = "nud_calPer100";
            this.nud_calPer100.Size = new System.Drawing.Size(123, 25);
            this.nud_calPer100.TabIndex = 56;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(43, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 25);
            this.txt_name.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Porsiyon gr/ml";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "100 gr/ml Kalorisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Kategori Seçin :";
            // 
            // cb_kategoriler
            // 
            this.cb_kategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kategoriler.FormattingEnabled = true;
            this.cb_kategoriler.Location = new System.Drawing.Point(42, 230);
            this.cb_kategoriler.Margin = new System.Windows.Forms.Padding(4);
            this.cb_kategoriler.Name = "cb_kategoriler";
            this.cb_kategoriler.Size = new System.Drawing.Size(330, 27);
            this.cb_kategoriler.TabIndex = 57;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_ekle.FlatAppearance.BorderSize = 2;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(42, 280);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(94, 31);
            this.btn_ekle.TabIndex = 59;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_guncelle.Enabled = false;
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_guncelle.FlatAppearance.BorderSize = 2;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(144, 280);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(94, 31);
            this.btn_guncelle.TabIndex = 59;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_sil.Enabled = false;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_sil.FlatAppearance.BorderSize = 2;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(246, 280);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(126, 31);
            this.btn_sil.TabIndex = 59;
            this.btn_sil.Text = "Listeden Kaldır";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_sec
            // 
            this.btn_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btn_sec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.btn_sec.FlatAppearance.BorderSize = 2;
            this.btn_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sec.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sec.ForeColor = System.Drawing.Color.White;
            this.btn_sec.Location = new System.Drawing.Point(311, 59);
            this.btn_sec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(62, 31);
            this.btn_sec.TabIndex = 59;
            this.btn_sec.Text = "Seç";
            this.btn_sec.UseVisualStyleBackColor = false;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // ch_listede
            // 
            this.ch_listede.AutoSize = true;
            this.ch_listede.Location = new System.Drawing.Point(42, 167);
            this.ch_listede.Name = "ch_listede";
            this.ch_listede.Size = new System.Drawing.Size(124, 24);
            this.ch_listede.TabIndex = 60;
            this.ch_listede.Text = "Yemek Listede";
            this.ch_listede.UseVisualStyleBackColor = true;
            // 
            // FoodControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaloriMeter.UI.Properties.Resources.bggray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 349);
            this.Controls.Add(this.ch_listede);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_kategoriler);
            this.Controls.Add(this.nud_portionSize);
            this.Controls.Add(this.nud_calPer100);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(426, 388);
            this.Name = "FoodControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Düzenleme Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.nud_portionSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_calPer100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nud_portionSize;
        private System.Windows.Forms.NumericUpDown nud_calPer100;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_kategoriler;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.CheckBox ch_listede;
    }
}