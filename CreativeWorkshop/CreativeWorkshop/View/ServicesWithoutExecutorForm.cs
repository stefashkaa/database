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
$@"SELECT c.{Db.id}, s.{Db.Service.serviceTypeName} 
FROM ({Db.Contract.title} c INNER JOIN {Db.Service.title} s 
ON c.{Db.Contract.purchaseId} = s.{Db.Service.purchaseId}) a
WHERE a.{Db.Service.employeeId} IS null;"))
            {
                while (read.Read())
                {
                    withoutExecutorView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(Db.id)),
                        read.GetValue(read.GetOrdinal(Db.Service.serviceTypeName))
                    });
                }
            }
        }
    }
}
