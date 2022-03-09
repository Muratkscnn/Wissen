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

namespace Telefon_Rehberi_v2
{
    public partial class Liste : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        string sorguCumlesi;
        string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=sRehber; user=sa; pwd=123";
        public Liste()
        {
            InitializeComponent();
        }
        void Aktar()//dgvkisiler üzerinden tıklandıgında yan tarafa ilgili kaydın degerlerıAktarılır
        {
            //currentrow tüm satır.
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                cmbCinsiyet.Text = "K";
            }
            else
            {
               cmbCinsiyet.Text = "E";

            }

        }
        void Duzelt()
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            char Cinsiyet;
            string tel = txtTelefon.Text;
            if (cmbCinsiyet.Text == "Kadın")
            {
                Cinsiyet = 'K';
            }
            else
            {
                Cinsiyet= 'E';

            }
            sorguCumlesi = $"UPDATE tblKisiler SET Ad='{Ad}',Soyad='{Soyad}',Cinsiyet='{Cinsiyet}',Telefon='{tel}'WHERE ID='{dgvKisiler.CurrentRow.Cells[0].Value.ToString()}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisileriGetir();
        }
        void Sil()
        {
            string ID = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE FROM tblKisiler WHERE ID={ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisileriGetir();

        }
        void kisileriGetir()
        {
            
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }
        private void Liste_Load(object sender, EventArgs e)
        {
            kisileriGetir();
            panel1.Visible = false;
        }

        private void Liste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anaform = new Form1();
            anaform.Show();
        }

       

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Duzelt();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
