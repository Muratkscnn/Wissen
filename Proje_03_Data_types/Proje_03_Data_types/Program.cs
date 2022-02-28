using System;

namespace Proje_03_Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Data Types";
            Console.WriteLine("------------- VERİ TİPLERİ -------------");
            Console.WriteLine("A) TAMSAYILAR(İNTEGRAL)");
            Console.WriteLine("a) İŞARETSİZ tamsayılar");
            Console.WriteLine("1) Byte:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer        => {byte.MinValue} ");
            Console.WriteLine($"Maxmimum Değer       => {byte.MaxValue} ");
            Console.WriteLine($"Bellekteki Boyut     => {sizeof(byte)} byte");
            //Console.ReadLine();
            Console.WriteLine("2) ushort:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer         => {ushort.MinValue} ");
            Console.WriteLine($"Maxmimum Değer        => {ushort.MaxValue:0,00} ");
            Console.WriteLine($"Boyut                 => {sizeof(ushort)} byte");
            //Console.ReadLine();
            Console.WriteLine("3) uint:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer         => {uint.MinValue} ");
            Console.WriteLine($"Maxmimum Değer        => {uint.MaxValue:0,00} ");
            Console.WriteLine($"Boyut                 => {sizeof(uint)} byte");
            //Console.ReadLine();
            Console.WriteLine("4) ulong:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer         => {ulong.MinValue} ");
            Console.WriteLine($"Maxmimum Değer        => {ulong.MaxValue:0,00} ");
            Console.WriteLine($"Boyut                 => {sizeof(ulong)} byte");
            //Console.ReadLine();
            Console.WriteLine("b) İŞARETLİ(signed) tamsayılar");
            Console.WriteLine("1)sbyte:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer        => {sbyte.MinValue:0,00} ");
            Console.WriteLine($"Maxmimum Değer       => {sbyte.MaxValue:0,00} ");
            Console.WriteLine($"Bellekteki Boyut     => {sizeof(byte)} byte");
            //Console.ReadLine();
            Console.WriteLine("2)short:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer        => {short.MinValue:0,00} ");
            Console.WriteLine($"Maxmimum Değer       => {short.MaxValue:0,00} ");
            Console.WriteLine($"Bellekteki Boyut     => {sizeof(short)} byte");
            //Console.ReadLine();
            Console.WriteLine("3)int:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer        => {int.MinValue:0,00} ");
            Console.WriteLine($"Maxmimum Değer       => {int.MaxValue:0,00} ");
            Console.WriteLine($"Bellekteki Boyut     => {sizeof(int)} byte");
            //Console.ReadLine();
            Console.WriteLine("4)long:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer        => {long.MinValue:0,00} ");
            Console.WriteLine($"Maxmimum Değer       => {long.MaxValue:0,00} ");
            Console.WriteLine($"Bellekteki Boyut     => {sizeof(long)} byte");
            //Console.ReadLine();
            Console.WriteLine("B) Ondalıklı(Decimal)");
            Console.WriteLine("1) float");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer       => {float.MinValue}");
            Console.WriteLine($"Maximum Değer       => {float.MaxValue}");
            Console.WriteLine($"Bellek Boyutu       => {sizeof(float)} byte");
            Console.WriteLine("2) double");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer       => {double.MinValue}");
            Console.WriteLine($"Maximum Değer       => {double.MaxValue}");
            Console.WriteLine($"Bellek Boyutu       => {sizeof(double)} byte");
            Console.WriteLine("3) decimal");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer       => {decimal.MinValue}");
            Console.WriteLine($"Maximum Değer       => {decimal.MaxValue}");
            Console.WriteLine($"Bellek Boyutu       => {sizeof(decimal)} byte");

            Console.WriteLine("C) Karakter(char) Veri Tipi");
            Console.WriteLine("1) CHAR");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer       => {(int)char.MinValue}");
            Console.WriteLine($"Maximum Değer       => {(int)char.MaxValue}");
            Console.WriteLine("E) Tarih(date) Veri Tipi");
            Console.WriteLine("1) DateTime");
            Console.WriteLine("----------------");
            Console.WriteLine($"Minimum Değer       => {DateTime.MinValue}");
            Console.WriteLine($"Maximum Değer       => {DateTime.MaxValue}");
            unsafe
            {
                Console.WriteLine($"Bellek Boyutu       => {sizeof(DateTime)} byte");
            }
            Console.ReadLine();
        }
    }
}
