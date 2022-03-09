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

namespace WitchClassSQL_02_CRUD
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
     
        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar form = new FormHastalar();
            form.Show();
            this.Hide();
        }

        private void btnBolumler_Click(object sender, EventArgs e)
        {
            FormBolumler xd = new FormBolumler();
            xd.Show();
            this.Hide();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            Randevu rdvu = new Randevu();
            rdvu.Show();
            this.Hide();
        }
    }
}
