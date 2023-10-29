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
    public partial class KayitOl : Form
    {
     
        public KayitOl()
        {
            InitializeComponent();
            
        }       
        private void btnUyeOL_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "TAKE(1)GameBlog");
                return;
            }                                
            AppUserProfile ap = new AppUserProfile();
            ap.FirstName = txtIsim.Text;
            ap.LastName = txtSoyisim.Text;
            ap.BirthDate = dtpDogumTarihi.Value;
            ap.Email = txtEmail.Text;

            AppUser au = new AppUser()
            {
                UserName = txtKullaniciAdi.Text,
                Password = txtSifre.Text,
                Profile = ap
            };
            try
            {
                AppUsersRepository aur = new AppUsersRepository();
                aur.Add(au);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Kayıt Başarılı");
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {        
            Form1 g = new Form1();
            g.Show();
            this.Hide();
        }
    }
}
