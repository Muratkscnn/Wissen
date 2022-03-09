using System;

namespace Proje_04_Referance_Types
{
    class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

        }
        static void Main(string[] args)
        {
            Kisi person1 = new Kisi();
            Kisi person2 = new Kisi();
            person2.Ad = "Necati";
            person2.Yas = 30;
            person1.Ad = "Murat";
            person1.Yas = 24;
            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} Yaşındasın..");
            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} Yaşındasın..");
            person2 = person1;
            Console.WriteLine($"{person1.Ad}, sen {person1.Yas} Yaşındasın..");
            Console.WriteLine($"{person2.Ad}, sen {person2.Yas} Yaşındasın..");
            Console.ReadLine();

        }
    }
}
