using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace KursProjesi.DataAccess.BaglantiDAL
{
    public static class Baglanti
    {
        private static SqlConnection baglantiNesnesi;

        public static SqlConnection BaglantiNesnesi
        {
            get
            {
                if (baglantiNesnesi==null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CsKurslar"].ConnectionString);

                }
                return baglantiNesnesi; 
            }
            set 
            {
                baglantiNesnesi = value;
            }
        }

        

        public static void Ac()
        {
            if (baglantiNesnesi.State==ConnectionState.Closed) baglantiNesnesi.Open();
            
        }
        public static void Kapa()
        {
            if (baglantiNesnesi.State == ConnectionState.Open) baglantiNesnesi.Close();
            
        }
    }
}
