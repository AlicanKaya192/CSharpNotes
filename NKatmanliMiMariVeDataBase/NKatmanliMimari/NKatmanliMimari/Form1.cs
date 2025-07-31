using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using EntityLayer;
using DataAccessLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityEmployee> EmployeeList = LogicEmployee.LLEmployeeList();
            dataGridView1.DataSource = EmployeeList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityEmployee ent = new EntityEmployee();
            ent.Name = TxtName.Text;
            ent.Surname = TxtSurname.Text;
            ent.City = TxtCity.Text;
            ent.Duty = TxtDuty.Text;
            ent.Salary = short.Parse(TxtSalary.Text);
            LogicEmployee.LLEmployeeAdd(ent);
            BtnList.PerformClick();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityEmployee ent = new EntityEmployee();
            ent.Id = int.Parse(TxtID.Text);
            LogicEmployee.LLEmployeeDelete(ent.Id);
            BtnList.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnList.PerformClick();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityEmployee ent = new EntityEmployee();
            ent.Id = int.Parse(TxtID.Text);
            ent.Name = TxtName.Text;
            ent.Surname = TxtSurname.Text;
            ent.City = TxtCity.Text;
            ent.Duty = TxtDuty.Text;
            ent.Salary = short.Parse(TxtSalary.Text);
            LogicEmployee.LLEmployeeUpdate(ent);
            BtnList.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;

            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtDuty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
