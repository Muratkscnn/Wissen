using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WitchClassSQL_02_CRUD
{
    public partial class YeniKayit : Form
    {
        string sorguCumlesi;
        Veritabani vt = new Veritabani();
        public YeniKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCumlesi = $"INSERT INTO tblHastalar VALUES ('{txtTc.Text}', '{txtAd.Text}', '{txtSoyad.Text}', '{cinsiyet}','{txtAdres.Text}','{txtTel.Text}','{txtMail.Text}')";

            if (!vt.kontrol2(txtTc.Text,txtAd.Text,txtSoyad.Text,cinsiyet))
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                
                vt.Islem(sorguCumlesi);
            }
            

        }

       

        private void YeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHastalar hasta = new FormHastalar();
            hasta.Show();
            
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
