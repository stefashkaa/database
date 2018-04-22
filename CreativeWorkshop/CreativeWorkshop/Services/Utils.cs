using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using System;
using System.Collections.Generic;

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

        public static void CheckDbMessage(SQLiteException e)
        {
            var mess = e.Message.ToLower();
            if (mess.Contains("unique"))
            {
                MessageBox.Show("Такая запись уже содержится в базе данных!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mess.Contains("foreign key"))
            {
                MessageBox.Show(@"Выбранная запись не может быть удалена, 
так как на нее ссылаются другие объекты!

* для удаления записи необходимо удалить данные о ней из других таблиц", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($@"Неизвестная ошибка! 

Подробности ошибки:
{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Microsoft.Office.Interop.Word.Font ToWordFont(System.Drawing.Font font)
        {
            var wordF = new Microsoft.Office.Interop.Word.Font();
            wordF.Bold = Convert.ToInt32(font.Bold);
            wordF.Italic = Convert.ToInt32(font.Italic);
            wordF.Name = font.Name;
            wordF.Size = font.Size;
            return wordF;
        }

        public static System.Drawing.Font ToFont(Microsoft.Office.Interop.Word.Font fontW)
        {
            bool isBold = Convert.ToBoolean(fontW.Bold);
            bool isItalic = Convert.ToBoolean(fontW.Italic);
            bool isStrikeout = Convert.ToBoolean(fontW.StrikeThrough);
            bool isUnderline = Convert.ToBoolean(fontW.Underline);
            FontStyle style = 
                (isBold) ? FontStyle.Bold :
                (isItalic) ? FontStyle.Italic :
                (isStrikeout) ? FontStyle.Strikeout :
                (isUnderline) ? FontStyle.Underline :
                FontStyle.Regular;
            var font = new System.Drawing.Font(fontW.Name, fontW.Size, style, GraphicsUnit.Point, 204);
            return font;
        }

        public static void DeletePage(Document doc, int i)
        {
            Range rngD = doc.GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToAbsolute, i, Type.Missing);
            rngD.Bookmarks["\\Page"].Range.Delete();
        }

        public static void SaveSeatingMap(string fileName, List<string> names, System.Drawing.Font font)
        {
            var splittedNames = splitNames(names);
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            object missing = System.Type.Missing;
            doc = word.Documents.Add();
            doc.PageSetup.LeftMargin = doc.PageSetup.RightMargin;
            doc.PageSetup.BottomMargin = 5;
            object oEndOfDoc = "\\endofdoc";
            Range objRange;
            Table tbl;
            Paragraph objParagraph;
            object objRangePara;

            for (int i = 1; i <= splittedNames.Count; i++)
            {
                objRange = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                tbl = doc.Tables.Add(objRange, 3, 2, ref missing, ref missing);

                tbl.Range.Font.Size = font.Size;
                tbl.Range.Font.Name = font.Name;
                tbl.Rows.Height = 240;
                tbl.Columns.DistributeWidth();
                int index = 0;
                tbl.Cell(1, 1).Range.Text = "";
                tbl.Cell(1, 2).Range.Text = "";

                for (int j = 2; j <= 3; j++)
                {
                    for (int k = 1; k <= 2; k++)
                    {
                        if (index >= splittedNames[i - 1].Count) break;

                        tbl.Cell(j, k).Range.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        tbl.Cell(j, k).Range.Text = splittedNames[i - 1][index];
                        index++;
                    }
                }
                objRangePara = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                objParagraph = doc.Content.Paragraphs.Add(ref objRangePara);
                objParagraph.Range.Text = Environment.NewLine;
            }
            doc.SaveAs2(fileName);
            ((_Document)doc).Close();
            ((_Application)word).Quit();
        }

        public static List<string> GetNames(string fName)
        {
            var names = new List<string>();
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            object fileName = fName;
            // Define an object to pass to the API for missing parameters
            object missing = System.Type.Missing;
            doc = word.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);
            String read = string.Empty;
            for (int i = 0; i < doc.Paragraphs.Count; i++)
            {
                var name = doc.Paragraphs[i + 1].Range.Text.Trim();
                if (name != string.Empty)
                    names.Add(name);
            }
            doc.Save();
            ((_Document)doc).Close();
            ((_Application)word).Quit();

            return names;
        }

        private static List<List<string>> splitNames(List<string> names)
        {
            if (names?.Count == 0)
            {
                return null;
            }
            var splitted = new List<List<string>>();
            int i = 0;
            for (int k = 0; i < names.Count; i += 4, k++)
            {
                splitted.Add(new List<string>());
                for (int j = 0; j < 4; j++)
                {
                    if (i + j >= names.Count) break;
                    splitted[k].Add(names[i + j]);
                }
            }
            return splitted;
        }
    }
}
