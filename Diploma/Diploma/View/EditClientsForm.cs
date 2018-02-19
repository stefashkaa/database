using Diploma.Model;
using Diploma.Services;
using System;
using System.Windows.Forms;

namespace Diploma.View
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
                    (int)row.Cells[4].Value,
                    (string)row.Cells[5].Value
                );
            }
            else
            {
                lClient = new LClient(
                    (string)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (int)row.Cells[2].Value,
                    (string)row.Cells[3].Value
                );
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isPhys)
            {
                if (!Utils.IsNotEmptyTextInputs(psurname,pname,ppatronymic,paddress,pmobile,pemail) ||
                    !Utils.IsValidFullName(psurname, pname, ppatronymic) ||
                    !Utils.IsValidMobile(pmobile) ||
                    !Utils.IsValidEmail(pemail))
                {
                    return;
                }
                pClient = new PClient(
                        psurname.Text,
                        pname.Text,
                        ppatronymic.Text,
                        paddress.Text,
                        Convert.ToInt64(pmobile.Text),
                        pemail.Text
                    );
            }
            else
            {
                if (!Utils.IsNotEmptyTextInputs(lname,laddress,lmobile,lemail) ||
                    !Utils.IsValidMobile(lmobile) ||
                    !Utils.IsValidEmail(lemail))
                {
                    return;
                }
                lClient = new LClient(
                        lname.Text,
                        laddress.Text,
                        Convert.ToInt64(lmobile.Text),
                        lemail.Text
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
                    psurname.Text = pClient.Surname;
                    pname.Text = pClient.Name;
                    ppatronymic.Text = pClient.Patronymic;
                    paddress.Text = pClient.Address;
                    pmobile.Text = pClient.Mobile.ToString();
                    pemail.Text = pClient.Email;
                }
                else
                {
                    lname.Text = lClient.Name;
                    laddress.Text = lClient.Address;
                    lmobile.Text = lClient.Mobile.ToString();
                    lemail.Text = lClient.Email;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.Close();
        }
    }
}
