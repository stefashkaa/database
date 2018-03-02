using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            new ServiceTypeReport(new List<DateTime>(){dateTime.Value}).ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DatabaseService.CloseConnection();
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
        }

        private void executeServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExecuteServicesForm().ShowDialog();
        }

        private void invitationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InvitationsForm().ShowDialog();
        }

        private void seatingMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SeatingMapForm().ShowDialog();
        }

        private void statisticReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatisticReportsForm().ShowDialog();
        }
    }
}
