using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari
{
    public partial class Karar_Yapilari_Egzersiz : Form
    {
        public Karar_Yapilari_Egzersiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;

            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;

            if(ort >= 50)
            {
                durum = "Geçtiniz";
            }
            else
            {
                durum = "Kaldınız";
            }

            textBox4.Text = ort.ToString("0.00") + " /" + durum;
        }
    }
}
