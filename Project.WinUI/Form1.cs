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
        AppUsersRepository app = new AppUsersRepository();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void lblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kyt = new KayitOl(); // KayitOl paneline gitmek için bir nesne yaratıyoruz
            kyt.Show();
            Hide();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try // program çökmesin diye giriş yapma işlemlerini trycathe aldık
            {
                if (txtKullaniciAdi.Text != string.Empty && txtSifre.Text != string.Empty && txtKullaniciAdi.Text.Length>7) // giriş yapma textboxları null geçilmemesi için kontrol
                {
                    AppUsersRepository app = new AppUsersRepository(); // veritabanına erişen metotlara erişmek için.
                    AppUser user = app.FirstOrDefault(x => x.UserName == txtKullaniciAdi.Text.ToLower() && x.Password == txtSifre.Text); //kutulardaki verilere uyan bir kullanıcı var ise dbize kullanıcıyı döncek yok ise null döncek sorgu. şifre tolower değil güvenlik amaçlı

                    if (user != null) // eğer bide firsordefault metodundan null değer dönmezse alttaki kodlar çalışsın
                    {
                        MessageBox.Show("Giriş Başarili");
                        MainPage mp = new MainPage(); // blog paneline gitmek için bir nesne yaratıyoruz
                        mp.Show();
                        Hide();
                    }
                    else MessageBox.Show("Girdiğiniz Bilgileri kontrol ediniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
