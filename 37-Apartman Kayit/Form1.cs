using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButtonGiris_Click(object sender, EventArgs e)
        {
            if (textKullaniciAd.Text == "Yönetici" && textSifre.Text == "admin13579")
            {
                frmAnaSayfa form= new frmAnaSayfa();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcıadı veya şifre");
            }
        }
    }
}
