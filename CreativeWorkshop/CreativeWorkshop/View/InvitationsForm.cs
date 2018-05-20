using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CreativeWorkshop.Services;
using System.IO;

namespace CreativeWorkshop.View
{
    public partial class InvitationsForm : Form
    {
        private Font font;
        private List<Contract> contracts;
        private Contract selectedContract;
        private List<string> names;
        private List<string> filterNames;
        private List<string> pages;
        private string text;

        public InvitationsForm()
        {
            InitializeComponent();
            font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeFont();
            contracts = ContractController.GetAllContracts();
            if (contracts?.Count == 0)
            {
                return;
            }
            names = new List<string>();
            pages = new List<string>();
            selectedContract = contracts.First();
            clientName.Text = ContractController.GetClientName(selectedContract);
            AddContracts();
        }

        private void contractId_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContract = contracts.First(c => c.Id == contractIdText.SelectedItem.ToString());
            clientName.Text = ContractController.GetClientName(selectedContract);
            names = Utils.GetNames(selectedContract.FileName);
            filterNames = names;
            countText.Text = filterNames.Count.ToString();
            makePages();
        }

        private void makePage(int num)
        {
            if (filterNames == null || filterNames?.Count == 0) return;
            pages.Add($"{filterNames[num - 1]}!\r\n");

            if (!string.IsNullOrWhiteSpace(text))
            {
                pages[num - 1] += $"\r\n{text}";
            }
        }

        private void makePages()
        {
            pages = new List<string>(filterNames.Count);

            for (int i = 1; i <= filterNames.Count; i++)
            {
                makePage(i);
            }
            viewPage(int.Parse(numberText.Text));
        }

        private void viewPage(int num)
        {
            invitationText.Clear();
            var temp = pages[num - 1].Split('\n');

            for (int i = 0; i < temp.Length; i++)
            {
                invitationText.Select(invitationText.TextLength, 0);
                invitationText.SelectionAlignment = HorizontalAlignment.Center;
                invitationText.AppendText(temp[i]);
            }
        }

        private void changeFont()
        {
            invitationText.Font = new Font(font.Name, font.Size / 2, font.Style);
        }

        private void AddContracts()
        {
            if (contractIdText == null)
            {
                return;
            }
            contractIdText.Items.Clear();

            foreach (var contract in contracts)
            {
                contractIdText.Items.Add(contract.Id);
            }

            if (contractIdText.Items.Count != 0)
            {
                contractIdText.SelectedIndex = 0;
            }
        }

        private void listInv_btn_Click(object sender, EventArgs e)
        {
            if (names != null && names?.Count != 0)
            {
                var listInvitationsForm = new ListInvitationsForm(names, filterNames);
                listInvitationsForm.ShowDialog();
                if (listInvitationsForm.FilterNames != null)
                {
                    filterNames = listInvitationsForm.FilterNames;
                    int count = filterNames.Count;
                    int current = int.Parse(numberText.Text);

                    if (current > count)
                    {
                        numberText.Text = count.ToString();
                    }
                    countText.Text = count.ToString();
                    makePages();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            saveFileDialog1.InitialDirectory = Path.Combine(projectPath, "Resources");
            saveFileDialog1.FileName = $"Invitations{contractIdText.Text}";
            saveFileDialog1.Filter = "docx files(*.docx)| *.docx|doc files (*.doc)|*.doc";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveInvitations(saveFileDialog1.FileName, pages, font);
            }
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            openFileDialog1.InitialDirectory = Path.Combine(projectPath, "Resources");
            openFileDialog1.FileName = $"Invitations{contractIdText.Text}";
            openFileDialog1.Filter = "docx files(*.docx)| *.docx|doc files (*.doc)|*.doc";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text = Utils.GetText(openFileDialog1.FileName);
                makePages();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            int current = int.Parse(numberText.Text);

            if (current == 1)
            {
                return;
            }
            numberText.Text = (--current).ToString();
            viewPage(current);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int count = int.Parse(countText.Text);
            int current = int.Parse(numberText.Text);

            if (current >= count)
            {
                return;
            }
            numberText.Text = (++current).ToString();
            viewPage(current);
        }
    }
}
