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
            this.button3 = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.ComboBox();
            this.font = new System.Windows.Forms.ComboBox();
            this.id_txt = new System.Windows.Forms.ComboBox();
            this.listInv_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(278, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "Сохранить как";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textSize
            // 
            this.textSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSize.FormattingEnabled = true;
            this.textSize.Location = new System.Drawing.Point(300, 129);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(163, 27);
            this.textSize.TabIndex = 18;
            this.textSize.Text = "Размер шрифта";
            // 
            // font
            // 
            this.font.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font.FormattingEnabled = true;
            this.font.Location = new System.Drawing.Point(300, 87);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(163, 27);
            this.font.TabIndex = 17;
            this.font.Text = "Шрифт";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_txt.FormattingEnabled = true;
            this.id_txt.Location = new System.Drawing.Point(135, 17);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(117, 27);
            this.id_txt.TabIndex = 16;
            // 
            // listInv_btn
            // 
            this.listInv_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listInv_btn.Location = new System.Drawing.Point(300, 39);
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
            this.label3.Location = new System.Drawing.Point(296, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Список приглашенных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код договора:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 129);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "\r\n\r\n\r\n\r\nИмя";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 129);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "\r\n\r\n\r\n\r\nИмя";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 211);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 129);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "\r\n\r\n\r\n\r\nИмя";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 211);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 129);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "\r\n\r\n\r\n\r\nИмя";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeatingMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 352);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.font);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.listInv_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeatingMapForm";
            this.Text = "Карты рассадки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox textSize;
        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.ComboBox id_txt;
        private System.Windows.Forms.Button listInv_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}