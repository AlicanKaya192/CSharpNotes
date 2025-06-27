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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad,soyad,yas,meslek;
            
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox4.Text;

            listBox1.Items.Add("Ad: " + ad + "Soyad: " + soyad + "Yas: " + yas + "Meslek: " + meslek);
        }
    }
}
