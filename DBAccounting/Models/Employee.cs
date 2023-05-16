using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccounting.Models
{
    public enum TypeEducation
    {
        Preschool = 0, //Школьное
        BasicGeneral = 1, //Основное общее
        SecondaryVocational = 2, //Среднее профессиональное  
        HigherProfessional = 3 //Высшее профессиональное 
    }

    public class Employee
    {
        public long Id { get; set; }
        public string FullName { get; set; } //ФИО
        public TypeEducation Education { get; set; } //Образование
        public string PositionWork { get; set; } //Должность
        public DateTime AdmissionWork { get; set; } //Дата поступления на работу
        public float Salary { get; set; } //Оклад

        public void SetIntEducation(long value)
        {
            Education = (TypeEducation)value;
        }

        public string GetTypeEducationTextRus()
        {
            string res = "";
            switch (Education)
            {
                case TypeEducation.Preschool:
                    res = "Дошкольное образование";
                    break;
                case TypeEducation.BasicGeneral:
                    res = "Основное общее образование";
                    break;
                case TypeEducation.SecondaryVocational:
                    res = "Среднее профессиональное образование";
                    break;
                case TypeEducation.HigherProfessional:
                    res = "Высшее образование";
                    break;
            }
            return res;
        }

        public int GetExperience()
        {
            DateTime d2;
            d2 = DateTime.Today;
            int delta = d2.Year - AdmissionWork.Year;
            //но еще нужна еще корректировка по разнице месяцев и дней, поэтому делаем следующее:
            if (AdmissionWork > d2.AddYears(-delta)) delta--;//delta содержит точное количество лет разницы дат

            return delta;
        }
    }
}
