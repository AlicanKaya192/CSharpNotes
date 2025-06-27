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
    public partial class Donguler_Do_while : Form
    {
        public Donguler_Do_while()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            do
            {
                listBox1.Items.Add("Merhaba Dunya");
                i++;
            } while (i <= 10);
        }
    }
}
