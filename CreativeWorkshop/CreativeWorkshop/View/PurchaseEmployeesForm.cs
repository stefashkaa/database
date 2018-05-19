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
$@"SELECT DISTINCT e.{Db.Employees.surname}, e.{Db.Employees.name}, e.{Db.Employees.patronymic}, 
e.{Db.Employees.position}, e.{Db.Employees.mobile} 
FROM ({Db.Service.title} s INNER JOIN {Db.Employees.title} e 
ON e.{Db.id} = s.{Db.Service.employeeId}) a 
WHERE a.{Db.Service.purchaseId} = {contract.OrderId};"))
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
    }
}
