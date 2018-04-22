using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using CreativeWorkshop.Services;

namespace CreativeWorkshop.View
{
    public partial class SeatingMapForm : Form
    {
        private System.Drawing.Font font;
        private List<Contract> contracts;
        List<string> names;
        private Contract selectedContract;

        public SeatingMapForm()
        {
            InitializeComponent();
            font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contracts = ContractController.GetAllContracts();
            if (contracts?.Count == 0)
            {
                return;
            }
            names = new List<string>();
            selectedContract = contracts.First();
            AddContracts();
        }

        private void contractId_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContract = contracts.First(c => c.Id == contractId_txt.SelectedItem.ToString());
            names = Utils.GetNames(selectedContract.FileName);
            makeExample();
        }

        private void makeExample()
        {
            if (names?.Count == 0) return;

            for (int i = 1; i <= 4; i++)
            {
                if (i <= names.Count)
                {
                    var txtBox = this.Controls["textBox" + i.ToString()] as TextBox;
                    txtBox.TextAlign = HorizontalAlignment.Center;
                    
                    txtBox.Text = $"\r\n\r\n\r\n\r\n\r\n{names[i - 1]}";
                }
            }
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

        private void listInv_btn_Click(object sender, EventArgs e)
        {
            new ListInvitationsForm().ShowDialog();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveSeatingMap(saveFileDialog1.FileName, names, font);
            }
        }
    }
}
