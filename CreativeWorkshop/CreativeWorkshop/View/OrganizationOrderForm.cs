using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class OrganizationOrderForm : Form
    {
        private Font font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        public OrganizationOrderForm()
        {
            InitializeComponent();
            AddItems<ServiceType>(service_txt1);
            AddClients();
        }

        private void AddClients()
        {
            if (phys_rb.Checked)
            {
                AddItems<PClient>(clientId_txt);
            }
            else
            {
                AddItems<LClient>(clientId_txt);
            }
        }

        private void contract_Click(object sender, EventArgs e)
        {
            var client = getClient();
            var sum = getSum();
            if (client == null || sum <= 0)
            {
                MessageBox.Show(@"Невозможно оформить заказ!
Не заполнены одно или несколько полей", "Предупреждение",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(firstSum_txt.Text, out long firstPay) || firstPay < 0 || firstPay > sum)
            {
                MessageBox.Show(@"Поле 'первоначальный взнос' введено не корректно!
Первоначальный взнос должен быть меньше итоговой суммы", "Предупреждение",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new CreateContractForm(
                new Purchase(client, firstPay, dateTimeFirst.Value, dateTimeLast.Value, Status.Unfilled), 
                sum).ShowDialog();
        }

        private long getSum()
        {
            long sum = 0;
            var types = ServiceTypeController.GetAllTypes();
            if (types.Count == 0)
            {
                return 0;
            }
            foreach (var row in servicePanel.Controls.Cast<Panel>())
            {
                sum += (types.First(t => t.Name == (row.Controls[1] as ComboBox)?.SelectedItem.ToString()).Price *
                    Convert.ToInt64((row.Controls[3] as NumericUpDown)?.Value)); 
            }
            return sum;
        }

        private void addService_Click(object sender, EventArgs e)
        {
            createRow();
        }

        private Client getClient()
        {
            if (phys_rb.Checked)
            {
                return ClientController.GetAllPClients().FirstOrDefault(p => p.GetShortName() == clientId_txt.Text);
            }
            else
            {
                return ClientController.GetAllLClients().FirstOrDefault(l => l.Name == clientId_txt.Text);
            }
        }

        private void createRow()
        {
            int i = servicePanel.Controls.Count + 1;
            var currentRow = new Panel() { Name = $"row{i}", Size = new Size(540, 50), BorderStyle = BorderStyle.FixedSingle };

            var labelName = new Label() { AutoSize = true, Font = font, Location = new Point(3, 15),
                Name = $"serviceName{i}", Text = "Название вида услуги:" };

            var name = new ComboBox() { Font = font, Location = new Point(169, 12), Name = $"service_txt{i}",
                Size = new Size(117, 27), DropDownWidth = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            AddItems<ServiceType>(name);

            var countLabel = new Label() { AutoSize = true, Font = font, Location = new Point(305, 15),
                Name = $"countName{i}", Text = "Количество:" };

            var count = new NumericUpDown() { Font = font, Location = new Point(403, 13), Name = $"count{i}",
                Size = new Size(66, 26), Minimum = 1, Maximum = 100 };

            var delete = new Button() { Font = font, Location = new Point(480, 12), Name = $"deleteService{i}",
                Size = new Size(48, 27), Text = "-", UseVisualStyleBackColor = true };
            delete.Click += minus_Click;

            currentRow.Controls.AddRange(new Control[] { labelName, name, countLabel, count, delete });
            servicePanel.Controls.Add(currentRow);
        }

        private void AddItems<T>(object sender)
        {
            var box = sender as ComboBox;
            if (box == null)
            {
                return;
            }
            box.Items.Clear();
            addNamesToList<T>(box);
            if (box.Items.Count != 0)
            {
                box.SelectedIndex = 0;
            }
        }

        private void addNamesToList<T>(ComboBox box)
        {
            if (typeof(T) == typeof(LClient))
            {
                foreach (var client in ClientController.GetAllLClients())
                {
                    box.Items.Add(client.Name);
                }
            }
            else if (typeof(T) == typeof(ServiceType))
            {
                foreach (var type in ServiceTypeController.GetAllTypes())
                {
                    box.Items.Add(type.Name);
                }
            }
            else if (typeof(T) == typeof(PClient))
            {
                foreach (var client in ClientController.GetAllPClients())
                {
                    box.Items.Add(client.GetShortName());
                }
            }
            else if (typeof(T) == typeof(Employee))
            {
                foreach (var employee in EmployeeController.GetAllEmployees())
                {
                    box.Items.Add(employee.GetShortName());
                }
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            var row = (sender as Button)?.Parent as Panel;
            if (row == null || !servicePanel.Contains(row))
            {
                return;
            }
            servicePanel.Controls.Remove(row);

            row = null;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            AddClients();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
