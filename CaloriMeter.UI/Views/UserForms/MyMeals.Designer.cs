namespace CaloriMeter.UI.Views.UserForms
{
    partial class MyMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMeals));
            this.lst_meals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dtp_bitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_ogunDetay = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_ogunAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_meals
            // 
            this.lst_meals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_meals.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lst_meals.FullRowSelect = true;
            this.lst_meals.HideSelection = false;
            this.lst_meals.Location = new System.Drawing.Point(24, 160);
            this.lst_meals.MultiSelect = false;
            this.lst_meals.Name = "lst_meals";
            this.lst_meals.Size = new System.Drawing.Size(549, 207);
            this.lst_meals.TabIndex = 10;
            this.lst_meals.UseCompatibleStateImageBehavior = false;
            this.lst_meals.View = System.Windows.Forms.View.Details;
            this.lst_meals.SelectedIndexChanged += new System.EventHandler(this.lst_meals_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğün Türü";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toplam Kalori";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yemek Adedi";
            this.columnHeader4.Width = 150;
            // 
            // dtp_baslangic
            // 
            this.dtp_baslangic.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.dtp_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_baslangic.Location = new System.Drawing.Point(263, 129);
            this.dtp_baslangic.Name = "dtp_baslangic";
            this.dtp_baslangic.Size = new System.Drawing.Size(109, 25);
            this.dtp_baslangic.TabIndex = 11;
            // 
            // dtp_bitis
            // 
            this.dtp_bitis.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.dtp_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bitis.Location = new System.Drawing.Point(401, 129);
            this.dtp_bitis.Name = "dtp_bitis";
            this.dtp_bitis.Size = new System.Drawing.Size(109, 25);
            this.dtp_bitis.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(259, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label2.Location = new System.Drawing.Point(397, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bitiş";
            // 
            // lst_ogunDetay
            // 
            this.lst_ogunDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lst_ogunDetay.HideSelection = false;
            this.lst_ogunDetay.Location = new System.Drawing.Point(24, 404);
            this.lst_ogunDetay.Name = "lst_ogunDetay";
            this.lst_ogunDetay.Size = new System.Drawing.Size(549, 227);
            this.lst_ogunDetay.TabIndex = 14;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(20, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Öğün Detayları";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::CaloriMeter.UI.Properties.Resources.delete_red32x32;
            this.btn_delete.Location = new System.Drawing.Point(579, 239);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(55, 42);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btn_ekle.Image = global::CaloriMeter.UI.Properties.Resources.addicon32x32;
            this.btn_ekle.Location = new System.Drawing.Point(24, 112);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(126, 42);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Öğün Ekle";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = global::CaloriMeter.UI.Properties.Resources.edit32x32;
            this.btn_edit.Location = new System.Drawing.Point(579, 189);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(55, 42);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_ogunAra
            // 
            this.btn_ogunAra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ogunAra.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ogunAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogunAra.Image = global::CaloriMeter.UI.Properties.Resources.search32x32;
            this.btn_ogunAra.Location = new System.Drawing.Point(518, 112);
            this.btn_ogunAra.Name = "btn_ogunAra";
            this.btn_ogunAra.Size = new System.Drawing.Size(55, 42);
            this.btn_ogunAra.TabIndex = 12;
            this.btn_ogunAra.UseVisualStyleBackColor = false;
            this.btn_ogunAra.Click += new System.EventHandler(this.btn_ogunAra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 89);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Anasayfaya Dön";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaloriMeter.UI.Properties.Resources.caloriemeterlogowhite;
            this.pictureBox1.Location = new System.Drawing.Point(479, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MyMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_ogunDetay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_ogunAra);
            this.Controls.Add(this.dtp_bitis);
            this.Controls.Add(this.dtp_baslangic);
            this.Controls.Add(this.lst_meals);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(662, 697);
            this.Name = "MyMeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyMeals";
            this.Load += new System.EventHandler(this.MyMeals_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lst_meals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker dtp_baslangic;
        private System.Windows.Forms.DateTimePicker dtp_bitis;
        private System.Windows.Forms.Button btn_ogunAra;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lst_ogunDetay;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}