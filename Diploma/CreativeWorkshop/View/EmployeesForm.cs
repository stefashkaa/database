using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CreativeWorkshop
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            employeesView.MultiSelect = false;
            employeesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            var addForm = new EditEmployeesForm() { Text = "Добавить" };
            addForm.ShowDialog();
            if (!addForm.IsSaved)
            {
                return;
            }

            var emp = addForm.Employee;
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.Employees.surname}", emp.Surname),
                new SQLiteParameter($"@{DbConstants.Employees.name}", emp.Name),
                new SQLiteParameter($"@{DbConstants.Employees.patronymic}", emp.Patronymic),
                new SQLiteParameter($"@{DbConstants.Employees.position}", emp.Position),
                new SQLiteParameter($"@{DbConstants.Employees.mobile}", emp.Mobile)
            };
            DatabaseService.Execute(DbConstants.Employees.Insert, parameters);
            ViewData();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            var tmp = employeesView.SelectedRows.Count != 0 ? employeesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == employeesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.Employees.surname}", tmp.Cells[0].Value),
                new SQLiteParameter($"@{DbConstants.Employees.name}", tmp.Cells[1].Value),
                new SQLiteParameter($"@{DbConstants.Employees.patronymic}", tmp.Cells[2].Value)
            };
            DatabaseService.Execute(DbConstants.Employees.Delete, parameters);
            ViewData();
        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            var tmp = employeesView.SelectedRows.Count != 0 ? employeesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == employeesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var editForm = new EditEmployeesForm(tmp) { Text = "Редактировать" };
            editForm.ShowDialog();
            if (!editForm.IsSaved)
            {
                return;
            }
            var emp = editForm.Employee;
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.Employees.surname}", emp.Surname),
                new SQLiteParameter($"@{DbConstants.Employees.name}", emp.Name),
                new SQLiteParameter($"@{DbConstants.Employees.patronymic}", emp.Patronymic),
                new SQLiteParameter($"@{DbConstants.Employees.position}", emp.Position),
                new SQLiteParameter($"@{DbConstants.Employees.mobile}", emp.Mobile),
                new SQLiteParameter($"@{DbConstants.Employees.surname}1", tmp.Cells[0].Value),
                new SQLiteParameter($"@{DbConstants.Employees.name}1", tmp.Cells[1].Value),
                new SQLiteParameter($"@{DbConstants.Employees.patronymic}1", tmp.Cells[2].Value)
            };
            DatabaseService.Execute(DbConstants.Employees.Update, parameters);
            ViewData();
        }

        private void ViewData()
        {
            employeesView.Rows.Clear();
            using (var read = DatabaseService.Select(DbConstants.Employees.title))
            {
                while (read.Read())
                {
                    employeesView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.Employees.surname)),
                        read.GetValue(read.GetOrdinal(DbConstants.Employees.name)),
                        read.GetValue(read.GetOrdinal(DbConstants.Employees.patronymic)),
                        read.GetValue(read.GetOrdinal(DbConstants.Employees.position)),
                        read.GetValue(read.GetOrdinal(DbConstants.Employees.mobile))
                    });
                }
            }
        }

        private List<Employee> GetEmployees()
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

        private void reportButton_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer(GetEmployees());
            reportViewer.Show();
        }
    }
}
