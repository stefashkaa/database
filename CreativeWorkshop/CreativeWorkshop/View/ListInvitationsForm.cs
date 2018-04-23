using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ListInvitationsForm : Form
    {
        private List<string> names;

        public List<string> FilterNames { get; private set; }

        public ListInvitationsForm(List<string> names, List<string> filterNames)
        {
            InitializeComponent();
            this.names = names;
            names.ForEach(name =>
            {
                if (filterNames.Contains(name))
                {
                    namesList.Items.Add(name, true);
                }
                else
                {
                    namesList.Items.Add(name, false);
                }
            });
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (namesList.CheckedItems.Count != 0)
            {
                FilterNames = names.Where(name => namesList.CheckedItems.Contains(name)).ToList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Должно быть выбрано хотя бы одно имя!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
