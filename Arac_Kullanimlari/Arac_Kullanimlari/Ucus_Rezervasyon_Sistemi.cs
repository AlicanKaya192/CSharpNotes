using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Ucus_Rezervasyon_Sistemi : Form
    {
        public Ucus_Rezervasyon_Sistemi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + " ' dan " + comboBox2.Text + " 'ya " + " Tarih : " + dateTimePicker1.Text + " Saat : " + maskedTextBox1.Text + " Yolcu Adi : " + textBox1.Text + " Yolcu TC : " + maskedTextBox2.Text + " Yolcu Telefon : " + maskedTextBox3.Text);
            MessageBox.Show("Uçuş Rezervasyonu Başarıyla Yapılmıştır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;    
            comboBox1.Text = label9.Text;
        }
    }
}
