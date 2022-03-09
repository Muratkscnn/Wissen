using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        Veritabani vt = new Veritabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }
        
        
        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            
            //odunclistesini güncelliyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

            //üye listesini guncelliyor
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvUye.DataSource = vt.dt;
            for (int i = 0; i < dgvUye.Columns.Count ; i++)
            {
                dgvUye.Columns[i].Visible = false;
            }
            dgvUye.Columns[1].Visible = true;
            //kitap listesi

            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvKitap.Columns.Count; i++)
            {
                dgvKitap.Columns[i].Visible = false;
            }
            dgvKitap.Columns[1].Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            vt.TableName = "tblOdunc";
            int ID = int.Parse(dgvOdunc.CurrentRow.Cells[0].Value.ToString());
            vt.Islem(ID);
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            vt.TableName = "tblOdunc";
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = Convert.ToInt32(dgvUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpVerilisTarih.Value;
            yeniOdunc.Iptal = false;
            vt.Islem(yeniOdunc);
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
            
        }
        void Aktar()
        {
            int aranan = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[1].Value.ToString());
            foreach (DataGridViewRow satir in dgvUye.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString())==aranan)
                {
                    satir.Selected = true;
                    break;
                }
            }
             aranan = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[2].Value.ToString());

            foreach (DataGridViewRow satir in dgvKitap.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString()) == aranan)
                {
                    satir.Selected = true;
                    break;
                }
            }
        }

        private void dgvOdunc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Aktar();
            }
            catch (Exception)
            {

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aktar();
        }
    }
}
