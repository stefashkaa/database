using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
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
            employeesView.MultiSelect = false;
            employeesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewData();
        }

        private void ViewData()
        {
            employeesView.Rows.Clear();
            using (var read = DatabaseService.ExecuteAndReturn(
$@"SELECT e.{DbConstants.Employees.surname}, e.{DbConstants.Employees.name}, e.{DbConstants.Employees.patronymic}, 
e.{DbConstants.Employees.position}, e.{DbConstants.Employees.mobile} 
FROM ({DbConstants.Service.title} s INNER JOIN {DbConstants.Employees.title} e 
ON e.{DbConstants.id} = s.{DbConstants.Service.employeeId}) a 
WHERE a.{DbConstants.Service.purchaseId} = {contract.OrderId};"))
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
