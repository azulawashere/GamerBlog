namespace Project.WinUI
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOyunIsmi = new System.Windows.Forms.TextBox();
            this.btnOyunEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.cmbKullanicilar = new System.Windows.Forms.ComboBox();
            this.lstYorumlar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.txtKategoriEkle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.btnYorumSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 79);
            this.label2.TabIndex = 0;
            this.label2.Text = "Take(1) Admin Paneli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOyunIsmi
            // 
            this.txtOyunIsmi.Location = new System.Drawing.Point(113, 93);
            this.txtOyunIsmi.Name = "txtOyunIsmi";
            this.txtOyunIsmi.Size = new System.Drawing.Size(155, 22);
            this.txtOyunIsmi.TabIndex = 1;
            // 
            // btnOyunEkle
            // 
            this.btnOyunEkle.Location = new System.Drawing.Point(140, 121);
            this.btnOyunEkle.Name = "btnOyunEkle";
            this.btnOyunEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOyunEkle.TabIndex = 2;
            this.btnOyunEkle.Text = "Oyun Ekle";
            this.btnOyunEkle.UseVisualStyleBackColor = true;
            this.btnOyunEkle.Click += new System.EventHandler(this.btnOyunEkle_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üye İşlemleri:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(676, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yorum İşlemleri:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Location = new System.Drawing.Point(244, 448);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(131, 33);
            this.btnUyeSil.TabIndex = 4;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // cmbKullanicilar
            // 
            this.cmbKullanicilar.FormattingEnabled = true;
            this.cmbKullanicilar.Location = new System.Drawing.Point(855, 107);
            this.cmbKullanicilar.Name = "cmbKullanicilar";
            this.cmbKullanicilar.Size = new System.Drawing.Size(224, 24);
            this.cmbKullanicilar.TabIndex = 5;
            // 
            // lstYorumlar
            // 
            this.lstYorumlar.FormattingEnabled = true;
            this.lstYorumlar.ItemHeight = 16;
            this.lstYorumlar.Location = new System.Drawing.Point(694, 147);
            this.lstYorumlar.Name = "lstYorumlar";
            this.lstYorumlar.Size = new System.Drawing.Size(487, 260);
            this.lstYorumlar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori Ekle:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(167, 260);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(117, 28);
            this.btnKategoriEkle.TabIndex = 8;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.ItemHeight = 16;
            this.lstUyeler.Location = new System.Drawing.Point(140, 313);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(338, 116);
            this.lstUyeler.TabIndex = 9;
            // 
            // txtKategoriEkle
            // 
            this.txtKategoriEkle.Location = new System.Drawing.Point(147, 232);
            this.txtKategoriEkle.Name = "txtKategoriEkle";
            this.txtKategoriEkle.Size = new System.Drawing.Size(155, 22);
            this.txtKategoriEkle.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kategori Seç:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(147, 176);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cmbKategoriler.TabIndex = 13;
            // 
            // btnYorumSil
            // 
            this.btnYorumSil.Location = new System.Drawing.Point(884, 413);
            this.btnYorumSil.Name = "btnYorumSil";
            this.btnYorumSil.Size = new System.Drawing.Size(118, 41);
            this.btnYorumSil.TabIndex = 14;
            this.btnYorumSil.Text = "Yorum Sil";
            this.btnYorumSil.UseVisualStyleBackColor = true;
            this.btnYorumSil.Click += new System.EventHandler(this.btnYorumSil_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 536);
            this.Controls.Add(this.btnYorumSil);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.lstYorumlar);
            this.Controls.Add(this.cmbKullanicilar);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.btnOyunEkle);
            this.Controls.Add(this.txtKategoriEkle);
            this.Controls.Add(this.txtOyunIsmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOyunIsmi;
        private System.Windows.Forms.Button btnOyunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.ComboBox cmbKullanicilar;
        private System.Windows.Forms.ListBox lstYorumlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.TextBox txtKategoriEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Button btnYorumSil;
    }
}