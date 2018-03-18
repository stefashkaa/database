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
    public partial class CreateContractForm : Form
    {
        private long sum;
        private Purchase purchase;
        private bool isPhys;
        public CreateContractForm()
        {
            InitializeComponent();
        }

        public CreateContractForm(Purchase p, long sum) : this()
        {
            this.sum = sum;
            this.purchase = p;
            sum_txt.Text = sum.ToString();
            orderId.Text = DatabaseService.GetNextId(DbConstants.Purchase.title).ToString();
            var pClient = p.Client as PClient;
            var lClient = p.Client as LClient;
            isPhys = pClient != null;
            contractId.Text = isPhys
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
            saveNewPurchase();
            saveNewContract();
            this.Close();
        }

        private void saveNewContract()
        {
            int purchaseId = DatabaseService.GetNextId(DbConstants.Purchase.title) - 1;
            if (purchaseId <= 0)
            {
                MessageBox.Show("Заказ не был сохранен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var contract = new Contract(contractId.Text, dateTime.Value, sum, purchaseId);
            try
            {
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{DbConstants.id}", contractId.Text),
                    new SQLiteParameter($"@{DbConstants.Contract.summa}", sum),
                    new SQLiteParameter($"@{DbConstants.Contract.deliveryDate}", dateTime.Value.Ticks),
                    new SQLiteParameter($"@{DbConstants.Contract.purchaseId}", purchaseId)
                };
                DatabaseService.Execute(DbConstants.Contract.Insert, parameters);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно создать договор!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveNewPurchase()
        {
            try
            {
                var clientId = (isPhys)
                    ?
                    DatabaseService.GetIdByName(DbConstants.PClients.title, $"surname = @surname AND name = @name AND patronymic = @patronymic",
                    new List<SQLiteParameter>()
                    {
                        new SQLiteParameter($"@{DbConstants.PClients.surname}", ((PClient)purchase.Client).Surname),
                        new SQLiteParameter($"@{DbConstants.PClients.name}", ((PClient)purchase.Client).Name),
                        new SQLiteParameter($"@{DbConstants.PClients.patronymic}", ((PClient)purchase.Client).Patronymic)
                    },
                    DbConstants.PClients.clientId)
                    :
                    DatabaseService.GetIdByName(DbConstants.LClients.title, $"name = @name",
                    new List<SQLiteParameter>() { new SQLiteParameter($"@{DbConstants.LClients.name}", ((LClient)purchase.Client).Name) },
                    DbConstants.LClients.clientId);
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{DbConstants.Purchase.clientId}", clientId),
                    new SQLiteParameter($"@{DbConstants.Purchase.firstSum}", purchase.FirstSum),
                    new SQLiteParameter($"@{DbConstants.Purchase.firstDate}", purchase.GetFirstDate()),
                    new SQLiteParameter($"@{DbConstants.Purchase.lastDate}", purchase.GetLastDate()),
                    new SQLiteParameter($"@{DbConstants.Purchase.status}", purchase.Status)
                };
                DatabaseService.Execute(DbConstants.Purchase.Insert, parameters);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно сохранить заказ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
