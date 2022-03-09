using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    
    class DataBase
    {
        
        string queryString;
        SqlConnection connection;
        public DataTable dt;
        public DataBase()
        {
            CreateConnection();
        }
        void CreateConnection()
        {
            string sName = $"DESKTOP-8M7D7GE\\SQLEXPRESS";
            string dName = $"aKutuphane";
            string uName = $"sa";
            string pass = $"123";
            string connectString = $"Server={sName};Database={dName};User={uName};Pwd={pass}";
            connection = new SqlConnection(connectString);
       }
        void Open()
        {
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        void Close()
        {
            if (connection.State!=ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public string TableName { get; set; }
        
        public DataTable Process()
        {
            string kosul = $"WHERE Durum='False'";
            if (TableName!="tblOdunc")
            {
                kosul = "";
            }
              
            queryString = $"SELECT * FROM {TableName} {kosul}";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString,connection);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void Process(Odunc newOdunc)
        {
            string queryString = "INSERT INTO tblOdunc (UyeID,KitapISBN,VerilisTarihi, Durum) VALUES" +
                "(@uyeID,@kitapISBN,@verilisTarihi,@durum)";
            SqlCommand komut = new SqlCommand(queryString, connection);
            komut.Parameters.AddWithValue("@uyeID", newOdunc.UyeID);
            komut.Parameters.AddWithValue("@kitapISBN", newOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@verilisTarihi", newOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@durum", newOdunc.Iptal);
            Open();
            komut.ExecuteNonQuery();
            Close();
        }
        public void Process(string silinecekID)
        {
            string queryString = $"UPDATE {TableName} SET Durum='true' WHERE ID=@silinecekID";
            SqlCommand komut = new SqlCommand(queryString, connection);
            komut.Parameters.AddWithValue("@silinecekID",silinecekID);
            Open();
            komut.ExecuteNonQuery();
            Close();
        }

    }
}

