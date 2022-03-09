using System;

namespace Proje_08_for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     int toplam = 0;
                 for (int i = 0 ; i < 11; i++)
                 {
                     if (i%2==0)
                     {
                         toplam += i;
                         Console.WriteLine(i);
                     }
                  } 
                 Console.WriteLine(toplam); */

            //1 ile 100 arasındaki asal sayıları bulup yazdırım.

            /* bool asal = true;
             for (int i = 2; i <= 100; i++)
             {

                 for (int x = 2; x < i; x++)
                 {
                     if (i % x == 0)
                     {
                         asal = false;
                         break;
                     }
                 }
                 if (asal)
                 {
                     Console.WriteLine(i);
                 }
                 asal = true;
             }
             */
            //1 ile 100 arasında 5 ve 7 ye bölunenler ve bölunmeyenler
            /* Console.WriteLine("5 ve 7'nin katları");
             for (int i = 1; i <= 100; i++)
             {
                 if (i%5==0 && i%7==0)
                 {
                     Console.WriteLine(i);
                 }

             } */
            //5x5 * matris


            //çarpım tablosu

            /* for (int x = 1; x < 11; x++)
             {
                for (int i = 1; i < 11; i++)
                 {
                     Console.Write($"{i * x}\t");

                 }
                 Console.WriteLine();
             } */

            //klavyedengirilecek 3 adet sayıdan en büyüğünü bulup ekrana yazdırın
            /*   Console.Write("1.sayıyı Giriniz:  ");
               int sayi1 = int.Parse(Console.ReadLine());
               Console.Write("2.sayıyı Giriniz:  ");
               int sayi2 = int.Parse(Console.ReadLine());
               Console.Write("3.sayıyı Giriniz:  ");
               int sayi3 = int.Parse(Console.ReadLine());
               int sonuc = 0;
            //ilk yol
                   if (sayi1 > sayi2 && sayi1 > sayi3)
                   {
                      
                       sonuc = sayi1;
                        }
                   else if (sayi2 > sayi3 && sayi2 > sayi3)
                   {
                       
                       sonuc = sayi2;
                       }
                       else
                       {
                       sonuc = sayi3;
                       }
                   }
               Console.WriteLine(sonuc);

               */
            // 2.yol


            int sayi1;
            int sonuc = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"{i}.sayıyı Giriniz:  ");

                sayi1 = int.Parse(Console.ReadLine());
                if (sayi1 > sonuc)
                {
                    
                    sonuc = sayi1;
                }

                
            }
            Console.WriteLine($"{sonuc}");


            Console.ReadLine();
        }
    }
}
