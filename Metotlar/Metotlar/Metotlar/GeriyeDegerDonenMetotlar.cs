using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class GeriyeDegerDonenMetotlar : Form
    {
        public GeriyeDegerDonenMetotlar()
        {
            InitializeComponent();
        }

        int Topla(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Topla(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)).ToString();
        }
    }
}
