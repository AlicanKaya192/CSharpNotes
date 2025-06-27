using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinifOlusturma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();

            rb2.renk = "Turuncu";
            rb2.hiz = 200;
            rb2.motor = 125;
            rb2.durum = 'A';
            rb2.fiyat = 139159389;

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.durum.ToString();
            label5.Text = rb2.fiyat.ToString("C0"); // C0 formatı, para birimi olarak gösterir
        }
    }
}
