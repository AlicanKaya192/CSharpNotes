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
    public partial class Metin_Belge_Kayit : Form
    {
        public Metin_Belge_Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Belgeleri (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*"; // Dosya kaydetme penceresini filtreler
            saveFileDialog1.Title = "Metin Belgesi Kaydet"; // Dosya kaydetme penceresinin başlığını ayarlar
            saveFileDialog1.ShowDialog(); // Dosya kaydetme penceresini açar
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName); // Seçilen dosyaya yazmak için StreamWriter oluşturur
            sw.WriteLine(richTextBox1.Text); // TextBox içeriğini dosyaya yazar
            sw.Close(); // Dosyayı kapatır
            MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kullanıcıya bilgi mesajı gösterir
        }
    }
}
