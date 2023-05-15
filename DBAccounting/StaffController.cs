using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccounting.Models;

namespace DBAccounting
{
    class StaffController
    {
        private static List<Employee> s_staff = new List<Employee>();

        public static void AddEmployee(Employee employee) => s_staff.Add(employee);

        /// <summary>
        /// Получить всех сотрудников
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetStaffAll() => s_staff;

        /// <summary>
        /// Сортировка сотрудников по образованию
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetStaffEducationSort()
        {
            s_staff.OrderBy(p => p.GetTypeEducationTextRus());

            return s_staff;
        }

        /// <summary>
        /// Сортировка сотрудников по окладу
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetStaffSalarySort()
        {
            s_staff.OrderBy(p => p.Salary);

            return s_staff;
        }

        /// <summary>
        /// Сортировка сотрудников по окладу
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetStaffExperienceSort()
        {
            s_staff.OrderBy(p => p.GetExperience());

            return s_staff;
        }

        public static List<Employee> GetFindFullnameEmployee(string fullname)
        {
            return s_staff.Where(a => a.Fullname.Contains(fullname)).ToList();
        }
    }
}
