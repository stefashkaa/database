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
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            contractsView.MultiSelect = false;
            contractsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var user = AuthForm.User;
            if (user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                deleteContract.Enabled = !isDesigner;
            }
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            contractsView.Rows.Clear();
            using (var read = DatabaseService.Select(DbConstants.Contract.title))
            {
                while (read.Read())
                {
                    contractsView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.id)),
                        read.GetValue(read.GetOrdinal(DbConstants.Contract.purchaseId)),
                        read.GetValue(read.GetOrdinal(DbConstants.Contract.summa)),
                        Contract.ToDateString((long)read.GetValue(read.GetOrdinal(DbConstants.Contract.deliveryDate)))
                    });
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
