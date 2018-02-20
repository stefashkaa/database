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
        public OrganizationOrderForm()
        {
            InitializeComponent();
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            if (plus1.Text == "+")
            {
                type1txt.ForeColor = Color.Black;
                type1.ForeColor = Color.Black;
                count1txt.ForeColor = Color.Black;
                count1.ForeColor = Color.Black;
                plus1.Text = "-";
            }
            else
            {
                type1txt.ForeColor = SystemColors.ControlDark;
                type1.ForeColor = SystemColors.ControlDark;
                count1txt.ForeColor = SystemColors.ControlDark;
                count1.ForeColor = SystemColors.ControlDark;
                plus1.Text = "+";
            }
        }

        private void plus2_Click(object sender, EventArgs e)
        {
            if (plus2.Text == "+")
            {
                type2txt.ForeColor = Color.Black;
                type2.ForeColor = Color.Black;
                count2txt.ForeColor = Color.Black;
                count2.ForeColor = Color.Black;
                plus2.Text = "-";
            }
            else
            {
                type2txt.ForeColor = SystemColors.ControlDark;
                type2.ForeColor = SystemColors.ControlDark;
                count2txt.ForeColor = SystemColors.ControlDark;
                count2.ForeColor = SystemColors.ControlDark;
                plus2.Text = "+";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new ContractForm().ShowDialog();
        }
    }
}
