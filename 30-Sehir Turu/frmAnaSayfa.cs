using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehir_Turu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            frmBilgiAl form=new frmBilgiAl();
            form.ShowDialog();
        }

        private void btnCami_Click(object sender, EventArgs e)
        {
            frmCami form = new frmCami();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text= DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void btnUniversite_Click(object sender, EventArgs e)
        {
            frmUniversite form = new frmUniversite();
            form.ShowDialog();
        }
    }
}
