using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToList metodu ile Bölümleri listeleyelim
            void BolumleriListele()
            {
                HastaneSabahEntities hastane = new HastaneSabahEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID\t Bolum Adı");
                Console.WriteLine("--------------------------");

                foreach (var item in bolumler)
                {
                    Console.WriteLine($"{item.ID}\t\t {item.BolumAd}");
                }
                Console.ReadLine();
            }
            //Where ile Sorgulama,Diş Bölümünü Getir
            void BolumGetir()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    //var sonuc = hastane.Bolumler.Where(x => x.BolumAd == "Diş");
                    //var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    var sonuc = hastane.Bolumler.Where(x => x.BolumAd.EndsWith("i"));


                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"Bölüm ID: {item.ID} BölümAd: {item.BolumAd}");
                    }
                    Console.ReadLine();
                }
            }
            //Select ile veri Çekme
            void DoktorAdListele()
            {
                using (HastaneSabahEntities hastane =new HastaneSabahEntities())
                {
                    var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    foreach (var item in adlar)
                    {
                        Console.WriteLine($"Doktor Adı: {item}");
                    }
                }
                Console.ReadLine();
            }
            //Find ile hızlı Arama Yapma
            void HizliAra()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    //find metodu ilgili tablodaki primary key üzerinden arama yapar.
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} Bölümü: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }
            //ilk Kaydı getirme, ilk demet evgarı getir
            void IlkKayit() {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad == "Demet Evgar")
                        .First();
                    Console.WriteLine($"Doktor Ad: {doktor.AdSoyad} Bölüm Ad: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }
            //ilk 3 doktoru getir
            void IlkUcDoktor()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3);
                    foreach (var item in ilkUcDoktor)
                    {
                        Console.WriteLine(item.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }
            //Var mı?
            void VarMi()
            {
                using (HastaneSabahEntities hastane =new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Demet Evgar");
                        if (sonuc)
                    {
                        Console.WriteLine("Aradıdığınız doktor var");

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız doktor YOK");
                    }
                }
                Console.ReadLine();
            }
            //uygunluk varmı? tüm tablo demet evgar mı?
            void UyuyorMu()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.AdSoyad == "Demet Evgar");
                    Console.WriteLine(sonuc);
                }
                Console.ReadLine();
            }
            //a'dan z'ye küçükten büyüye
            void SiralaAsc()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var item in siraliDoktorlar)
                    {
                        Console.WriteLine(item.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }
            //z'den A'ya büyükten küçüge
            void SiralaDesc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var item in siraliDoktorlar)
                    {
                        Console.WriteLine(item.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }
            //son 3 doktor
            void SonUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3).OrderByDescending(x => x.ID);
                    foreach (var item in ilkUcDoktor)
                    {
                        Console.WriteLine(item.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }
            //Bölümlere Göre doktor sayısını bulucaz
            void BolumlereGoreDoktorSayisiGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    Console.WriteLine("Bölüm Ad\t Sayısı");
                    var sonuc = hastane.Doktorlar.GroupBy(a => a.Bolumler.BolumAd)
                        .Select(b => new
                        {
                            name = b.Key,
                            count = b.Count()
                        });
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"{item.name}\t {item.count}");
                    }
                    Console.ReadLine();
                }
            }



            //BolumleriListele();
            //BolumGetir();
            //DoktorAdListele();
            //HizliAra();
            //IlkKayit();
            //IlkUcDoktor();
            //VarMi();
            //UyuyorMu();
            //SiralaAsc();
            //SiralaDesc();
            //SonUcDoktor();
            //BolumlereGoreDoktorSayisiGetir();

        }
    }
}
