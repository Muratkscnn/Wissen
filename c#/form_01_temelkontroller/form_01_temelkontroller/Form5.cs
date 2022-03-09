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
    public partial class Form5 : Form
    {
        Random rnd = new Random();
        int rSayi = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            rSayi = rnd.Next(1, 100);
            label1.Text = rSayi.ToString();
        }
        void Sonuc()
        {
            if (listBox1.Items.Count == 2)
            {
                MessageBox.Show("KAZANDINIZ");
                listBox1.Items.Clear();

            }
        }
        void Cift()
        {

            if (timer1.Enabled == true)
            {
                timer1.Stop();
                if (rSayi % 2 == 0)
                {
                    lblSonuc.Text = "BİLDİN";
                    listBox1.Items.Add(rSayi);

                }
                else
                {
                    lblSonuc.Text = "BİLEMEDİN";
                }
            }
            else
            {
                timer1.Start();
            }
        }
        void Tek()
        {

            if (timer1.Enabled == true)
            {
                timer1.Stop();
                if (rSayi % 2 != 0)
                {
                    lblSonuc.Text = "BİLDİN";
                    listBox1.Items.Add(rSayi);
                }
                else
                {
                    lblSonuc.Text = "BİLEMEDİN";
                }
            }
            else
            {
                timer1.Start();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (rdbCift.Checked == true)
            {
                Cift();
                Sonuc();
            }
            else
            {
                Tek();
                Sonuc();

            }
        }
    }
}