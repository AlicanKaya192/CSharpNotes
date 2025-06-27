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
    public partial class Degiskenler_Double4 : Form
    {
        public Degiskenler_Double4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;

            s1 = 60;
            s2 = 70;
            s3 = 79;
            ort = (s1 + s2 + s3) / 3;

            label1.Text = ort.ToString("0.00");

            double sayi1 = Convert.ToDouble(textBox1.Text);

            label2.Text = sayi1.ToString();
        }
    }
}
