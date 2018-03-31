using CreativeWorkshop.Controller;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ExecuteServicesForm : Form
    {
        public ExecuteServicesForm()
        {
            InitializeComponent();
            AddContracts();
            employeesList.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            executeView.AllowUserToAddRows = false;
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
            var employees = EmployeeController.GetAllEmployees();
            comboBox.MaxDropDownItems = 2;
            foreach (var employee in employees)
            {
                comboBox.Items.Add(employee.GetShortName());
            }
        }

        private void ViewData()
        {
            executeView.Rows.Clear();
            using (var read = DatabaseService.Select(DbConstants.Employees.title))
            {
                while (read.Read())
                {
                    executeView.Rows.Add(new object[] {
                        "coding",//read.GetValue(read.GetOrdinal(DbConstants.Employees.surname)),
                        "123",//read.GetValue(read.GetOrdinal(DbConstants.Employees.name)),
                        1000000//lead.GetValue(read.GetOrdinal(DbConstants.Employees.patronymic))
                        //combobox
                    });
                }
            }
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

            foreach (var contract in ContractController.GetAllContracts())
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
            ViewData();
        }
    }
}
