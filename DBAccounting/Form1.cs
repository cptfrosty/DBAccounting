using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAccounting.Models;


namespace DBAccounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Employee emp1 = new Employee();
            emp1.Fullname = "Иванов Иван Иванович";
            Employee emp2 = new Employee();
            emp2.Fullname = "Иванов Сергей Петрович";
            Employee emp3 = new Employee();
            emp3.Fullname = "Лунский Павел Иванович";
            Employee emp4 = new Employee();
            emp4.Fullname = "Сергеев Иван Иванович";
            emp4.Id = 4;
            StaffController.AddEmployee(emp1);
            StaffController.AddEmployee(emp2);
            StaffController.AddEmployee(emp3);
            StaffController.AddEmployee(emp4);
        }

        private void BtnAllEmp_Click(object sender, EventArgs e)
        {
            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("post", "Должность");
            dgEmplooyes.Columns.Add("salary", "Оклад");

            var list = StaffController.GetStaffEducationSort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.Fullname, emp.GetTypeEducationTextRus());
            }
        }

        private void BtnEducation_Click(object sender, EventArgs e)
        {
            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("education", "Образование");

            var list = StaffController.GetStaffEducationSort();
            foreach (Employee emp in list) {
                dgEmplooyes.Rows.Add(emp.Fullname, emp.GetTypeEducationTextRus());
            }

        }

        private void BtnRatingSalary_Click(object sender, EventArgs e)
        {
            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("salary", "Оклад");

            var list = StaffController.GetStaffSalarySort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.Fullname, emp.Salary);
            }
        }

        private void BtnExperience_Click(object sender, EventArgs e)
        {
            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("exp", "Стаж");

            var list = StaffController.GetStaffExperienceSort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.Fullname, emp.GetExperience());
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(SearchWindow.Instance == null)
            {
                SearchWindow sw = new SearchWindow();
                sw.Show();
            }
        }
    }
}
