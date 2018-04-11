using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class PurchaseEmployeesForm : Form
    {
        private Contract contract;

        public PurchaseEmployeesForm(Contract contract)
        {
            this.contract = contract;
            InitializeComponent();
            ViewData();
        }

        private void ViewData()
        {
            employeesView.Rows.Clear();
            //TODO: create query
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
    }
}
