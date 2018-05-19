using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using CreativeWorkshop.View;
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
            init();
        }

        private void init()
        {
            employeesView.MultiSelect = false;
            employeesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var user = AuthForm.User;
            if (user != null && user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                addEmployee.Enabled = !isDesigner;
                editEmployee.Enabled = !isDesigner;
                deleteEmployee.Enabled = !isDesigner;
            }
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
                new SQLiteParameter($"@{Db.Employees.surname}", emp.Surname),
                new SQLiteParameter($"@{Db.Employees.name}", emp.Name),
                new SQLiteParameter($"@{Db.Employees.patronymic}", emp.Patronymic),
                new SQLiteParameter($"@{Db.Employees.position}", emp.Position),
                new SQLiteParameter($"@{Db.Employees.mobile}", emp.Mobile)
            };
            DatabaseService.Execute(Db.Employees.Insert, parameters);
            ViewData();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            var tmp = employeesView.SelectedRows.Count != 0 ? employeesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == employeesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Utils.AreYouShureToRemove())
            {
                return;
            }
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{Db.Employees.surname}", tmp.Cells[0].Value),
                new SQLiteParameter($"@{Db.Employees.name}", tmp.Cells[1].Value),
                new SQLiteParameter($"@{Db.Employees.patronymic}", tmp.Cells[2].Value)
            };
            DatabaseService.Execute(Db.Employees.Delete, parameters);
            ViewData();
        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            var tmp = employeesView.SelectedRows.Count != 0 ? employeesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == employeesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                new SQLiteParameter($"@{Db.Employees.surname}", emp.Surname),
                new SQLiteParameter($"@{Db.Employees.name}", emp.Name),
                new SQLiteParameter($"@{Db.Employees.patronymic}", emp.Patronymic),
                new SQLiteParameter($"@{Db.Employees.position}", emp.Position),
                new SQLiteParameter($"@{Db.Employees.mobile}", emp.Mobile),
                new SQLiteParameter($"@{Db.Employees.surname}1", tmp.Cells[0].Value),
                new SQLiteParameter($"@{Db.Employees.name}1", tmp.Cells[1].Value),
                new SQLiteParameter($"@{Db.Employees.patronymic}1", tmp.Cells[2].Value)
            };
            DatabaseService.Execute(Db.Employees.Update, parameters);
            ViewData();
        }

        private void ViewData()
        {
            employeesView.Rows.Clear();
            using (var read = DatabaseService.Select(Db.Employees.title))
            {
                while (read.Read())
                {
                    employeesView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(Db.Employees.surname)),
                        read.GetValue(read.GetOrdinal(Db.Employees.name)),
                        read.GetValue(read.GetOrdinal(Db.Employees.patronymic)),
                        read.GetValue(read.GetOrdinal(Db.Employees.position)),
                        read.GetValue(read.GetOrdinal(Db.Employees.mobile))
                    });
                }
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer(EmployeeController.GetAllEmployees());
            reportViewer.Show();
        }
    }
}
