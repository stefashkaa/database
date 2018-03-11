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
            var userName = userName_txt.Text;
            var password = password_txt.Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) ||
               userName == "Имя пользователя" || password == "Пароль")
            {
                MessageBox.Show("Заполните все поля!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var users = UserController.GetAllUsers();

            var currentUser = users.FirstOrDefault(u => u.Name == userName && u.Password == password);
            if (currentUser == null)
            {
                MessageBox.Show(@"Нет такого пользователя, либо был введен не верный пароль! 
Повторите ввод.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
