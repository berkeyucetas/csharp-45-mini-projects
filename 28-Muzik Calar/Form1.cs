using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Müzik_Çalar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string selectedGenre = comboBox1.SelectedItem.ToString();

            if (selectedGenre == "Pop")
            {
                string[] i = Directory.GetFiles(@"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\slow", "*.mp3");

                listBox1.Items.Clear();
                foreach (string dosyaYolu in i)
                {
                    string dosyaAdi = Path.GetFileName(dosyaYolu);
                    listBox1.Items.Add(dosyaAdi);
                }
            }
            else if (selectedGenre == "Klasik")
            {
                string[] klasik = Directory.GetFiles(@"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\klasik", "*.mp3");

                listBox1.Items.Clear();
                foreach (string dosyaYolu in klasik)
                {
                    string dosyaAdi = Path.GetFileName(dosyaYolu);
                    listBox1.Items.Add(dosyaAdi);
                }
            }
            else if (selectedGenre == "Arabesk")
            {
                string[] arabesk = Directory.GetFiles(@"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\arabesk", "*.mp3");

                listBox1.Items.Clear();
                foreach (string dosyaYolu in arabesk)
                {
                    string dosyaAdi = Path.GetFileName(dosyaYolu);
                    listBox1.Items.Add(dosyaAdi);
                }
            }
            else if (selectedGenre == "Yabancı")
            {
                string[] yabanci = Directory.GetFiles(@"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\yabanci", "*.mp3");

                listBox1.Items.Clear();
                foreach (string dosyaYolu in yabanci)
                {
                    string dosyaAdi = Path.GetFileName(dosyaYolu);
                    listBox1.Items.Add(dosyaAdi);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedSong = listBox1.SelectedItem.ToString();
                string selectedGenre = comboBox1.SelectedItem.ToString();
                string fullPath = GetSongFullPath(selectedGenre, selectedSong);

                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private string GetSongFullPath(string genre, string fileName)
        {
            string genrePath = "";

            if (genre == "Pop")
            {
                genrePath = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\slow";
            }
            else if (genre == "Klasik")
            {
                genrePath = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\klasik";
            }
            else if (genre == "Arabesk")
            {
                genrePath = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\arabesk";
            }
            else if (genre == "Yabancı")
            {
                genrePath = @"C:\Users\bekoo\Desktop\DERS\C# Uygulama\Müzik Çalar\Müzikler\yabanci";
            }

            return Path.Combine(genrePath, fileName);
        }
        private double currentPosition = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = currentPosition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition; 
            axWindowsMediaPlayer1.Ctlcontrols.pause(); 
        }        
        private int currentSongIndex = -1;
        private List<string> shuffledSongs = new List<string>();
        private void PlayNextSong()
        {
            if (currentSongIndex < shuffledSongs.Count - 1)
            {
                currentSongIndex++;
                string selectedSong = shuffledSongs[currentSongIndex];
                axWindowsMediaPlayer1.URL = selectedSong;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Son şarkı çalındı.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PlayPreviousSong();
        }

        private void PlayPreviousSong()
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                string selectedSong = shuffledSongs[currentSongIndex];
                axWindowsMediaPlayer1.URL = selectedSong;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Bu ilk şarkı.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
