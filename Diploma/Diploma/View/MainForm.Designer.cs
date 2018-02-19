namespace Diploma.View
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notExecuteOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invitationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNotExecute = new System.Windows.Forms.Label();
            this.view_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionariesToolStripMenuItem,
            this.workWithClientsToolStripMenuItem,
            this.queresToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionariesToolStripMenuItem
            // 
            this.dictionariesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.typeServicesToolStripMenuItem});
            this.dictionariesToolStripMenuItem.Name = "dictionariesToolStripMenuItem";
            this.dictionariesToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.dictionariesToolStripMenuItem.Text = "Справочники";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.employeesToolStripMenuItem.Text = "Сотрудники";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // typeServicesToolStripMenuItem
            // 
            this.typeServicesToolStripMenuItem.Name = "typeServicesToolStripMenuItem";
            this.typeServicesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.typeServicesToolStripMenuItem.Text = "Виды услуг";
            this.typeServicesToolStripMenuItem.Click += new System.EventHandler(this.typeServicesToolStripMenuItem_Click);
            // 
            // workWithClientsToolStripMenuItem
            // 
            this.workWithClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizationOrderToolStripMenuItem,
            this.executeServicesToolStripMenuItem});
            this.workWithClientsToolStripMenuItem.Name = "workWithClientsToolStripMenuItem";
            this.workWithClientsToolStripMenuItem.Size = new System.Drawing.Size(155, 23);
            this.workWithClientsToolStripMenuItem.Text = "Работа с клиентами";
            // 
            // organizationOrderToolStripMenuItem
            // 
            this.organizationOrderToolStripMenuItem.Name = "organizationOrderToolStripMenuItem";
            this.organizationOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.organizationOrderToolStripMenuItem.Text = "Формирование заказа";
            this.organizationOrderToolStripMenuItem.Click += new System.EventHandler(this.organizationOrderToolStripMenuItem_Click);
            // 
            // executeServicesToolStripMenuItem
            // 
            this.executeServicesToolStripMenuItem.Name = "executeServicesToolStripMenuItem";
            this.executeServicesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.executeServicesToolStripMenuItem.Text = "Выполнение услуг";
            this.executeServicesToolStripMenuItem.Click += new System.EventHandler(this.executeServicesToolStripMenuItem_Click);
            // 
            // queresToolStripMenuItem
            // 
            this.queresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeListToolStripMenuItem,
            this.notExecuteOrdersToolStripMenuItem,
            this.serviceListToolStripMenuItem});
            this.queresToolStripMenuItem.Name = "queresToolStripMenuItem";
            this.queresToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.queresToolStripMenuItem.Text = "Запросы";
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.employeeListToolStripMenuItem.Text = "Список сотрудников";
            // 
            // notExecuteOrdersToolStripMenuItem
            // 
            this.notExecuteOrdersToolStripMenuItem.Name = "notExecuteOrdersToolStripMenuItem";
            this.notExecuteOrdersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.notExecuteOrdersToolStripMenuItem.Text = "Невыполненные заказы";
            // 
            // serviceListToolStripMenuItem
            // 
            this.serviceListToolStripMenuItem.Name = "serviceListToolStripMenuItem";
            this.serviceListToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.serviceListToolStripMenuItem.Text = "Список услуг";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invitationsToolStripMenuItem,
            this.seatingMapToolStripMenuItem,
            this.statisticReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // invitationsToolStripMenuItem
            // 
            this.invitationsToolStripMenuItem.Name = "invitationsToolStripMenuItem";
            this.invitationsToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.invitationsToolStripMenuItem.Text = "Приглашения";
            this.invitationsToolStripMenuItem.Click += new System.EventHandler(this.invitationsToolStripMenuItem_Click);
            // 
            // seatingMapToolStripMenuItem
            // 
            this.seatingMapToolStripMenuItem.Name = "seatingMapToolStripMenuItem";
            this.seatingMapToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.seatingMapToolStripMenuItem.Text = "Карты рассадки";
            this.seatingMapToolStripMenuItem.Click += new System.EventHandler(this.seatingMapToolStripMenuItem_Click);
            // 
            // statisticReportsToolStripMenuItem
            // 
            this.statisticReportsToolStripMenuItem.Name = "statisticReportsToolStripMenuItem";
            this.statisticReportsToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.statisticReportsToolStripMenuItem.Text = "Статистические отчеты";
            this.statisticReportsToolStripMenuItem.Click += new System.EventHandler(this.statisticReportsToolStripMenuItem_Click);
            // 
            // labelNotExecute
            // 
            this.labelNotExecute.AutoSize = true;
            this.labelNotExecute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotExecute.Location = new System.Drawing.Point(12, 164);
            this.labelNotExecute.Name = "labelNotExecute";
            this.labelNotExecute.Size = new System.Drawing.Size(414, 19);
            this.labelNotExecute.TabIndex = 2;
            this.labelNotExecute.Text = "На                                       не выполнены следующие услуги:";
            // 
            // view_btn
            // 
            this.view_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_btn.Location = new System.Drawing.Point(16, 210);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(234, 32);
            this.view_btn.TabIndex = 3;
            this.view_btn.Text = "Показать";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(272, 210);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(235, 32);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime.Location = new System.Drawing.Point(41, 164);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(140, 20);
            this.dateTime.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 257);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelNotExecute);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Творческая мастерская\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invitationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticReportsToolStripMenuItem;
        private System.Windows.Forms.Label labelNotExecute;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}