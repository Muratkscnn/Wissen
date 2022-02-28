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

namespace Telefon_Rehberi_v1
{
    public partial class Form1 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        string sorguCumlesi;
        string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=sRehber; user=sa; pwd=123";
        public Form1()
        {
            InitializeComponent();
        }
        void kisileriGetir()
        {;
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }

        void Aktar()//dgvkisiler üzerinden tıklandıgında yan tarafa ilgili kaydın degerlerıAktarılır
        {
            lblId.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();//currentrow tüm satır.
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="K")
            {
                rdbKadin.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;

            }

        }
        
        void Duzelt()
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            char Cinsiyet;
            string tel = txtTel.Text;
            string ID = lblId.Text;
            if (rdbKadin.Checked == true)
            {
                Cinsiyet = 'K';
            }
            else
            {
                Cinsiyet = 'E';
            }
            sorguCumlesi = $"UPDATE tblKisiler SET Ad='{Ad}',Soyad='{Soyad}',Cinsiyet='{Cinsiyet}',Telefon='{tel}'WHERE ID={ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisileriGetir();
        }
        void Sil()
        {
            string ID = lblId.Text;
            sorguCumlesi = $"DELETE FROM tblKisiler WHERE ID={ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisileriGetir();

        }
        void Ara()
        {
            string AD = txtAranan.Text;
            
            sorguCumlesi = $"SELECT * FROM tblKisiler WHERE Ad='{AD}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
        }
        void Ara2()
        {
            string Aranan = txtAranan.Text;
            DataView dw = dt.DefaultView;
            dw.RowFilter = $"Ad LIKE '{Aranan}%'";
        }
        void YeniKayit()
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            char Cinsiyet;
            string tel = txtTel.Text;
            string ID = lblId.Text;
            if (rdbKadin.Checked == true)
            {
                Cinsiyet = 'K';
            }
            else
            {
                Cinsiyet = 'E';
            }
            
            sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{Ad}','{Soyad}','{Cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisileriGetir();
        }
        void temizle()
        {
            lblId.Text = "Yeni Kayıt";
            txtAd.ResetText();
            txtSoyad.ResetText();
            rdbErkek.Checked = false;
            rdbKadin.Checked = true;
            txtTel.ResetText();
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisileriGetir();

        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text=="Yeni")
            {
                btnYeni.Text = "KAYDET";

            }
            else
            {
                btnYeni.Text = "Yeni";
                YeniKayit();
            }
            temizle();
            
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            //Ara();
            Ara2();
        }
    }
}
