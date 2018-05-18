namespace CreativeWorkshop.View
{
    partial class AuthForm
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
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.logonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameText.ForeColor = System.Drawing.Color.Gray;
            this.userNameText.Location = new System.Drawing.Point(65, 62);
            this.userNameText.MaxLength = 30;
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(153, 26);
            this.userNameText.TabIndex = 0;
            this.userNameText.Text = "Имя пользователя";
            this.userNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.ForeColor = System.Drawing.Color.Gray;
            this.passwordText.Location = new System.Drawing.Point(65, 106);
            this.passwordText.MaxLength = 30;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(153, 26);
            this.passwordText.TabIndex = 1;
            this.passwordText.Text = "Пароль";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logonButton
            // 
            this.logonButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logonButton.Location = new System.Drawing.Point(65, 152);
            this.logonButton.Name = "logonButton";
            this.logonButton.Size = new System.Drawing.Size(153, 26);
            this.logonButton.TabIndex = 2;
            this.logonButton.Text = "Войти";
            this.logonButton.UseVisualStyleBackColor = true;
            this.logonButton.Click += new System.EventHandler(this.logonButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logonButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button logonButton;
    }
}