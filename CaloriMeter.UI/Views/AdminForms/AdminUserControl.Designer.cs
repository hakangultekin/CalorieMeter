namespace CaloriMeter.UI.Views.AdminForms
{
    partial class AdminUserControl
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(45, 132);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 62;
            this.dgvListe.RowTemplate.Height = 28;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(912, 565);
            this.dgvListe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(186, 58);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(543, 29);
            this.txtAra.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(761, 49);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(200, 52);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Bul";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(503, 730);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(226, 54);
            this.btnGoruntule.TabIndex = 3;
            this.btnGoruntule.Text = "Tümünü Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(762, 730);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(201, 54);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 835);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListe);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnGuncelle;
    }
}