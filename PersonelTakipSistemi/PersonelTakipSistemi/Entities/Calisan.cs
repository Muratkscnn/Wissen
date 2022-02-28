using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipSistemi.Entities
{
    class Calisan
    {
        //Bu class bizim Entities katmanımızdadır.
        //Entitilerimizden tblCalisanlar'a ait bir entitie için hazırlandı.

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string PersonelNO { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Departman { get; set; }
        public string Unvan { get; set; }
        public string Durumu { get; set; }
    }
}
