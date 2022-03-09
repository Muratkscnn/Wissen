using System;

namespace Proje_10_metot_02
{

    class Program
    {
        static int Topla(int number1, int number2)
        {
            int sonuc = number1 + number2;
            return sonuc;

        }
        static int Topla(int number1, int number2, int number3)
        {
            int sonuc = number1 + number2 + number3;
            return sonuc;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(Topla(50,112));
            Console.WriteLine(Topla(50,100,52));
            Console.ReadLine();

        }
    }
}
