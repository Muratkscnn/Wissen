using System;

namespace Proje_02
{
    class Program
    {
        static void Main(string[] args)
        {
            String adSoyad;
            adSoyad = "Eyüp Murat Kuşcan";
            Console.WriteLine(adSoyad);
            int yas = 24;
            Console.WriteLine(yas);
            int hour = DateTime.Now.Hour;
            int year = DateTime.Today.Year;
            Console.WriteLine(year + "  " + hour);
            Console.WriteLine("Merhaba " + adSoyad + " günün güzel geçsin.");
            Console.WriteLine($"Merhaba {adSoyad} günün güzel geçsin.");
            Console.ReadLine();
        }

    }
}
