using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class StatisticReportsForm : Form
    {
        public StatisticReportsForm()
        {
            InitializeComponent();
            dateTimeSecond.Value = DateTime.Now.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type = radioButton1.Checked ? 0 : (radioButton2.Checked ? 1 : 2);
            switch (type)
            {
                case 0:
                    var executedPurchases = ReportExecutor.GetAllExecutedPurchases(dateTimeFirst.Value, dateTimeSecond.Value);
                    new ReportViewer(executedPurchases, type, dateTimeFirst.Value, dateTimeSecond.Value).ShowDialog();
                    break;
                case 1:
                    var priceReportData = ReportExecutor.GetDataForPriceReport(dateTimeFirst.Value, dateTimeSecond.Value);
                    new ReportViewer(priceReportData, type, dateTimeFirst.Value, dateTimeSecond.Value).ShowDialog();
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

        private void dateTimeFirst_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFirst.Value.Ticks > DateTime.Now.Ticks)
            {
                MessageBox.Show("Выбранная дата не может быть больше сегодняшней!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeFirst.Value = DateTime.Now;
            }
        }

        private void dateTimeSecond_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimeSecond.Value.Ticks < dateTimeFirst.Value.Ticks || dateTimeFirst.Value.ToShortDateString() == dateTimeSecond.Value.ToShortDateString())
            {
                MessageBox.Show("Выбранная дата не может быть меньше или равной первичной!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeSecond.Value = DateTime.Now.AddDays(1);
            }
        }
    }

    public class ReportExecutor
    {
        public static List<ExecutedPurchaseReport> GetAllExecutedPurchases(DateTime first, DateTime second)
        {
            var executedPurchases = new List<ExecutedPurchaseReport>();
            var contracts = ContractController.GetAllContracts();

            using (var read = DatabaseService.ExecuteAndReturn(
$@"SELECT c.{Db.id}, p.{Db.Purchase.firstDate}, c.{Db.Contract.deliveryDate}, c.{Db.Contract.summa} 
FROM ({Db.Contract.title} c INNER JOIN {Db.Purchase.title} p 
ON c.{Db.Contract.purchaseId} = p.{Db.id}) a 
WHERE a.{Db.Purchase.firstDate} BETWEEN {first.Ticks - first.TimeOfDay.Ticks} AND {second.Ticks - second.TimeOfDay.Ticks + TimeSpan.TicksPerDay - 1};"))
            {
                while (read.Read())
                {
                    executedPurchases.Add(
                        new ExecutedPurchaseReport(
                            ContractController.GetClientName(contracts.First(c => c.Id == (string)read.GetValue(read.GetOrdinal(Db.id)))),
                            Contract.ToDate((long)read.GetValue(read.GetOrdinal(Db.Purchase.firstDate))),
                            Contract.ToDate((long)read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate))),
                            (long)read.GetValue(read.GetOrdinal(Db.Contract.summa))
                        )
                    );
                }
            }
            return executedPurchases;
        }

        public static List<PriceReport> GetDataForPriceReport(DateTime first, DateTime second)
        {
            var priceReportData = new List<PriceReport>();
            var contracts = ContractController.GetAllContracts();

            using (var read = DatabaseService.ExecuteAndReturn(
$@"SELECT s.{Db.Service.serviceTypeName}, t.{Db.ServiceTypes.price}, s.{Db.Service.count} 
FROM (({Db.Purchase.title} p INNER JOIN {Db.Service.title} s 
ON p.{Db.id} = s.{Db.Service.purchaseId}) b INNER JOIN {Db.ServiceTypes.title} t 
ON b.{Db.Service.serviceTypeName} = t.{Db.ServiceTypes.name}) a 
WHERE a.{Db.Purchase.firstDate} BETWEEN {first.Ticks - first.TimeOfDay.Ticks} AND {second.Ticks - second.TimeOfDay.Ticks + TimeSpan.TicksPerDay - 1} 
GROUP BY s.{Db.Service.serviceTypeName};"))
            {
                while (read.Read())
                {
                    var price = Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.ServiceTypes.price)));
                    var count = Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Service.count)));
                    priceReportData.Add(
                        new PriceReport(
                            (string)read.GetValue(read.GetOrdinal(Db.Service.serviceTypeName)),
                            price,
                            count,
                            price * count
                        )
                    );
                }
            }
            return priceReportData;
        }
    }
}
