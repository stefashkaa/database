namespace CreativeWorkshop.View
{
    partial class SelectContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectContractForm));
            this.contractId_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contractId_txt
            // 
            this.contractId_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractId_txt.DropDownWidth = 200;
            this.contractId_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractId_txt.FormattingEnabled = true;
            this.contractId_txt.Location = new System.Drawing.Point(123, 20);
            this.contractId_txt.Name = "contractId_txt";
            this.contractId_txt.Size = new System.Drawing.Size(154, 27);
            this.contractId_txt.TabIndex = 58;
            this.contractId_txt.SelectedIndexChanged += new System.EventHandler(this.contractId_txt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Код договора:";
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_btn.Location = new System.Drawing.Point(12, 82);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(265, 32);
            this.select_btn.TabIndex = 60;
            this.select_btn.Text = "Выбрать";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // SelectContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(289, 126);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.contractId_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите договор:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectContractForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contractId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_btn;
    }
}