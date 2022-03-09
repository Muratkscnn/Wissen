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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //lblSayi.Text = txtSayi.Text;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lblSayi.Text = txtSayi.Text;
            //if (e.KeyChar.ToString()=="A")
            //{
            //    MessageBox.Show("Büyük A harfine bastınız");
            //}
            //else
            //{
            //    MessageBox.Show("olmadı yar");
            //}
            //if (char.IsDigit(e.KeyChar))
            //{
            //    MessageBox.Show("Evet, bir rakam yazdınız");

            //}
            //else
            //{
            //    MessageBox.Show("hayır, rakam dışında birşey yazdınız");
            //}
            //sadece sayı girme
            //if (!(char.IsDigit(e.KeyChar) || e.KeyChar==(char)Keys.Back))
            //{
            //    e.Handled = true;
            //}

        }

        private void txtHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harf girişi
            //if (!(char.IsLetter(e.KeyChar) || e.KeyChar==(char)Keys.Back))
            //{
            //    e.Handled = true;

            //}
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtBuyukHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KÜÇÜKHARF için islower
            e.Handled = !(char.IsUpper(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar==(char)Keys.Space);
        }

        void Doldur()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mobil Programlama");
            comboBox1.Items.Add("Web Programlama");
            comboBox1.Items.Add("Deskop Programlama");
            comboBox1.Items.Add("Mobil Programlama");


        }
        void Doldur2()
        {
            string[] iller = { "İstanbul", "Ankara", "İzmir", "Bursa" };
            comboBox2.Items.AddRange(iller);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
            Doldur2();
            rdbEvet.Checked = true;
            //comboBox1.Items.Clear();


        }
        void kontrol()
        {
            if (rdbEvet.Checked)
            {
                lblSayi.Text = "evet dediniz";
            }
            else
            {
                lblSayi.Text = "hayır dediniz";

            }
        }
        private void rdbEvet_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void rdbHayir_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
