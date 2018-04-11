namespace CreativeWorkshop.View
{
    partial class NotExecutePurchasesForm
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
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dateColumn});
            this.notExecutePurchasesView.Location = new System.Drawing.Point(15, 15);
            this.notExecutePurchasesView.Margin = new System.Windows.Forms.Padding(6);
            this.notExecutePurchasesView.MultiSelect = false;
            this.notExecutePurchasesView.Name = "notExecutePurchasesView";
            this.notExecutePurchasesView.Size = new System.Drawing.Size(394, 256);
            this.notExecutePurchasesView.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID Договора";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 175;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Дата выдачи";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 175;
            // 
            // NotExecutePurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 286);
            this.Controls.Add(this.notExecutePurchasesView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NotExecutePurchasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список невыполненных заказов";
            ((System.ComponentModel.ISupportInitialize)(this.notExecutePurchasesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView notExecutePurchasesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
    }
}