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
$@"SELECT c.{Db.id}, c.{Db.Contract.deliveryDate} 
FROM ({Db.Contract.title} c INNER JOIN {Db.Purchase.title} p 
ON c.{Db.Contract.purchaseId} = p.{Db.id}) a 
WHERE a.{Db.Purchase.status} = {(uint)Status.Unfilled};"))
            {
                while (read.Read())
                {
                    notExecutePurchasesView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(Db.id)),
                        Contract.ToDateString((long)read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate)))
                    });
                }
            }
        }
    }
}
