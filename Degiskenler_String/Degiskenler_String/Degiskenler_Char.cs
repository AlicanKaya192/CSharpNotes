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
    public partial class Degiskenler_Char : Form
    {
        public Degiskenler_Char()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char takim;
            takim = 'B';
            label1.Text = takim.ToString();

            char ders;
            ders = Convert.ToChar(textBox1.Text);

            label2.Text = ders.ToString();
        }
    }
}
