using CreativeWorkshop.Controller;
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
            switch (type)
            {
                case 0:
                    new ReportViewer(null, type, dateTimeFirst.Value, dateTimeSecond.Value).ShowDialog();
                    break;
                case 1:
                    new ReportViewer(null, type, dateTimeFirst.Value, dateTimeSecond.Value).ShowDialog();
                    break;
                case 2:
                    new ReportViewer(ServiceTypeController.GetAllTypes(), type).ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                dateTimeFirst.Enabled = false;
                dateTimeSecond.Enabled = false;
            }
            else
            {
                dateTimeFirst.Enabled = true;
                dateTimeSecond.Enabled = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
