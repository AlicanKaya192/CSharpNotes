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
    public partial class Degiskenler_Islem3 : Form
    {
        public Degiskenler_Islem3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bolum;

            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            bolum = sayi1 / sayi2;

            MessageBox.Show("Toplam : " + toplam + "\n" + "Fark : " + fark + "\n" + "Carpim : " + carpim + "\n" + "Bolum : " + bolum);
        }
    }
}
