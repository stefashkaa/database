using CreativeWorkshop.Services;
using System;
using System.Windows.Forms;

namespace CreativeWorkshop
{
    public partial class EditEmployeesForm : Form
    {
        public bool IsSaved = false;
        public Employee Employee;

        public EditEmployeesForm()
        {
            InitializeComponent();
        }

        public EditEmployeesForm(DataGridViewRow row) : this()
        {
            Employee = new Employee(
                    (string)row.Cells[0].Value,
                    (string)row.Cells[1].Value,
                    (string)row.Cells[2].Value,
                    (string)row.Cells[3].Value,
                    Convert.ToInt64(row.Cells[4].Value)
                );
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Utils.IsNotEmptyTextInputs(surnameText,nameText,patronymicText,positionText,mobileText) ||
                !Utils.IsValidFullName(surnameText, nameText, patronymicText) ||
                !Utils.IsValidMobile(mobileText))
            {
                return;
            }
            IsSaved = true;
            Employee = new Employee(
                    surnameText.Text,
                    nameText.Text,
                    patronymicText.Text,
                    positionText.Text,
                    Convert.ToInt64(mobileText.Text)
                );
            Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (Employee != null && Text == "Редактировать")
            {
                surnameText.Text = Employee.Surname;
                nameText.Text = Employee.Name;
                patronymicText.Text = Employee.Patronymic;
                positionText.Text = Employee.Position;
                mobileText.Text = Employee.Mobile.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            Close();
        }
    }
}
