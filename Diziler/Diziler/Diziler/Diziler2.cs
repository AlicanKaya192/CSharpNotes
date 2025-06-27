using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Diziler2 : Form
    {
        public Diziler2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cities = { "Ankara","Istanbul","Bursa","Adana","Antalya"};

            for (int i = 0; i < cities.Length; i++)
            {
                listBox1.Items.Add(cities[i]);
            }
        }
    }
}
