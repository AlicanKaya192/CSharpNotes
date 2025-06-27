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
    public partial class TimerOrnek2 : Form
    {
        public TimerOrnek2()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();

            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
                label2.Text = dakika.ToString();
                
                if(dakika == 60)
                {
                    dakika = 0;
                    saat++;
                    label3.Text = saat.ToString();
                }
            }
        }
    }
}
