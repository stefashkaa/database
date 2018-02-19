using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using Diploma.View;
using Diploma.View.Reports;

namespace Diploma
{
    public partial class ReportViewer : Form
    {

        private List<Employee> employees;

        public ReportViewer(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var empReport = new EmployeeReport();
            /*
             * Дополнительные сведения: Не удалось загрузить файл или сборку 
             * "file:///C:\Program Files (x86)\SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win32_x86\dotnet1\crdb_adoplus.dll" 
             * либо одну из их зависимостей. Не удается найти указанный файл.
             */
            empReport.SetDataSource((IEnumerable<Employee>)employees);//вот здесь косяк, ему нужно передать данные, я хз, в каком виде
            this.crystalReportViewer1.ReportSource = empReport;
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
