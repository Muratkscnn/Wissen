using PersonelTakipSistemi.DataAccess;
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
        CalisanDAL calisanDAL = new CalisanDAL();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll("WHERE Durumu='Aktif'");

        }
        void clearTools()
        {
            foreach (Control item in pnlAraclar.Controls)
            {
                if (item.GetType()!=typeof(Label))
                {
                    item.Text = string.Empty;
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearTools();
        }
    }
}
