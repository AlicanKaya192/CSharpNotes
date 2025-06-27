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
    public partial class Alisveris_Indirim_Tutar_Hesaplama : Form
    {
        public Alisveris_Indirim_Tutar_Hesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapAdet;
            double toplam;

            kitapAdet = Convert.ToInt32(textBox1.Text);
            
            if(kitapAdet >= 0 && kitapAdet <= 20)
            {
                toplam = (kitapAdet * 8.0) - (kitapAdet * 8 * 0.20);
                label3.Text = toplam.ToString("0.00") + " TL";
            }
            else if (kitapAdet >= 21 && kitapAdet <= 40)
            {
                toplam = (kitapAdet * 8.0) - (kitapAdet * 8 * 0.40);
                label3.Text = toplam.ToString("0.00") + " TL";
            }
            else if (kitapAdet >= 41 && kitapAdet <= 60)
            {
                toplam = (kitapAdet * 8.0) - (kitapAdet * 8 * 0.60);
                label3.Text = toplam.ToString("0.00") + " TL";
            }
            else if (kitapAdet >= 61 && kitapAdet <= 80)
            {
                toplam = (kitapAdet * 8.0) - (kitapAdet * 8 * 0.80);
                label3.Text = toplam.ToString("0.00") + " TL";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir adet giriniz.");
            }
        }
    }
}
