using System;

namespace Proje_11_metot_examples1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int can = 5;
            int tahmin = 0;
            int puan = 0;
            int sayi =RastgeleSayi();
            bool tekrar;

            do
            {
               puan = 60;
               OyunaBasla();
               tekrar= TekrarOyna();
            } while (tekrar);
                
            
            Console.ReadLine();

            

            void OyunaBasla()
            {
                for (int i = 0; i < 5; i++)
                {
                    tahmin = TahminYap();
                    puan = puan - 10;
                    
                    if (sayi == tahmin)
                    {
                        Console.WriteLine($"KAZANDINIZ {puan} Puan aldınız");
                        break;
                    }
                    if (sayi != tahmin && can > 0)
                    {
                        Console.WriteLine("Yanlış Tahmin");
                    }
                    
                    
                }
                OyunSonuBilgisi();
            }





            int TahminYap()
            {
                Console.Write($"{sayi} Tahmininizi girin: ");
                int tahmin = int.Parse(Console.ReadLine());
                return tahmin;
            }
            int RastgeleSayi()
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                return sayi;
            }
           

            
            void OyunSonuBilgisi()
            {
                if (sayi != tahmin)
                {
                    Console.WriteLine("Hakkınız Bitti");

                }
                
            }
            
            bool TekrarOyna()
            {
                Console.Write("Tekrar Oynamak İçin [Y/N]:  ");
                string secim = Console.ReadLine();
                bool x;
                if (secim == "Y")
                {
                    x = true;
                    sayi = RastgeleSayi();
                    Console.Clear();
                }
                else
                {
                    x = false;
                    
                }
                return x;
            }
           
        }
    }
}
