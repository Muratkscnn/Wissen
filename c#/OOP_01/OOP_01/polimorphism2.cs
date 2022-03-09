using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class polimorphism2 : Form
    {
        Sepet sepet = new Sepet();

        public polimorphism2()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, EventArgs e)
        {
            Tekstil tekstil = new Tekstil("Gömlek", 300, "İpek", 3);
            sepet.Ekle(tekstil);
            dgvsepet.Rows.Add(tekstil.UrunAdi, tekstil.Fiyat, tekstil.KDVUygula());
        }

        private void polimorphism2_Load(object sender, EventArgs e)
        {

        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            CepTelefonu cep = new CepTelefonu("İphone 13 Pro",20000,"Apple");
            sepet.Ekle(cep);
            dgvsepet.Rows.Add(cep.UrunAdi, cep.Fiyat, cep.KDVUygula());


        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("Uno", 100,"Kepekli",400);
            sepet.Ekle(ekmek);
            dgvsepet.Rows.Add(ekmek.UrunAdi, ekmek.Fiyat, ekmek.KDVUygula());

        }
    }
}
