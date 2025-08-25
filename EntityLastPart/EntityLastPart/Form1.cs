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
        }
    } 
}
