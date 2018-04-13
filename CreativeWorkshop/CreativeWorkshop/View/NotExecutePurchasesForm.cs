using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class NotExecutePurchasesForm : Form
    {
        public NotExecutePurchasesForm()
        {
            InitializeComponent();
            notExecutePurchasesView.MultiSelect = false;
            notExecutePurchasesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewData();
        }

        private void ViewData()
        {
            notExecutePurchasesView.Rows.Clear();
            using (var read = DatabaseService.ExecuteAndReturn(
$@"SELECT c.{DbConstants.id}, p.{DbConstants.Purchase.firstDate} 
FROM ({DbConstants.Contract.title} c INNER JOIN {DbConstants.Purchase.title} p 
ON c.{DbConstants.Contract.purchaseId} = p.{DbConstants.id}) a
WHERE a.{DbConstants.Purchase.status} = {(uint)Status.Unfilled};"))
            {
                while (read.Read())
                {
                    notExecutePurchasesView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.id)),
                        Contract.ToDateString(Convert.ToInt64(read.GetValue(read.GetOrdinal(DbConstants.Purchase.firstDate))))
                    });
                }
            }
        }
    }
}
