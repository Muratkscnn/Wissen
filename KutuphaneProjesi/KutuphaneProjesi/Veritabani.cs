using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{

    class Veritabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        string sorguCumlesi;
        DataTable dt;
        //ilk olarak bir bağlantısı yapacak metod hazırlayalım
        public SqlConnection baglan()
        {
            baglanti = new SqlConnection(@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=sKutuphane;user=sa;pwd=123;");

            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }
        public void Kapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();

            }
        }
      
        public DataTable KayitListele(string sorguCumlesi)
        {
            
            adaptor = new SqlDataAdapter(sorguCumlesi,baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }
        public void Islem(string sorguCumlesi,string turAd)
        {
            komut = new SqlCommand(sorguCumlesi, baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void KitapEkle(string sorguCumlesi,string[] kitap,string[] parametre)
        {
            komut = new SqlCommand(sorguCumlesi, baglan());
            for (int i = 0; i < kitap.Length; i++)
            {
                komut.Parameters.AddWithValue($"{parametre[i]}", kitap[i]);
                
            }

            komut.ExecuteNonQuery();

            baglanti.Close();
        }
        public void yayinEviEkle(string sorguCumlesi, string[] yevi, string[] parametre)
        {
            komut = new SqlCommand(sorguCumlesi, baglan());
            for (int i = 0; i < yevi.Length; i++)
            {
                komut.Parameters.AddWithValue($"{parametre[i]}", yevi[i]);

            }

            komut.ExecuteNonQuery();

            baglanti.Close();
        }

        public bool kontrol(string tcNo,string Ad, string Soyad,string Cinsiyet)//1. Yöntem
        {
            bool donus = false;
            if ((tcNo=="" || Ad=="" || Soyad=="" || Cinsiyet==""))
            {

                donus = true;
                
                
            }
            return donus;
            
        }
        public bool kontrol2(params string[] e) //2.yöntem
        {
            bool donus = true;
            foreach (var item in e)
            {
                if (item=="")
                {
                    donus = false;
                    break;
                }
            }
            return donus;
        }
    }
    }

