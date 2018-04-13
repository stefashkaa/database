namespace CreativeWorkshop.View
{
    partial class ClientsForm
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
            this.editClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.phisView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physRb = new System.Windows.Forms.RadioButton();
            this.legalRb = new System.Windows.Forms.RadioButton();
            this.legalView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phisView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalView)).BeginInit();
            this.SuspendLayout();
            // 
            // editClient
            // 
            this.editClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editClient.Location = new System.Drawing.Point(252, 353);
            this.editClient.Margin = new System.Windows.Forms.Padding(4);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(226, 32);
            this.editClient.TabIndex = 7;
            this.editClient.Text = "Изменить";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteClient.Location = new System.Drawing.Point(486, 353);
            this.deleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(226, 32);
            this.deleteClient.TabIndex = 6;
            this.deleteClient.Text = "Удалить";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addClient.Location = new System.Drawing.Point(18, 353);
            this.addClient.Margin = new System.Windows.Forms.Padding(4);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(226, 32);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // phisView
            // 
            this.phisView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phisView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phisView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.patronymicColumn,
            this.positionColumn,
            this.mobileColumn,
            this.Column1});
            this.phisView.Location = new System.Drawing.Point(18, 18);
            this.phisView.Margin = new System.Windows.Forms.Padding(4);
            this.phisView.MultiSelect = false;
            this.phisView.Name = "phisView";
            this.phisView.Size = new System.Drawing.Size(694, 327);
            this.phisView.TabIndex = 4;
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
            this.positionColumn.HeaderText = "Адрес";
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
            // Column1
            // 
            this.Column1.HeaderText = "E-mail";
            this.Column1.Name = "Column1";
            // 
            // physRb
            // 
            this.physRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.physRb.AutoSize = true;
            this.physRb.Checked = true;
            this.physRb.Location = new System.Drawing.Point(720, 18);
            this.physRb.Margin = new System.Windows.Forms.Padding(4);
            this.physRb.Name = "physRb";
            this.physRb.Size = new System.Drawing.Size(145, 23);
            this.physRb.TabIndex = 8;
            this.physRb.TabStop = true;
            this.physRb.Text = "Физическое лицо";
            this.physRb.UseVisualStyleBackColor = true;
            this.physRb.CheckedChanged += new System.EventHandler(this.phisRb_CheckedChanged);
            // 
            // legalRb
            // 
            this.legalRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.legalRb.AutoSize = true;
            this.legalRb.Location = new System.Drawing.Point(720, 49);
            this.legalRb.Margin = new System.Windows.Forms.Padding(4);
            this.legalRb.Name = "legalRb";
            this.legalRb.Size = new System.Drawing.Size(158, 23);
            this.legalRb.TabIndex = 9;
            this.legalRb.Text = "Юридическое лицо";
            this.legalRb.UseVisualStyleBackColor = true;
            this.legalRb.CheckedChanged += new System.EventHandler(this.legalRb_CheckedChanged);
            // 
            // legalView
            // 
            this.legalView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.legalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.legalView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.legalView.Location = new System.Drawing.Point(18, 18);
            this.legalView.Margin = new System.Windows.Forms.Padding(4);
            this.legalView.MultiSelect = false;
            this.legalView.Name = "legalView";
            this.legalView.Size = new System.Drawing.Size(694, 327);
            this.legalView.TabIndex = 10;
            this.legalView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название организации";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 401);
            this.Controls.Add(this.legalView);
            this.Controls.Add(this.legalRb);
            this.Controls.Add(this.physRb);
            this.Controls.Add(this.editClient);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.phisView);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phisView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.DataGridView phisView;
        private System.Windows.Forms.RadioButton physRb;
        private System.Windows.Forms.RadioButton legalRb;
        private System.Windows.Forms.DataGridView legalView;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}