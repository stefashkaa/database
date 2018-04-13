using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreativeWorkshop.Services
{
    public static class Utils
    {
        public static bool IsNotEmptyTextInputs(params TextBox[] args)
        {
            foreach (var item in args)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidFullName(params TextBox[] args)
        {
            foreach (var item in args)
            {
                if ( item.Text.Count() > 30 || item.Text.Any(a => !char.IsLetter(a)))
                {
                    MessageBox.Show(@"Поля 'ФИО' заполнены не корректно!
ФИО должно состоять только из букв. Длина слов не превышает 30.", "Предупреждение",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidMobile(TextBox textBox)
        {
            long res;
            if (!long.TryParse(textBox.Text, out res) ||
                res <= 80000000000L ||
                res >= 90000000000L)
            {
                MessageBox.Show(@"Заполните поле 'Мобильный телефон' корректно!
Номер телефона должен содержать 11 цифр без пробелов
и начинаться с '8'.", "Предупреждение",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox textBox)
        {
            bool flag = false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBox.Text);
                flag = addr.Address == textBox.Text;
                if (!flag) return false;
                var arr = new string[] {"@yandex.ru", "@mail.ru", "@gmail.com", "@ssau.ru", "@list.ru"};
                flag = arr.Any(e => textBox.Text.Contains(e));
                return flag;
            }
            catch
            {
                flag = false;
                return flag;
            }
            finally
            {
                if (!flag)
                {
                    MessageBox.Show(@"Поле 'e-mail' заполнено не корректно!
Используйте следующие домены:
@yandex.ru
@mail.ru
@gmail.com
@ssau.ru
@list.ru", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static bool IsValidPrice(TextBox textBox)
        {
            int res;
            if (!int.TryParse(textBox.Text, out res) || res < 0 || res > 5000)
            {
                MessageBox.Show(@"Поле 'Цена' заполнено не корректно!
Можно использовать только целые числа, не превышающие 5000.", "Предупреждение",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
