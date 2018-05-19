namespace CreativeWorkshop.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notExecuteOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close_btn = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.auth_txt = new System.Windows.Forms.Label();
            this.invitationsButton = new System.Windows.Forms.Button();
            this.seatingMapButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.contractsView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionariesToolStripMenuItem,
            this.workWithClientsToolStripMenuItem,
            this.queresToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionariesToolStripMenuItem
            // 
            this.dictionariesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.dictionariesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.typeServicesToolStripMenuItem,
            this.договорыToolStripMenuItem});
            this.dictionariesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dictionariesToolStripMenuItem.Name = "dictionariesToolStripMenuItem";
            this.dictionariesToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.dictionariesToolStripMenuItem.Text = "Справочники";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.employeesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.employeesToolStripMenuItem.Text = "Сотрудники";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // typeServicesToolStripMenuItem
            // 
            this.typeServicesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.typeServicesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.typeServicesToolStripMenuItem.Name = "typeServicesToolStripMenuItem";
            this.typeServicesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.typeServicesToolStripMenuItem.Text = "Виды услуг";
            this.typeServicesToolStripMenuItem.Click += new System.EventHandler(this.typeServicesToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.договорыToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.contractsToolStripMenuItem_Click);
            // 
            // workWithClientsToolStripMenuItem
            // 
            this.workWithClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizationOrderToolStripMenuItem,
            this.executeServicesToolStripMenuItem});
            this.workWithClientsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.workWithClientsToolStripMenuItem.Name = "workWithClientsToolStripMenuItem";
            this.workWithClientsToolStripMenuItem.Size = new System.Drawing.Size(155, 23);
            this.workWithClientsToolStripMenuItem.Text = "Работа с клиентами";
            // 
            // organizationOrderToolStripMenuItem
            // 
            this.organizationOrderToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.organizationOrderToolStripMenuItem.Name = "organizationOrderToolStripMenuItem";
            this.organizationOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.organizationOrderToolStripMenuItem.Text = "Формирование заказа";
            this.organizationOrderToolStripMenuItem.Click += new System.EventHandler(this.organizationOrderToolStripMenuItem_Click);
            // 
            // executeServicesToolStripMenuItem
            // 
            this.executeServicesToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.executeServicesToolStripMenuItem.Name = "executeServicesToolStripMenuItem";
            this.executeServicesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.executeServicesToolStripMenuItem.Text = "Выполнение услуг";
            this.executeServicesToolStripMenuItem.Click += new System.EventHandler(this.executeServicesToolStripMenuItem_Click);
            // 
            // queresToolStripMenuItem
            // 
            this.queresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeListToolStripMenuItem,
            this.serviceListToolStripMenuItem,
            this.notExecuteOrdersToolStripMenuItem});
            this.queresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.queresToolStripMenuItem.Name = "queresToolStripMenuItem";
            this.queresToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.queresToolStripMenuItem.Text = "Запросы";
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.employeeListToolStripMenuItem.Text = "Список сотрудников";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // serviceListToolStripMenuItem
            // 
            this.serviceListToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.serviceListToolStripMenuItem.Name = "serviceListToolStripMenuItem";
            this.serviceListToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.serviceListToolStripMenuItem.Text = "Услуги без исполнителя";
            this.serviceListToolStripMenuItem.Click += new System.EventHandler(this.servicesWithoutExecutorToolStripMenuItem_Click);
            // 
            // notExecuteOrdersToolStripMenuItem
            // 
            this.notExecuteOrdersToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.notExecuteOrdersToolStripMenuItem.Name = "notExecuteOrdersToolStripMenuItem";
            this.notExecuteOrdersToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.notExecuteOrdersToolStripMenuItem.Text = "Невыполненные заказы";
            this.notExecuteOrdersToolStripMenuItem.Click += new System.EventHandler(this.notExecuteOrdersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.close_btn.Location = new System.Drawing.Point(563, 43);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(95, 32);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Выход";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(336, 50);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(110, 19);
            this.labelAuth.TabIndex = 6;
            this.labelAuth.Text = "Вы вошли как: ";
            // 
            // auth_txt
            // 
            this.auth_txt.AutoSize = true;
            this.auth_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_txt.Location = new System.Drawing.Point(452, 50);
            this.auth_txt.Name = "auth_txt";
            this.auth_txt.Size = new System.Drawing.Size(0, 19);
            this.auth_txt.TabIndex = 7;
            // 
            // invitationsButton
            // 
            this.invitationsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.invitationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.invitationsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitationsButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.invitationsButton.Location = new System.Drawing.Point(361, 117);
            this.invitationsButton.Name = "invitationsButton";
            this.invitationsButton.Size = new System.Drawing.Size(297, 32);
            this.invitationsButton.TabIndex = 8;
            this.invitationsButton.Text = "Приглашения";
            this.invitationsButton.UseVisualStyleBackColor = false;
            this.invitationsButton.Click += new System.EventHandler(this.invitationsButton_Click);
            // 
            // seatingMapButton
            // 
            this.seatingMapButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.seatingMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seatingMapButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatingMapButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.seatingMapButton.Location = new System.Drawing.Point(361, 169);
            this.seatingMapButton.Name = "seatingMapButton";
            this.seatingMapButton.Size = new System.Drawing.Size(297, 32);
            this.seatingMapButton.TabIndex = 9;
            this.seatingMapButton.Text = "Карты рассадки";
            this.seatingMapButton.UseVisualStyleBackColor = false;
            this.seatingMapButton.Click += new System.EventHandler(this.seatingMapButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::CreativeWorkshop.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 87);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(330, 281);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // contractsView
            // 
            this.contractsView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contractsView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contractsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.deliveryDateColumn});
            this.contractsView.GridColor = System.Drawing.Color.LightCoral;
            this.contractsView.Location = new System.Drawing.Point(361, 285);
            this.contractsView.Margin = new System.Windows.Forms.Padding(6);
            this.contractsView.MultiSelect = false;
            this.contractsView.Name = "contractsView";
            this.contractsView.Size = new System.Drawing.Size(294, 174);
            this.contractsView.TabIndex = 11;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID Договора";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 125;
            // 
            // deliveryDateColumn
            // 
            this.deliveryDateColumn.HeaderText = "Срок выдачи";
            this.deliveryDateColumn.Name = "deliveryDateColumn";
            this.deliveryDateColumn.ReadOnly = true;
            this.deliveryDateColumn.Width = 125;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(427, 260);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(171, 19);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Невыполненные заказы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 474);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.contractsView);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.seatingMapButton);
            this.Controls.Add(this.invitationsButton);
            this.Controls.Add(this.auth_txt);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Творческая мастерская\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dictionariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workWithClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notExecuteOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceListToolStripMenuItem;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label auth_txt;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.Button invitationsButton;
        private System.Windows.Forms.Button seatingMapButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView contractsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateColumn;
        private System.Windows.Forms.Label infoLabel;
    }
}