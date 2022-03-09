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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class Ayakkabi
        {
            public Ayakkabi()
            {

            }
            public Ayakkabi(Markalar gelenMarka)
            {
                Marka = gelenMarka;
            }
            public Ayakkabi(Markalar gelenMarka,AyakkabiTipleri gelenAyakkabiTipi)
            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
            }
            public Ayakkabi(Markalar gelenMarka, AyakkabiTipleri gelenAyakkabiTipi,MalzemeTipleri gelenMalzemeTipi)
            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
                MalzemeTipi = gelenMalzemeTipi;
            }
            public Markalar Marka { get; set; }
            public AyakkabiTipleri AyakkabiTipi { get; set; }
            public MalzemeTipleri MalzemeTipi { get; set; }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Ayakkabi a = new Ayakkabi();
            a.Marka = Markalar.Adidas;
            a.AyakkabiTipi = AyakkabiTipleri.Çizme;
            a.MalzemeTipi = MalzemeTipleri.ElmaDerisi;
            MessageBox.Show($@"Markası: {a.Marka}
Ayakkabı Tipi: {a.AyakkabiTipi}
Malzeme Tipi: {a.MalzemeTipi}");
            Ayakkabi b = new Ayakkabi(Markalar.Puma);
            MessageBox.Show($@"Markası: {b.Marka}
Ayakkabı Tipi: {b.AyakkabiTipi}
Malzeme Tipi: {b.MalzemeTipi}");
            Ayakkabi c = new Ayakkabi(Markalar.Hummel, AyakkabiTipleri.SporAyakkabi);
            MessageBox.Show($@"Markası: {c.Marka}
Ayakkabı Tipi: {c.AyakkabiTipi}
Malzeme Tipi: {c.MalzemeTipi}");
            Ayakkabi d = new Ayakkabi(Markalar.Puma, AyakkabiTipleri.Çizme, MalzemeTipleri.ElmaDerisi);
            MessageBox.Show($@"Markası: {d.Marka}
Ayakkabı Tipi: {d.AyakkabiTipi}
Malzeme Tipi: {d.MalzemeTipi}");
        }
        
    }
}
