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
    class ogrenci
    {
        public ogrenci()
        {
            yas = 15;
        }
        public ogrenci(short gelenYas)//overload
        {
            yas = gelenYas;
        }
        private short yas;

        public short Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

    }
    public class Ayakkabi
        {
        public Ayakkabi(string varsayilanMarka)
        {
            marka = "Adidas";
        }
        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private int numara;

        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }

    }

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.Ad = "Engin";
            MessageBox.Show($"Adı: {ogrenci1.Ad}\n Yaşı:{ogrenci1.Yas}");
            ogrenci ogrenci3 = new ogrenci(24);
            MessageBox.Show($"Adı: {ogrenci3.Ad}\n Yaşı:{ogrenci3.Yas}");

        }
    }
}
