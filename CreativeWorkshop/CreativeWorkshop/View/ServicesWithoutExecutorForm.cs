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

namespace CreativeWorkshop
{
    public partial class ServicesWithoutExecutorForm : Form
    {
        public ServicesWithoutExecutorForm()
        {
            InitializeComponent();
            withoutExecutorView.MultiSelect = false;
            withoutExecutorView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewData();
        }

        private void ViewData()
        {
            withoutExecutorView.Rows.Clear();
            using (var read = DatabaseService.ExecuteAndReturn(
$@"SELECT c.{DbConstants.id}, s.{DbConstants.Service.serviceTypeName} 
FROM ({DbConstants.Contract.title} c INNER JOIN {DbConstants.Service.title} s 
ON c.{DbConstants.Contract.purchaseId} = s.{DbConstants.Service.purchaseId}) a
WHERE a.{DbConstants.Service.employeeId} IS null;"))
            {
                while (read.Read())
                {
                    withoutExecutorView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.id)),
                        read.GetValue(read.GetOrdinal(DbConstants.Service.serviceTypeName))
                    });
                }
            }
        }
    }
}
