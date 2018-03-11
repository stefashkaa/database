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
        private string title = DbConstants.PClients.title;

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
            if (user?.Role != Role.Unknown)
            {
                var isDesigner = user.Role == Role.Designer;
                addClient.Enabled = !isDesigner;
                editClient.Enabled = !isDesigner;
                deleteClient.Enabled = !isDesigner;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            phisView.Visible = true;
            legalView.Visible = false;
            title = DbConstants.PClients.title;
            ViewData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            phisView.Visible = false;
            legalView.Visible = true;
            title = DbConstants.LClients.title;
            ViewData();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == DbConstants.PClients.title;
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
                    new SQLiteParameter($"@{DbConstants.PClients.surname}", phys.Surname),
                    new SQLiteParameter($"@{DbConstants.PClients.name}", phys.Name),
                    new SQLiteParameter($"@{DbConstants.PClients.patronymic}", phys.Patronymic),
                    new SQLiteParameter($"@{DbConstants.PClients.address}", phys.Address),
                    new SQLiteParameter($"@{DbConstants.PClients.mobile}", phys.Mobile),
                    new SQLiteParameter($"@{DbConstants.PClients.email}", phys.Email)
                };
                DatabaseService.Execute(DbConstants.PClients.Insert, parameters);
            }
            else
            {
                var legal = addForm.lClient;
                var parameters = new List<SQLiteParameter>()
                {
                    new SQLiteParameter($"@{DbConstants.LClients.name}", legal.Name),
                    new SQLiteParameter($"@{DbConstants.LClients.address}", legal.Address),
                    new SQLiteParameter($"@{DbConstants.LClients.mobile}", legal.Mobile),
                    new SQLiteParameter($"@{DbConstants.LClients.email}", legal.Email)
                };
                DatabaseService.Execute(DbConstants.LClients.Insert, parameters);
            }
            ViewData();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == DbConstants.PClients.title;
            var view = (isPhys) ? phisView : legalView;
            var tmp = view.SelectedRows.Count != 0 ? view.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == view.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (isPhys)
            {
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.surname}", tmp.Cells[0].Value));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.name}", tmp.Cells[1].Value));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.patronymic}", tmp.Cells[2].Value));
                DatabaseService.Execute(DbConstants.PClients.Delete, parameters);
            }
            else
            {
                parameters.Add(new SQLiteParameter($"@{DbConstants.LClients.name}", tmp.Cells[0].Value));
                DatabaseService.Execute(DbConstants.LClients.Delete, parameters);
            }
            ViewData();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            var isPhys = title == DbConstants.PClients.title;
            var view = (isPhys) ? phisView : legalView;
            var tmp = view.SelectedRows.Count != 0 ? view.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == view.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.surname}", phys.Surname));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.name}", phys.Name));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.patronymic}", phys.Patronymic));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.address}", phys.Address));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.mobile}", phys.Mobile));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.email}", phys.Email));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.surname}1", tmp.Cells[0].Value));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.name}1", tmp.Cells[1].Value));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.patronymic}1", tmp.Cells[2].Value));
                DatabaseService.Execute(DbConstants.PClients.Update, parameters);
            }
            else
            {
                var legal = editForm.lClient;
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.name}", legal.Name));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.address}", legal.Address));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.mobile}", legal.Mobile));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.email}", legal.Email));
                parameters.Add(new SQLiteParameter($"@{DbConstants.PClients.name}1", tmp.Cells[0].Value));
                DatabaseService.Execute(DbConstants.LClients.Update, parameters);
            }
            ViewData();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            using (var read = DatabaseService.Select(title))
            {
                if (title == DbConstants.PClients.title)
                {
                    phisView.Rows.Clear();
                    while (read.Read())
                    {
                        phisView.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.surname)),
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.name)),
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.patronymic)),
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.address)),
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.mobile)),
                            read.GetValue(read.GetOrdinal(DbConstants.PClients.email))
                        });
                    }
                }
                else
                {
                    legalView.Rows.Clear();
                    while (read.Read())
                    {
                        legalView.Rows.Add(new object[] {
                            read.GetValue(read.GetOrdinal(DbConstants.LClients.name)),
                            read.GetValue(read.GetOrdinal(DbConstants.LClients.address)),
                            read.GetValue(read.GetOrdinal(DbConstants.LClients.mobile)),
                            read.GetValue(read.GetOrdinal(DbConstants.LClients.email))
                        });
                    }
                }
            }
        }
    }
}
