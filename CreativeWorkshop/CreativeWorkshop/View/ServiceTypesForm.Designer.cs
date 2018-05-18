namespace CreativeWorkshop.View
{
    partial class ServiceTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceTypesForm));
            this.serviceTypesView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editServiceType = new System.Windows.Forms.Button();
            this.deleteServiceType = new System.Windows.Forms.Button();
            this.addServiceType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypesView)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceTypesView
            // 
            this.serviceTypesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceTypesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn});
            this.serviceTypesView.Location = new System.Drawing.Point(13, 13);
            this.serviceTypesView.Margin = new System.Windows.Forms.Padding(4);
            this.serviceTypesView.MultiSelect = false;
            this.serviceTypesView.Name = "serviceTypesView";
            this.serviceTypesView.Size = new System.Drawing.Size(544, 261);
            this.serviceTypesView.TabIndex = 3;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Название вида услуг";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            this.surnameColumn.Width = 250;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Цена за единицу услуги";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 250;
            // 
            // editServiceType
            // 
            this.editServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editServiceType.Location = new System.Drawing.Point(196, 289);
            this.editServiceType.Margin = new System.Windows.Forms.Padding(4);
            this.editServiceType.Name = "editServiceType";
            this.editServiceType.Size = new System.Drawing.Size(177, 34);
            this.editServiceType.TabIndex = 6;
            this.editServiceType.Text = "Изменить";
            this.editServiceType.UseVisualStyleBackColor = true;
            this.editServiceType.Click += new System.EventHandler(this.editType_Click);
            // 
            // deleteServiceType
            // 
            this.deleteServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteServiceType.Location = new System.Drawing.Point(380, 289);
            this.deleteServiceType.Margin = new System.Windows.Forms.Padding(4);
            this.deleteServiceType.Name = "deleteServiceType";
            this.deleteServiceType.Size = new System.Drawing.Size(177, 34);
            this.deleteServiceType.TabIndex = 5;
            this.deleteServiceType.Text = "Удалить";
            this.deleteServiceType.UseVisualStyleBackColor = true;
            this.deleteServiceType.Click += new System.EventHandler(this.deleteType_Click);
            // 
            // addServiceType
            // 
            this.addServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addServiceType.Location = new System.Drawing.Point(13, 289);
            this.addServiceType.Margin = new System.Windows.Forms.Padding(4);
            this.addServiceType.Name = "addServiceType";
            this.addServiceType.Size = new System.Drawing.Size(177, 34);
            this.addServiceType.TabIndex = 4;
            this.addServiceType.Text = "Добавить";
            this.addServiceType.UseVisualStyleBackColor = true;
            this.addServiceType.Click += new System.EventHandler(this.addType_Click);
            // 
            // ServiceTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(570, 331);
            this.Controls.Add(this.editServiceType);
            this.Controls.Add(this.deleteServiceType);
            this.Controls.Add(this.addServiceType);
            this.Controls.Add(this.serviceTypesView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ServiceTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виды услуг";
            this.Load += new System.EventHandler(this.TypeServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView serviceTypesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.Button editServiceType;
        private System.Windows.Forms.Button deleteServiceType;
        private System.Windows.Forms.Button addServiceType;

    }
}