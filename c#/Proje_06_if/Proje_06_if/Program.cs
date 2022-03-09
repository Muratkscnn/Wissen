using System;

namespace Proje_06_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>50)
            {
                Console.WriteLine("sayı 50'den Büyüktür.");
            }
            else if (sayi<50)
            {
                Console.WriteLine("sayı 50'den Küçüktür.");

            }
            else
            {
                Console.WriteLine("Eşittir");
            }
            Console.ReadLine();
        }
    }
}
