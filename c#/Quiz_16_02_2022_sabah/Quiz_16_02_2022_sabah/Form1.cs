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
//DESKTOP-8M7D7GE\SQLEXPRESS

namespace Quiz_16_02_2022_sabah
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti;
        SqlDataAdapter adapter;
        string baglantıCumlesi = @"server=DESKTOP-8M7D7GE\SQLEXPRESS;Database=sRehber;user=sa;pwd=123";
        string sorguCumlesi;
        void kisilerigetir()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantıCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerigetir();
        }
    }
}
