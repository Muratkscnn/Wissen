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
    //
    public partial class FormKutuphane : Form
    {
        DataBase db = new DataBase();
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            //Ödünç İşlemleri Grid'imizi dolduruyor.
            db.TableName = "tblOdunc";
            db.Process();
            dgvOdunc.DataSource = db.dt;
            ////Üye listesini doldurma
           
            db.TableName = "tblUyeler";
            db.Process();
            dgvOduncUye.DataSource = db.dt;
            for (int i = 0; i < dgvOduncUye.ColumnCount; i++)
            {
                dgvOduncUye.Columns[i].Visible = false;
            }
            dgvOduncUye.Columns[1].Visible = true;
            dgvOduncUye.Columns[1].HeaderText = "Üye Adı";
            //Ödünç İşlemleri Grid'imizi dolduruyor.
            
            db.TableName = "tblKitaplar";
            db.Process();
            dgvOduncKitap.DataSource = db.dt;
            //Üye listesini doldurma
            db.TableName = "tblKitaplar";
            db.Process();
            dgvOduncKitap.DataSource = db.dt;
            for (int i = 0; i < dgvOduncKitap.ColumnCount; i++)
            {
                dgvOduncKitap.Columns[i].Visible = false;
            }
            dgvOduncKitap.Columns[1].Visible = true;
            dgvOduncKitap.Columns[1].HeaderText = "Kitap Adı";
            pnlOduncTeslimTarihi.Visible = false;
            dtpOduncTeslimEtTarihi.Value.AddDays(5).ToString();
           // MessageBox.Show(dtpOduncVerilisTarih.Value.AddDays(5).ToString());

        }

        private void dtpOduncVerilisTarih_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            Odunc newOdunc = new Odunc();
            newOdunc.UyeID = Convert.ToInt32(dgvOduncUye.SelectedRows[0].Cells[0].Value.ToString());
            newOdunc.KitapISBN =Convert.ToInt32( dgvOduncKitap.SelectedRows[0].Cells[0].Value.ToString());
            newOdunc.VerilisTarihi = dtpOduncVerilisTarih.Value;
            newOdunc.Iptal = false;
            db.Process(newOdunc);
            db.TableName = "tblOdunc";
            dgvOdunc.DataSource = db.Process();

        }

        private void dtpOduncVerilisTarih_ValueChanged(object sender, EventArgs e)
        {
            dtpOduncTeslimEtTarihi.Text = dtpOduncVerilisTarih.Value.AddDays(5).ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Odunc iptalOdunc = new Odunc();
           string silinecekID =dgvOdunc.SelectedRows[0].Cells[0].Value.ToString();
            db.TableName = "tblOdunc";
            db.Process(silinecekID);
            dgvOdunc.DataSource = db.Process();
           
            
        }
    }
}
