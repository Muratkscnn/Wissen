using PersonelTakipSistemi.DataAccess;
using PersonelTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipSistemi
{
    public partial class FormAna : Form
    {
        int secilenID = 0;
        CalisanDAL calisanDAL = new CalisanDAL();
        Calisan calisan = new Calisan();
        public FormAna()
        {
            InitializeComponent();
        }
        void Reflesh()
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll("WHERE Durumu='Aktif'");

        }
        private void FormAna_Load(object sender, EventArgs e)
        {
            Reflesh();
        }
        void clearTools()
        {
            foreach (Control item in pnlAraclar.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    item.Text = string.Empty;
                }
            }
            dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
            dtpDogumTarihi.CustomFormat = " ";
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpIseBaslamaTarihi.CustomFormat = " ";
            txtAd.Focus();
            Cancel();

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearTools();
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;

        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;

        }
        void Transfer()
        {
            secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value.ToString());
            txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
            txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
            txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value.ToString());
            dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value.ToString());
            cmbDepartman.Text = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
            cmbUnvan.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
            cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Transfer();

            }
            catch (Exception)
            {

            }
        }
        bool BlankControl()
        {
            bool result = true;
            foreach (Control item in pnlAraclar.Controls)
            {
                if (item.Text == string.Empty || item.Text == " ")
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BlankControl())
            {
                MessageBox.Show("Lütfen tüm alanları Doldurunuz..");
            }
            else
            {
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.TcNo = txtTcNo.Text;
                calisan.PersonelNO = txtPersonelNo.Text;
                calisan.DogumTarihi = dtpDogumTarihi.Value;
                calisan.IseBaslamaTarihi = dtpDogumTarihi.Value;
                calisan.Departman = cmbDepartman.SelectedItem.ToString();
                calisan.Unvan = cmbUnvan.SelectedItem.ToString();
                calisan.Durumu = cmbDurumu.SelectedItem.ToString();
                bool result = calisanDAL.Insert(calisan);
                if (result)
                {
                    Reflesh();
                    MessageBox.Show("Kayıt Başarılı..");
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
            else
            {
                DialogResult answer = MessageBox.Show("Secilen Kayıt silinecektir!\nEmin Misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    bool result = calisanDAL.Delete(secilenID);
                    if (result)
                    {
                        Reflesh();
                        MessageBox.Show($"{secilenID} ID'li kaydı silme işlemi gerçekleşmiştir.");
                    }
                }

            }
            
        }
        void Cancel()
        {
            Reflesh();
            dgvCalisanlar.ClearSelection();
            secilenID = 0;
            
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Tablonuzdaki tüm kayıtlar silinecekti\nEmin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                bool result = calisanDAL.Delete();
                if (result)
                {
                    Reflesh();
                    MessageBox.Show("Silme işlemi başarılı");
                }
            }
        }

        private void FormAna_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCalisanlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                clearTools();
            }
        }
        string CreateQueryString()
        {
            string queryString = string.Empty;
            List<string> alanlar = new List<string>();
            foreach (Control item in pnlAraclar.Controls)
            {
                if (item.Tag == null) continue;
                string fieldName = item.Tag.ToString();
                string value = string.Empty;
                if (string.IsNullOrEmpty(item.Text) || item.Text == " ") continue;               
                if (item.GetType()==typeof(DateTimePicker))
                {
                    value =Convert.ToDateTime(item.Text).ToString("yyyy-MM-dd");
                    alanlar.Add($"{fieldName} = '{value}'");

                }
                else if (item.GetType() == typeof(ComboBox))
                {
                    value = item.Text;
                    alanlar.Add($"{fieldName} = '{value}'");
                }
                
                else
                {
                    value = item.Text;
                    alanlar.Add($"{fieldName} LIKE '{value}%'");

                }
            }
            if (alanlar.Count>0)
            {
                queryString = $"WHERE {string.Join(" AND ", alanlar)}";
            }
            return queryString;
            
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll(CreateQueryString());
        }
    }
}
