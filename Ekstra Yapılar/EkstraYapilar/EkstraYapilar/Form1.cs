﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int s1, s2, s3;
            //s1 = rnd.Next(1, 5);
            //s2 = rnd.Next(1, 5);
            //s3 = rnd.Next(1, 5);

            //label1.Text = s1.ToString();
            //label2.Text = s2.ToString();
            //label3.Text = s3.ToString();

            // MINI SAYISAL LOTO

            Random rnd = new Random();
            int s1, s2, s3, s4;

            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);
            s4 = rnd.Next(1, 5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();


            // sayi1
            if (textBox1.Text == s1.ToString())
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            // sayi2
            if (textBox2.Text == s2.ToString())
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            // sayi3
            if (textBox3.Text == s3.ToString())
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            // sayi4
            if (textBox4.Text == s4.ToString())
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Captcha fr2 = new Captcha();
            fr2.Show();
            this.Hide();
        }
    }
}
