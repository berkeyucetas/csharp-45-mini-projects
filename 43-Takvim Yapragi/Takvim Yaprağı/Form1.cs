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

namespace Takvim_Yaprağı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection(@"Data Source=DESKTOP-1IAQ7GQ;Initial Catalog=takvim;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text= DateTime.Now.ToLongDateString();
            label10.Text= DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Veriler where id=" + comboBox1.Text, baglanti);
            cmd.Parameters.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.Text = reader["tarihtebugun"].ToString();
                richTextBox2.Text = reader["gununsozu"].ToString();
                richTextBox3.Text = reader["cocukismi"].ToString();
                richTextBox4.Text = reader["gununyemegi"].ToString();
                richTextBox5.Text = reader["pratikbilgiler"].ToString();
                richTextBox6.Text = reader["kissadanhisse"].ToString();
            }
            baglanti.Close();
        }
    }
}
