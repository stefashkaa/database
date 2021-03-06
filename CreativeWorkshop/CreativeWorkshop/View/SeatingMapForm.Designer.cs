﻿namespace CreativeWorkshop.View
{
    partial class SeatingMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatingMapForm));
            this.save_btn = new System.Windows.Forms.Button();
            this.listInv_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contractId_txt = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.font_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.A4_1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.A4_2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.A4_4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.A4_3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.A4_1.SuspendLayout();
            this.A4_2.SuspendLayout();
            this.A4_4.SuspendLayout();
            this.A4_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(278, 308);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(205, 32);
            this.save_btn.TabIndex = 19;
            this.save_btn.Text = "Сохранить как";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // listInv_btn
            // 
            this.listInv_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listInv_btn.Location = new System.Drawing.Point(320, 98);
            this.listInv_btn.Name = "listInv_btn";
            this.listInv_btn.Size = new System.Drawing.Size(163, 32);
            this.listInv_btn.TabIndex = 15;
            this.listInv_btn.Text = "Выбрать";
            this.listInv_btn.UseVisualStyleBackColor = true;
            this.listInv_btn.Click += new System.EventHandler(this.listInv_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(316, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Список приглашенных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пример:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код договора:";
            // 
            // contractId_txt
            // 
            this.contractId_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractId_txt.DropDownWidth = 200;
            this.contractId_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractId_txt.FormattingEnabled = true;
            this.contractId_txt.Location = new System.Drawing.Point(121, 17);
            this.contractId_txt.Name = "contractId_txt";
            this.contractId_txt.Size = new System.Drawing.Size(129, 27);
            this.contractId_txt.TabIndex = 59;
            this.contractId_txt.SelectedIndexChanged += new System.EventHandler(this.contractId_txt_SelectedIndexChanged);
            // 
            // font_btn
            // 
            this.font_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font_btn.Location = new System.Drawing.Point(320, 149);
            this.font_btn.Name = "font_btn";
            this.font_btn.Size = new System.Drawing.Size(163, 32);
            this.font_btn.TabIndex = 60;
            this.font_btn.Text = "Шрифт";
            this.font_btn.UseVisualStyleBackColor = true;
            this.font_btn.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // A4_1
            // 
            this.A4_1.BackColor = System.Drawing.Color.White;
            this.A4_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4_1.Controls.Add(this.textBox1);
            this.A4_1.Location = new System.Drawing.Point(80, 76);
            this.A4_1.Name = "A4_1";
            this.A4_1.Size = new System.Drawing.Size(83, 129);
            this.A4_1.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(3, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 13);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "Имя";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A4_2
            // 
            this.A4_2.BackColor = System.Drawing.Color.White;
            this.A4_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4_2.Controls.Add(this.textBox2);
            this.A4_2.Location = new System.Drawing.Point(169, 76);
            this.A4_2.Name = "A4_2";
            this.A4_2.Size = new System.Drawing.Size(83, 129);
            this.A4_2.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(3, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(75, 13);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "Имя";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A4_4
            // 
            this.A4_4.BackColor = System.Drawing.Color.White;
            this.A4_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4_4.Controls.Add(this.textBox4);
            this.A4_4.Location = new System.Drawing.Point(169, 211);
            this.A4_4.Name = "A4_4";
            this.A4_4.Size = new System.Drawing.Size(83, 129);
            this.A4_4.TabIndex = 64;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(3, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(75, 13);
            this.textBox4.TabIndex = 64;
            this.textBox4.Text = "Имя";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A4_3
            // 
            this.A4_3.BackColor = System.Drawing.Color.White;
            this.A4_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4_3.Controls.Add(this.textBox3);
            this.A4_3.Location = new System.Drawing.Point(80, 211);
            this.A4_3.Name = "A4_3";
            this.A4_3.Size = new System.Drawing.Size(83, 129);
            this.A4_3.TabIndex = 63;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Location = new System.Drawing.Point(3, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(75, 13);
            this.textBox3.TabIndex = 63;
            this.textBox3.Text = "Имя";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientName.Location = new System.Drawing.Point(256, 17);
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Size = new System.Drawing.Size(227, 26);
            this.clientName.TabIndex = 65;
            this.clientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeatingMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(495, 352);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.A4_4);
            this.Controls.Add(this.A4_3);
            this.Controls.Add(this.A4_2);
            this.Controls.Add(this.A4_1);
            this.Controls.Add(this.font_btn);
            this.Controls.Add(this.contractId_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.listInv_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SeatingMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карты рассадки";
            this.A4_1.ResumeLayout(false);
            this.A4_1.PerformLayout();
            this.A4_2.ResumeLayout(false);
            this.A4_2.PerformLayout();
            this.A4_4.ResumeLayout(false);
            this.A4_4.PerformLayout();
            this.A4_3.ResumeLayout(false);
            this.A4_3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button listInv_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contractId_txt;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button font_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel A4_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel A4_2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel A4_4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel A4_3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox clientName;
    }
}