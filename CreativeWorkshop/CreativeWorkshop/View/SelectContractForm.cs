using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class SelectContractForm : Form
    {
        private List<Contract> contracts;
        private bool selected = false;

        public bool DontShow { get; private set; } = false;
        public Contract Contract { get; private set; } = null;

        public SelectContractForm()
        {
            contracts = ContractController.GetAllContracts();
            if (contracts?.Count == 0)
            {
                DontShow = true;
                return;
            }
            Contract = contracts.First();
            selected = false;
            InitializeComponent();
            AddContracts();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            selected = true;
            Close();
        }

        private void contractId_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract = contracts.First(c => c.Id == contractId_txt.SelectedItem.ToString());
        }

        private void AddContracts()
        {
            if (contractId_txt == null)
            {
                return;
            }
            contractId_txt.Items.Clear();

            foreach (var contract in contracts)
            {
                contractId_txt.Items.Add(contract.Id);
            }

            if (contractId_txt.Items.Count != 0)
            {
                contractId_txt.SelectedIndex = 0;
            }
        }

        private void SelectContractForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!selected)
            {
                Contract = null;
            }
        }
    }
}
