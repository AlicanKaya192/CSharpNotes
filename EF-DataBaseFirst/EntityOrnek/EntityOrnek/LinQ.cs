using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class LinQ : Form
    {
        public LinQ()
        {
            InitializeComponent();
        }

        DbExamStudentEntities db = new DbExamStudentEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var values = from x in db.Notes
                            where x.Exam1 < 50
                            select new
                            {
                                x.NoteID,
                                Student = x.Student.NAME + " " + x.Student.SURNAME,
                                x.Lectures.LectureName,
                                x.Exam1,
                                x.Exam2,
                                x.Exam3,
                                x.Average,
                                Status = x.Status == true ? "Passed" : "Failed"
                            };

                //var values = db.Notes.Select(x => new
                //{
                //    x.NoteID,
                //    Student = x.Student.NAME + " " + x.Student.SURNAME,
                //    x.Lectures.LectureName,
                //    x.Exam1,
                //    x.Exam2,
                //    x.Exam3,
                //    x.Average,
                //    Status = x.Status == true ? "Passed" : "Failed"
                //});

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var ali = from x in db.Student
                          where x.NAME == "Ali"
                          select new
                          {
                              x.ID,
                              x.NAME,
                              x.SURNAME,
                              x.PHOTO
                          };

                // var ali = Db.Student.Where(x => x.NAME == "Ali");

                dataGridView1.DataSource = ali.ToList();
            }
            if (radioButton3.Checked == true)
            {
                var findStudent = from x in db.Student
                                  where x.NAME == textBox1.Text || x.SURNAME == textBox1.Text
                                  select new
                                  {
                                      x.ID,
                                      x.NAME,
                                      x.SURNAME,
                                      x.PHOTO
                                  };

                // var findStudent = db.Student.Where(x => x.NAME == textBox1.Text || x.SURNAME == textBox1.Text);

                dataGridView1.DataSource = findStudent.ToList();
            }
            if (radioButton4.Checked == true)
            {
                var values = db.Student.Select(x => new { surname = x.SURNAME });

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton5.Checked == true)
            {
                var values = db.Student.Select(x => new { NAME = x.NAME.ToUpper(), SURNAME = x.SURNAME.ToLower() });

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var values = db.Notes.Select(x => new 
                { 
                    Student = x.Student.NAME + " " + x.Student.SURNAME,
                    x.Exam1,
                    x.Exam2,
                    x.Exam3,
                    x.Average,
                    Status = x.Status == true ? "Passed" : "Failed"
                });

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton7.Checked== true)
            {
                var values = db.Notes.SelectMany(x => db.Student.Where(y => y.ID == x.StudentID), (x,y) => 
                    new
                    {
                        y.NAME,
                        x.Average
                    });

                dataGridView1.DataSource= values.ToList();
            }
            if (radioButton8.Checked == true)
            {
                var values = db.Student.OrderBy(x => x.ID).Take(3);

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton9.Checked == true)
            {
                var values = db.Student.OrderByDescending(x => x.ID).Take(3);

                dataGridView1.DataSource = values.ToList();
            }
            if ( radioButton10.Checked == true)
            {
                var values = db.Student.OrderBy(x => x.NAME);

                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton11.Checked == true)
            {
                var values = db.Student.OrderByDescending(x => x.ID).Skip(3);

                dataGridView1.DataSource = values.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
