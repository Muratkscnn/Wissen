using System;

namespace Proje_10_Metotlar
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Yaz()
            {
                Console.WriteLine("Merhaba Wissen");
            }
            void topla()
            {
                int a = 8;
                int b = 10;
                Console.WriteLine(a + b);
            }
            void topla2(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + sayi2);
            }
            void yaz2(string Ad)
            {
                Console.WriteLine($"Merhaba {Ad}");
            }
            void topla3() 
            {
                Console.Write("1. sayı giriniz:\t");
                int x = int.Parse(Console.ReadLine());
                Console.Write("2. sayı giriniz:\t");
                int y = int.Parse(Console.ReadLine());
                Console.Write($"TOPLAM:\t {x+y}");
            }
            void IslemYap(string secim)
            {
                int sonuc = 0;
                if (secim == "*" || secim == "-" || secim == "*" || secim == "/")
                {


                    Console.Write("1. sayı giriniz:\t");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("2. sayı giriniz:\t");
                    int y = int.Parse(Console.ReadLine());

                    if (secim == "+")
                    {
                        sonuc = x + y;
                    }
                    else if (secim == "-")
                    {
                        sonuc = x - y;
                    }
                    else if (secim == "*")
                    {
                        sonuc = x * y;
                    }
                    else if (secim == "/")
                    {
                        sonuc = x / y;
                    }
                    Console.WriteLine($"Sonuç : {sonuc}");
                }
                else
                {
                    Console.WriteLine("Lütfen doğru bir işlem gir");
                }
            }
                /*Yaz();
                topla();
                topla2(2, 5);
                yaz2("murat"); 
                topla3; 
                IslemYap("*"); */



                Console.ReadLine();
            }
        }

    }

