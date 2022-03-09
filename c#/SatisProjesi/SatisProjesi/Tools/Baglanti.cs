using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi.Tools
{
    class SQLBaglanti
    {
        static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(@"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=SatisProjesi;User=sa;Pwd=123;");
                }
                return baglanti;

            }
            set { baglanti = value; }
        }


        public static void BaglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }
        public static void BaglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

        }
    }
}
