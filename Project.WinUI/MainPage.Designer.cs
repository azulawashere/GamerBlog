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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.cmbBegenilenOyunlar = new System.Windows.Forms.ComboBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblBegenilenOyun = new System.Windows.Forms.Label();
            this.lblOyunKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
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
            // pctFoto
            // 
            this.pctFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctFoto.BackgroundImage")));
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctFoto.Location = new System.Drawing.Point(79, 237);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(190, 121);
            this.pctFoto.TabIndex = 27;
            this.pctFoto.TabStop = false;
            this.pctFoto.Visible = false;
            // 
            // cmbBegenilenOyunlar
            // 
            this.cmbBegenilenOyunlar.FormattingEnabled = true;
            this.cmbBegenilenOyunlar.Location = new System.Drawing.Point(326, 165);
            this.cmbBegenilenOyunlar.Name = "cmbBegenilenOyunlar";
            this.cmbBegenilenOyunlar.Size = new System.Drawing.Size(121, 21);
            this.cmbBegenilenOyunlar.TabIndex = 26;
            this.cmbBegenilenOyunlar.SelectedIndexChanged += new System.EventHandler(this.cmbBegenilenOyunlar_SelectedIndexChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(73, 19);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(243, 33);
            this.lblBaslik.TabIndex = 25;
            this.lblBaslik.Text = "TakeBirGaming";
            // 
            // lblBegenilenOyun
            // 
            this.lblBegenilenOyun.AutoSize = true;
            this.lblBegenilenOyun.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblBegenilenOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegenilenOyun.Location = new System.Drawing.Point(322, 121);
            this.lblBegenilenOyun.Name = "lblBegenilenOyun";
            this.lblBegenilenOyun.Size = new System.Drawing.Size(258, 24);
            this.lblBegenilenOyun.TabIndex = 24;
            this.lblBegenilenOyun.Text = "En Çok Beğenilen Oyunlar";
            // 
            // lblOyunKategori
            // 
            this.lblOyunKategori.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOyunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunKategori.Location = new System.Drawing.Point(87, 121);
            this.lblOyunKategori.Name = "lblOyunKategori";
            this.lblOyunKategori.Size = new System.Drawing.Size(182, 24);
            this.lblOyunKategori.TabIndex = 23;
            this.lblOyunKategori.Text = "Oyun Kategorileri";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(91, 165);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 22;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.Location = new System.Drawing.Point(941, 83);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(39, 21);
            this.btnAra.TabIndex = 21;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(79, 84);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(863, 20);
            this.txtAra.TabIndex = 20;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.WinUI.Properties.Resources.darth_vader_sith_star_wars_dark_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 675);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.cmbBegenilenOyunlar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblBegenilenOyun);
            this.Controls.Add(this.lblOyunKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnKullanici);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.ComboBox cmbBegenilenOyunlar;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblBegenilenOyun;
        private System.Windows.Forms.Label lblOyunKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
    }
}