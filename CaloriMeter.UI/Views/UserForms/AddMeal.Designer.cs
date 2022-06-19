namespace CaloriMeter.UI.Views.UserForms
{
    partial class AddMeal
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
            this.cb_mealTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_ogunDetay = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_yemekAdi = new System.Windows.Forms.TextBox();
            this.txt_kalori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_birim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_yemekAra = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.nud_gram = new System.Windows.Forms.NumericUpDown();
            this.btn_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gram)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_mealTypes
            // 
            this.cb_mealTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mealTypes.FormattingEnabled = true;
            this.cb_mealTypes.Location = new System.Drawing.Point(16, 32);
            this.cb_mealTypes.Name = "cb_mealTypes";
            this.cb_mealTypes.Size = new System.Drawing.Size(121, 27);
            this.cb_mealTypes.TabIndex = 0;
            this.cb_mealTypes.SelectedIndexChanged += new System.EventHandler(this.cb_mealTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğün Türü Seçin";
            // 
            // lst_ogunDetay
            // 
            this.lst_ogunDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lst_ogunDetay.FullRowSelect = true;
            this.lst_ogunDetay.HideSelection = false;
            this.lst_ogunDetay.Location = new System.Drawing.Point(12, 130);
            this.lst_ogunDetay.MultiSelect = false;
            this.lst_ogunDetay.Name = "lst_ogunDetay";
            this.lst_ogunDetay.Size = new System.Drawing.Size(641, 275);
            this.lst_ogunDetay.TabIndex = 15;
            this.lst_ogunDetay.UseCompatibleStateImageBehavior = false;
            this.lst_ogunDetay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Öğün Türü";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yemek Adı";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Miktar";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kalori";
            this.columnHeader8.Width = 120;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_ekle.Image = global::CaloriMeter.UI.Properties.Resources.addicon32x32;
            this.btn_ekle.Location = new System.Drawing.Point(573, 83);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(80, 41);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_yemekAdi
            // 
            this.txt_yemekAdi.Location = new System.Drawing.Point(57, 99);
            this.txt_yemekAdi.Name = "txt_yemekAdi";
            this.txt_yemekAdi.ReadOnly = true;
            this.txt_yemekAdi.Size = new System.Drawing.Size(196, 25);
            this.txt_yemekAdi.TabIndex = 17;
            // 
            // txt_kalori
            // 
            this.txt_kalori.Location = new System.Drawing.Point(491, 99);
            this.txt_kalori.Name = "txt_kalori";
            this.txt_kalori.ReadOnly = true;
            this.txt_kalori.Size = new System.Drawing.Size(69, 25);
            this.txt_kalori.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yemek Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(487, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(393, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gram";
            // 
            // cb_birim
            // 
            this.cb_birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_birim.FormattingEnabled = true;
            this.cb_birim.Items.AddRange(new object[] {
            "100 Gr",
            "Porsiyon / Adet"});
            this.cb_birim.Location = new System.Drawing.Point(259, 97);
            this.cb_birim.Name = "cb_birim";
            this.cb_birim.Size = new System.Drawing.Size(121, 27);
            this.cb_birim.TabIndex = 18;
            this.cb_birim.SelectedIndexChanged += new System.EventHandler(this.cb_birim_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(255, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birim";
            // 
            // btn_yemekAra
            // 
            this.btn_yemekAra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_yemekAra.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_yemekAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yemekAra.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btn_yemekAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_yemekAra.Image = global::CaloriMeter.UI.Properties.Resources.search32x32;
            this.btn_yemekAra.Location = new System.Drawing.Point(12, 81);
            this.btn_yemekAra.Name = "btn_yemekAra";
            this.btn_yemekAra.Size = new System.Drawing.Size(43, 43);
            this.btn_yemekAra.TabIndex = 16;
            this.btn_yemekAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yemekAra.UseVisualStyleBackColor = false;
            this.btn_yemekAra.Click += new System.EventHandler(this.btn_yemekAra_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::CaloriMeter.UI.Properties.Resources.delete_red32x32;
            this.btn_delete.Location = new System.Drawing.Point(659, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(55, 42);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // nud_gram
            // 
            this.nud_gram.Location = new System.Drawing.Point(397, 99);
            this.nud_gram.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_gram.Name = "nud_gram";
            this.nud_gram.Size = new System.Drawing.Size(68, 25);
            this.nud_gram.TabIndex = 21;
            this.nud_gram.ValueChanged += new System.EventHandler(this.nud_gram_ValueChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btn_kaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_kaydet.Image = global::CaloriMeter.UI.Properties.Resources.kayit32x32;
            this.btn_kaydet.Location = new System.Drawing.Point(537, 411);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 41);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(723, 510);
            this.Controls.Add(this.nud_gram);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_birim);
            this.Controls.Add(this.txt_kalori);
            this.Controls.Add(this.txt_yemekAdi);
            this.Controls.Add(this.btn_yemekAra);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lst_ogunDetay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_mealTypes);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğün Girişi";
            this.Load += new System.EventHandler(this.AddMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_gram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_mealTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_ogunDetay;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_yemekAdi;
        private System.Windows.Forms.TextBox txt_kalori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_birim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_yemekAra;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown nud_gram;
        private System.Windows.Forms.Button btn_kaydet;
    }
}