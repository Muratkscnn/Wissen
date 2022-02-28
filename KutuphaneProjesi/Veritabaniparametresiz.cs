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
        public Veritabani()//constructor Method
        {
        }
        public Veritabani(String tabloAd,params string[] sutunlar)//Bu overload Kayıt listeleme yapacak
        {

            string sutunMetni = string.Join(",", sutunlar);
            sorguCumlesi = $"SELECT {sutunMetni} FROM {tabloAd}";
            KayitListele(sorguCumlesi);
            //foreach (var siradakiSutunAd in sutunlar)
            //{
            //    sutunMetni += siradakiSutunAd + ", ";

            //}
            //sutunMetni = sutunMetni.Substring(0, sutunMetni.Length - 1);
        }


        SqlConnection baglanti;
        string sorguCumlesi;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        DataTable dt;
        //ilk olarak bir bağlantısı yapacak metod hazırlayalım
        public SqlConnection baglan()
        {
            baglanti = new SqlConnection(@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=sHastane;user=sa;pwd=123;");

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
      
        DataTable KayitListele(string sorguCumlesi)
        {
            adaptor = new SqlDataAdapter(sorguCumlesi,baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }
        public void Islem(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi, baglan());
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

