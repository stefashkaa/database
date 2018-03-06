using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            logon_btn.Select();
            userName_txt.GotFocus += UserName_txt_GotFocus;
            userName_txt.LostFocus += UserName_txt_LostFocus;
            password_txt.GotFocus += Password_txt_GotFocus;
            password_txt.LostFocus += Password_txt_LostFocus;
        }

        private void Password_txt_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(password_txt.Text))
            {
                password_txt.PasswordChar = '\0';
                password_txt.Text = "Пароль";
            }
        }

        private void Password_txt_GotFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(password_txt.Text) || password_txt.Text.Equals("Пароль"))
            {
                password_txt.Text = "";
                password_txt.PasswordChar = '*';
            }
        }

        private void UserName_txt_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userName_txt.Text))
            {
                userName_txt.Text = "Имя пользователя";
            }
        }

        private void UserName_txt_GotFocus(object sender, EventArgs e)
        {
            if (userName_txt.Text.Equals("Имя пользователя"))
            {
                userName_txt.Text = "";
            }
        }

        private void logon_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
