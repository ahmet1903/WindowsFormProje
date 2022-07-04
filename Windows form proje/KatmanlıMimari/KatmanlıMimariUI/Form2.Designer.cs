namespace KatmanlıMimariUI
{
    partial class Form2
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHepsiniGetir = new System.Windows.Forms.Button();
            this.dataGridSiparis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunId = new System.Windows.Forms.ComboBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(545, 44);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 30);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(452, 306);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(69, 31);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(439, 222);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(71, 31);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(238, 325);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(71, 31);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHepsiniGetir
            // 
            this.btnHepsiniGetir.Location = new System.Drawing.Point(33, 325);
            this.btnHepsiniGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnHepsiniGetir.Name = "btnHepsiniGetir";
            this.btnHepsiniGetir.Size = new System.Drawing.Size(71, 46);
            this.btnHepsiniGetir.TabIndex = 18;
            this.btnHepsiniGetir.Text = "Hepsini Getir";
            this.btnHepsiniGetir.UseVisualStyleBackColor = true;
            this.btnHepsiniGetir.Click += new System.EventHandler(this.btnHepsiniGetir_Click);
            // 
            // dataGridSiparis
            // 
            this.dataGridSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparis.Location = new System.Drawing.Point(32, 25);
            this.dataGridSiparis.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSiparis.Name = "dataGridSiparis";
            this.dataGridSiparis.RowTemplate.Height = 24;
            this.dataGridSiparis.Size = new System.Drawing.Size(391, 280);
            this.dataGridSiparis.TabIndex = 15;
            this.dataGridSiparis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSiparis_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürün ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Toplam Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri Adı";
            // 
            // cmbUrunId
            // 
            this.cmbUrunId.FormattingEnabled = true;
            this.cmbUrunId.Location = new System.Drawing.Point(439, 184);
            this.cmbUrunId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUrunId.Name = "cmbUrunId";
            this.cmbUrunId.Size = new System.Drawing.Size(76, 21);
            this.cmbUrunId.TabIndex = 10;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(439, 136);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(76, 20);
            this.txtToplamTutar.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(439, 92);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(76, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(439, 44);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(76, 20);
            this.txtMusteriAdi.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(753, 427);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnHepsiniGetir);
            this.Controls.Add(this.dataGridSiparis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunId);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMusteriAdi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHepsiniGetir;
        private System.Windows.Forms.DataGridView dataGridSiparis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunId;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMusteriAdi;
    }
}