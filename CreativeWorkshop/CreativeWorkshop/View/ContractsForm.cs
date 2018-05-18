using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            contractsView.MultiSelect = false;
            contractsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var user = AuthForm.User;
            if (user != null && user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                deleteContract.Enabled = !isDesigner;
            }
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            viewData();
        }

        private void viewData()
        {
            contractsView.Rows.Clear();
            using (var read = DatabaseService.Select(Db.Contract.title))
            {
                while (read.Read())
                {
                    int purchaseId = Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Contract.purchaseId)));
                    contractsView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(Db.id)),
                        purchaseId,
                        read.GetValue(read.GetOrdinal(Db.Contract.summa)),
                        Contract.ToDateString((long)read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate))),
                        getStatus(purchaseId)
                    });
                }
            }
        }

        private string getStatus(int id)
        {
            using (var read = DatabaseService.Where(Db.Purchase.title, $"id = {id}"))
            {
                Status status = Status.Unfilled;
                while (read.Read())
                {
                    status = (Status)Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Purchase.status)));
                }
                switch (status)
                {
                    case Status.Unfilled:
                        return "Не выполнен";
                    case Status.Filled:
                        return "Выполнен";
                    default:
                        return "Не выполнен";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteContract_Click(object sender, EventArgs e)
        {
            var tmp = contractsView.SelectedRows.Count != 0 ? contractsView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == contractsView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var status = tmp.Cells[4].Value.ToString();
            if (status.ToLower().Contains("не выполнен"))
            {
                var result = MessageBox.Show(@"Договор, который Вы хотите удалить, не выполнен.
Желаете продолжить удаление?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{Db.id}", tmp.Cells[0].Value),
            };
            DatabaseService.Execute(Db.Contract.Delete, parameters);
            parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{Db.Service.purchaseId}", tmp.Cells[1].Value),
            };
            DatabaseService.Execute(Db.Service.Delete, parameters);
            parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{Db.id}", tmp.Cells[1].Value),
            };
            DatabaseService.Execute(Db.Purchase.Delete, parameters);
            viewData();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            var tmp = contractsView.SelectedRows.Count != 0 ? contractsView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == contractsView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tmp.Cells[4].Value.ToString() == "Выполнен")
            {
                MessageBox.Show("Данный заказ уже выполнен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{Db.Purchase.status}", Status.Filled),
                new SQLiteParameter($"@{Db.id}1", tmp.Cells[1].Value.ToString())
            };
            DatabaseService.Execute(Db.Purchase.UpdateStatus, parameters);
            viewData();
        }
    }
}
