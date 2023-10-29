using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void lblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kyt = new KayitOl();
            kyt.Show();
            this.Hide();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            AppUsersRepository app= new AppUsersRepository();
            AppUser user= app.FirstOrDefault(x => x.UserName==txtKullaniciAdi.Text && x.Password==txtSifre.Text);
            if(user != null )
            {
                MessageBox.Show("Giriş Başarili");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgileri kontrol ediniz.");
            }

        }
    }
}
