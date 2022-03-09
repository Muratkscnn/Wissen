using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Kisi
        {
            string ad; //bu bir field.
            string soyad;
            string yas;

            public string Ad
            {
                get
                {
                    return ad;
                }
                set
                {
                    ad = value;
                }
            }
            public string Soyad
            {
                get
                {
                    return soyad;
                }
                set
                {
                    soyad = value;
                }
            }
        }
        class Personel
        {
            string adSoyad;
            int yas;

            public string AdSoyad { get; set; }
            public int Yas { get; set; }
        }
        class Araba
        {
            public string Marka { get; set; }
            public int ModelYili { get; set; }
        }
        class Ogrenci
        {
            public string AdSoyad { get; set; }
            public short Yas { get; set; }
            public string Bolum { get; set; }
            public string Sehir { get; set; }
            public double Ortalama { get; set; }

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi ogrenci1 = new Kisi();
            ogrenci1.Ad = "Osman";
            ogrenci1.Soyad = "Can";
            MessageBox.Show(ogrenci1.Ad + " " + ogrenci1.Soyad);


            Personel personel1 = new Personel();
            personel1.AdSoyad = "Kemalettin Neettin";
            personel1.Yas = 66;
            MessageBox.Show(personel1.AdSoyad + ", " + personel1.Yas + " yaşındasınız..");


            Araba otomobil = new Araba();
            otomobil.Marka = "Opel";
            otomobil.ModelYili = 1997;
            MessageBox.Show(otomobil.Marka + " "+ otomobil.ModelYili);

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.AdSoyad = "Muhterem Sevindik";
            ogrenci.Bolum = "Değerli Taşlar";
            ogrenci.Sehir = "Madagaskar";
            ogrenci.Yas = 23;
            ogrenci.Ortalama = 76;
            EkranaYaz(ogrenci);
            BuyukHarfeCevir(ogrenci);
        }
        void EkranaYaz(Ogrenci ogrencix)
        {
            MessageBox.Show(ogrencix.AdSoyad);
        }
        void BuyukHarfeCevir(Ogrenci o)
        {
            o.AdSoyad = o.AdSoyad.ToUpper();
            MessageBox.Show(o.AdSoyad);
        }
    }
    
}
