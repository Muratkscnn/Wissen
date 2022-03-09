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
    public partial class Form3 : Form
    {
        string baglantiCumlesi = "";
        string sorguCumlesi = "";

        public Form3()
        {
            InitializeComponent();
        }
        void DataGridViewDoldur()
        {
            baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; user=sa; pwd=123";
            sorguCumlesi = "SELECT * FROM tblPersonel";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCumlesi, baglanti);//disconnected bağlantı yöntemi. programda değiştirelen veriler databaseye etki etmez
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvPersonel.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            dgvPersonel.Columns["ID"].Visible = false; //kolonbaşlığı metodu
            dgvPersonel.Columns[5].Visible = false; //kolon indexi metodu


        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
