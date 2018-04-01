using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
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
        private List<Contract> contracts;

        public ExecuteServicesForm()
        {
            contracts = ContractController.GetAllContracts();
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
            var contract = contracts.First(c => c.Id == contractId_txt.SelectedItem.ToString());

            executeView.Rows.Clear();
            foreach(var service in ServiceController.GetServices(contract.OrderId))
            {
                executeView.Rows.Add(new object[] {
                    service.Name,
                    service.Count,
                    //combobox
                });
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
            ViewData();
        }
    }
}
