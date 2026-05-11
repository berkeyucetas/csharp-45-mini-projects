using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehir_Turu
{
    public partial class frmUniversite : Form
    {
        public frmUniversite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Konya Teknik Üniversitesi, yeni adı ile 2018 yılında kurulan Konya ilinin Selçuklu ilçesinde bulunan devlet üniversitesi.\r\n\r\nKTÜN bugün bünyesindeki 4 fakülte, 1 enstitü ve 1 meslek yüksekokul ile 5508 lisans, 3851 önlisans, 3484 lisansüstü olmak üzere toplamda 12 bin 843 öğrencisi ile eğitim hayatını sürdürmektedir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\universite\\ktu.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2005 yılında kuruluş çalışmalarına başlanan Konya Ticaret Odası (KTO) Karatay Üniversitesi, Konya Ticaret Odası Eğitim ve Sağlık Vakfı tarafından Konya’nın ilk vakıf üniversitesi olarak 2009 yılında açılmıştır. KTO Karatay Üniversitesi ilk öğrencilerini 2010-2011 eğitim-öğretim yılında kabul etmiş ve ilk mezunlarını Haziran 2013’te vermiştir.\r\n\r\nKTO Karatay Üniversitesi 2010 yılında 3 fakülte ile eğitim öğretime başlamış olup bugün itibarıyla 5 fakülte, 3 yüksekokul, 3 meslek yüksekokulu ve 1 enstitü ile ön lisans, lisans ve lisansüstü eğitim vermektedir. 2020-2021 eğitim öğretim yılında üniversitenin toplam öğrenci sayısı yaklaşık 9.000'dir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\universite\\karatay.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Necmettin Erbakan Üniversitesi, 2010 yılında Konya'da bir devlet üniversitesi olarak 14 Temmuz 2010 tarih ve 6005 sayılı kanun ile \"Konya Üniversitesi\" adı ile kurulmuş ve kuruluşu 21 Temmuz 2010 tarih ve 27648 sayılı Resmî Gazete’de yayınlanmıştır.[2]\r\n\r\nKonya Üniversitesi Rektörlüğüne, Cumhurbaşkanlığınca Anayasa'nın 130'uncu ve 2547 sayılı Yükseköğretim Kanunu'nun 13'üncü maddeleri uyarınca 10.12.2010 tarihinde Prof. Dr. Muzaffer Şeker atanmıştır. Üniversite; Sosyal ve Beşeri Bilimler, Mühendislik ve Mimarlık, Fen, Turizm, Eğitim Bilimleri, Havacılık ve Uzay Bilimleri, Meram Tıp, Ahmet Keleşoğlu Eğitim,Diş Hekimliği, Ereğli Eğitim, Ereğli Mühendislik, Seydişehir Mühendislik, Güzel Sanatlar ve İlahiyat Fakülteleri ile Devlet Konservatuvarı, Uygulamalı Bilimler Fakültesi, Yabancı Diller Yüksekokulu ve Sosyal Bilimler, Fen Bilimleri, Eğitim Bilimleri ve Sağlık Bilimleri Enstitüleri olmak üzere on dört Fakülte, bir Konservatuvar, dört Enstitü ve iki Yüksekokul’dan oluşmaktadır.\r\n\r\n11 Nisan 2012 tarihinde Resmi Gazete'de yayımlanan \"İlköğretim ve Eğitim Kanunu ile Bazı Kanunlarda Değişiklik Yapılmasına Dair Kanun\" ile \"Yükseköğretim Kurumları Teşkilatı Kanunu'nda yapılan değişiklikle\", \"Konya Üniversitesi\"nin adı, \"Necmettin Erbakan Üniversitesi\" olarak değiştirilmiştir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\universite\\erbakan.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Selçuk Üniversitesi, 11 Nisan 1975 tarihinde Konya'da kurulmuş olan bir devlet üniversitesidir.[1]\r\n\r\nTarihçe\r\n1955 - 1962\r\nKonya'da üniversite açılması 1955 yılında gündeme gelmiştir. Bu tarihte üniversite için TBMM'de kanun tasarısı hazırlanmıştır. Tasarı, milletvekillerinin yarısından fazlası tarafından imzalanmıştır ancak Milli Eğitim Komisyonu'ndan geçememiştir.\r\n\r\n1962 - 1977\r\n1962'de Konya, MEB'e bağlı Selçuk Eğitim Enstitüsü ve Yüksek İslâm Enstitüsü ile üniversiteye sahip olma yolunda ilk büyük adımını atmıştır. Daha sonra bu adımın güçlendirilmesi ve geliştirilmesi için 1968 yılında Konya'da Üniversite Kurma ve Yaşatma Derneği kurulmuştur. Nihayet bugünkü Mühendislik-Mimarlık Fakültesi'nin nüvesini teşkil eden Mühendislik-Mimarlık Yüksekokulu kurulmuştur. Binası, dershanesi, personeli ve bütçesi olmadığı halde Üniversite Kurma ve Yaşatma Derneği sayesinde 1970-1971 Eğitim-Öğretim yılında Çocuk Esirgeme Kurumu'na ait bir binada (Gazi Lisesi) hizmet vermeye başlayan bu Yüksekokul, 5 Temmuz 1971 tarih ve 1418 sayılı kanunun 9. maddesine istinaden Konya Devlet Mimarlık Mühendislik Akademisi unvanını almıştır.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\universite\\selcuk.png";
        }
    }
}
