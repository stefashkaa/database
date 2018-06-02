using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class MainForm : Form
    {
        public bool Logoff { get; set; } = false;

        public MainForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            var user = AuthForm.User;
            if (user != null && user?.Role != Role.Unknown)
            {
                auth_txt.Text = user.Name;
                var isDesigner = user.Role == Role.Designer;
                workWithClientsToolStripMenuItem.Enabled = !isDesigner;
                employeeListToolStripMenuItem.Enabled = !isDesigner;
                serviceListToolStripMenuItem.Enabled = !isDesigner;
                reportsToolStripMenuItem.Enabled = !isDesigner;
            }
            contractsView.MultiSelect = false;
            contractsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contractsView.AllowUserToAddRows = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logoff = true;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void typeServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceTypesForm().ShowDialog();
        }

        private void organizationOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrganizationOrderForm().ShowDialog();
            ViewData();
        }

        private void executeServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contracts = ContractController.GetAllContracts();
            if (contracts?.Count != 0)
            {
                new ExecuteServicesForm(contracts).ShowDialog();
            }
        }

        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContractsForm().ShowDialog();
            ViewData();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectContractForm = new SelectContractForm();
            if (selectContractForm.DontShow)
            {
                return;
            }
            selectContractForm.ShowDialog();
            if (selectContractForm.Contract != null)
            {
                new PurchaseEmployeesForm(selectContractForm.Contract).ShowDialog();
            }
        }

        private void notExecuteOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContractController.GetAllContracts()?.Count != 0)
            {
                new NotExecutePurchasesForm().ShowDialog();
            }
        }

        private void servicesWithoutExecutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContractController.GetAllContracts()?.Count != 0)
            {
                new ServicesWithoutExecutorForm().ShowDialog();
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatisticReportsForm().ShowDialog();
        }

        private void invitationsButton_Click(object sender, EventArgs e)
        {
            new InvitationsForm().ShowDialog();
        }

        private void seatingMapButton_Click(object sender, EventArgs e)
        {
            new SeatingMapForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            contractsView.Rows.Clear();
            if (ContractController.GetAllContracts()?.Count != 0)
            {
                using (var read = DatabaseService.Where(Db.Contract.title,
                    $"{Db.Contract.deliveryDate} BETWEEN {DateTime.Now.Ticks} AND {DateTime.Now.AddDays(3).Ticks} ORDER BY {Db.Contract.deliveryDate} DESC"))
                {
                    while (read.Read())
                    {
                        int purchaseId = Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Contract.purchaseId)));

                        if (getStatus(purchaseId) == Status.Unfilled)
                        {
                            contractsView.Rows.Add(new object[]
                            {
                                read.GetValue(read.GetOrdinal(Db.id)),
                                Contract.ToDateString((long)read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate)))
                            });
                        }
                    }
                    foreach (DataGridViewRow row in contractsView.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private Status getStatus(int id)
        {
            using (var read = DatabaseService.Where(Db.Purchase.title, $"id = {id}"))
            {
                if (read.Read())
                {
                    return (Status)Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Purchase.status)));
                }

                return Status.Unfilled;
            }
        }
    }
}
