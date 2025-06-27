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
    public partial class ForEachDongusucs : Form
    {
        public ForEachDongusucs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali" };

            //foreach(string kisi in kisiler)
            //{
            //    listBox1.Items.Add(kisi);
            //}

            int toplam = 0;

            int[] sinavlar = { 85, 90, 78, 92, 88 };

            foreach (int sinav in sinavlar)
            {
                listBox1.Items.Add(sinav);
                toplam = toplam + sinav;
            }

            label1.Text = toplam.ToString();

            int ortalama = toplam / sinavlar.Length;

            label2.Text = ortalama.ToString();
        }
    }
}
