﻿using CreativeWorkshop.Model;
using System;
using System.Collections.Generic;
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
            if (user?.Role != Role.Unknown)
            {
                auth_txt.Text = user.Name;
                var isDesigner = user.Role == Role.Designer;
                workWithClientsToolStripMenuItem.Enabled = !isDesigner;
                queresToolStripMenuItem.Enabled = !isDesigner;
                reportsToolStripMenuItem.Enabled = !isDesigner;
            }
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
            Logoff = true;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContractsForm().ShowDialog();
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

        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContractsForm().ShowDialog();
        }
    }
}
