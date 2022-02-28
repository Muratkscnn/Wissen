using System;

namespace Proje_11_metot_03
{
    class Program
    {
        static int EnBuyukBul(int[] sayilar)
        {
            int enbuyuk = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if ( sayilar [i] > enbuyuk)
                {
                    enbuyuk = sayilar[i];
                }
            }
            return enbuyuk;
        }
        static double daireAlanBul(double yarıcap, double pi=3.14)
        {
            double alan =  pi * yarıcap * yarıcap;
            return alan;

        }
        static void Main(string[] args)
        {

            /* int[] sayilar = { 15, 76, 85, 95,105};
             int buyukBul = EnBuyukBul(sayilar);
             Console.WriteLine(buyukBul); */
            Console.Write("Yarıçap Giriniz");
            double[] yaricap = { double.Parse(Console.ReadLine()) };
            
            daireAlanBul(yaricap[]);
            Console.ReadLine();
        }
    }
}
