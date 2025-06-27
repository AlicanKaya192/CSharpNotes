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
    public partial class PastaPisirmeSureci : Form
    {
        public PastaPisirmeSureci()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if(progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Red;
            }

            else if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Green;
            }
            
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
                MessageBox.Show("Pasta Pişirme Tamamlandı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;

            if (progressBar2.Value % 10 == 0)
            {
                label1.BackColor = Color.Green;
            }

            else if (progressBar2.Value % 10 == 5)
            {
                label1.BackColor = Color.Red;
            }

            if(progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
                MessageBox.Show("Çırpma İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;

            if(progressBar3.Value % 40 == 20)
            {
                label1.BackColor = Color.Red;
            }

            else if (progressBar3.Value % 40 == 0)
            {
                label1.BackColor = Color.Green;
            }

            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
                MessageBox.Show("Malzemeler Eklendi ve Karıştırıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 5;

            if (progressBar4.Value % 10 == 0)
            {
                label1.BackColor = Color.Green;
            }
            else if (progressBar4.Value % 10 == 5)
            {
                label1.BackColor = Color.Red;
            }

            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pasta Hazır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
