namespace CreativeWorkshop.View
{
    partial class ExecuteServicesForm
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
            this.executeView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.contractId_txt = new System.Windows.Forms.ComboBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.executeView)).BeginInit();
            this.SuspendLayout();
            // 
            // executeView
            // 
            this.executeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.employeesList});
            this.executeView.Location = new System.Drawing.Point(13, 55);
            this.executeView.Margin = new System.Windows.Forms.Padding(4);
            this.executeView.MultiSelect = false;
            this.executeView.Name = "executeView";
            this.executeView.Size = new System.Drawing.Size(544, 255);
            this.executeView.TabIndex = 4;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Название услуги";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            this.surnameColumn.Width = 200;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Количество";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // employeesList
            // 
            this.employeesList.HeaderText = "Сотрудник";
            this.employeesList.MinimumWidth = 150;
            this.employeesList.Name = "employeesList";
            this.employeesList.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код договора:";
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(282, 327);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(275, 32);
            this.close_btn.TabIndex = 55;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // contractId_txt
            // 
            this.contractId_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractId_txt.DropDownWidth = 200;
            this.contractId_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractId_txt.FormattingEnabled = true;
            this.contractId_txt.Location = new System.Drawing.Point(119, 13);
            this.contractId_txt.Name = "contractId_txt";
            this.contractId_txt.Size = new System.Drawing.Size(117, 27);
            this.contractId_txt.TabIndex = 56;
            this.contractId_txt.SelectedIndexChanged += new System.EventHandler(this.contractId_txt_SelectedIndexChanged);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientName.Location = new System.Drawing.Point(439, 13);
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Size = new System.Drawing.Size(117, 26);
            this.clientName.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(370, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Клиент:";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(12, 327);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(264, 32);
            this.save_btn.TabIndex = 59;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ExecuteServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 371);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractId_txt);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executeView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExecuteServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнение услуг";
            ((System.ComponentModel.ISupportInitialize)(this.executeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView executeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox contractId_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeesList;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_btn;
    }
}