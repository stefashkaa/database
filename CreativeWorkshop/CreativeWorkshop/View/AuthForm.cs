using CreativeWorkshop.Controller;
using CreativeWorkshop.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CreativeWorkshop.View
{
    public partial class AuthForm : Form
    {
        public static User User = null;

        public AuthForm()
        {
            InitializeComponent();
            logonButton.Select();
            userNameText.GotFocus += UserNameText_GotFocus;
            userNameText.LostFocus += UserNameText_LostFocus;
            passwordText.GotFocus += PasswordText_GotFocus;
            passwordText.LostFocus += PasswordText_LostFocus;
        }

        private void PasswordText_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(passwordText.Text))
            {
                passwordText.PasswordChar = '\0';
                passwordText.Text = "Пароль";
            }
        }

        private void PasswordText_GotFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(passwordText.Text) || passwordText.Text.Equals("Пароль"))
            {
                passwordText.Text = "";
                passwordText.PasswordChar = '*';
            }
        }

        private void UserNameText_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userNameText.Text))
            {
                userNameText.Text = "Имя пользователя";
            }
        }

        private void UserNameText_GotFocus(object sender, EventArgs e)
        {
            if (userNameText.Text.Equals("Имя пользователя"))
            {
                userNameText.Text = "";
            }
        }

        private void logonButton_Click(object sender, EventArgs e)
        {
            var userName = userNameText.Text;
            var password = passwordText.Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) ||
               userName == "Имя пользователя" || password == "Пароль")
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var users = UserController.GetAllUsers();

            var currentUser = users.FirstOrDefault(u => u.Name == userName && u.Password == password);
            if (currentUser == null)
            {
                MessageBox.Show(@"Нет такого пользователя, либо был введен не верный пароль! 
Повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User = currentUser;
            Visible = false;
            var form = new MainForm();
            form.ShowDialog();
            if (form.Logoff)
            {
                Visible = true;
            }
        }
    }
}
