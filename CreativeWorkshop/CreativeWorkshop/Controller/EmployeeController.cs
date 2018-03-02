using CreativeWorkshop.Services;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class EmployeeController
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (var read = DatabaseService.Select(DbConstants.Employees.title))
            {
                while (read.Read())
                {
                    employees.Add(new Employee(
                        (string)read.GetValue(read.GetOrdinal(DbConstants.Employees.surname)),
                        (string)read.GetValue(read.GetOrdinal(DbConstants.Employees.name)),
                        (string)read.GetValue(read.GetOrdinal(DbConstants.Employees.patronymic)),
                        (string)read.GetValue(read.GetOrdinal(DbConstants.Employees.position)),
                        (long)read.GetValue(read.GetOrdinal(DbConstants.Employees.mobile)))
                    );
                }
            }
            return employees;
        }
    }
}
