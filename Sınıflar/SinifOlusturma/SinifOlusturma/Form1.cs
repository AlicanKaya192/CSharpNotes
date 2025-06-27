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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Turuncu";
            rb.hiz = 200;
            rb.motor = 125;
            rb.durum = 'A';
            rb.fiyat = 139159389;
            rb.YIL = 2023;
            rb.MARKASI = "Supra";
            rb.muayene = 2025;
            rb.plaka = "34ABC123";
            rb.sahip = "Alican Kaya";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.durum.ToString();
            label5.Text = rb.fiyat.ToString("C0"); // C0 formatı, para birimi olarak gösterir
            label6.Text = "Model Yil = " + rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = "Son Muayene = " + rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;
        }
    }
}
