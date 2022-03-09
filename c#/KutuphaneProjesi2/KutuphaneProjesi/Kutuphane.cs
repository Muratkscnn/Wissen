using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class Kutuphane
    {
        
    }
    public class Tur
    {
        private int id;

        public int ID 
        {
            get { return id; }
        }
        private string turAd;

        public string TurAd
        {
            get { return turAd; }
            set { turAd = value.ToUpper(); }
        }

    }
    public class YayinEvi
    {
        private int id;
        public int ID 
        {
            get { return id; }
        }
        public string Adi { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
    }
    public class Kisi
    {
        private int id;

        public int ID
        {
            get { return id; }
        }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
    }
    public class Uye : Kisi
    {
        public enum UTip
        {
            Standart,
            Elit
        }
        public Uye()
        {
            CezaDurumu = false;
        }
        public enum EDTip
        {
            ilkokulMezun, OrtaokulMezun, LiseMezun, ÜniversiteMezun, Ogrenci
        }
        public DateTime UyelikTarihi { get; set; }
        public UTip UyelikTipi { get; set; }
        public string TcNo { get; set; }
        public string Meslek { get; set; }
        public EDTip EgitimDurumu { get; set; }
        public bool CezaDurumu { get; set; }

    }
    public class Yazar : Kisi
    {
        public int TurID { get; set; }
    }
    public class Kitap 
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public int SayfaSayisi { get; set; }
        public int Stok { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        public int YayinEviID { get; set; }
    }
    public class Odunc //tblOdunc
    {
        private int id;

        public int ID
        {
            get { return id; }
        }
        public int UyeID { get; set; }
        public string KitapISBN { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Iptal { get; set; }//silinenler False

    }
}
