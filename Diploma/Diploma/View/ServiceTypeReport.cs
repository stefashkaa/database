using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma.View
{
    public partial class ServiceTypeReport : Form
    {
        public ServiceTypeReport()
        {
            InitializeComponent();
        }

        public ServiceTypeReport(List<DateTime> date)
            : this()
        {
            if (date.Count == 1)
            {
                Text = "Невыполненные заказы";
                type_txt.Text = "        Отчет\nпо видам услуг";
                date_txt.Text = date[0].ToShortDateString();
            }
            else
            {
                date_txt.Text = date[0].ToShortDateString() + " - " + date[1].ToShortDateString();
            }
        }

        public ServiceTypeReport(List<DateTime> date, int type)
            : this(date)
        {
            switch (type)
            {
                case 0: Text = "Отчет по выполненным заказам"; type_txt.Text = "                 Отчет\nпо выполненным заказам"; break;
                case 1: Text = "Отчет по стоимости работ"; type_txt.Text = "           Отчет\nпо стоимости работ"; break;
                case 2: Text = "Отчет по видам услуг"; type_txt.Text = "        Отчет\nпо видам услуг"; break;
                default:
                    break;
            }
        }
    }
}
