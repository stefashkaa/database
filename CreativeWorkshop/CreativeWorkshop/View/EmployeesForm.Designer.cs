namespace CreativeWorkshop
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesView
            // 
            this.employeesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.patronymicColumn,
            this.positionColumn,
            this.mobileColumn});
            this.employeesView.Location = new System.Drawing.Point(13, 13);
            this.employeesView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.Size = new System.Drawing.Size(593, 331);
            this.employeesView.TabIndex = 0;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Фамилия";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // patronymicColumn
            // 
            this.patronymicColumn.HeaderText = "Отчество";
            this.patronymicColumn.Name = "patronymicColumn";
            this.patronymicColumn.ReadOnly = true;
            // 
            // positionColumn
            // 
            this.positionColumn.HeaderText = "Должность";
            this.positionColumn.Name = "positionColumn";
            this.positionColumn.ReadOnly = true;
            // 
            // mobileColumn
            // 
            this.mobileColumn.HeaderText = "Телефон";
            this.mobileColumn.Name = "mobileColumn";
            this.mobileColumn.ReadOnly = true;
            this.mobileColumn.Width = 150;
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEmployee.Location = new System.Drawing.Point(13, 354);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(192, 34);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEmployee.Location = new System.Drawing.Point(414, 354);
            this.deleteEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(192, 34);
            this.deleteEmployee.TabIndex = 2;
            this.deleteEmployee.Text = "Удалить";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // editEmployee
            // 
            this.editEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editEmployee.Location = new System.Drawing.Point(214, 354);
            this.editEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(192, 34);
            this.editEmployee.TabIndex = 3;
            this.editEmployee.Text = "Изменить";
            this.editEmployee.UseVisualStyleBackColor = true;
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(619, 401);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.employeesView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileColumn;
    }
}

