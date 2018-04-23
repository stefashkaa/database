using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CreativeWorkshop.Model;
using CreativeWorkshop.Services;

namespace CreativeWorkshop.View
{
    public partial class CreateContractForm : Form
    {
        private long sum;
        private Purchase purchase;
        private List<ServiceType> selectedServiceTypes;
        private List<int> selectedCount;
        private bool isPhys;
        public CreateContractForm()
        {
            InitializeComponent();
        }

        public CreateContractForm(Purchase p, long sum, List<ServiceType> selectedServiceTypes, List<int> selectedCount) : this()
        {
            this.sum = sum;
            this.purchase = p;
            this.selectedServiceTypes = selectedServiceTypes;
            this.selectedCount = selectedCount;
            sumText.Text = sum.ToString();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileNameText.Text))
            {
                MessageBox.Show("Выберите файл клиента со списком приглашенных!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            saveNewPurchase();
            saveNewContract(out int purchase_id);
            saveServices(purchase_id);
            this.Close();
        }

        private void saveNewContract(out int purchaseId)
        {
            purchaseId = DatabaseService.GetNextId(DbConstants.Purchase.title) - 1;
            if (purchaseId <= 0)
            {
                MessageBox.Show("Заказ не был сохранен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var contract = new Contract(contractId.Text, dateTime.Value, sum, purchaseId, fileNameText.Text);
            try
            {
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{DbConstants.id}", contract.Id),
                    new SQLiteParameter($"@{DbConstants.Contract.summa}", contract.Sum),
                    new SQLiteParameter($"@{DbConstants.Contract.deliveryDate}", contract.Date.Ticks),
                    new SQLiteParameter($"@{DbConstants.Contract.purchaseId}", contract.OrderId),
                    new SQLiteParameter($"@{DbConstants.Contract.fileName}", contract.FileName)
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

        private void saveServices(int purchase_id)
        {
            try
            {
                for(int i = 0; i < selectedServiceTypes.Count(); i++)
                {
                    var parameters = new List<SQLiteParameter>()
                    {
                        new SQLiteParameter($"@{DbConstants.Service.purchaseId}", purchase_id),
                        new SQLiteParameter($"@{DbConstants.Service.serviceTypeName}", selectedServiceTypes[i].Name),
                        new SQLiteParameter($"@{DbConstants.Service.count}", selectedCount[i])
                    };
                    DatabaseService.Execute(DbConstants.Service.Insert, parameters);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Невозможно сохранить услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            openFileDialog1.InitialDirectory = Path.Combine(projectPath, "Resources");
            openFileDialog1.FileName = "NewDocument";
            openFileDialog1.Filter = "docx files(*.docx)| *.docx|doc files (*.doc)|*.doc";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameText.Text = openFileDialog1.FileName;
            }
        }
    }
}
