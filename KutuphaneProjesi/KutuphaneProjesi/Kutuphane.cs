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
    public class Turler//tblturler tablosu için
    {
        private int id;

        public int ID //ID ALANI
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
    public class YayinEvleri //tblYayinevleri tablosu için
    {
        private int id;
        public int ID //ID ALANI
        {
            get { return id; }
        }
        public string Adi { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
    }
    public class Kisiler
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
    public class Uyeler : Kisiler
    {
        public enum UTip
        {
            Standart,
            Elit
        }
        public Uyeler()
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
    public class Yazarlar : Kisiler
    {
        public int TurID { get; set; }//yazarın ön plana çıktığı tür bilgisi
    }
    public class Kitaplar //tblKitaplar
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
        public int KitapISBN { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Iptal { get; set; }

    }
}
