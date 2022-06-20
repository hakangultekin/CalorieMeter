namespace CaloriMeter.UI.Views.UserForms
{
    partial class AddFood
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
            this.cb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.nud_calPer100 = new System.Windows.Forms.NumericUpDown();
            this.nud_portionSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_calPer100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_portionSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_kategoriler
            // 
            this.cb_kategoriler.FormattingEnabled = true;
            this.cb_kategoriler.Location = new System.Drawing.Point(21, 116);
            this.cb_kategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_kategoriler.Name = "cb_kategoriler";
            this.cb_kategoriler.Size = new System.Drawing.Size(160, 27);
            this.cb_kategoriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Seçin :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(21, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(241, 25);
            this.txt_name.TabIndex = 2;
            // 
            // nud_calPer100
            // 
            this.nud_calPer100.Location = new System.Drawing.Point(288, 52);
            this.nud_calPer100.Name = "nud_calPer100";
            this.nud_calPer100.Size = new System.Drawing.Size(123, 25);
            this.nud_calPer100.TabIndex = 3;
            // 
            // nud_portionSize
            // 
            this.nud_portionSize.Location = new System.Drawing.Point(447, 52);
            this.nud_portionSize.Name = "nud_portionSize";
            this.nud_portionSize.Size = new System.Drawing.Size(104, 25);
            this.nud_portionSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "100 gr/ml Kalorisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Porsiyon gr/ml";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_save.Image = global::CaloriMeter.UI.Properties.Resources.task32x32;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(474, 105);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 38);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Ekle";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 192);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.nud_portionSize);
            this.Controls.Add(this.nud_calPer100);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_kategoriler);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Yemek Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.nud_calPer100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_portionSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_kategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown nud_calPer100;
        private System.Windows.Forms.NumericUpDown nud_portionSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
    }
}