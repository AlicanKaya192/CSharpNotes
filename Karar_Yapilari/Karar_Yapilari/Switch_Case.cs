﻿using System;
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
    public partial class Switch_Case : Form
    {
        public Switch_Case()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text.ToLower();

            switch (mevsim)
            {
                case "yaz":
                    label2.Text = "Haziran, Temmuz, Ağustos";
                    break;
                case "sonbahar":
                    label2.Text = "Eylül, Ekim, Kasım";
                    break;
                case "kış":
                    label2.Text = "Aralık, Ocak, Şubat";
                    break;
                case "ilkbahar":
                    label2.Text = "Mart, Nisan, Mayıs";
                    break;
                default:
                    label2.Text = "Yanlış Mevsim Girdiniz";
                    break;
            }

            //int ay = Convert.ToInt16(textBox1.Text);

            //switch(ay)
            //{
            //    case 1:
            //        label2.Text = "Ocak";
            //        break;
            //    case 2:
            //        label2.Text = "Şubat";
            //        break;
            //    case 3:
            //        label2.Text = "Mart";
            //        break;
            //    case 4:
            //        label2.Text = "Nisan";
            //        break;
            //    case 5:
            //        label2.Text = "Mayıs";
            //        break;
            //    case 6:
            //        label2.Text = "Haziran";
            //        break;
            //    case 7:
            //        label2.Text = "Temmuz";
            //        break;
            //    case 8:
            //        label2.Text = "Ağustos";
            //        break;
            //    case 9:
            //        label2.Text = "Eylül";
            //        break;
            //    case 10:
            //        label2.Text = "Ekim";
            //        break;
            //    case 11:
            //        label2.Text = "Kasım";
            //        break;
            //    case 12:
            //        label2.Text = "Aralık";
            //        break;
            //    default:
            //        label2.Text = "Yanlış Ay Girdiniz";
            //        break;
            //}
        }
    }
}
