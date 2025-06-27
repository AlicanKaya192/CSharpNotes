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
    public partial class Degiskenler_Int : Form
    {
        public Degiskenler_Int()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar,uzunKenar,alan,cevre;

            kisaKenar = 10;
            uzunKenar = 20;
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);

            label1.Text = "Alan: " + alan + " Cevre: " + cevre;
        }
    }
}
