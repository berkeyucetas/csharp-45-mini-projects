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
    public partial class frmCami : Form
    {
        public frmCami()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Aziziye Cami; bu cami 1867 senesinde Sultan Abdülaziz'in emriyle inşa edilmiştir. Şehir merkezinde yer alır. Köşe kubbelerinde altın işlemeler mevcuttur. Yere kadar uzanan büyük pencereleri sayesinde gün boyu aydınlıktır. Aziziye Cami pencereleri kapılarından daha büyük olan cami olarak bilinir. Bu camide Avrupa Barok mimarisinin izlerini görmek de mümkün.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\cami\\aziziye.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "İplikçi Cami; bu cami 1202 senesinde Selçuklular döneminde inşa edilmiştir. Bu caminin mihrabı özel bir taş olan gök mermerden yapılmıştır. Caminin en önemli özelliği ise Mevlana'nın Bleh şehrinden Konya'ya gelip bu caminin bir köşesinde bir süre yaşamış olmasıdır. Bu caminin en bilinen ve farklı özelliği ise akustik bir şadırvana sahip olması. Şadırvanda bulunan sütunlardan karşılıklı olarak konuşursanız sesiniz net olarak karşıdaki kişi tarafından duyulur. Fısıldasanız dahi karşıdaki kişi sizi net olarak duyabilir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\cami\\iplikci.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Alaaddin Cami; bu cami Alaaddin tepesi üzerinde bulunmaktadır. 1220 yılında inşa edilmiştir. Konya'nın en büyük camisidir ve hükümdarlar tarafından genişletilmiştir. Caminin bahçesine baktığınızda pek çok kümbet görebilirsiniz.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\cami\\aladdin.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Kapu Cami; 1568 yılında Eski Odun Pazarı semtinde inşa edilmiştir. İki defa yıkılmış, bir defa da yanmıştır. 1868 yılında ise bugünkü halini almıştır. Osmanlı Devleti döneminde Konya' da inşa edilen en büyük camidir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\cami\\kapu.jpg";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Eşrefoğlu Cami; Konya'nın Beyşehir ilçesinde bulunan bu cami ahşap direkli camilerin en büyüğü olarak bilinir. 2012 senesinde UNESCO tarafından Dünya Mirası Geçici Listesi'ne alınmıştır. Farklı zamanlarda tamir görmüştür ve kimin ne zaman yaptırdığı bilinmemektedir.";
            pictureBox1.ImageLocation = "C:\\Users\\bekoo\\Desktop\\DOSYA\\C# Uygulama\\Şehir Turu\\cami\\esrefoglu.jpg";
        }
    }
}
