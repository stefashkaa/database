using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class EditClientsForm : Form
    {
        public PClient pClient;
        public LClient lClient;
        public bool IsSaved = false;
        private bool isPhys = true;
        public EditClientsForm(bool isPhys)
        {
            InitializeComponent();
            this.isPhys = isPhys;
            if (isPhys)
            {
                physPanel.Visible = true;
                legalPanel.Visible = false;
            }
            else
            {
                physPanel.Visible = false;
                legalPanel.Visible = true;
            }
        }

        public EditClientsForm(bool isPhys, DataGridViewRow row) : this(isPhys)
        {
            if (isPhys)
            {
                pClient = new PClient(
                    (string)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (string)row.Cells[3].Value,
                    (long)row.Cells[4].Value,
                    (string)row.Cells[5].Value
                );
            }
            else
            {
                lClient = new LClient(
                    (string)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (long)row.Cells[2].Value,
                    (string)row.Cells[3].Value
                );
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isPhys)
            {
                if (!Utils.IsNotEmptyTextInputs(pSurname,pName,pPatronymic,pAddress,pMobile,pEmail) ||
                    !Utils.IsValidFullName(pSurname, pName, pPatronymic) ||
                    !Utils.IsValidMobile(pMobile) ||
                    !Utils.IsValidEmail(pEmail))
                {
                    return;
                }
                pClient = new PClient(
                        pSurname.Text,
                        pName.Text,
                        pPatronymic.Text,
                        pAddress.Text,
                        Convert.ToInt64(pMobile.Text),
                        pEmail.Text
                    );
            }
            else
            {
                if (!Utils.IsNotEmptyTextInputs(lName,lAddress,lMobile,lEmail) ||
                    !Utils.IsValidMobile(lMobile) ||
                    !Utils.IsValidEmail(lEmail))
                {
                    return;
                }
                lClient = new LClient(
                        lName.Text,
                        lAddress.Text,
                        Convert.ToInt64(lMobile.Text),
                        lEmail.Text
                    );
            }
            IsSaved = true;
            this.Close();
        }

        private void EditClientsForm_Load(object sender, EventArgs e)
        {
            if ((lClient != null || pClient != null) && Text == "Редактировать")
            {
                if (pClient != null)
                {
                    pSurname.Text = pClient.Surname;
                    pName.Text = pClient.Name;
                    pPatronymic.Text = pClient.Patronymic;
                    pAddress.Text = pClient.Address;
                    pMobile.Text = pClient.Mobile.ToString();
                    pEmail.Text = pClient.Email;
                }
                else
                {
                    lName.Text = lClient.Name;
                    lAddress.Text = lClient.Address;
                    lMobile.Text = lClient.Mobile.ToString();
                    lEmail.Text = lClient.Email;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }
    }
}
