namespace CreativeWorkshop.View
{
    partial class PurchaseEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseEmployeesForm));
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.employeesView.Margin = new System.Windows.Forms.Padding(4);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.Size = new System.Drawing.Size(593, 379);
            this.employeesView.TabIndex = 1;
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
            // PurchaseEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(619, 405);
            this.Controls.Add(this.employeesView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PurchaseEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileColumn;
    }
}