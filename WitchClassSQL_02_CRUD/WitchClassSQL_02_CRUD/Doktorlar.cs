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
    public partial class Doktorlar : Form
    {
        Veritabani vt = new Veritabani();
        string Bolum;
        public Doktorlar()
        {
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            cmbBolum.DataSource = vt.KayitListele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";

        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bolum = cmbBolum.SelectedValue.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorguCumlesi = $"INSERT INTO tblDoktorlar VALUES('{txtSicilNo.Text}','{txtAdSoyad.Text}','{txtTel.Text}','{txtMail.Text}','{Bolum}')";
            vt.Islem(sorguCumlesi);
        }
    }
}
