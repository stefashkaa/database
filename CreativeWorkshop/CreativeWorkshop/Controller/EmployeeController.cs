using CreativeWorkshop.Services;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class EmployeeController
    {
        public static List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            using (var read = DatabaseService.Select(Db.Employees.title))
            {
                while (read.Read())
                {
                    employees.Add(
                        new Employee(
                            (string)read.GetValue(read.GetOrdinal(Db.Employees.surname)),
                            (string)read.GetValue(read.GetOrdinal(Db.Employees.name)),
                            (string)read.GetValue(read.GetOrdinal(Db.Employees.patronymic)),
                            (string)read.GetValue(read.GetOrdinal(Db.Employees.position)),
                            (long)read.GetValue(read.GetOrdinal(Db.Employees.mobile))
                        )
                    );
                }
            }
            return employees;
        }

        public static string GetName(int id)
        {
            using (var read = DatabaseService.Where(Db.Employees.title, $"{Db.id} = {id}"))
            {
                if (read.Read())
                {
                    var e = new Employee(
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.surname)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.name)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.patronymic)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.position)),
                        (long)read.GetValue(read.GetOrdinal(Db.Employees.mobile))
                    );
                    return e.GetShortName();
                }
            }
            return null;
        }
    }
}
