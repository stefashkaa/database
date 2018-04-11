namespace CreativeWorkshop
{
    partial class ServicesWithoutExecutorForm
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
            this.notExecutePurchasesView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.notExecutePurchasesView)).BeginInit();
            this.SuspendLayout();
            // 
            // notExecutePurchasesView
            // 
            this.notExecutePurchasesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notExecutePurchasesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notExecutePurchasesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.serviceNameColumn});
            this.notExecutePurchasesView.Location = new System.Drawing.Point(15, 15);
            this.notExecutePurchasesView.Margin = new System.Windows.Forms.Padding(6);
            this.notExecutePurchasesView.MultiSelect = false;
            this.notExecutePurchasesView.Name = "notExecutePurchasesView";
            this.notExecutePurchasesView.Size = new System.Drawing.Size(395, 216);
            this.notExecutePurchasesView.TabIndex = 5;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID Договора";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 175;
            // 
            // serviceNameColumn
            // 
            this.serviceNameColumn.HeaderText = "Услуга";
            this.serviceNameColumn.Name = "serviceNameColumn";
            this.serviceNameColumn.ReadOnly = true;
            this.serviceNameColumn.Width = 175;
            // 
            // ServicesWithoutExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.notExecutePurchasesView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServicesWithoutExecutorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги без исполнителя";
            ((System.ComponentModel.ISupportInitialize)(this.notExecutePurchasesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView notExecutePurchasesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameColumn;
    }
}