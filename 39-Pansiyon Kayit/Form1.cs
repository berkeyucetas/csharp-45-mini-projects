using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Pansiyon_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1IAQ7GQ;Initial Catalog=pansiyon;Integrated Security=True");
        private void verigöster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr["id"].ToString();
                ekle.SubItems.Add(rdr["Ad"].ToString());
                ekle.SubItems.Add(rdr["Soyad"].ToString());
                ekle.SubItems.Add(rdr["OdaNo"].ToString());
                ekle.SubItems.Add(rdr["GTarih"].ToString());
                ekle.SubItems.Add(rdr["Telefon"].ToString());
                ekle.SubItems.Add(rdr["Hesap"].ToString());
                ekle.SubItems.Add(rdr["CTarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigöster();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteriler(id,Ad,Soyad,OdaNo,GTarih,Telefon,Hesap,CTarih) values ('" + textID.Text.ToString() + "','" + textAd.Text.ToString() + "','" + textSoyad.Text.ToString() + "','" + comboOda.Text.ToString() + "','" + dateG.Text.ToString() + "','" + textTel.Text.ToString() + "','" + textHesap.Text.ToString() + "','" + dateC.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigöster();
            textID.Clear();
            textAd.Clear();
            textSoyad.Clear();
            comboOda.Text = "";
            textTel.Clear();
            textHesap.Clear();
        }
        int id = 0;

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriler where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigöster();
            textID.Clear();
            textAd.Clear();
            textSoyad.Clear();
            comboOda.Text = "";
            textTel.Clear();
            textHesap.Clear();
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriler set id='" + textID.Text.ToString() + "',Ad='" + textAd.Text.ToString() + "',Soyad='" + textSoyad.Text.ToString() + "',OdaNo='" + comboOda.Text.ToString() + "',GTarih='" + dateG.Text.ToString() + "',Telefon='" + textTel.Text.ToString() + "',Hesap='" + textHesap.Text.ToString() + "',Ctarih='" + dateC.Text.ToString() + "' where id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigöster();
            textID.Clear();
            textAd.Clear();
            textSoyad.Clear();
            comboOda.Text = "";
            textTel.Clear();
            textHesap.Clear();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboOda.Text= listView1.SelectedItems[0].SubItems[3].Text;
            dateG.Text= listView1.SelectedItems[0].SubItems[4].Text;
            textTel.Text= listView1.SelectedItems[0].SubItems[5].Text;
            textHesap.Text= listView1.SelectedItems[0].SubItems[6].Text;
            dateC.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler where Ad like'%"+textBul.Text+"%'", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr["id"].ToString();
                ekle.SubItems.Add(rdr["Ad"].ToString());
                ekle.SubItems.Add(rdr["Soyad"].ToString());
                ekle.SubItems.Add(rdr["OdaNo"].ToString());
                ekle.SubItems.Add(rdr["GTarih"].ToString());
                ekle.SubItems.Add(rdr["Telefon"].ToString());
                ekle.SubItems.Add(rdr["Hesap"].ToString());
                ekle.SubItems.Add(rdr["CTarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }
    }
}
