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
            this.txtOyunEkle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOyunEkle = new System.Windows.Forms.Button();
            this.cmbUyeler = new System.Windows.Forms.ComboBox();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAKE-BİR GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun Ekle : ";
            // 
            // txtOyunEkle
            // 
            this.txtOyunEkle.Location = new System.Drawing.Point(120, 84);
            this.txtOyunEkle.Name = "txtOyunEkle";
            this.txtOyunEkle.Size = new System.Drawing.Size(185, 22);
            this.txtOyunEkle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Üye İşlemleri :";
            // 
            // btnOyunEkle
            // 
            this.btnOyunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunEkle.Location = new System.Drawing.Point(120, 112);
            this.btnOyunEkle.Name = "btnOyunEkle";
            this.btnOyunEkle.Size = new System.Drawing.Size(185, 23);
            this.btnOyunEkle.TabIndex = 9;
            this.btnOyunEkle.Text = "Ekle";
            this.btnOyunEkle.UseVisualStyleBackColor = true;
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.Location = new System.Drawing.Point(746, 86);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(185, 24);
            this.cmbUyeler.TabIndex = 10;
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeSil.Location = new System.Drawing.Point(746, 116);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(185, 23);
            this.btnUyeSil.TabIndex = 11;
            this.btnUyeSil.Text = "Üye Sil ";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Project.WinUI.Properties.Resources.takebir1;
            this.ClientSize = new System.Drawing.Size(952, 641);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.cmbUyeler);
            this.Controls.Add(this.btnOyunEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOyunEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOyunEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOyunEkle;
        private System.Windows.Forms.ComboBox cmbUyeler;
        private System.Windows.Forms.Button btnUyeSil;
    }
}