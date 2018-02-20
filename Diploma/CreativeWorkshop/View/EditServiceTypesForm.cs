using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class EditServiceTypesForm : Form
    {
        public bool IsSaved = false;
        public ServiceType ServiceType;

        public EditServiceTypesForm()
        {
            InitializeComponent();
        }

        public EditServiceTypesForm(DataGridViewRow row) : this()
        {
            ServiceType = new ServiceType(
                    (string)row.Cells[0].Value,
                    Convert.ToInt32(row.Cells[1].Value)
                );
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Utils.IsNotEmptyTextInputs(name_text,price_text) ||
                !Utils.IsValidPrice(price_text))
            {
                return;
            }
            IsSaved = true;
            ServiceType = new ServiceType(
                    name_text.Text,
                    Convert.ToInt32(price_text.Text)
                );
            Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (ServiceType != null && Text == "Редактировать")
            {
                name_text.Text = ServiceType.Name;
                price_text.Text = ServiceType.Price.ToString();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            Close();
        }

        private void EditServiceTypesForm_Load(object sender, EventArgs e)
        {
            if (ServiceType != null && Text == "Редактировать")
            {
                name_text.Text = ServiceType.Name;
                price_text.Text = ServiceType.Price.ToString();
            }
        }
    }
}
