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
    public partial class StatisticReportsForm : Form
    {
        public StatisticReportsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type = radioButton1.Checked ? 0 : (radioButton2.Checked ? 1 : 2);
            new ServiceTypeReport(new List<DateTime>() { dateTimeFirst.Value, dateTimeSecond.Value }, type).ShowDialog();
        }
    }
}
