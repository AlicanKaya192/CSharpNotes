using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosyaİslemleri
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void PDF_Load(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog(); // OpenFileDialog nesnesi oluşturma
            if (ac.ShowDialog() == DialogResult.OK) // Kullanıcı dosya seçtiyse
            {
                axAcroPDF1.LoadFile(ac.FileName); // Seçilen dosyayı PDF kontrolüne yükleme
            }
            else
            {
                MessageBox.Show("Dosya seçilmedi.");
            }
        }
    }
}
