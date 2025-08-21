using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbExamStudentEntities db = new DbExamStudentEntities(); // Initialize the database context

        private void BtnLectureList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Lectures.ToList(); // Set the DataSource of the DataGridView to the list of Lectures
        }

        private void BtnStudentList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Student.ToList();
            dataGridView1.Columns[3].Visible = false; // Hide the Notes column
            dataGridView1.Columns[4].Visible = false; // Hide the Lectures column
        }

        private void BtnNoteList_Click(object sender, EventArgs e)
        {
            var query = from item in db.Notes // Join Notes with Student and Lectures
                        select new // Select the properties you want to display
                        {
                            item.NoteID,
                            item.Student.NAME,
                            item.Student.SURNAME,
                            Lecture = item.Lectures.LectureName,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average,
                            item.Status
                        };
            dataGridView1.DataSource = query.ToList(); // Set the DataSource of the DataGridView to the query result

            // var query = from item in db.Notes
            //             join s in db.Student on item.StudentID equals s.ID // Join Notes with Student
            //             join l in db.Lectures on item.LectureID equals l.LectureID // Join Notes with Lectures
            //             select new
            //             {
            //                 item.NoteID,
            //                 StudentName = s.NAME + " " + s.SURNAME, // Concatenate NAME and SURNAME
            //                 LectureName = l.LectureName, // Get the LectureName
            //                 item.Exam1,
            //                 item.Exam2,
            //                 item.Exam3,
            //                 item.Average,
            //                 item.Status
            //             };
            // dataGridView1.DataSource = query.ToList(); // Set the DataSource of the DataGridView to the query result
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var t = new Student(); // Create a new instance of the Student class
            t.NAME = TxtName.Text; // Set the NAME property from the text box
            t.SURNAME = TxtSurname.Text; // Set the SURNAME property from the text box
            db.Student.Add(t); // Add the new student to the context
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Student added successfully."); // Notify the user
            BtnStudentList.PerformClick(); // Refresh the student list
        }

        private void BtnLectureAdd_Click(object sender, EventArgs e)
        {
            var l = new Lectures(); // Create a new instance of the Lectures class
            l.LectureName = TxtLectureName.Text; // Set the LectureName property from the text box
            db.Lectures.Add(l); // Add the new lecture to the context
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Lecture added successfully."); // Notify the user
            BtnLectureList.PerformClick(); // Refresh the lecture list
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var x = db.Student.Find(Convert.ToInt32(TxtStudentID.Text)); // Find the student by ID
            db.Student.Remove(x); // Remove the student from the context
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Student deleted successfully."); // Notify the user
            BtnStudentList.PerformClick(); // Refresh the student list
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var x = db.Student.Find(Convert.ToInt32(TxtStudentID.Text)); // Find the student by ID
            x.NAME = TxtName.Text; // Update the NAME property from the text box
            x.SURNAME = TxtSurname.Text; // Update the SURNAME property from the text box
            x.PHOTO = TxtPhoto.Text; // Update the PHOTO property from the text box
            db.SaveChanges(); // Save changes to the database
            BtnStudentList.PerformClick(); // Refresh the student list
            MessageBox.Show("Student updated successfully."); // Notify the user
        }

        private void BtnLectureDelete_Click(object sender, EventArgs e)
        {
            var x = db.Lectures.Find(Convert.ToInt32(TxtLectureID.Text)); // Find the lecture by ID
            db.Lectures.Remove(x); // Remove the lecture from the context
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Lecture deleted successfully."); // Notify the user
            BtnLectureList.PerformClick(); // Refresh the lecture list
        }

        private void BtnNoteProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NoteList(); // Call the stored procedure NoteList
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Student.Where(x => x.NAME == TxtName.Text | x.SURNAME == TxtSurname.Text).ToList(); // Find students by name or surname
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No students found with the given name or surname."); // Notify the user if no students are found
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string wantedValue = TxtName.Text;
            var values = from item in db.Student
                         where item.NAME.Contains(wantedValue) // Filter students by name containing the wanted value
                         select item;
            dataGridView1.DataSource = values.ToList(); // Update the DataGridView with the list of students
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==  true)
            {
                List<Student> list1 = db.Student.OrderBy(p => p.NAME).ToList(); // Get all students from the database
                dataGridView1.DataSource = list1; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton2.Checked == true)
            {
                List<Student> list2 = db.Student.OrderByDescending(p => p.NAME).ToList(); // Get all students from the database in descending order
                dataGridView1.DataSource = list2; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton3.Checked == true)
            {
                List<Student> list3 = db.Student.OrderBy(p => p.NAME).Take(3).ToList(); // Get the first 3 students from the database
                dataGridView1.DataSource = list3; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton4.Checked == true)
            {
                List<Student> list4 = db.Student.Where(p => p.ID == 5).ToList(); // Get the student with ID 5 from the database
                dataGridView1.DataSource = list4; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton5.Checked == true)
            {
                List<Student> list5 = db.Student.Where(p => p.NAME.StartsWith("a")).ToList(); // Get students whose name contains 'a'
                dataGridView1.DataSource = list5; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton6.Checked == true)
            {
                List<Student> list6 = db.Student.Where(p => p.NAME.EndsWith("a")).ToList(); // Get students whose name contains 'a'
                dataGridView1.DataSource = list6; // Set the DataSource of the DataGridView to the list of students
            }
            if (radioButton7.Checked == true)
            {
                bool value = db.CLUBS.Any(); // Check if there are any students in the database
                MessageBox.Show(value.ToString(), "Information", MessageBoxButtons.OK,MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton8.Checked == true)
            {
               int count = db.Student.Count(); // Count the number of students in the database
               MessageBox.Show(count.ToString(), "Total Number of Students", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton9.Checked == true)
            {
                var score = db.Notes.Sum(p => p.Exam1); // Calculate the sum of Exam1 scores
                MessageBox.Show(score.ToString(), "Total Exam1 Score", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton10.Checked == true)
            {
                var avg = db.Notes.Average(p => p.Exam1); // Calculate the average of Exam1, Exam2, and Exam3 scores
                MessageBox.Show(avg.ToString(), "Average Exam Score", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton11.Checked == true)
            {
                var avg = db.Notes.Average(p => p.Exam1); // Calculate the average of Exam1 scores

                var x = from z in db.Notes
                        where z.Exam1 > avg // Filter notes where Exam1 score is greater than the average
                        select new
                        {
                           z.NoteID,
                           Student = z.Student.NAME + " " + z.Student.SURNAME,
                           z.Lectures.LectureName,
                           z.Exam1,
                        };

                dataGridView1.DataSource = x.ToList(); // Set the DataSource of the DataGridView to the list of notes
                MessageBox.Show("Notes with Exam1 score greater than average have been listed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton12.Checked == true)
            {
                var highestExam1 = db.Notes.Max(p => p.Exam1); // Find the highest Exam1 score
                var x = from z in db.Notes
                        where z.Exam1 == highestExam1 // Filter notes where Exam1 score is equal to the highest score
                        select new
                        {
                            z.NoteID,
                            Student = z.Student.NAME + " " + z.Student.SURNAME,
                            z.Lectures.LectureName,
                            z.Exam1,
                        };
                dataGridView1.DataSource = x.ToList(); // Set the DataSource of the DataGridView to the list of notes
                MessageBox.Show("Notes with the highest Exam1 score have been listed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
            if (radioButton13.Checked == true)
            {
                var lowestExam1 = db.Notes.Min(p => p.Exam1); // Find the highest Exam1 score
                var x = from z in db.Notes
                        where z.Exam1 == lowestExam1 // Filter notes where Exam1 score is equal to the highest score
                        select new
                        {
                            z.NoteID,
                            Student = z.Student.NAME + " " + z.Student.SURNAME,
                            z.Lectures.LectureName,
                            z.Exam1,
                        };
                dataGridView1.DataSource = x.ToList(); // Set the DataSource of the DataGridView to the list of notes
                MessageBox.Show("Notes with the lowest Exam1 score have been listed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notify the user
            }
        }

        private void BtnNoteUpdate_Click(object sender, EventArgs e)
        {
            var examID = db.Notes.Find(Convert.ToInt32(TxtNoteID.Text)); // Find the note by ID
            examID.Exam1 = Convert.ToByte(TxtExam1.Text); // Update the Exam1 score from the text box
            examID.Exam2 = Convert.ToByte(TxtExam2.Text); // Update the Exam2 score from the text box
            examID.Exam3 = Convert.ToByte(TxtExam3.Text); // Update the Exam3 score from the text box
            examID.Average = (examID.Exam1 + examID.Exam2 + examID.Exam3) / 3; // Calculate the average score
            examID.Status = Convert.ToBoolean(examID.Average >= 50 ? "True" : "False"); // Determine the status based on the average score
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Note updated successfully."); // Notify the user
            BtnNoteList.PerformClick(); // Refresh the note list
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var calculate = db.Notes.Find(Convert.ToInt32(TxtNoteID.Text)); // Find the note by ID
            calculate.Average = (calculate.Exam1 + calculate.Exam2 + calculate.Exam3) / 3; // Calculate the average score
            calculate.Status = Convert.ToBoolean(calculate.Average >= 50 ? "True" : "False"); // Determine the status based on the average score
            db.SaveChanges(); // Save changes to the database
            MessageBox.Show("Average and status calculated successfully."); // Notify the user
            BtnNoteList.PerformClick(); // Refresh the note list
        }
    }
}
