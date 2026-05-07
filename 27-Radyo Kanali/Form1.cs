using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo_Kanalı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkralfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
            MessageBox.Show(" Kral Fm Radyo Çalıyor...");
        }   

        private void btnalemfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
            MessageBox.Show(" Alem Fm Radyo Çalıyor...");
        }

        private void btnbestfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
            MessageBox.Show(" Best Fm Radyo Çalıyor...");
        }

        private void btnistanbulfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://45.32.154.169:9300/;";
            MessageBox.Show(" İstanbul Fm Radyo Çalıyor...");
        }

        private void btnmetrofm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls";
            MessageBox.Show(" Metro Fm Radyo Çalıyor...");
        }

        private void btnpowerfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
            MessageBox.Show(" Power Fm Radyo Çalıyor...");
        }

        private void btnsuperfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/SUPER_FMAAC.pls";
            MessageBox.Show(" Super Fm Radyo Çalıyor...");
        }

        private void btnslowfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://r3.rocketcdn.com/slowturk/abr/playlist.m3u8";
            MessageBox.Show(" Slow Fm Radyo Çalıyor...");
        }

        private void btnfenomenfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://fenomen.listenfenomen.com/fenomen/128/icecast.audio";
            MessageBox.Show(" Fenomen Fm Radyo Çalıyor...");
        }

        private void btntrtfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://trtcanlifm-lh.akamaihd.net/i/TRTFM_1@181846/master.m3u8";
            MessageBox.Show(" Trt Fm Radyo Çalıyor...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
