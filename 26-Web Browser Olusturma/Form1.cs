using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void btnins_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/");        
        }

        private void btnface_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/");        
        }

        private void btnmail_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://mail.google.com/");
        }

        private void btnlink_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.linkedin.com/");
        }

        private void btngithub_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://github.com/");
        }

        private void btntwitter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/");
        }

        private void btnwp_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }

        private void btnyoutube_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }

        private void btnsahibinden_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sahibinden.com/");
        }

        private void btnchat_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://chat.openai.com/");
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("C# Web Browser'a hoşgeldiniz..");
        }

        private void btngit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
