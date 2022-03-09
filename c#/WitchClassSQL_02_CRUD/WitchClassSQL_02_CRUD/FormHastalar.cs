using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WitchClassSQL_02_CRUD
{
    public partial class FormHastalar : Form
    {
        Veritabani vt = new Veritabani();
        string ID;
        string Cinsiyet;
        string sorguCumlesi;
        public FormHastalar()
        {
            InitializeComponent();
        }
        void Aktar()//dgvkisiler üzerinden tıklandıgında yan tarafa ilgili kaydın degerlerıAktarılır
        {
            //currentrow tüm satır.
            txtTc.Text= dgvHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvHastalar.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtAdres.Text = dgvHastalar.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvHastalar.CurrentRow.Cells[7].Value.ToString();
            ID= dgvHastalar.CurrentRow.Cells[0].Value.ToString();

            if (dgvHastalar.CurrentRow.Cells[4].Value.ToString() == "K")
            {
                cmbCinsiyet.Text = "Kadın";
            }
            else
            {
                cmbCinsiyet.Text = "Erkek";

            }
           
        }
        private void Duzelt_Load(object sender, EventArgs e)
        {
            sorguCumlesi = $"SELECT * FROM tblHastalar";
          dgvHastalar.DataSource=vt.KayitListele(sorguCumlesi);
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
            
        }
        
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"UPDATE tblHastalar SET tcNo='{txtTc.Text}', Ad='{txtAd.Text}',Soyad='{txtSoyad.Text}',Cinsiyet='{Cinsiyet}',Telefon='{txtTel.Text}',Mail='{txtMail.Text}',Adres='{txtAdres.Text}' WHERE ID='{ID}'";

            if (vt.kontrol(txtTc.Text, txtAd.Text, txtSoyad.Text, Cinsiyet))
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                if (cmbCinsiyet.Text == "Kadın")
                {
                    Cinsiyet = "K";
                }
                else
                {
                    Cinsiyet = "E";
                }

                vt.Islem(sorguCumlesi);
                sorguCumlesi = $"SELECT * FROM tblHastalar";
                dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
            }
            
        }

        private void Duzelt_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna anaform = new FormAna();
            anaform.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"DELETE FROM tblHastalar WHERE ID={ID}";
            vt.Islem(sorguCumlesi);
            sorguCumlesi = $"SELECT * FROM tblHastalar";
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void YeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayit frmYeni = new YeniKayit();
            frmYeni.Show();
            this.Hide();
        }
    }
}
