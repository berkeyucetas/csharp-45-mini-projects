using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Kayıt_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal class Kayit
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Numara { get; set; }

        }

        private List<Kayit> kayitlar = new List<Kayit>();


        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = textBox1.Text;
            string Soyad = textBox2.Text;
            string Numara = textBox3.Text;

            Kayit yeniKayit = new Kayit
            {
                Ad = Ad,
                Soyad = Soyad,
                Numara = Numara
            };

            kayitlar.Add(yeniKayit);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = kayitlar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                kayitlar[index].Ad = textBox1.Text;
                kayitlar[index].Soyad = textBox2.Text;
                kayitlar[index].Numara = textBox3.Text;

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = kayitlar;
            }
            else
            {
                MessageBox.Show("Güncellenecek satırı seçiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                kayitlar.RemoveAt(index);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = kayitlar;
            }
            else
            {
                MessageBox.Show("Silinecek satırı seçiniz.");
            }
        }
    }

    
}
