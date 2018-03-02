using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class OrganizationOrderForm : Form
    {
        private int locationY;
        private List<Panel> rows = new List<Panel>();
        private Font font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);

        public OrganizationOrderForm()
        {
            InitializeComponent();
            locationY = row1.Location.Y;
            rows.Add(row1);
        }

        //private void plus1_Click(object sender, EventArgs e)
        //{
        //    if (deleteService.Text == "+")
        //    {
        //        type1txt.ForeColor = Color.Black;
        //        type1.ForeColor = Color.Black;
        //        count1txt.ForeColor = Color.Black;
        //        count1.ForeColor = Color.Black;
        //        deleteService.Text = "-";
        //    }
        //    else
        //    {
        //        type1txt.ForeColor = SystemColors.ControlDark;
        //        type1.ForeColor = SystemColors.ControlDark;
        //        count1txt.ForeColor = SystemColors.ControlDark;
        //        count1.ForeColor = SystemColors.ControlDark;
        //        deleteService.Text = "+";
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //new ContractForm().ShowDialog();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            createRow();
        }

        private Panel createRow()
        {
            int i = rows.Count() + 1;
            locationY += 51;
            var currentRow = new Panel();
            currentRow.Location = new Point(3, locationY);
            currentRow.Name = $"row{i}";
            currentRow.Size = new Size(540, 50);
            currentRow.BorderStyle = BorderStyle.FixedSingle;

            var labelName = new Label();
            labelName.AutoSize = true;
            labelName.Font = font;
            labelName.Location = new Point(3, 15);
            labelName.Name = $"serviceName{i}";
            labelName.Text = "Название вида услуги:";

            var delete = new Button();
            delete.Font = font;
            delete.Location = new Point(480, 12);
            delete.Name = $"deleteService{i}";
            delete.Size = new Size(48, 27);
            delete.Text = "-";
            delete.UseVisualStyleBackColor = true;
            delete.Click += minus_Click;

            var name = new ComboBox();
            name.Font = font;
            name.FormattingEnabled = true;
            name.Location = new Point(169, 12);
            name.Name = $"service_txt{i}";
            name.Size = new Size(117, 27);

            var count = new NumericUpDown();
            count.Font = font;
            count.Location = new Point(403, 13);
            count.Name = $"count{i}";
            count.Size = new Size(66, 26);
            count.Minimum = 1;
            count.Maximum = 100;

            var countLabel = new Label();
            countLabel.AutoSize = true;
            countLabel.Font = font;
            countLabel.Location = new Point(305, 15);
            countLabel.Name = $"countName{i}";
            countLabel.Text = "Количество:";

            currentRow.Controls.AddRange(new Control[] { labelName, name, countLabel, count, delete });
            servicePanel.Controls.Add(currentRow);

            rows.Add(currentRow);
            return currentRow;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            var row = (sender as Button)?.Parent as Panel;
            if (row == null)
            {
                return;
            }
            if (servicePanel.Contains(row))
            {
                servicePanel.Controls.Remove(row);
                rows.Remove(row);

                row = null;
            }
        }
    }
}
