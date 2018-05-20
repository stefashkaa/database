using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CreativeWorkshop.Model;
using CrystalDecisions.CrystalReports.Engine;

namespace CreativeWorkshop
{
    public partial class ReportViewer : Form
    {

        private object objects;
        private DateTime? first;
        private DateTime? second;
        private int type;

        public ReportViewer(object objects, int type, DateTime? first = null, DateTime? second = null)
        {
            InitializeComponent();
            this.objects = objects;
            this.first = first;
            this.second = second;
            this.type = type;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            ReportClass report = null;

            switch (type)
            {
                case 0:
                case 1:
                    if (type == 0)
                    {
                        report = new View.Reports.ExecutedReport();
                        report.Refresh();
                        report.SetDataSource((IEnumerable<ServiceType>)objects);
                    }
                    else
                    {
                        report = new View.Reports.PriceReport();
                        report.Refresh();
                        report.SetDataSource((IEnumerable<ServiceType>)objects);
                        report.SetParameterValue("Total", "0 руб.");
                    }
                    report.SetParameterValue("First", first.Value.ToShortDateString());
                    report.SetParameterValue("Second", second.Value.ToShortDateString());
                    break;
                case 2:
                    report = new View.Reports.ServiceTypeReport();
                    report.Refresh();
                    report.SetDataSource((IEnumerable<ServiceType>)objects);
                    break;
                default:
                    break;
            }
            crystalReportViewer1.ReportSource = report;
        }
    }
}
