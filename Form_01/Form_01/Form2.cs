using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
           lblSonuc.Text = (int.Parse(txtSayı1.Text) + int.Parse(txtSayı2.Text)).ToString();
            

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (int.Parse(txtSayı1.Text) - int.Parse(txtSayı2.Text)).ToString();
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (double.Parse(txtSayı1.Text) * double.Parse(txtSayı2.Text)).ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (double.Parse(txtSayı1.Text) / double.Parse(txtSayı2.Text)).ToString();

        }
    }
}
