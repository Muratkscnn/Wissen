using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_Sayı_tahmin
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int can = 5;
        public int RastgeleSayi()
        {
            Random rnd = new Random();
            int rndsayi = rnd.Next(1, 100);
            return rndsayi;
        }
        void aktifet()
        {
            txtTahmin.Enabled = true;
            btnSayıGir.Enabled = true;
        }
        void pasifet()
        {
            txtTahmin.Enabled = false;
            btnSayıGir.Enabled = false;
        }
        void kontrolet()
        {

            if (txtTahmin.Text != "")

            {
                int tahmin = int.Parse(txtTahmin.Text);

                if (tahmin == hedef)
            {
                lblSonuc.Text=($"oyunu kazandınız PUAN={can*10}");
                pasifet();
                btnBaslat.Visible = true;
            }
            else if(can>1)
            {
                can--;
                if (tahmin > hedef)
                {
                    lblCan.Text = can.ToString();
                   lblSonuc.Text = $"Sayınız: {txtTahmin.Text} Daha Küçük Sayı Gir";
                }
                else
                {
                    lblCan.Text = can.ToString();
                    lblSonuc.Text = $"Sayınız: {txtTahmin.Text} Daha Büyük Sayı Gir";
                }
            }
            else
            {
                lblSonuc.Text = "OYUNU KAYBETTİNİZ";
                btnBaslat.Text = "TEKRAR OYNA";
                lblCan.Text = "0";
                btnBaslat.Visible = true;
                pasifet();
            }

            }
            else
            {
                MessageBox.Show("SAYI GİR");
            }

        }
        public Form1()
        {
            
            InitializeComponent();
        }
        

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            can = 5;
            aktifet();
            lblSonuc.Text = "";
            lblCan.Text = can.ToString();
            btnSayıGir.Visible = true;
            lblCan.Visible = true;
            lblKalanCan.Visible = true;
            txtTahmin.Visible = true;
            lblTahmin.Visible = true;
            btnBaslat.Visible = false;
            hedef=RastgeleSayi();
            btnBaslat.Text = "TEKRAR OYNA";
            lblHile.Text = hedef.ToString();
            txtTahmin.Focus();
        }
        void tahmingir()
        {
            kontrolet();
            txtTahmin.Clear();
            txtTahmin.Focus();
        }
        private void btnSayıGir_Click(object sender, EventArgs e)
        {
            tahmingir();
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                tahmingir();
            }
        }

        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
