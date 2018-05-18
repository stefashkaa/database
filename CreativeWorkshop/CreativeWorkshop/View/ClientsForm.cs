using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ClientsForm : Form
    {
        private string title = Db.PClients.title;

        public ClientsForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            phisView.MultiSelect = false;
            phisView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            legalView.MultiSelect = false;
            legalView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var user = AuthForm.User;
            if (user != null && user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                addClient.Enabled = !isDesigner;
                editClient.Enabled = !isDesigner;
                deleteClient.Enabled = !isDesigner;
            }
        }

        private void phisRb_CheckedChanged(object sender, EventArgs e)
        {
            phisView.Visible = true;
            legalView.Visible = false;
            title = Db.PClients.title;
            viewData();
        }

        private void legalRb_CheckedChanged(object sender, EventArgs e)
        {
            phisView.Visible = false;
            legalView.Visible = true;
            title = Db.LClients.title;
            viewData();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == Db.PClients.title;
            var addForm = new EditClientsForm(isPhys) { Text = "Добавить" };
            addForm.ShowDialog();
            if (!addForm.IsSaved)
            {
                MessageBox.Show("Данные не сохранены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isPhys)
            {
                var phys = addForm.pClient;
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{Db.PClients.surname}", phys.Surname),
                    new SQLiteParameter($"@{Db.PClients.name}", phys.Name),
                    new SQLiteParameter($"@{Db.PClients.patronymic}", phys.Patronymic),
                    new SQLiteParameter($"@{Db.Clients.address}", phys.Address),
                    new SQLiteParameter($"@{Db.Clients.mobile}", phys.Mobile),
                    new SQLiteParameter($"@{Db.Clients.email}", phys.Email)
                };
                DatabaseService.Execute(Db.PClients.Insert, parameters);
            }
            else
            {
                var legal = addForm.lClient;
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{Db.LClients.name}", legal.Name),
                    new SQLiteParameter($"@{Db.Clients.address}", legal.Address),
                    new SQLiteParameter($"@{Db.Clients.mobile}", legal.Mobile),
                    new SQLiteParameter($"@{Db.Clients.email}", legal.Email)
                };
                DatabaseService.Execute(Db.LClients.Insert, parameters);
            }
            viewData();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == Db.PClients.title;
            var view = (isPhys) ? phisView : legalView;
            var tmp = view.SelectedRows.Count != 0 ? view.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == view.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (isPhys)
            {
                parameters.Add(new SQLiteParameter($"@{Db.PClients.surname}", tmp.Cells[0].Value));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.name}", tmp.Cells[1].Value));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.patronymic}", tmp.Cells[2].Value));
                DatabaseService.Execute(Db.PClients.Delete, parameters);
            }
            else
            {
                parameters.Add(new SQLiteParameter($"@{Db.LClients.name}", tmp.Cells[0].Value));
                DatabaseService.Execute(Db.LClients.Delete, parameters);
            }
            viewData();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == Db.PClients.title;
            var view = (isPhys) ? phisView : legalView;
            var tmp = view.SelectedRows.Count != 0 ? view.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == view.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var editForm = new EditClientsForm(isPhys, tmp) { Text = "Редактировать" };
            editForm.ShowDialog();
            if (!editForm.IsSaved)
            {
                return;
            }
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (isPhys)
            {
                var phys = editForm.pClient;
                parameters.Add(new SQLiteParameter($"@{Db.PClients.surname}", phys.Surname));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.name}", phys.Name));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.patronymic}", phys.Patronymic));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.address}", phys.Address));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.mobile}", phys.Mobile));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.email}", phys.Email));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.surname}1", tmp.Cells[0].Value));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.name}1", tmp.Cells[1].Value));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.patronymic}1", tmp.Cells[2].Value));
                DatabaseService.Execute(Db.PClients.Update, parameters);
            }
            else
            {
                var legal = editForm.lClient;
                parameters.Add(new SQLiteParameter($"@{Db.PClients.name}", legal.Name));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.address}", legal.Address));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.mobile}", legal.Mobile));
                parameters.Add(new SQLiteParameter($"@{Db.Clients.email}", legal.Email));
                parameters.Add(new SQLiteParameter($"@{Db.PClients.name}1", tmp.Cells[0].Value));
                DatabaseService.Execute(Db.LClients.Update, parameters);
            }
            viewData();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            viewData();
        }

        private void viewData()
        {
            using (var read = DatabaseService.Select(title))
            {
                if (title == Db.PClients.title)
                {
                    phisView.Rows.Clear();
                    while (read.Read())
                    {
                        phisView.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal(Db.PClients.surname)),
                            read.GetValue(read.GetOrdinal(Db.PClients.name)),
                            read.GetValue(read.GetOrdinal(Db.PClients.patronymic)),
                            read.GetValue(read.GetOrdinal(Db.Clients.address)),
                            read.GetValue(read.GetOrdinal(Db.Clients.mobile)),
                            read.GetValue(read.GetOrdinal(Db.Clients.email))
                        });
                    }
                }
                else
                {
                    legalView.Rows.Clear();
                    while (read.Read())
                    {
                        legalView.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal(Db.LClients.name)),
                            read.GetValue(read.GetOrdinal(Db.Clients.address)),
                            read.GetValue(read.GetOrdinal(Db.Clients.mobile)),
                            read.GetValue(read.GetOrdinal(Db.Clients.email))
                        });
                    }
                }
            }
        }
    }
}
