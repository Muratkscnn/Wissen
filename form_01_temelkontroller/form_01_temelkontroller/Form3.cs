using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_01_temelkontroller
{
    public partial class Form3 : Form
    {
        string cinsiyet = "";
        public Form3()
        {
            InitializeComponent();
        }
        string CinsiyetBelirle()
        {
            if (rdbKadın.Checked==true)
            {
                return "Kadın";
            }
            else
            {
                return "Erkek";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadın.Checked = true;
        }
        void ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text;//lvi'nin text özelliği 1.kolon demektir.
            lvi.SubItems.Add(CinsiyetBelirle());
            lsvKisiler.Items.Add(lvi);
            txtAdSoyad.ResetText();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }
    }
}
