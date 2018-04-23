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
using System.IO;

namespace CreativeWorkshop.View
{
    public partial class SeatingMapForm : Form
    {
        private System.Drawing.Font font;
        private List<Contract> contracts;
        private List<string> names;
        private List<string> filterNames;
        private Contract selectedContract;

        public SeatingMapForm()
        {
            InitializeComponent();
            font = new System.Drawing.Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeFont();
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
            filterNames = names;
            makeExample();
        }

        private void makeExample()
        {
            if (filterNames == null || filterNames?.Count == 0) return;

            for (int i = 1; i <= 4; i++)
            {
                if (i <= filterNames.Count)
                {
                    var txtBox = (this.Controls[$"A4_{i}"] as Panel).Controls[$"textBox{i}"] as TextBox;
                    //var txtBox = this.Controls["textBox" + i.ToString()] as TextBox;
                    txtBox.TextAlign = HorizontalAlignment.Center;
                    
                    txtBox.Text = $"\r\n\r\n\r\n\r\n\r\n{filterNames[i - 1]}";
                }
            }
        }

        private void changeFont()
        {
            for (int i = 1; i <= 4; i++)
            {
                var txtBox = (this.Controls[$"A4_{i}"] as Panel).Controls[$"textBox{i}"] as TextBox;
                txtBox.Font = new System.Drawing.Font(font.Name, font.Size / 2, font.Style);
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
            if ( names != null && names?.Count != 0)
            {
                var listInvitationsForm = new ListInvitationsForm(names, filterNames);
                listInvitationsForm.ShowDialog();
                if (listInvitationsForm.FilterNames != null)
                {
                    filterNames = listInvitationsForm.FilterNames;
                    makeExample();
                }
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                changeFont();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            saveFileDialog1.InitialDirectory = Path.Combine(projectPath, "Resources");
            saveFileDialog1.FileName = $"SeatingMap{contractId_txt.Text}";
            saveFileDialog1.Filter = "docx files(*.docx)| *.docx|doc files (*.doc)|*.doc";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveSeatingMap(saveFileDialog1.FileName, filterNames, font);
            }
        }
    }
}
