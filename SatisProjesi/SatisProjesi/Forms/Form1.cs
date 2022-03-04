using SatisProjesi.DataAccess;
using SatisProjesi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi
{
    public partial class Form1 : Form
    {
        UrunDAL urunDAL = new UrunDAL();

        SatislarDAL satislarDAL = new SatislarDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.SatisTarihi = dtpTarih.Value;
            satis.UrunID =Convert.ToInt32(cmbUrunAD.SelectedValue);
            satis.SatisAdedi =int.Parse(txtAdet.Text);
            satislarDAL.Insert(satis);
            urunDAL.UpdateStok(satis); //sql'de trigger eklendi
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUrunAD.DataSource = urunDAL.GetAll();
            cmbUrunAD.ValueMember = "ID";
            cmbUrunAD.DisplayMember = "UrunAd";
        }
    }
}
