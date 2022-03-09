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
        public DataTable dt;
        string sorguCumlesi;
        public string TableName { get; set; }


        public Veritabani()
        {
            baglanti = Yarat();
        }
       SqlConnection Yarat()
        {
            string baglantiCumlesi = (@"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sKutuphane;user=sa;pwd=123;");
            baglanti = new SqlConnection(baglantiCumlesi);         
            return baglanti;
        }
        void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        void Kapat()
        {
            if (baglanti.State==ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        //public DataTable Dt { get; set; }
        
        /// <summary>
        /// Kayıt Listeleme İşlemi İçin Kullanılır.
        /// </summary>
        public void Islem()
        {
            sorguCumlesi = $"SELECT * FROM {TableName}";
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adaptor.Fill(dt);
        }
        /// <summary>
        /// Verilen ID'ye göre silme işlemi yapar ama gerçekte slmez
        /// ilgili kaydın ıptal kolonuna true yazar.
        /// </summary>
        /// <param name="ID"></param>
        public void Islem(int ID)
        {
            sorguCumlesi = $"UPDATE {TableName} SET Iptal=1 WHERE ID={ID}";
            Ac();
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);

            komut.ExecuteNonQuery();
            Kapat();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Islem(Odunc yeniOdunc)
        {
            Ac();
            sorguCumlesi = $"INSERT INTO {TableName} (UyeID,KitapISBN,VerilisTarihi,Iptal) VALUES (@1,@2,@3,@4)";
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.Parameters.AddWithValue("@1", yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@2", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@3", yeniOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@4", yeniOdunc.Iptal);
            komut.ExecuteNonQuery();
            Kapat();
        }
    }
}

