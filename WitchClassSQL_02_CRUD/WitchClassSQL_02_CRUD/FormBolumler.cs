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
    public partial class FormBolumler : Form
    {
        Veritabani vt = new Veritabani();
        string sorguCumlesi;
        public FormBolumler()
        {
            InitializeComponent();
        }

        private void FormBolumler_Load(object sender, EventArgs e)
        {
            sorguCumlesi = $"SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"UPDATE tblBolumler SET BolumAd='{txtBolumAd.Text}' WHERE ID={dgvBolumler.CurrentRow.Cells[0].Value}";
            vt.Islem(sorguCumlesi);
            sorguCumlesi = $"SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBolumAd.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"DELETE tblBolumler WHERE ID={dgvBolumler.CurrentRow.Cells[0].Value}";
            vt.Islem(sorguCumlesi);
            sorguCumlesi = $"SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (btnYeniKayit.Text=="Yeni Kayıt")
            {
                txtBolumAd.ResetText();
                btnYeniKayit.Text = "KAYDET";
            }
            else
            {
                sorguCumlesi = $"INSERT INTO tblBolumler VALUES ('{txtBolumAd.Text}')";
                vt.Islem(sorguCumlesi);
                sorguCumlesi = $"SELECT * FROM tblBolumler";
                dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
                btnYeniKayit.Text = "Yeni Kayıt";

            }

        }
    }
}
