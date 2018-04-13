using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                deleteContract.Enabled = !isDesigner;
            }
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            contractsView.Rows.Clear();
            using (var read = DatabaseService.Select(DbConstants.Contract.title))
            {
                while (read.Read())
                {
                    int purchaseId = Convert.ToInt32(read.GetValue(read.GetOrdinal(DbConstants.Contract.purchaseId)));
                    contractsView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.id)),
                        purchaseId,
                        read.GetValue(read.GetOrdinal(DbConstants.Contract.summa)),
                        Contract.ToDateString((long)read.GetValue(read.GetOrdinal(DbConstants.Contract.deliveryDate))),
                        getStatus(purchaseId)
                    });
                }
            }
        }

        private string getStatus(int id)
        {
            using (var read = DatabaseService.Where(DbConstants.Purchase.title, $"id = {id}"))
            {
                Status status = Status.Unfilled;
                while (read.Read())
                {
                    status = (Status)Convert.ToInt32(read.GetValue(read.GetOrdinal(DbConstants.Purchase.status)));
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
            this.Close();
        }

        private void deleteContract_Click(object sender, EventArgs e)
        {
            var tmp = contractsView.SelectedRows.Count != 0 ? contractsView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == contractsView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var status = tmp.Cells[4].Value.ToString();
            if (status.ToLower().Contains("не выполнен"))
            {
                var result = MessageBox.Show(@"Договор, который Вы хотите удалить, не выполнен.
Желаете продолжить удаление?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var parameters1 = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.id}", tmp.Cells[1].Value),
            };
            DatabaseService.Execute(DbConstants.Purchase.Delete, parameters1);
            var parameters2 = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.id}", tmp.Cells[0].Value),
            };
            DatabaseService.Execute(DbConstants.Contract.Delete, parameters2);
            ViewData();
        }

        private void execute_btn_Click(object sender, EventArgs e)
        {
            var tmp = contractsView.SelectedRows.Count != 0 ? contractsView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == contractsView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tmp.Cells[4].Value.ToString() == "Выполнен")
            {
                MessageBox.Show("Данный заказ уже выполнен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.Purchase.status}", Status.Filled),
                new SQLiteParameter($"@{DbConstants.id}1", tmp.Cells[1].Value.ToString())
            };
            DatabaseService.Execute(DbConstants.Purchase.UpdateStatus, parameters);
            ViewData();
        }
    }
}
