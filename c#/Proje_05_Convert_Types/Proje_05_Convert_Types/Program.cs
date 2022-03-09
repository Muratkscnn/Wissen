using System;

namespace Proje_05_Convert_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Adınızı Giriniz: ");
            string Ad = Console.ReadLine();
            Console.WriteLine($"Merhaba {Ad}, hoşgeldin");
           
            */
            /*Console.Write("Lütfen 1. sayıyı giriniz: ");
            int sayi1 =Convert.ToInt32( Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            int sayi2 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Toplam: {sayi1+sayi2}");
            */
            /*
            byte b = 15;
            short s = b;

            short s1 = 258;
            byte b1 = (byte)s1;
            Console.WriteLine($"s1-short: {s1} =====> b1-byte; {b1}");
            */

            Console.Write("1.kenarın uzunluğunu giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.Write("2.kenarın uzunlupunu giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Girdiğiniz değerlere göre ALAN:{kenar1*kenar2}");


            Console.ReadLine();
        }
    }
}
