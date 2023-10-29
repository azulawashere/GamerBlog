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
    public partial class KayitOl : Form
    {
     
        public KayitOl()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text) MessageBox.Show("Şifreler uyuşmuyor","TAKE(1)GameBlog");
            AppUserProfile ap = new AppUserProfile();
            ap.FirstName = txtIsim.Text;
            ap.LastName = txtSoyisim.Text;
            ap.BirthDate = dtpDogumTarihi.Value;
            ap.Email = txtEmail.Text;
            ap.AppUser.Password = txtSifre.Text;
            ap.AppUser.UserName = txtKullaniciAdi.Text;



        }
    }
}
