using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_01_temelkontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void ekle()
        {
            lstKisiler.Items.Add(txtAdSoyad.Text.ToUpper().Trim());//toupper Büyük harf Trim baştaki ve sondaki boşlukları siler
            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                ekle();
            }
            string adSoyad = txtAdSoyad.Text;
            int uzunluk = adSoyad.Length;
            int konum = uzunluk - 1;
            if (uzunluk >= 1)
            {
                if (adSoyad[konum].ToString() == " " )
                {
                    e.Handled = e.KeyChar == (char)Keys.Space;
                }
            }
            else
            {
                e.Handled = e.KeyChar == (char)Keys.Space;
            }



        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kişi Sayısı: {lstKisiler.Items.Count}");
        }
        void ara()
        {
            string aranan = txtAranan.Text.ToUpper();
            if (lstKisiler.Items.Contains(aranan))
            {
                lblBulunan.Text = aranan;
            }
            else
            {
                lblBulunan.Text = "Aradığınız kayıt bulunamadı";
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            ara();
           
        }

        private void txtAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                ara();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
