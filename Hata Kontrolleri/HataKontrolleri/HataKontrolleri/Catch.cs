using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataKontrolleri
{
    public partial class Catch : Form
    {
        public Catch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = "Sonuç: " + s1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata var burasi çalıştı.");
            }
            finally
            {
                MessageBox.Show("Finally bloğu çalıştı.");
            }
        }
    }
}
