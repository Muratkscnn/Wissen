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
    public partial class Randevu : Form
    {
        Veritabani vt = new Veritabani();
        string sorguCumlesi;
        string bolumID;
        public Randevu()
        {
            InitializeComponent();
        }
        void Kaydet()
        {
            string BolumIDx = cmbBolum.SelectedValue.ToString();
            string doktorID = lstDoktorlar.SelectedValue.ToString();
            string hastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string tarih = dtpTarih.Value.ToShortDateString();
            string saat = dtpSaat.Value.ToShortTimeString();
            sorguCumlesi = $"INSERT INTO tblRandevular VALUES('{BolumIDx}','{doktorID}','{hastaID}','{tarih}','{saat}')";
            vt.Islem(sorguCumlesi);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string BolumAd = cmbBolum.Text;
            string doktorAd = lstDoktorlar.Text;
            string hastaAdSoyad = dgvHastalar.CurrentRow.Cells[1].Value.ToString() + " " + dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            string tarih = dtpTarih.Value.ToShortDateString();
            FormOnay formOnay = new FormOnay(BolumAd, hastaAdSoyad, doktorAd, tarih);
            formOnay.Show();
            //Dipğer formdan gelecek onaya göre kayıt yapılacak.
            Kaydet();
        }
        void Doldur()
        {
            cmbBolum.DataSource = vt.KayitListele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";
            bolumID = cmbBolum.SelectedValue.ToString();

            sorguCumlesi = "SELECT ID,Ad,Soyad FROM tblHastalar";
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }
        void doktorDoldur()
        {
            bolumID = cmbBolum.SelectedValue.ToString();

            sorguCumlesi = $"SELECT * FROM tblDoktorlar WHERE BolumID='{bolumID}'";
            lstDoktorlar.DataSource = vt.KayitListele(sorguCumlesi);
            lstDoktorlar.DisplayMember = "AdSoyad";
            lstDoktorlar.ValueMember = "ID";
        }
        private void Randevu_Load(object sender, EventArgs e)
        {
            Doldur();
            doktorDoldur();
            
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                doktorDoldur();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Randevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }
    }
}
