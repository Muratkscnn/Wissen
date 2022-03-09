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
    class SatislarDAL
    {
        
        public bool Insert(Satis satis)
        {
            
            string sorguCumlesi = $"INSERT INTO tblSatislar VALUES(@p1,@p2,@p3)";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {

                    command.Parameters.AddWithValue("@p1", satis.SatisTarihi.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@p2", satis.UrunID);
                    command.Parameters.AddWithValue("@p3", satis.SatisAdedi);                    
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
