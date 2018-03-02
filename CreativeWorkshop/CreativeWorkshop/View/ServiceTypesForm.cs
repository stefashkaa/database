using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class ServiceTypesForm : Form
    {
        public ServiceTypesForm()
        {
            InitializeComponent();
            serviceTypesView.MultiSelect = false;
            serviceTypesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void addType_Click(object sender, EventArgs e)
        {
            var addForm = new EditServiceTypesForm() { Text = "Добавить" };
            addForm.ShowDialog();
            if (!addForm.IsSaved)
            {
                return;
            }
            var type = addForm.ServiceType;
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.ServiceTypes.name}", type.Name),
                new SQLiteParameter($"@{DbConstants.ServiceTypes.price}", type.Price),
            };
            DatabaseService.Execute(DbConstants.ServiceTypes.Insert, parameters);
            ViewData();
        }

        private void deleteType_Click(object sender, EventArgs e)
        {
            var tmp = serviceTypesView.SelectedRows.Count != 0 ? serviceTypesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == serviceTypesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.ServiceTypes.name}", tmp.Cells[0].Value)
            };
            DatabaseService.Execute(DbConstants.ServiceTypes.Delete, parameters);
            ViewData();
        }

        private void editType_Click(object sender, EventArgs e)
        {
            var tmp = serviceTypesView.SelectedRows.Count != 0 ? serviceTypesView.SelectedRows[0] : null;
            if (tmp == null || tmp.Index == serviceTypesView.Rows.Count - 1)
            {
                MessageBox.Show("Ничего не выбрано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var editForm = new EditServiceTypesForm(tmp) { Text = "Редактировать" };
            editForm.ShowDialog();
            if (!editForm.IsSaved)
            {
                return;
            }

            var type = editForm.ServiceType;
            var parameters = new List<SQLiteParameter>()
            {
                new SQLiteParameter($"@{DbConstants.ServiceTypes.name}", type.Name),
                new SQLiteParameter($"@{DbConstants.ServiceTypes.price}", type.Price),
                new SQLiteParameter($"@{DbConstants.ServiceTypes.name}1", tmp.Cells[0].Value)
            };
            DatabaseService.Execute(DbConstants.ServiceTypes.Update, parameters);
            ViewData();
        }

        private void TypeServicesForm_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            serviceTypesView.Rows.Clear();
            using (var read = DatabaseService.Select(DbConstants.ServiceTypes.title))
            {
                while (read.Read())
                {
                    serviceTypesView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal(DbConstants.ServiceTypes.name)),
                        read.GetValue(read.GetOrdinal(DbConstants.ServiceTypes.price))
                    });
                }
            }
        }
    }
}
