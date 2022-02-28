using System;

namespace if_soru_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bir öğrencinin not ortlaması 60 ve üzerindeyse öğrenci başarılı değilse başarısız kabul ediliyor 
             * öğrencenin ortalaması vize ve final notları üzerinden şu şekilde hesaplanıyor Vize %40'ı finalın %60.
             * vize ve fianl notları klavyeden girilen bir öğrencinin not ortalaması ve başarı durumunu yazan 
             * 2.soru
             * bir mağazadan alınan ürünlerin fiyatı 100 liradan fazla ve eşitse 5 lira olan kargo ücreti alınmamaktadır
             * ürünün fiyatı girildiğinde toplam maliyet yazacaktır.
             * */

            /*Console.Write("Vize notu giriniz: ");
            int vize =Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.Write("Devamsızlık bilgisi giriniz: ");
            int devam = Convert.ToInt32(Console.ReadLine());


            double not = (vize * 0.4) + (final * 0.6);
            if (not>=60 && devam < 10)
            {
                Console.WriteLine($"Not ortalamanız: {not} GEÇTİNİZ");
            }
            else if (not <60 && devam < 10 )
            {
                Console.WriteLine($"Not ortalamanız: {not} KALDINIZ");
            }
            else if (not>=60 && devam > 9 )
            {
                Console.WriteLine($"devamsızlıktan kaldınız");
            }

            else
            {
                Console.WriteLine($"devamsızlıktan ve nottan kaldınız..");
            }
            */
            /* Console.Write("ürün fiyatı giriniz: ");
             int fiyat = Convert.ToInt32(Console.ReadLine());

             if (fiyat<100)
             {
                 fiyat = fiyat+5;
             }

             Console.WriteLine($"Ürün toplam fiyatı:  {fiyat}");
            */
            /*Console.Write("1.ürün fiyatı giriniz: ");
            int fiyat1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.ürün fiyatı giriniz: ");
            int fiyat2 = Convert.ToInt32(Console.ReadLine());
            double toplam = fiyat1 + fiyat2;
            double sonfiyat;
            if (toplam>=200)
            {
                sonfiyat =toplam - fiyat2 * 0.3;
                Console.WriteLine($"indirimli tutar: {sonfiyat}");
            }
            else
            {
                Console.WriteLine(toplam);
            }
                     
                */
            Console.WriteLine("ilk ürünün fiyatını giriniz");
            int fiyat1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ikinci ürünün fiyatını giriniz");
            int fiyat2 = Convert.ToInt16(Console.ReadLine());
            double toplam = fiyat1 + fiyat2;
            if (toplam > 200)
            {
                toplam = fiyat1 + (fiyat2 * 0.65);
                if (toplam > 250 )
                {
                    
                    Console.WriteLine($"Toplam fiyat: {toplam} İndirim yapılmıştır kargo ücreti alınmamıştır..");
                }
                else
                {
                    toplam = toplam + 25;
                    Console.WriteLine($"Kargo dahil Toplam fiyat: {toplam} İndirim uygulanmıştır.");
                }
                else
                {
                    toplam = toplam + 25;
                    Console.WriteLine($"Kargo Dahil Toplam fiyat: {toplam}");
                }
            }




            Console.ReadLine();
        }
    }
}
