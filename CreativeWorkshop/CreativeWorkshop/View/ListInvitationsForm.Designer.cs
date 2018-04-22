namespace CreativeWorkshop.View
{
    partial class ListInvitationsForm
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
            this.namesList = new System.Windows.Forms.CheckedListBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesList
            // 
            this.namesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namesList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesList.FormattingEnabled = true;
            this.namesList.Items.AddRange(new object[] {
            "Имя1",
            "Имя2",
            "Имя3",
            "Имя4",
            "Имя5",
            "Имя6",
            "Имя7"});
            this.namesList.Location = new System.Drawing.Point(25, 19);
            this.namesList.Name = "namesList";
            this.namesList.Size = new System.Drawing.Size(230, 298);
            this.namesList.TabIndex = 9;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(25, 336);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(230, 32);
            this.ok_btn.TabIndex = 10;
            this.ok_btn.Text = "Готово";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListInvitationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.namesList);
            this.Name = "ListInvitationsForm";
            this.Text = "Список приглашенных";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox namesList;
        private System.Windows.Forms.Button ok_btn;
    }
}