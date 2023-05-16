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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            CbEducation.Items.Add(Models.TypeEducation.Preschool); //0
            CbEducation.Items.Add(Models.TypeEducation.BasicGeneral); //1
            CbEducation.Items.Add(Models.TypeEducation.SecondaryVocational); //2
            CbEducation.Items.Add(Models.TypeEducation.HigherProfessional); //3

            CbEducation.SelectedIndex = 1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Models.Employee employee = new Models.Employee();

            employee.FullName = TbFullName.Text;
            employee.SetIntEducation(CbEducation.SelectedIndex);
            employee.PositionWork = TbPositionWork.Text;
            employee.AdmissionWork = DTPAdmissionWork.Value;

            try
            {
                employee.Salary = float.Parse(TbSalary.Text);

                Database.Database.InsertDataEmployee(employee);
                StaffController.DBInit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно указано значение заработной платы");
            }
        }
    }
}
