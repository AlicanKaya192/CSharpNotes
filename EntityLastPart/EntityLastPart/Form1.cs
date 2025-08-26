using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLastPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbExamStudentEntities db = new DbExamStudentEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.Students.OrderBy(x => x.City).GroupBy(y => y.City).Select(z => new
            {
                City = z.Key,
                Count = z.Count()
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = db.Notes.Max(x => x.Average).ToString(); // En yüksek ortalama
            label2.Text = db.Notes.Min(x => x.Exam1).ToString(); // En düşük ortalama
            label3.Text = db.Notes.Where(x => x.Status == false).Max(x => x.Average).ToString(); // Kalan öğrencilerin en yüksek ortalaması
            label4.Text = db.Products.Count().ToString(); // Ürün sayısı
            label5.Text = db.Products.Sum(x => x.STOCK).ToString(); // Toplam stok
            label6.Text = db.Products.Where(x => x.NAME == "Freezer").Sum(x => x.STOCK).ToString(); // Buzdolabındaki toplam stok
            label7.Text = db.Products.Where(x => x.NAME == "Freezer").Average(x => x.PRICE).ToString(); // Buzdolabındaki ortalama fiyat
            label8.Text = db.Products.Where(x => x.STOCK == db.Products.Max(y => y.STOCK)).Select(z => z.NAME).FirstOrDefault(); // En yüksek stoklu ürün adı

            //label8.Text =  (from x in db.Products
            //               orderby x.STOCK descending
            //               select x.NAME).First();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ClubList().ToList();
        }
    }
}
