namespace CreativeWorkshop.View
{
    partial class InvitationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvitationsForm));
            this.invitationText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listInvButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.contractIdText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.clientName = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // invitationText
            // 
            this.invitationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invitationText.BackColor = System.Drawing.Color.White;
            this.invitationText.Location = new System.Drawing.Point(16, 56);
            this.invitationText.Name = "invitationText";
            this.invitationText.ReadOnly = true;
            this.invitationText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.invitationText.Size = new System.Drawing.Size(251, 323);
            this.invitationText.TabIndex = 2;
            this.invitationText.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(282, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список приглашенных:";
            // 
            // listInvButton
            // 
            this.listInvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listInvButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listInvButton.Location = new System.Drawing.Point(286, 153);
            this.listInvButton.Name = "listInvButton";
            this.listInvButton.Size = new System.Drawing.Size(163, 32);
            this.listInvButton.TabIndex = 5;
            this.listInvButton.Text = "Выбрать";
            this.listInvButton.UseVisualStyleBackColor = true;
            this.listInvButton.Click += new System.EventHandler(this.listInv_btn_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(286, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 32);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Сохранить как";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontButton.Location = new System.Drawing.Point(286, 191);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(163, 32);
            this.fontButton.TabIndex = 63;
            this.fontButton.Text = "Шрифт";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // contractIdText
            // 
            this.contractIdText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractIdText.DropDownWidth = 200;
            this.contractIdText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractIdText.FormattingEnabled = true;
            this.contractIdText.Location = new System.Drawing.Point(121, 18);
            this.contractIdText.Name = "contractIdText";
            this.contractIdText.Size = new System.Drawing.Size(95, 27);
            this.contractIdText.TabIndex = 62;
            this.contractIdText.SelectedIndexChanged += new System.EventHandler(this.contractId_txt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Код договора:";
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientName.Location = new System.Drawing.Point(222, 18);
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Size = new System.Drawing.Size(227, 26);
            this.clientName.TabIndex = 64;
            this.clientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(222, 392);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(45, 32);
            this.nextButton.TabIndex = 65;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prevButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.Location = new System.Drawing.Point(171, 392);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(45, 32);
            this.prevButton.TabIndex = 66;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // numberText
            // 
            this.numberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberText.Location = new System.Drawing.Point(16, 399);
            this.numberText.Name = "numberText";
            this.numberText.ReadOnly = true;
            this.numberText.Size = new System.Drawing.Size(45, 19);
            this.numberText.TabIndex = 67;
            this.numberText.Text = "1";
            this.numberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(67, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "из";
            // 
            // countText
            // 
            this.countText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countText.Location = new System.Drawing.Point(97, 399);
            this.countText.Name = "countText";
            this.countText.ReadOnly = true;
            this.countText.Size = new System.Drawing.Size(45, 19);
            this.countText.TabIndex = 69;
            this.countText.Text = "1";
            this.countText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textButton
            // 
            this.textButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textButton.Location = new System.Drawing.Point(286, 96);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(163, 32);
            this.textButton.TabIndex = 70;
            this.textButton.Text = "Текст";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InvitationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 436);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.contractIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listInvButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invitationText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InvitationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приглашения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox invitationText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listInvButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.ComboBox contractIdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}