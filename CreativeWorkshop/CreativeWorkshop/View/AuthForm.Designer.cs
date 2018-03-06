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
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.logon_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_txt
            // 
            this.userName_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName_txt.Location = new System.Drawing.Point(65, 62);
            this.userName_txt.MaxLength = 20;
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(153, 26);
            this.userName_txt.TabIndex = 0;
            this.userName_txt.Text = "Имя пользователя";
            this.userName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_txt.Location = new System.Drawing.Point(65, 106);
            this.password_txt.MaxLength = 20;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(153, 26);
            this.password_txt.TabIndex = 1;
            this.password_txt.Text = "Пароль";
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logon_btn
            // 
            this.logon_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logon_btn.Location = new System.Drawing.Point(65, 152);
            this.logon_btn.Name = "logon_btn";
            this.logon_btn.Size = new System.Drawing.Size(153, 26);
            this.logon_btn.TabIndex = 2;
            this.logon_btn.Text = "Войти";
            this.logon_btn.UseVisualStyleBackColor = true;
            this.logon_btn.Click += new System.EventHandler(this.logon_btn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logon_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.userName_txt);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button logon_btn;
    }
}