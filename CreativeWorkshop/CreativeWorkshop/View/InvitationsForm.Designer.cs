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
            this.label2 = new System.Windows.Forms.Label();
            this.invitationText = new System.Windows.Forms.RichTextBox();
            this.overview_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listInv_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.contractId_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст:";
            // 
            // invitationText
            // 
            this.invitationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invitationText.Location = new System.Drawing.Point(66, 67);
            this.invitationText.Name = "invitationText";
            this.invitationText.Size = new System.Drawing.Size(201, 299);
            this.invitationText.TabIndex = 2;
            this.invitationText.Text = "";
            // 
            // overview_btn
            // 
            this.overview_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overview_btn.Location = new System.Drawing.Point(286, 66);
            this.overview_btn.Name = "overview_btn";
            this.overview_btn.Size = new System.Drawing.Size(163, 32);
            this.overview_btn.TabIndex = 3;
            this.overview_btn.Text = "Обзор";
            this.overview_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(282, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список приглашенных:";
            // 
            // listInv_btn
            // 
            this.listInv_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listInv_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listInv_btn.Location = new System.Drawing.Point(286, 128);
            this.listInv_btn.Name = "listInv_btn";
            this.listInv_btn.Size = new System.Drawing.Size(163, 32);
            this.listInv_btn.TabIndex = 5;
            this.listInv_btn.Text = "Выбрать";
            this.listInv_btn.UseVisualStyleBackColor = true;
            this.listInv_btn.Click += new System.EventHandler(this.listInv_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(286, 334);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(163, 32);
            this.save_btn.TabIndex = 55;
            this.save_btn.Text = "Сохранить как";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontButton.Location = new System.Drawing.Point(286, 175);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(163, 32);
            this.fontButton.TabIndex = 63;
            this.fontButton.Text = "Шрифт";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // contractId_txt
            // 
            this.contractId_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractId_txt.DropDownWidth = 200;
            this.contractId_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractId_txt.FormattingEnabled = true;
            this.contractId_txt.Location = new System.Drawing.Point(121, 18);
            this.contractId_txt.Name = "contractId_txt";
            this.contractId_txt.Size = new System.Drawing.Size(146, 27);
            this.contractId_txt.TabIndex = 62;
            this.contractId_txt.SelectedIndexChanged += new System.EventHandler(this.contractId_txt_SelectedIndexChanged);
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
            // pageFormat
            // 
            this.pageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageFormat.DropDownWidth = 200;
            this.pageFormat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageFormat.FormattingEnabled = true;
            this.pageFormat.Location = new System.Drawing.Point(286, 253);
            this.pageFormat.Name = "pageFormat";
            this.pageFormat.Size = new System.Drawing.Size(163, 27);
            this.pageFormat.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Формат страницы:";
            // 
            // InvitationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pageFormat);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.contractId_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.listInv_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.overview_btn);
            this.Controls.Add(this.invitationText);
            this.Controls.Add(this.label2);
            this.Name = "InvitationsForm";
            this.Text = "Приглашения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox invitationText;
        private System.Windows.Forms.Button overview_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listInv_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.ComboBox contractId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox pageFormat;
        private System.Windows.Forms.Label label4;
    }
}