using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
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
    public partial class MainPage : Form
    {
        AppUser User;
        AppUsersRepository _appUsersRepository;
        CommentRepository _commentRepository;

        public MainPage(AppUser user)
        {
           _appUsersRepository = new AppUsersRepository();
            _commentRepository = new CommentRepository();
            InitializeComponent();
            User = user;
            lblUserName.Text = User.UserName;
            lblStatu.Text = StatuYazdır();
           
        }
        string[] veriler = { "Battlefront3", "csgo", "Fifa24" };
        string[] begenilenOyun = { "Battlefront3", "Fifa24" };
        
        public string StatuYazdır()
        {
            return $"Kullanıcı Sayısı:{_appUsersRepository.GetActives().Count} \n Yorum Sayısı:{_commentRepository.GetActives().Count} \n {DateTime.Now}";
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.AddRange(veriler);
            cmbBegenilenOyunlar.Items.AddRange(begenilenOyun);

        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctFoto.Visible = false;
            if (cmbKategori.SelectedItem as string == "Battlefront3")
            {
                if (cmbKategori.SelectedItem == veriler)
                {
                    pctFoto.Visible = false;
                }
                else
                {
                    pctFoto.Visible = true;
                }
            }

        }

        private void cmbBegenilenOyunlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBegenilenOyunlar.SelectedItem as string == "Battlefront3")
            {
                this.BackgroundImage = Properties.Resources._90cd46ae29323a1f31d55900c3a2436d;


            }
            else if (cmbBegenilenOyunlar.SelectedItem as string == "Fifa24")
            {
                this.BackgroundImage = Properties.Resources.ronaldo_nazario_real_madrid_uowrhe3shq301vp41b5ha5ct4;

            }
            else
            {
                this.BackgroundImage = Properties.Resources.darth_vader_sith_star_wars_dark_wallpaper_preview;
            }
            pctFoto.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenIndex = comboBox1.SelectedIndex;
            if(secilenIndex>-1)
            {
                if(secilenIndex == 0)
                {
                    KullaniciProfili kp=new KullaniciProfili(User);
                    kp.Show();
                    this.Hide();
                }
                else if(secilenIndex == 1)
                {
                    Form1 form1 = new Form1();
                    Hide();
                    form1.ShowDialog();
                }
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex > -1)
            {
                groupBox1.Visible = true;
            }
            else MessageBox.Show("Yorum yapmak için Oyun seçiniz");

        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            if (txtYorum.Text!=null&& txtTitle.Text!=null&&cmbKategori.SelectedIndex>-1)
            {
                Comment comment = new Comment
                {
                    Title = txtTitle.Text,
                    Description = txtYorum.Text,
                   
                };
                _commentRepository.Add(comment);
            }
           
        }

     
    }
}
