using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAccounting
{
    public partial class InfoUser : Form
    {
        public static InfoUser Instance;

        private Models.Employee _employee;
        public InfoUser(Models.Employee employee)
        {
            _employee = employee;
            Instance = this;
            InitializeComponent();

            CbEducation.Items.Add(Models.TypeEducation.Preschool); //0
            CbEducation.Items.Add(Models.TypeEducation.BasicGeneral); //1
            CbEducation.Items.Add(Models.TypeEducation.SecondaryVocational); //2
            CbEducation.Items.Add(Models.TypeEducation.HigherProfessional); //3

            TbFullName.Text = _employee.FullName;
            CbEducation.SelectedItem = _employee.Education;
            TbPositionWork.Text = _employee.PositionWork;
            DTPAdmissionWork.Value = _employee.AdmissionWork;
            TbSalary.Text = _employee.Salary.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _employee.FullName = TbFullName.Text;
            _employee.SetIntEducation(CbEducation.SelectedIndex);
            _employee.PositionWork = TbPositionWork.Text;
            _employee.AdmissionWork = DTPAdmissionWork.Value;
            try
            {
                _employee.Salary = float.Parse(TbSalary.Text);

                Database.Database.UpdateDataEmployee(_employee);
            }catch(Exception ex)
            {
                MessageBox.Show("Неверно указано значение заработной платы");
            }
        }
    }
}
