using System;

namespace Proje_09_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int[] firstArray = { 40, 50, 80 };
              for (int i = 0; i < firstArray.Length; i++)
              {
                  Console.WriteLine(firstArray[i]);
              } */
            /* Random rnd = new Random(); //randomsayı üretme
             int[] sayilar= new int [10];
             for (int i = 0; i < 10; i++)
             {
                 sayilar[i]= rnd.Next(1,100);
             }
              for (int i = 0; i < sayilar.Length; i++)
              {
                  Console.WriteLine(sayilar[i]*2);
              } */
            /*  foreach (var sayi in sayilar)
              {
                  Console.WriteLine(sayi);
              }
            */
            //programımız 1-100 arasında rastgele sayı üretsin kullanıcıdan bu sayıyı tahmin etmesini isteyeliö
            /* Random rnd = new Random();
             int sayi = rnd.Next(1, 100);
             int tahmin=0;

             for (int i = 0; i < 5; i++)
             {
                 Console.Write($"({sayi})sayı giriniz:  ");
                 tahmin = int.Parse(Console.ReadLine());
                 if (sayi == tahmin)
                 {
                     Console.WriteLine("KAZANDINIZ");
                     break;
                 }
                 }
             if (sayi!=tahmin)
             {
                 Console.WriteLine("kaybettiniz");

             } */ //for

            //while

            /*   Random rnd = new Random();
               int sayi = rnd.Next(1, 100);
               int tahmin = 0;
               int can = 1;
               do
               {
                   Console.Write($"({sayi})sayı giriniz:  ");
                   tahmin = int.Parse(Console.ReadLine());
                   if (sayi != tahmin)
                   {
                       Console.WriteLine("YANLIŞ TAHMİN");

                   }
                   can++;
               } while (can <= 5 && sayi != tahmin);

               if (sayi != tahmin)
               {
                   Console.WriteLine("Hakkınız Bitti");

               }
               else
               {
                   Console.WriteLine("KAZANDINIZ");
               } */
            //1.tahmin 50/2-40/3-30/4-20/5-10/

            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            int tahmin = 0;
            int can = 1;
            int puan = 60;
            do
            {
                Console.Write($"({sayi})sayı giriniz:  ");
                tahmin = int.Parse(Console.ReadLine());
                if (sayi != tahmin)
                {
                    Console.WriteLine("YANLIŞ TAHMİN");

                }
                can++;
                puan = puan - 10;
            } while (can <= 5 && sayi != tahmin);

            if (sayi != tahmin)
            {
                Console.WriteLine("Hakkınız Bitti");

            }
            else
            {
                Console.WriteLine($"KAZANDINIZ {puan} Puan aldınız");
            }




            Console.ReadLine();
        }



    }
}
        
        
    
