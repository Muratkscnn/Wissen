using KursProjesi.DataAccess.BaglantiDAL;
using KursProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesi.DataAccess.DAL
{
    class EgitimDAL
    {
        public void GetAll()
        {
            Kurs kurs = null;
            try
            {
                using (SqlCommand cmd =new SqlCommand("SELECT * FROM tblEgitimler",Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    using (SqlDataReader dr =cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            kurs = new Kurs()
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Ad = dr["ID"].ToString(),
                                Sorumlu = dr["ID"].ToString(),
                                BaslangicTarihi = Convert.ToDateTime(dr["BaslangicTarihi"]),
                                Sure = Convert.ToInt32(dr["Sure"])
                            };

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
