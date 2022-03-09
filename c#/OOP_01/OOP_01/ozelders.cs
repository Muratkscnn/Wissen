using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Özel Ders Uygulaması
         * 3 üyelik paketi olacak
         * standart üyelik
         * pro üyelik
         * elit üyelik
         * standart olarak her üyede olması gereken özellikler
         * -üye adı soyadı
         * -kullanıcı adı
         * -branşı(matematik,fizik,kimya,türkçe)
         * -yaşı
         * -deneyim süresi
         * -herkese açık olmayacak sekilde telefon numarası
         * pro üyelik
         * -onaylı üye rozeti
         * -Anasayfada Görüntülenme
         * -herkese açık telefon numarası
         * -ders almak isteyenlere direk erişmek(metot)
         * elite 
         * -arama sonuclarında üstte yer alma(metot)
         * -önerilme(Metot)
         * 
         */

namespace OOP_01
{
    class ozelders
    {
        public class StandartUyelik
        {
            public enum BransSecenekleri
            {
                Matematik,Fizik,Kimya,Turkce
            }
            public string AdSoyad { get; set; }
            public string KullanıcıAdı { get; set; }
            public BransSecenekleri Brans { get; set; }
            public short Yas { get; set; }
            public short DeneyimSuresi { get; set; }
            private string ceptelefon;

            public string CepTelefon
            {
               
                set { ceptelefon = value; }
            }




        }
        class ProUyelik : StandartUyelik
        {
            
            public bool AnasayfaGorunurluk { get; set; }
            public bool OnaylıUye { get; set; }
            public new string CepTelefon { get; set; }

            public void FulErisim()
            {

            }

        }
        class ElitUyelik : ProUyelik
        {
            public void EnUstteYerAlma()
            {

            }
            public void Onerilme()
            {

            }
           
        }
    }
}
