﻿namespace CreativeWorkshop.View
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
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sum_txt = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.rub_txt = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.contractId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Дата выдачи заказа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(235, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Код договора:";
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
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(12, 231);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(226, 32);
            this.save_btn.TabIndex = 44;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Код заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Сумма:";
            // 
            // sum_txt
            // 
            this.sum_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sum_txt.Location = new System.Drawing.Point(101, 64);
            this.sum_txt.Name = "sum_txt";
            this.sum_txt.ReadOnly = true;
            this.sum_txt.Size = new System.Drawing.Size(117, 26);
            this.sum_txt.TabIndex = 50;
            this.sum_txt.Text = "0";
            this.sum_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(247, 231);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(226, 32);
            this.cancel_btn.TabIndex = 51;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // rub_txt
            // 
            this.rub_txt.AutoSize = true;
            this.rub_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rub_txt.Location = new System.Drawing.Point(224, 67);
            this.rub_txt.Name = "rub_txt";
            this.rub_txt.Size = new System.Drawing.Size(36, 19);
            this.rub_txt.TabIndex = 52;
            this.rub_txt.Text = "руб.";
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
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.contractId);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.rub_txt);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.sum_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label1);
            this.Name = "ContractForm";
            this.Text = "Договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sum_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label rub_txt;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox contractId;
    }
}