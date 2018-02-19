using Diploma.Services;
using System;
using System.Windows.Forms;

namespace Diploma
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
            if (!Utils.IsNotEmptyTextInputs(surname_text,name_text,patronymic_text,position_text,mobile_text) ||
                !Utils.IsValidFullName(surname_text, name_text, patronymic_text) ||
                !Utils.IsValidMobile(mobile_text))
            {
                return;
            }
            IsSaved = true;
            Employee = new Employee(
                    surname_text.Text,
                    name_text.Text,
                    patronymic_text.Text,
                    position_text.Text,
                    Convert.ToInt64(mobile_text.Text)
                );
            Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (Employee != null && Text == "Редактировать")
            {
                surname_text.Text = Employee.Surname;
                name_text.Text = Employee.Name;
                patronymic_text.Text = Employee.Patronymic;
                position_text.Text = Employee.Position;
                mobile_text.Text = Employee.Mobile.ToString();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            Close();
        }
    }
}
