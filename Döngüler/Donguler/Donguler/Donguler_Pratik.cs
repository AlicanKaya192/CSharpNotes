using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Donguler_Pratik : Form
    {
        public Donguler_Pratik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            int toplam = 1;

            for (int i = sayi; i > 1; i--)
            {
               toplam *= i;
            }

            listBox1.Items.Add(toplam);
        }
    }
}
