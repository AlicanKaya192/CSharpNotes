namespace EntityOrnek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPhoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLectureList = new System.Windows.Forms.Button();
            this.BtnLectureDelete = new System.Windows.Forms.Button();
            this.BtnLectureAdd = new System.Windows.Forms.Button();
            this.TxtLectureName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLectureID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtNoteID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnNoteProcedure = new System.Windows.Forms.Button();
            this.BtnNoteList = new System.Windows.Forms.Button();
            this.BtnNoteUpdate = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAvg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1110, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnStudentList.Location = new System.Drawing.Point(181, 281);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(155, 39);
            this.BtnStudentList.TabIndex = 1;
            this.BtnStudentList.Text = "Student List";
            this.BtnStudentList.UseVisualStyleBackColor = false;
            this.BtnStudentList.Click += new System.EventHandler(this.BtnStudentList_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.Location = new System.Drawing.Point(181, 225);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(155, 39);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Student Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(12, 225);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(155, 39);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Student Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BtnUpdate.Location = new System.Drawing.Point(12, 281);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(155, 39);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Student Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnFind.Location = new System.Drawing.Point(97, 326);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(155, 39);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "Student Find";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPhoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.BtnFind);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnStudentList);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.TxtStudentID);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 369);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // TxtPhoto
            // 
            this.TxtPhoto.Location = new System.Drawing.Point(136, 163);
            this.TxtPhoto.Name = "TxtPhoto";
            this.TxtPhoto.Size = new System.Drawing.Size(194, 29);
            this.TxtPhoto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "PHOTO :";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(136, 118);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(194, 29);
            this.TxtSurname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "SURNAME :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(136, 73);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(194, 29);
            this.TxtName.TabIndex = 17;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "NAME :";
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Location = new System.Drawing.Point(136, 28);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(194, 29);
            this.TxtStudentID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLectureList);
            this.groupBox2.Controls.Add(this.BtnLectureDelete);
            this.groupBox2.Controls.Add(this.BtnLectureAdd);
            this.groupBox2.Controls.Add(this.TxtLectureName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtLectureID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(380, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 264);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lectures";
            // 
            // BtnLectureList
            // 
            this.BtnLectureList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLectureList.Location = new System.Drawing.Point(136, 213);
            this.BtnLectureList.Name = "BtnLectureList";
            this.BtnLectureList.Size = new System.Drawing.Size(194, 39);
            this.BtnLectureList.TabIndex = 9;
            this.BtnLectureList.Text = "Lecture List";
            this.BtnLectureList.UseVisualStyleBackColor = false;
            this.BtnLectureList.Click += new System.EventHandler(this.BtnLectureList_Click);
            // 
            // BtnLectureDelete
            // 
            this.BtnLectureDelete.BackColor = System.Drawing.Color.Red;
            this.BtnLectureDelete.Location = new System.Drawing.Point(136, 168);
            this.BtnLectureDelete.Name = "BtnLectureDelete";
            this.BtnLectureDelete.Size = new System.Drawing.Size(194, 39);
            this.BtnLectureDelete.TabIndex = 19;
            this.BtnLectureDelete.Text = "Lecture Delete";
            this.BtnLectureDelete.UseVisualStyleBackColor = false;
            this.BtnLectureDelete.Click += new System.EventHandler(this.BtnLectureDelete_Click);
            // 
            // BtnLectureAdd
            // 
            this.BtnLectureAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnLectureAdd.Location = new System.Drawing.Point(136, 123);
            this.BtnLectureAdd.Name = "BtnLectureAdd";
            this.BtnLectureAdd.Size = new System.Drawing.Size(194, 39);
            this.BtnLectureAdd.TabIndex = 18;
            this.BtnLectureAdd.Text = "Lecture Add";
            this.BtnLectureAdd.UseVisualStyleBackColor = false;
            this.BtnLectureAdd.Click += new System.EventHandler(this.BtnLectureAdd_Click);
            // 
            // TxtLectureName
            // 
            this.TxtLectureName.Location = new System.Drawing.Point(136, 73);
            this.TxtLectureName.Name = "TxtLectureName";
            this.TxtLectureName.Size = new System.Drawing.Size(194, 29);
            this.TxtLectureName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "NAME :";
            // 
            // TxtLectureID
            // 
            this.TxtLectureID.Location = new System.Drawing.Point(136, 28);
            this.TxtLectureID.Name = "TxtLectureID";
            this.TxtLectureID.Size = new System.Drawing.Size(194, 29);
            this.TxtLectureID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtNoteID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.BtnNoteProcedure);
            this.groupBox3.Controls.Add(this.BtnNoteList);
            this.groupBox3.Controls.Add(this.BtnNoteUpdate);
            this.groupBox3.Controls.Add(this.TxtStatus);
            this.groupBox3.Controls.Add(this.BtnCalculate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtAvg);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtExam3);
            this.groupBox3.Controls.Add(this.TxtExam2);
            this.groupBox3.Controls.Add(this.TxtExam1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(747, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 385);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // TxtNoteID
            // 
            this.TxtNoteID.Location = new System.Drawing.Point(133, 28);
            this.TxtNoteID.Name = "TxtNoteID";
            this.TxtNoteID.Size = new System.Drawing.Size(194, 29);
            this.TxtNoteID.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "NOTE ID :";
            // 
            // BtnNoteProcedure
            // 
            this.BtnNoteProcedure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNoteProcedure.Location = new System.Drawing.Point(6, 335);
            this.BtnNoteProcedure.Name = "BtnNoteProcedure";
            this.BtnNoteProcedure.Size = new System.Drawing.Size(151, 39);
            this.BtnNoteProcedure.TabIndex = 26;
            this.BtnNoteProcedure.Text = "Procedure";
            this.BtnNoteProcedure.UseVisualStyleBackColor = false;
            this.BtnNoteProcedure.Click += new System.EventHandler(this.BtnNoteProcedure_Click);
            // 
            // BtnNoteList
            // 
            this.BtnNoteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnNoteList.Location = new System.Drawing.Point(6, 290);
            this.BtnNoteList.Name = "BtnNoteList";
            this.BtnNoteList.Size = new System.Drawing.Size(151, 39);
            this.BtnNoteList.TabIndex = 10;
            this.BtnNoteList.Text = "Note List";
            this.BtnNoteList.UseVisualStyleBackColor = false;
            this.BtnNoteList.Click += new System.EventHandler(this.BtnNoteList_Click);
            // 
            // BtnNoteUpdate
            // 
            this.BtnNoteUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BtnNoteUpdate.Location = new System.Drawing.Point(163, 335);
            this.BtnNoteUpdate.Name = "BtnNoteUpdate";
            this.BtnNoteUpdate.Size = new System.Drawing.Size(183, 39);
            this.BtnNoteUpdate.TabIndex = 12;
            this.BtnNoteUpdate.Text = "Exam Note Update";
            this.BtnNoteUpdate.UseVisualStyleBackColor = false;
            this.BtnNoteUpdate.Click += new System.EventHandler(this.BtnNoteUpdate_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(133, 249);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(194, 29);
            this.TxtStatus.TabIndex = 25;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCalculate.Location = new System.Drawing.Point(163, 290);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(183, 39);
            this.BtnCalculate.TabIndex = 11;
            this.BtnCalculate.Text = "AVG Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "STATUS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "EXAM 3 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "EXAM 2 :";
            // 
            // TxtAvg
            // 
            this.TxtAvg.Location = new System.Drawing.Point(133, 203);
            this.TxtAvg.Name = "TxtAvg";
            this.TxtAvg.Size = new System.Drawing.Size(194, 29);
            this.TxtAvg.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "AVG :";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(133, 158);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(194, 29);
            this.TxtExam3.TabIndex = 19;
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(133, 113);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(194, 29);
            this.TxtExam2.TabIndex = 17;
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(133, 68);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(194, 29);
            this.TxtExam1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "EXAM 1 :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1131, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(188, 28);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sort by Name A - Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(1192, 481);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(177, 49);
            this.BtnLinqEntity.TabIndex = 10;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1131, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(188, 28);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sort by Name Z - A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1131, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 28);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "First 3 Records";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1131, 124);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(192, 28);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fetch Data by ID (5)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1131, 158);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(249, 28);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Get Names Starting With A";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1131, 192);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(248, 28);
            this.radioButton6.TabIndex = 15;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Get Names Ending With A";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(1131, 226);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(238, 28);
            this.radioButton7.TabIndex = 16;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Is There Value? (CLUBS)";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(1131, 260);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(241, 28);
            this.radioButton8.TabIndex = 17;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Total Number of Students";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(1131, 294);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(193, 28);
            this.radioButton9.TabIndex = 18;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Exam 1 Total Score";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(1131, 328);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(233, 28);
            this.radioButton10.TabIndex = 19;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Exam1 AVG Total Score";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(1131, 362);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(344, 28);
            this.radioButton11.TabIndex = 20;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Higher than the Exam Grade Average";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(1131, 396);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(161, 28);
            this.radioButton12.TabIndex = 21;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Highest Exam 1";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(1131, 430);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(156, 28);
            this.radioButton13.TabIndex = 22;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Lowest Exam 1";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Form2 LinQ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton13);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtLectureName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLectureID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtAvg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnLectureList;
        private System.Windows.Forms.Button BtnNoteList;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNoteUpdate;
        private System.Windows.Forms.Button BtnLectureAdd;
        private System.Windows.Forms.Button BtnLectureDelete;
        private System.Windows.Forms.Button BtnNoteProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.TextBox TxtNoteID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

