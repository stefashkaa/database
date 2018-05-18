namespace CreativeWorkshop.View
{
    partial class CreateContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateContractForm));
            this.dateLabel = new System.Windows.Forms.Label();
            this.contractIdLabel = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.purchaseIdLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.contractId = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(13, 126);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(142, 19);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "Дата выдачи заказа:";
            // 
            // contractIdLabel
            // 
            this.contractIdLabel.AutoSize = true;
            this.contractIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractIdLabel.Location = new System.Drawing.Point(235, 15);
            this.contractIdLabel.Name = "contractIdLabel";
            this.contractIdLabel.Size = new System.Drawing.Size(103, 19);
            this.contractIdLabel.TabIndex = 46;
            this.contractIdLabel.Text = "Код договора:";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime.Location = new System.Drawing.Point(161, 124);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(166, 26);
            this.dateTime.TabIndex = 45;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 231);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(226, 32);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // purchaseIdLabel
            // 
            this.purchaseIdLabel.AutoSize = true;
            this.purchaseIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseIdLabel.Location = new System.Drawing.Point(13, 15);
            this.purchaseIdLabel.Name = "purchaseIdLabel";
            this.purchaseIdLabel.Size = new System.Drawing.Size(82, 19);
            this.purchaseIdLabel.TabIndex = 42;
            this.purchaseIdLabel.Text = "Код заказа:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(38, 67);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(57, 19);
            this.sumLabel.TabIndex = 49;
            this.sumLabel.Text = "Сумма:";
            // 
            // sumText
            // 
            this.sumText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sumText.Location = new System.Drawing.Point(101, 64);
            this.sumText.Name = "sumText";
            this.sumText.ReadOnly = true;
            this.sumText.Size = new System.Drawing.Size(117, 26);
            this.sumText.TabIndex = 50;
            this.sumText.Text = "0";
            this.sumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(247, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(226, 32);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suffixLabel.Location = new System.Drawing.Point(224, 67);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(36, 19);
            this.suffixLabel.TabIndex = 52;
            this.suffixLabel.Text = "руб.";
            // 
            // orderId
            // 
            this.orderId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderId.Location = new System.Drawing.Point(101, 12);
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Size = new System.Drawing.Size(117, 26);
            this.orderId.TabIndex = 53;
            this.orderId.Text = "0";
            // 
            // contractId
            // 
            this.contractId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contractId.Location = new System.Drawing.Point(344, 12);
            this.contractId.Name = "contractId";
            this.contractId.ReadOnly = true;
            this.contractId.Size = new System.Drawing.Size(117, 26);
            this.contractId.TabIndex = 54;
            this.contractId.Text = "0";
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.Transparent;
            this.selectFolder.BackgroundImage = global::CreativeWorkshop.Properties.Resources.folder;
            this.selectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectFolder.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.selectFolder.FlatAppearance.BorderSize = 0;
            this.selectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.selectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFolder.Location = new System.Drawing.Point(157, 176);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(33, 32);
            this.selectFolder.TabIndex = 55;
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Файл списка имен:";
            // 
            // fileNameText
            // 
            this.fileNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileNameText.Location = new System.Drawing.Point(196, 180);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.ReadOnly = true;
            this.fileNameText.Size = new System.Drawing.Size(277, 26);
            this.fileNameText.TabIndex = 57;
            // 
            // CreateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.contractId);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sumText);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.contractIdLabel);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.purchaseIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label contractIdLabel;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label purchaseIdLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox sumText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox contractId;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameText;
    }
}