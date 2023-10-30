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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStatu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYorum = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pctFoto.Location = new System.Drawing.Point(1045, 132);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(110, 70);
            this.pctFoto.TabIndex = 27;
            this.pctFoto.TabStop = false;
            this.pctFoto.Visible = false;
            // 
            // cmbBegenilenOyunlar
            // 
            this.cmbBegenilenOyunlar.FormattingEnabled = true;
            this.cmbBegenilenOyunlar.Location = new System.Drawing.Point(518, 91);
            this.cmbBegenilenOyunlar.Name = "cmbBegenilenOyunlar";
            this.cmbBegenilenOyunlar.Size = new System.Drawing.Size(121, 21);
            this.cmbBegenilenOyunlar.TabIndex = 26;
            this.cmbBegenilenOyunlar.SelectedIndexChanged += new System.EventHandler(this.cmbBegenilenOyunlar_SelectedIndexChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
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
            this.lblBegenilenOyun.Location = new System.Drawing.Point(459, 47);
            this.lblBegenilenOyun.Name = "lblBegenilenOyun";
            this.lblBegenilenOyun.Size = new System.Drawing.Size(258, 24);
            this.lblBegenilenOyun.TabIndex = 24;
            this.lblBegenilenOyun.Text = "En Çok Beğenilen Oyunlar";
            // 
            // lblOyunKategori
            // 
            this.lblOyunKategori.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOyunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunKategori.Location = new System.Drawing.Point(1051, 77);
            this.lblOyunKategori.Name = "lblOyunKategori";
            this.lblOyunKategori.Size = new System.Drawing.Size(84, 24);
            this.lblOyunKategori.TabIndex = 23;
            this.lblOyunKategori.Text = "Oyunlar";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(1035, 105);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 22;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.Location = new System.Drawing.Point(865, 8);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(39, 21);
            this.btnAra.TabIndex = 21;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(280, 9);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(584, 20);
            this.txtAra.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kullanıcı Ayarları",
            "Çıkış Yap"});
            this.comboBox1.Location = new System.Drawing.Point(1149, -1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1095, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 21);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(980, -2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(118, 22);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblStatu
            // 
            this.lblStatu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatu.Location = new System.Drawing.Point(1160, 629);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(138, 38);
            this.lblStatu.TabIndex = 32;
            this.lblStatu.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(28, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 141);
            this.label1.TabIndex = 33;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(28, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 141);
            this.label2.TabIndex = 33;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(28, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(649, 141);
            this.label3.TabIndex = 33;
            this.label3.Text = "label1";
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.Location = new System.Drawing.Point(95, 335);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(120, 33);
            this.btnYorumYap.TabIndex = 34;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtYorum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnYorumYap);
            this.groupBox1.Location = new System.Drawing.Point(960, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 391);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yorum Giriş";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1162, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 24);
            this.button2.TabIndex = 36;
            this.button2.Text = "Yorum Ekle:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "label4";
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(6, 223);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(326, 96);
            this.txtYorum.TabIndex = 37;
            this.txtYorum.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Yorum:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.WinUI.Properties.Resources.darth_vader_sith_star_wars_dark_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatu);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYorumYap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox txtYorum;
        private System.Windows.Forms.Label label5;
    }
}