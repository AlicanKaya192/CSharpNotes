using System;
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
    public partial class FormlarArasıVeriTasima : Form
    {
        public FormlarArasıVeriTasima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormlarArasiVeriTasima2 frm = new FormlarArasiVeriTasima2();
            frm.Show();
            this.Hide();

            frm.kimden = textBox1.Text;
            frm.mesaj = textBox2.Text;
        }
    }
}
