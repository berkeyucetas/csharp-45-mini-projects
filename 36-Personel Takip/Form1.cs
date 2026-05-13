using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        string[] personeller;
        int[] maaslar;
        int asgariücret =11400;
        private void buttonListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            personeller = new string[] { "Sema", "Beyza", "Mehmet", "Oktay", "Sedat", "Berke", "Samet", "Mustafa", "Mert" };
            maaslar = new int[] { 9900, 18000, 11100, 10500, 20500 , 50000, 11400 , 20000 , 9000};

            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan == personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }

            }

            if (bulundu)
            {
                MessageBox.Show("Personel Bulundu");
            }
            else
            {
                MessageBox.Show("Personel Bulunamadı.");
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            label2.Text = "Toplam Personel Sayısı : " + personeller.Length;
        }

        private void buttonMinmaas_Click(object sender, EventArgs e)
        {
            int dusuk = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (dusuk > maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            label2.Text = "En Düşük Maaş : " + dusuk;
        }

        private void buttonMaxmaas_Click(object sender, EventArgs e)
        {
            int yuksek = maaslar[0];
            int yuksekIndex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yuksek < maaslar[i])
                {
                    yuksek = maaslar[i];
                    yuksekIndex = i;
                }
            }
            label2.Text = "En Yüksek Maaş Alan : " + personeller[yuksekIndex];

        }

        private void buttonAsgari_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] <= asgariücret)
                {
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void buttonAsgarifazla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            int sayac = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] >= asgariücret)
                {
                    sayac++;
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }            
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplam += maaslar[i];
            }
            label2.Text = "Toplam Ödenen : " + toplam;
        }

        private void buttonZam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                personeller[selectedIndex]+= 500;

                listBox1.Items[selectedIndex] = $"{personeller[selectedIndex]} - {personeller[selectedIndex]} TL";
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin.");
            }
        }
    }
}
