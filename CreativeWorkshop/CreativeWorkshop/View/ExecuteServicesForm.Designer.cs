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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesList = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.run_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.executeView)).BeginInit();
            this.SuspendLayout();
            // 
            // executeView
            // 
            this.executeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.Column1,
            this.employeesList});
            this.executeView.Location = new System.Drawing.Point(13, 55);
            this.executeView.Margin = new System.Windows.Forms.Padding(4);
            this.executeView.MultiSelect = false;
            this.executeView.Name = "executeView";
            this.executeView.Size = new System.Drawing.Size(745, 255);
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
            // Column1
            // 
            this.Column1.HeaderText = "Сумма за услугу";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // employeesList
            // 
            this.employeesList.HeaderText = "Сотрудник";
            this.employeesList.MinimumWidth = 150;
            this.employeesList.Name = "employeesList";
            this.employeesList.Width = 200;
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_txt.FormattingEnabled = true;
            this.id_txt.Location = new System.Drawing.Point(120, 13);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(174, 27);
            this.id_txt.TabIndex = 8;
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
            this.close_btn.Location = new System.Drawing.Point(379, 327);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(379, 32);
            this.close_btn.TabIndex = 55;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // run_btn
            // 
            this.run_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.run_btn.Location = new System.Drawing.Point(12, 327);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(361, 32);
            this.run_btn.TabIndex = 54;
            this.run_btn.Text = "Выполнить";
            this.run_btn.UseVisualStyleBackColor = true;
            // 
            // ExecuteServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 371);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.id_txt);
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
        private System.Windows.Forms.ComboBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeesList;
    }
}