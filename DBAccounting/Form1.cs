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
            StaffController.DBInit();
            InfoLabel.Text = "";
        }

        private void BtnAllEmp_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";

            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("post", "Должность");
            dgEmplooyes.Columns.Add("salary", "Оклад");

            var list = StaffController.GetStaffEducationSort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.FullName, emp.GetTypeEducationTextRus());
            }
        }

        private void BtnEducation_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";

            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("education", "Образование");

            var list = StaffController.GetStaffEducationSort();
            foreach (Employee emp in list) {
                dgEmplooyes.Rows.Add(emp.FullName, emp.GetTypeEducationTextRus());
            }

            InfoLabel.Text =
                $"С высшем образованием: {StaffController.CountHigherEducation()}; " +
                $"Со средним специальным {StaffController.CountTechnicalEducation()}";
        }

        private void BtnRatingSalary_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";

            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("salary", "Оклад");

            var list = StaffController.GetStaffSalarySort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.FullName, emp.Salary);
            }
        }

        private void BtnExperience_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = "";

            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("exp", "Стаж");

            var list = StaffController.GetStaffExperienceSort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.FullName, emp.GetExperience());
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
