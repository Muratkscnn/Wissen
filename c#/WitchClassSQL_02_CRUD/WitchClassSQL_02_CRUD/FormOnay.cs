using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WitchClassSQL_02_CRUD
{
    public partial class FormOnay : Form
    {
        string bolumAd1;
        string hastaAd1;
        string doktorAd1;
        string tarih1;
        public FormOnay(string bolumAd, string hastaAd, string doktorAd, string tarih)
        {
            bolumAd1 = bolumAd;
            hastaAd1 = hastaAd;
            doktorAd1 = doktorAd;
            tarih1 = tarih;
            InitializeComponent();
        }

        private void FormOnay_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
