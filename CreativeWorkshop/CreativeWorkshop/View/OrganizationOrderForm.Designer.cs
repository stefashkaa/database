namespace CreativeWorkshop.View
{
    partial class OrganizationOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationOrderForm));
            this.close_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFirst = new System.Windows.Forms.DateTimePicker();
            this.clientId_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.legal_rb = new System.Windows.Forms.RadioButton();
            this.phys_rb = new System.Windows.Forms.RadioButton();
            this.service_txt1 = new System.Windows.Forms.ComboBox();
            this.serviceName1 = new System.Windows.Forms.Label();
            this.countName1 = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.NumericUpDown();
            this.deleteService1 = new System.Windows.Forms.Button();
            this.firstSum_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimeLast = new System.Windows.Forms.DateTimePicker();
            this.send_btn = new System.Windows.Forms.Button();
            this.row1 = new System.Windows.Forms.Panel();
            this.addService = new System.Windows.Forms.Button();
            this.servicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rub_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count1)).BeginInit();
            this.row1.SuspendLayout();
            this.servicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(399, 426);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(203, 32);
            this.close_btn.TabIndex = 19;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Первоначальный взнос:";
            // 
            // dateTimeFirst
            // 
            this.dateTimeFirst.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeFirst.Location = new System.Drawing.Point(188, 331);
            this.dateTimeFirst.Name = "dateTimeFirst";
            this.dateTimeFirst.Size = new System.Drawing.Size(166, 26);
            this.dateTimeFirst.TabIndex = 20;
            // 
            // clientId_txt
            // 
            this.clientId_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientId_txt.DropDownWidth = 200;
            this.clientId_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientId_txt.FormattingEnabled = true;
            this.clientId_txt.Location = new System.Drawing.Point(81, 20);
            this.clientId_txt.Name = "clientId_txt";
            this.clientId_txt.Size = new System.Drawing.Size(117, 27);
            this.clientId_txt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Клиент:";
            // 
            // legal_rb
            // 
            this.legal_rb.AutoSize = true;
            this.legal_rb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legal_rb.Location = new System.Drawing.Point(438, 56);
            this.legal_rb.Name = "legal_rb";
            this.legal_rb.Size = new System.Drawing.Size(158, 23);
            this.legal_rb.TabIndex = 25;
            this.legal_rb.Text = "Юридическое лицо";
            this.legal_rb.UseVisualStyleBackColor = true;
            this.legal_rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // phys_rb
            // 
            this.phys_rb.AutoSize = true;
            this.phys_rb.Checked = true;
            this.phys_rb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phys_rb.Location = new System.Drawing.Point(438, 19);
            this.phys_rb.Name = "phys_rb";
            this.phys_rb.Size = new System.Drawing.Size(145, 23);
            this.phys_rb.TabIndex = 24;
            this.phys_rb.TabStop = true;
            this.phys_rb.Text = "Физическое лицо";
            this.phys_rb.UseVisualStyleBackColor = true;
            this.phys_rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // service_txt1
            // 
            this.service_txt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_txt1.DropDownWidth = 200;
            this.service_txt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_txt1.FormattingEnabled = true;
            this.service_txt1.Location = new System.Drawing.Point(169, 12);
            this.service_txt1.Name = "service_txt1";
            this.service_txt1.Size = new System.Drawing.Size(117, 27);
            this.service_txt1.TabIndex = 27;
            // 
            // serviceName1
            // 
            this.serviceName1.AutoSize = true;
            this.serviceName1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceName1.Location = new System.Drawing.Point(3, 15);
            this.serviceName1.Name = "serviceName1";
            this.serviceName1.Size = new System.Drawing.Size(160, 19);
            this.serviceName1.TabIndex = 26;
            this.serviceName1.Text = "Название вида услуги:";
            // 
            // countName1
            // 
            this.countName1.AutoSize = true;
            this.countName1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countName1.Location = new System.Drawing.Point(305, 15);
            this.countName1.Name = "countName1";
            this.countName1.Size = new System.Drawing.Size(92, 19);
            this.countName1.TabIndex = 28;
            this.countName1.Text = "Количество:";
            // 
            // count1
            // 
            this.count1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count1.Location = new System.Drawing.Point(403, 13);
            this.count1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(66, 26);
            this.count1.TabIndex = 29;
            this.count1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteService1
            // 
            this.deleteService1.Enabled = false;
            this.deleteService1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteService1.Location = new System.Drawing.Point(480, 12);
            this.deleteService1.Name = "deleteService1";
            this.deleteService1.Size = new System.Drawing.Size(48, 27);
            this.deleteService1.TabIndex = 38;
            this.deleteService1.Text = "-";
            this.deleteService1.UseVisualStyleBackColor = true;
            // 
            // firstSum_txt
            // 
            this.firstSum_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSum_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstSum_txt.Location = new System.Drawing.Point(188, 285);
            this.firstSum_txt.MaxLength = 10;
            this.firstSum_txt.Name = "firstSum_txt";
            this.firstSum_txt.Size = new System.Drawing.Size(108, 26);
            this.firstSum_txt.TabIndex = 40;
            this.firstSum_txt.Text = "0";
            this.firstSum_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Дата приема заказа:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Срок исполнения:";
            // 
            // dateTimeLast
            // 
            this.dateTimeLast.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeLast.Location = new System.Drawing.Point(188, 377);
            this.dateTimeLast.Name = "dateTimeLast";
            this.dateTimeLast.Size = new System.Drawing.Size(166, 26);
            this.dateTimeLast.TabIndex = 43;
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.send_btn.Location = new System.Drawing.Point(188, 426);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(205, 32);
            this.send_btn.TabIndex = 44;
            this.send_btn.Text = "Оформить заказ";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.contract_Click);
            // 
            // row1
            // 
            this.row1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row1.Controls.Add(this.serviceName1);
            this.row1.Controls.Add(this.service_txt1);
            this.row1.Controls.Add(this.countName1);
            this.row1.Controls.Add(this.count1);
            this.row1.Controls.Add(this.deleteService1);
            this.row1.Location = new System.Drawing.Point(3, 3);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(540, 50);
            this.row1.TabIndex = 0;
            // 
            // addService
            // 
            this.addService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addService.Location = new System.Drawing.Point(568, 85);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(34, 194);
            this.addService.TabIndex = 39;
            this.addService.Text = "+";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // servicePanel
            // 
            this.servicePanel.AutoScroll = true;
            this.servicePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servicePanel.Controls.Add(this.row1);
            this.servicePanel.Location = new System.Drawing.Point(12, 85);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(550, 194);
            this.servicePanel.TabIndex = 45;
            // 
            // rub_txt
            // 
            this.rub_txt.AutoSize = true;
            this.rub_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rub_txt.Location = new System.Drawing.Point(302, 288);
            this.rub_txt.Name = "rub_txt";
            this.rub_txt.Size = new System.Drawing.Size(36, 19);
            this.rub_txt.TabIndex = 46;
            this.rub_txt.Text = "руб.";
            // 
            // OrganizationOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 470);
            this.Controls.Add(this.rub_txt);
            this.Controls.Add(this.servicePanel);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.dateTimeLast);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.firstSum_txt);
            this.Controls.Add(this.legal_rb);
            this.Controls.Add(this.phys_rb);
            this.Controls.Add(this.clientId_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeFirst);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrganizationOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование заказа";
            ((System.ComponentModel.ISupportInitialize)(this.count1)).EndInit();
            this.row1.ResumeLayout(false);
            this.row1.PerformLayout();
            this.servicePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFirst;
        private System.Windows.Forms.ComboBox clientId_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton legal_rb;
        private System.Windows.Forms.RadioButton phys_rb;
        private System.Windows.Forms.ComboBox service_txt1;
        private System.Windows.Forms.Label serviceName1;
        private System.Windows.Forms.Label countName1;
        private System.Windows.Forms.NumericUpDown count1;
        private System.Windows.Forms.Button deleteService1;
        private System.Windows.Forms.TextBox firstSum_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeLast;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Panel row1;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.FlowLayoutPanel servicePanel;
        private System.Windows.Forms.Label rub_txt;
    }
}