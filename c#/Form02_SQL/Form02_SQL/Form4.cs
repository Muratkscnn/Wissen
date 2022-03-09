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

namespace Form02_SQL
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti = null;
        SqlCommand komut = null;
        SqlDataReader dr = null;
        string sorguCümlesi = "";
        string baglantiCumlesi=@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; user=sa; pwd=123";
        int sayac = 1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblBar.Width = 0;
        }
        void status()
        {

            lblBar.Width += 60;
            lblstatus.Text += ".";
            sayac++;
        }
        void login()
        {
            string ad = txtUserName.Text;
            string pass = txtPass.Text;
            sorguCümlesi = $"SELECT * FROM tblUsers WHERE UserName='{ad}' AND pass='{pass}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCümlesi,baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblstatus.Text = "Giriş Başarılı";
                timer1.Start();
                
                
            }
            else
            {
                lblstatus.Text = "Kullanıcı adı veya şifre HATALI";
            }
            baglanti.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac <= 5)
            {
                status();

            }
            else
            {
                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
