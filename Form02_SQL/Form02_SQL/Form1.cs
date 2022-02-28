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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; User=sa; Pwd=123";
                //üstteki satır SQL server Authentication metodu ile bağlantı sağlar.
                /* SqlConnection baglanti = new SqlConnection();
                 baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; Trusted_Connection=true";
                 //üstteki satır WİNDOWS Authentication metodu ile bağlantı sağlar. */
                baglanti.Open();
                //işlemler
                //işlemler
                //işlemler
                //işlemler
                //işlemler
                //işlemler
                baglanti.Close();
                MessageBox.Show("Veri Tabanına bağlantı işlemi başarılırı");

                //buraya yazılacaklar çalıştırılması denenecek kodlar. Eğer çalışıyorsa sorun yok
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Bağlanma sorunum var.");
                //try scopuna yazılan kodlarda hata varsa, buraya düşer
                throw;
            }
           



        }
    }
}
