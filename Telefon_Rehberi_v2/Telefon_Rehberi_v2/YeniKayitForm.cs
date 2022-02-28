using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_v2
{
    public partial class YeniKayitForm : Form
    {
        string sorguCumlesi;
        string baglantiCumlesi = @"server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sRehber;user=sa;pwd=123";
        SqlConnection baglanti;
        SqlCommand komut;
        public YeniKayitForm()
        {
            InitializeComponent();
        }
        void Kaydet()
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string tel = txtTelefon.Text;
            char Cinsiyet = cmbCinsiyet.Text == "Erkek" ? 'E' : 'K';
            
           
            sorguCumlesi=$"INSERT INTO tblKisiler VALUES ('{Ad}','{Soyad}','{Cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizle();

        }

        void temizle()
        {
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbCinsiyet.ResetText();
            txtTelefon.ResetText();
        }

        

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void YeniKayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}
