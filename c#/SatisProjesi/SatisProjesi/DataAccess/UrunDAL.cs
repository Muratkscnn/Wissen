using SatisProjesi.Entity;
using SatisProjesi.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi.DataAccess
{
    class UrunDAL
    {
        public List<Urun> GetAll(string kosulCumlesi = "")
        {
            try
            {//Buraya yazacağımız işlemleri yapmayı dene sorun yoksa çalıştır
                List<Urun> urunler = new List<Urun>();
                //using satırında yaratılan command adlı nesne sadece bu scopeda yaşayacak daha sonra yok olacak.
                //bu nesenenin yok edilmesini garbage Collector'ün insiyatifine bırakmamış olduk..
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblUrunler {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    SQLBaglanti.BaglantiAc();
                    SqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())//geri dönen değerlerin hepsine bakmamızı sağlıyor.
                        {
                            Urun urun = new Urun()
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                UrunAd = reader["UrunAd"].ToString(),
                                StokMiktari = Convert.ToInt32(reader["StokMiktari"])

                            };
                            urunler.Add(urun);
                        }
                    }
                }
                return urunler;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
            public int StokMiktari(string kosulCumlesi = "")
            {
                try
                {
                    SqlCommand command = new SqlCommand($"SELECT  StokMiktari FROM tblUrunler {kosulCumlesi}", SQLBaglanti.Baglanti);
                    Urun urun = new Urun();
                    SQLBaglanti.BaglantiAc();
                    SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    urun.StokMiktari = Convert.ToInt32(reader["StokMiktari"]);
                }
                return urun.StokMiktari;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
                finally
                {
                    SQLBaglanti.BaglantiKapat();
                }
            }
        public bool UpdateStok(Satis satis)
        {
            string sorguCumlesi = $"UPDATE tblUrunler SET StokMiktari=(StokMiktari-@p1) WHERE ID=@p2 AND StokMiktari > @p1";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    //int stokMiktari = StokMiktari($"WHERE ID={satis.UrunID}");
                    command.Parameters.AddWithValue($"@p1",/*stokMiktari - */satis.SatisAdedi);
                    command.Parameters.AddWithValue("@p2", satis.UrunID);
                    SQLBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { SQLBaglanti.BaglantiKapat(); }
        }

    }
}
    
