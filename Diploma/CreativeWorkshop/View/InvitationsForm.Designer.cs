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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invitationText = new System.Windows.Forms.RichTextBox();
            this.overview_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listInv_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.font = new System.Windows.Forms.ComboBox();
            this.textSize = new System.Windows.Forms.ComboBox();
            this.formatText = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код договора:";
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.font.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font.FormattingEnabled = true;
            this.font.Location = new System.Drawing.Point(286, 182);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(163, 27);
            this.font.TabIndex = 7;
            this.font.Text = "Шрифт";
            // 
            // textSize
            // 
            this.textSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSize.FormattingEnabled = true;
            this.textSize.Location = new System.Drawing.Point(286, 226);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(163, 27);
            this.textSize.TabIndex = 8;
            this.textSize.Text = "Размер шрифта";
            // 
            // formatText
            // 
            this.formatText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.formatText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formatText.FormattingEnabled = true;
            this.formatText.Location = new System.Drawing.Point(286, 271);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(163, 27);
            this.formatText.TabIndex = 9;
            this.formatText.Text = "Формат";
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
            // InvitationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 378);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.formatText);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.font);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listInv_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.overview_btn);
            this.Controls.Add(this.invitationText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvitationsForm";
            this.Text = "Приглашения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox invitationText;
        private System.Windows.Forms.Button overview_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listInv_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.ComboBox textSize;
        private System.Windows.Forms.ComboBox formatText;
        private System.Windows.Forms.Button save_btn;
    }
}