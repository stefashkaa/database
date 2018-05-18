using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ExecuteServicesForm : Form
    {
        private List<Contract> contracts;
        private Contract selectedContract;
        private List<Employee> employees;

        public ExecuteServicesForm(List<Contract> contracts)
        {
            this.contracts = contracts;
            employees = EmployeeController.GetAllEmployees();

            selectedContract = contracts.First();
            InitializeComponent();
            AddContracts();
            employeesList.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            executeView.AllowUserToAddRows = false;
            executeView.MultiSelect = false;
            executeView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addEmployeesList(employeesList);
            ViewData();
        }

        private void addEmployeesList(object sender)
        {
            var comboBox = sender as DataGridViewComboBoxColumn;
            if (comboBox == null)
            {
                return;
            }
            comboBox.Items.Clear();
            foreach (var employee in employees)
            {
                comboBox.Items.Add(employee.GetShortName());
            }
        }

        private void ViewData()
        {
            executeView.Rows.Clear();
            int rowIndex = 0;
            foreach(var service in ServiceController.GetServices(selectedContract.OrderId))
            {
                executeView.Rows.Add(new object[] {
                    service.Name,
                    service.Count,
                    //combobox
                });
                setEmployeeName(executeView.Rows[rowIndex], service.EmployeeId);
                rowIndex++;
            }
        }

        private void setEmployeeName(DataGridViewRow selected, int id)
        {
            var cell = selected.Cells[2] as DataGridViewComboBoxCell;
            if (cell == null || id == -1)
            {
                return;
            }
            cell.Value = getNameById(id);
        }

        private string getNameById(int id)
        {
            Employee emp = null;
            using (var read = DatabaseService.Where(Db.Employees.title, $"id = {id}"))
            {
                while (read.Read())
                {
                    emp = new Employee(
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.surname)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.name)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.patronymic)),
                        (string)read.GetValue(read.GetOrdinal(Db.Employees.position)),
                        Convert.ToInt64(read.GetValue(read.GetOrdinal(Db.Employees.mobile)))
                    );
                }
            }
            return emp?.GetShortName();
        }

        private int getIdByName(string shortName)
        {
            var employee = employees.First(e => e.GetShortName() == shortName);
            int id = DatabaseService.GetIdByName(Db.Employees.title,
                $"surname = @surname AND name = @name AND patronymic = @patronymic",
                new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{Db.Employees.surname}", employee.Surname),
                    new SQLiteParameter($"@{Db.Employees.name}", employee.Name),
                    new SQLiteParameter($"@{Db.Employees.patronymic}", employee.Patronymic)
                });
            return id;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContracts()
        {
            if (contractId_txt == null)
            {
                return;
            }
            contractId_txt.Items.Clear();

            foreach (var contract in contracts)
            {
                contractId_txt.Items.Add(contract.Id);
            }

            if (contractId_txt.Items.Count != 0)
            {
                contractId_txt.SelectedIndex = 0;
            }
        }

        private void contractId_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContract = contracts.First(c => c.Id == contractId_txt.SelectedItem.ToString());
            ViewData();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < executeView.Rows.Count; i++)
                {
                    var cell = executeView.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                    if (cell == null || cell?.Value == null)
                    {
                        continue;
                    }
                    var parameters = new List<SQLiteParameter>()
                    {
                        new SQLiteParameter($"@{Db.Service.employeeId}", getIdByName(cell.Value.ToString())),
                        new SQLiteParameter($"@{Db.Service.purchaseId}1", selectedContract.OrderId),
                        new SQLiteParameter($"@{Db.Service.serviceTypeName}1", executeView.Rows[i].Cells[0].Value.ToString())
                    };
                    DatabaseService.Execute(Db.Service.UpdateEmployee, parameters);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно сохранить данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
