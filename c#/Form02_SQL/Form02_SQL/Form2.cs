using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02_SQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       void VerileriCek()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; User=sa; pwd=123");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblDepartman";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                int ID = (int)dr["ID"];
                string departmanAd = dr["DepartmanAd"].ToString();
                lstDepartman.Items.Add($"{ID}\t{departmanAd}");
            }
            
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }
    }
}
