namespace CreativeWorkshop.View
{
    partial class ContractsForm
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
            this.contractsView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteContract = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).BeginInit();
            this.SuspendLayout();
            // 
            // contractsView
            // 
            this.contractsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.purchaseIdColumn,
            this.summaColumn,
            this.deliveryDateColumn});
            this.contractsView.Location = new System.Drawing.Point(20, 19);
            this.contractsView.Margin = new System.Windows.Forms.Padding(6);
            this.contractsView.MultiSelect = false;
            this.contractsView.Name = "contractsView";
            this.contractsView.Size = new System.Drawing.Size(545, 223);
            this.contractsView.TabIndex = 3;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID Договора";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 125;
            // 
            // purchaseIdColumn
            // 
            this.purchaseIdColumn.HeaderText = "ID Заказа";
            this.purchaseIdColumn.Name = "purchaseIdColumn";
            this.purchaseIdColumn.ReadOnly = true;
            this.purchaseIdColumn.Width = 125;
            // 
            // summaColumn
            // 
            this.summaColumn.HeaderText = "Общая сумма";
            this.summaColumn.Name = "summaColumn";
            this.summaColumn.ReadOnly = true;
            this.summaColumn.Width = 125;
            // 
            // deliveryDateColumn
            // 
            this.deliveryDateColumn.HeaderText = "Дата";
            this.deliveryDateColumn.Name = "deliveryDateColumn";
            this.deliveryDateColumn.ReadOnly = true;
            this.deliveryDateColumn.Width = 125;
            // 
            // deleteContract
            // 
            this.deleteContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteContract.Location = new System.Drawing.Point(20, 252);
            this.deleteContract.Margin = new System.Windows.Forms.Padding(4);
            this.deleteContract.Name = "deleteContract";
            this.deleteContract.Size = new System.Drawing.Size(269, 34);
            this.deleteContract.TabIndex = 4;
            this.deleteContract.Text = "Удалить";
            this.deleteContract.UseVisualStyleBackColor = true;
            this.deleteContract.Click += new System.EventHandler(this.deleteContract_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.Location = new System.Drawing.Point(296, 252);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(269, 34);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 299);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteContract);
            this.Controls.Add(this.contractsView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.Contracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView contractsView;
        private System.Windows.Forms.Button deleteContract;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateColumn;
    }
}