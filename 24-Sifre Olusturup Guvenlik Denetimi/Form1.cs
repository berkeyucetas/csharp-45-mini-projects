using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Şifre_Oluşturup_Güvenlik_Denetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int karaktersayisi = textSifre.Text.Length;
            if (karaktersayisi > 0 && karaktersayisi < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label3.Text = "Zayıf";
            }
            else if (karaktersayisi >= 4 && karaktersayisi < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label3.Text = "Orta";
            }
            else if (karaktersayisi >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label3.Text = "Güçlü";
            }
            else
            {
                MessageBox.Show("Şifre Oluşturulamadı..!");

                progressBar1.Value = 0;
            }

        }
    }
}
