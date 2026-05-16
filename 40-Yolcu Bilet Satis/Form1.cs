using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Yolcu_Bilet_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\bekoo\\Documents\\bilet.accdb");
        OleDbCommand komut = new OleDbCommand();
        private void verigöster()
        {
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from bilgiler";
            OleDbDataReader oku= komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle= new ListViewItem();
                ekle.Text = oku["SeferNo"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Biniş"].ToString());
                ekle.SubItems.Add(oku["İniş"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void buttonVeri_Click(object sender, EventArgs e)
        {
            verigöster();
            textAdSoyad.Clear();
            textKoltuk.Clear();
            textSefer.Clear();
            textTelefon.Clear();
            textÜcret.Clear();
            comboBiniş.Items.Clear();
            comboCinsiyet.Items.Clear();
            comboSaat.Items.Clear();
            comboİniş.Items.Clear();           
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("insert into bilgiler(SeferNo,Tarih,Saat,AdSoyad,Telefon,KoltukNo,Ücret,Cinsiyet,Biniş,İniş) values ('" + textSefer.Text + "','" + date1.Value + "','" + comboSaat.SelectedItem + "','" + textAdSoyad.Text + "','" + textTelefon.Text + "','" + textKoltuk.Text + "','" + textÜcret.Text + "','" + comboCinsiyet.SelectedItem + "','" + comboBiniş.SelectedItem + "','" + comboİniş.SelectedItem + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verigöster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "16";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textKoltuk.Text = "17";
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "delete from bilgiler where AdSoyad='" + textAdSoyad.Text + "'";
            komut.ExecuteNonQuery();
            baglan.Close();
            verigöster();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update bilgiler set SeferNo='"+textSefer.Text+"',Tarih='"+date1.Text+ "',Saat='" + comboSaat.Text + "',Telefon='" + textTelefon.Text + "',KoltukNo='" + textKoltuk.Text + "',Ücret='" + textÜcret.Text + "',Cinsiyet='" + comboCinsiyet.Text + "',Biniş='" + comboBiniş.Text + "',İniş='" + comboİniş.Text + "' where AdSoyad='"+textAdSoyad.Text+"'");
            komut.ExecuteNonQuery();
            baglan.Close();
            verigöster();

        }
    }
}
