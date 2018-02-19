using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma.Services
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
                if (item.Text.Any(a => char.IsDigit(a)))
                {
                    MessageBox.Show("Заполните поля 'фио' корректно!");
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidMobile(TextBox textBox)
        {
            long res;
            if (!long.TryParse(textBox.Text, out res))
            {
                MessageBox.Show("Заполните поле 'мобильного телефона' корректно!");
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.All(a => a != '@'))
            {
                MessageBox.Show("Заполните поле 'email' корректно!");
                return false;
            }
            return true;
        }

        public static bool IsValidPrice(TextBox textBox)
        {
            int res;
            if (!int.TryParse(textBox.Text, out res))
            {
                MessageBox.Show("Заполните поле 'цены' корректно!");
                return false;
            }
            return true;
        }
    }
}
