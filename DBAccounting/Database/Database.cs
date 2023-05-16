using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DBAccounting.Database
{
    class Database
    {
        private static string _connect = "EmployeeAccounting.db";

        public static void Connect()
        {
            using (var connection = new SQLiteConnection($"Data Source={_connect}"))
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Получить сотрудников
        /// </summary>
        /// <returns></returns>
        public static List<Models.Employee> GetListEmployees()
        {
            List<Models.Employee> employees = new List<Models.Employee>();
            string sqlExpression = "SELECT * FROM Employee";
            using (var connection = new SQLiteConnection($"Data Source={_connect}"))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            long id = reader.GetInt32(0);
                            string fullname = reader.GetString(1);
                            long typeEducation = reader.GetInt32(2);
                            string positionWork = reader.GetString(3);
                            string admissionWork = reader.GetString(4);
                            float salary = reader.GetFloat(5);

                            Models.Employee employee = new Models.Employee();
                            employee.Id = id;
                            employee.FullName = fullname;
                            employee.SetIntEducation(typeEducation);
                            employee.PositionWork = positionWork;
                            employee.AdmissionWork = DateTime.Parse(admissionWork);
                            employee.Salary = salary;

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        /// <summary>
        /// Изменить данные о сотруднике
        /// </summary>
        /// <param name="newData"></param>
        public static void UpdateDataEmployee(Models.Employee newData)
        {
            string sqlExpression = $"UPDATE Employee SET " +
                $"FullName='{newData.FullName}', TypeEducation='{(int)newData.Education}', PositionWork = '{newData.PositionWork}'," +
                $"AdmissionWork = '{newData.AdmissionWork}', Salary = {newData.Salary}" +
                $" WHERE Id='{newData.Id}'";
            using (var connection = new SQLiteConnection($"Data Source={_connect}"))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);

                int number = command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Добавить нового сотрудника
        /// </summary>
        /// <param name="data"></param>
        public static void InsertDataEmployee(Models.Employee data)
        {
            using (var connection = new SQLiteConnection($"Data Source={_connect}"))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = 
                    "INSERT INTO Employee (FullName, TypeEducation, PositionWork, AdmissionWork, Salary) " +
                    $"VALUES ('{data.FullName}', {(int)data.Education}, '{data.PositionWork}', '{data.PositionWork}', {data.Salary})";

                command.ExecuteNonQuery();
            }
        }
    }
}
