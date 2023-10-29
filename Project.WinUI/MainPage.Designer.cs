namespace Project.WinUI
{
    partial class MainPage
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
            this.cmbBegenilenOyun = new System.Windows.Forms.ComboBox();
            this.lblTercihEdilenOyun = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbBegenilenEdilenOyun = new System.Windows.Forms.ComboBox();
            this.cmbBegenilenOyunlar = new System.Windows.Forms.ComboBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBegenilenOyun
            // 
            this.cmbBegenilenOyun.FormattingEnabled = true;
            this.cmbBegenilenOyun.Location = new System.Drawing.Point(217, 381);
            this.cmbBegenilenOyun.Name = "cmbBegenilenOyun";
            this.cmbBegenilenOyun.Size = new System.Drawing.Size(121, 21);
            this.cmbBegenilenOyun.TabIndex = 15;
            // 
            // lblTercihEdilenOyun
            // 
            this.lblTercihEdilenOyun.AutoSize = true;
            this.lblTercihEdilenOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTercihEdilenOyun.Location = new System.Drawing.Point(165, 332);
            this.lblTercihEdilenOyun.Name = "lblTercihEdilenOyun";
            this.lblTercihEdilenOyun.Size = new System.Drawing.Size(258, 24);
            this.lblTercihEdilenOyun.TabIndex = 14;
            this.lblTercihEdilenOyun.Text = "En Çok Beğenilen Oyunlar";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(-84, 332);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(172, 24);
            this.lblKategori.TabIndex = 13;
            this.lblKategori.Text = "Oyun Kategorileri";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(-65, 381);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 12;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(190, 277);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(919, 30);
            this.txtAra.TabIndex = 11;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(-40, 214);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(299, 45);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "TakeBirGaming";
            // 
            // cmbBegenilenEdilenOyun
            // 
            this.cmbBegenilenEdilenOyun.FormattingEnabled = true;
            this.cmbBegenilenEdilenOyun.Location = new System.Drawing.Point(217, 348);
            this.cmbBegenilenEdilenOyun.Name = "cmbBegenilenEdilenOyun";
            this.cmbBegenilenEdilenOyun.Size = new System.Drawing.Size(121, 21);
            this.cmbBegenilenEdilenOyun.TabIndex = 16;
            // 
            // cmbBegenilenOyunlar
            // 
            this.cmbBegenilenOyunlar.FormattingEnabled = true;
            this.cmbBegenilenOyunlar.Location = new System.Drawing.Point(217, 348);
            this.cmbBegenilenOyunlar.Name = "cmbBegenilenOyunlar";
            this.cmbBegenilenOyunlar.Size = new System.Drawing.Size(121, 21);
            this.cmbBegenilenOyunlar.TabIndex = 17;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(1490, 217);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayitOl.TabIndex = 19;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            // 
            // btnKullanici
            // 
            this.btnKullanici.Location = new System.Drawing.Point(1402, 217);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(82, 23);
            this.btnKullanici.TabIndex = 18;
            this.btnKullanici.Text = "Kullanıcı Giriş";
            this.btnKullanici.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-7, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.Location = new System.Drawing.Point(1110, 277);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(56, 30);
            this.btnAra.TabIndex = 21;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 675);
            this.Controls.Add(this.cmbBegenilenOyun);
            this.Controls.Add(this.lblTercihEdilenOyun);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.cmbBegenilenEdilenOyun);
            this.Controls.Add(this.cmbBegenilenOyunlar);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBegenilenOyun;
        private System.Windows.Forms.Label lblTercihEdilenOyun;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cmbBegenilenEdilenOyun;
        private System.Windows.Forms.ComboBox cmbBegenilenOyunlar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
    }
}