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
        public MainPage()
        {
            InitializeComponent();
        }
        string[] veriler = { "Battlefront3", "csgo", "Fifa24" };
        string[] begenilenOyun = { "Battlefront3", "Fifa24" };
        

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
    }
}
