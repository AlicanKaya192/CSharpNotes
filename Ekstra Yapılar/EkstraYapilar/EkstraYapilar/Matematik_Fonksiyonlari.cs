using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class Matematik_Fonksiyonlari : Form
    {
        public Matematik_Fonksiyonlari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);

            label2.Text = Math.Abs(sayi).ToString();

            // label2.Text = Math.Ceiling(sayi).ToString();
            // label2.Text = Math.Floor(sayi).ToString();
            // label2.Text = Math.Pow(sayi, 2).ToString(); // Üs alma işlemi (sayı^2)
            // label2.Text = Math.Sqrt(sayi).ToString(); // Karekök alma işlemi
            // label2.Text = Math.PI.ToString(); // Pi sayısı
            // label2.Text = Math.Cos(sayi).ToString(); // Kosinüs hesaplama işlemi
        }
    }
}

/*
 * Abs = Mutlak Değer
 * Ceil = Yukarı Yuvarlama
 * Floor = Aşağı Yuvarlama
 * Pow = Üs Alma
 * Sqrt = Karekök Alma
 * PI = Pi Sayısı (3.14...)
 * Cos = Kosinüs
 */