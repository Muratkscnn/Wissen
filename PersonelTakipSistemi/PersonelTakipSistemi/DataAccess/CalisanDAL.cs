﻿using PersonelTakipSistemi.Entities;
using PersonelTakipSistemi.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipSistemi.DataAccess
{
    class CalisanDAL
    {
        //Burada Data Access Layer hazırlıyoruz.
        //Calisan entitiemizle ilgili CRUD vb. işlemlerimiz burada gerçekleştirilecek
        /// <summary>
        /// Bu metot geriye içinde calisan tipinde değerler barındıran bir list tipinde değer döndürecek.
        /// </summary>
        /// <param name="sorguCumlesi"></param>
        /// bu parmaetre boş bırakılırsa yani "" veya string.empty şeklinde kullanılırsa
        /// tüm kayıtları döndürecek. eğer buraya uygun bir WHERE ifadesi yazılırsa
        /// koşla uygun kayıtları döndürecek
        /// <returns></returns>
        public List<Calisan> GetAll(string kosulCumlesi="")
        {
            try
            {//Buraya yazacağımız işlemleri yapmayı dene sorun yoksa çalıştır
                List<Calisan> calisanlar = new List<Calisan>();
                //using satırında yaratılan command adlı nesne sadece bu scopeda yaşayacak daha sonra yok olacak.
                //bu nesenenin yok edilmesini garbage Collector'ün insiyatifine bırakmamış olduk..
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    SQLBaglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())//geri dönen değerlerin hepsine bakmamızı sağlıyor.
                        {
                            Calisan calisan = new Calisan
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TcNo = reader["TcNo"].ToString(),
                                PersonelNO = reader["PersonelNo"].ToString(),
                                DogumTarihi =Convert.ToDateTime(reader["DogumTarihi"]),
                                IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()
                            };
                            calisanlar.Add(calisan);
                        }
                    }
                }
                return calisanlar;
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
        public bool Insert(Calisan calisan)
        {
            string sorguCumlesi = $"INSERT INTO tblCalisanlar " +
                $"(Ad,Soyad,TcNo,PersonelNo,IseBaslamaTarihi,DogumTarihi,Departman,Unvan,Durumu)" +
                $"VALUES " +
                $"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            try
            {
                using (SqlCommand command =new SqlCommand(sorguCumlesi,SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNO);
                    command.Parameters.AddWithValue("@p6", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p5", calisan.IseBaslamaTarihi);
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
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
            finally { SQLBaglanti.BaglantiKapat();  }
              
        }
        public bool Update(Calisan calisan)
        {
            string sorguCumlesi = $"UPDATE tblCalisanlar SET Ad=@p1,Soyad=@p2,TcNo=@p3,PersonelNo=@p4,IseBaslamaTarihi=@p5,DogumTarihi=@p6,Departman=@p7,Unvan=@p8,Durumu=@p9" +
                $"WHERE ID=@p10";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNO);
                    command.Parameters.AddWithValue("@p5", calisan.IseBaslamaTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
                    command.Parameters.AddWithValue("@p10", calisan.ID);
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
            finally { SQLBaglanti.BaglantiKapat();  }

        }
        public bool Delete(int id)
        {
            string sorguCumlesi = $"DELETE FROM tblcalisanlar WHERE ID = @p1";
            try
            {
                using (SqlCommand command=new SqlCommand(sorguCumlesi,SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", id);
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
        public bool Delete(string kosulCumlesi="")
        {
            string sorguCumlesi = $"DELETE FROM tblCalisanlar {kosulCumlesi}";
            try
            {
                using (SqlCommand command=new SqlCommand(sorguCumlesi,SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", kosulCumlesi);
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
            finally { SQLBaglanti.BaglantiKapat();  }
        }
        
    }
}
