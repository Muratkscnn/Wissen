using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        Veritabani vt = new Veritabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimTarihi.Visible = false;
        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.TurAd = txtTurAdı.Text;
            string sorguCumlesi = $"INSERT INTO tblTurler VALUES (@turAd)";
            vt.Islem(sorguCumlesi,yeniTur.TurAd);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kitaplar yenikitap = new Kitaplar();
            yenikitap.Ad = txtKitapAd.Text;
            yenikitap.ISBN = txtISBN.Text;
            yenikitap.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            yenikitap.Stok = int.Parse(txtStok.Text);
            string[] Kitaps = {yenikitap.Ad, yenikitap.ISBN, yenikitap.SayfaSayisi.ToString(), yenikitap.Stok.ToString() };
            string[] parametre = {"@ad", "@isbn", "@sayfa", "@stok"};
            
            string sorguCumlesi = $"INSERT INTO tblKitaplar (Ad,ISBN, SayfaSayisi,Stok) VALUES (@ad,@isbn,@sayfa,@stok)";
            vt.KitapEkle(sorguCumlesi, Kitaps, parametre);
            
            
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            YayinEvleri yayinevi = new YayinEvleri();
            yayinevi.Adi = txtYayinEviAd.Text;
            yayinevi.Adres = txtYayineviAdres.Text;
            yayinevi.Tel = txtYayinEviTel.Text;
            string[] yevi = { yayinevi.Adi,yayinevi.Adres,yayinevi.Tel};
            string[] parametre = { "@ad", "@adres", "@tel",};
            string sorguCumlesi = $"INSERT INTO tblYayinevleri VALUES (@ad,@adres,@tel)";
            vt.yayinEviEkle(sorguCumlesi, yevi, parametre);


        }
    }
}
