using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            DrawAllEmployeesGraph();
            InfoLabel.Text = "";

            dgEmplooyes.Columns.Clear();

            dgEmplooyes.Columns.Add("fullname", "ФИО");
            dgEmplooyes.Columns.Add("post", "Должность");
            dgEmplooyes.Columns.Add("salary", "Оклад");

            var list = StaffController.GetStaffEducationSort();
            foreach (Employee emp in list)
            {
                dgEmplooyes.Rows.Add(emp.FullName, emp.PositionWork, emp.Salary);
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
                $"С высшем образованием: {StaffController.CountEducationEmployees(TypeEducation.HigherProfessional)}; " +
                $"Со средним специальным {StaffController.CountEducationEmployees(TypeEducation.SecondaryVocational)}";

            DrawEducationGraph();
        }

        private void BtnRatingSalary_Click(object sender, EventArgs e)
        {
            DrawSealyGraph();

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
            DrawExperienceGraph(StaffController.GetStaffExperienceSort());

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

        private void DrawAllEmployeesGraph()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
        }

        private void DrawEducationGraph()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            string[] typeEducation = { "Школьное", "Основное общее", "Среднее профессиональное", "Высшее профессиональное" };
            int[] values =
            {
                StaffController.CountEducationEmployees(TypeEducation.Preschool),
                StaffController.CountEducationEmployees(TypeEducation.BasicGeneral),
                StaffController.CountEducationEmployees(TypeEducation.SecondaryVocational),
                StaffController.CountEducationEmployees(TypeEducation.HigherProfessional)
            };

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Образование");

            // Добавляем последовательность
            for (int i = 0; i < typeEducation.Length; i++)
            {
                Series series = chart1.Series.Add(typeEducation[i]);

                // Добавляем точку
                series.Points.Add(values[i]); 
            }
        }

        private void DrawSealyGraph()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();


        }

        private void DrawExperienceGraph(List<Employee> employees)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            if (employees.Count >= 4)
            {

                string[] typeEducation = { 
                    employees[0].FullName,
                    employees[1].FullName,
                    employees[2].FullName,
                    employees[3].FullName
                };

                float[] values =
                {
                    employees[0].Salary,
                    employees[1].Salary,
                    employees[2].Salary,
                    employees[3].Salary,
                };

                chart1.Palette = ChartColorPalette.SeaGreen;
                chart1.Titles.Add("Оклад");

                // Добавляем последовательность
                for (int i = 0; i < typeEducation.Length; i++)
                {
                    Series series = chart1.Series.Add(typeEducation[i]);

                    // Добавляем точку
                    series.Points.Add(values[i]);
                }
            }
        }
    }
}
