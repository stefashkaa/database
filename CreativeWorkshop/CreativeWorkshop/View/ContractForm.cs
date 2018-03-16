using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;

namespace CreativeWorkshop.View
{
    public partial class ContractForm : Form
    {
        private static int i = 1;
        private Employee employee;
        private Client client;
        private long sum;
        private long firstPay;
        private DateTimePicker first;
        private DateTimePicker last;
        public ContractForm()
        {
            InitializeComponent();
        }

        public ContractForm(Employee employee, Client client, long sum, long firstPay, DateTimePicker dateTimeFirst, DateTimePicker dateTimeLast) : this()
        {
            this.employee = employee;
            this.client = client;
            this.sum = sum;
            this.firstPay = firstPay;
            this.first = dateTimeFirst;
            this.last = dateTimeLast;
            sum_txt.Text = sum.ToString();
            orderId.Text = (++i).ToString();//for tests
            var pClient = client as PClient;
            var lClient = client as LClient;
            contractId.Text = pClient != null
                ? "PH" + DatabaseService.GetIdByName(DbConstants.PClients.title, $"surname = @surname AND name = @name AND patronymic = @patronymic",
                new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{DbConstants.PClients.surname}", pClient.Surname),
                    new SQLiteParameter($"@{DbConstants.PClients.name}", pClient.Name),
                    new SQLiteParameter($"@{DbConstants.PClients.patronymic}", pClient.Patronymic)
                })
                : "L" + DatabaseService.GetIdByName(DbConstants.LClients.title, $"name = @name",
                new List<SQLiteParameter>() { new SQLiteParameter($"@{DbConstants.LClients.name}", lClient.Name) });
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
