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
        private long sum;
        private Purchase purchase;
        public ContractForm()
        {
            InitializeComponent();
        }

        public ContractForm(Purchase p, long sum) : this()
        {
            this.sum = sum;
            this.purchase = p;
            sum_txt.Text = sum.ToString();
            orderId.Text = DatabaseService.GetNextId(DbConstants.Purchase.title).ToString();
            var pClient = p.Client as PClient;
            var lClient = p.Client as LClient;
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
