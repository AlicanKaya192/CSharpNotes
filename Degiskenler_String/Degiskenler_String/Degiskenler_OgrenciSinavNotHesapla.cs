using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class Degiskenler_OgrenciSinavNotHesapla : Form
    {
        public Degiskenler_OgrenciSinavNotHesapla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            decimal ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + proje) / 3;

            listBox1.Items.Add(ad + " " + soyad + " Ortalama : " + ortalama);
        }
    }
}
