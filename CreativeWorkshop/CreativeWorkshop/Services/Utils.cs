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
                    MessageBox.Show("Заполните поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (!long.TryParse(textBox.Text, out long res) ||
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
@list.ru", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static bool IsValidPrice(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out int res) || res < 0 || res > 5000)
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
{e.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ApplyFont(Microsoft.Office.Interop.Word.Font wFont, System.Drawing.Font font)
        {
            try
            {
                wFont.Bold = Convert.ToInt32(font.Bold);
                wFont.Italic = Convert.ToInt32(font.Italic);
                wFont.StrikeThrough = Convert.ToInt32(font.Strikeout);
                wFont.Size = font.Size;
                wFont.Underline = font.Underline ? WdUnderline.wdUnderlineSingle : WdUnderline.wdUnderlineNone;
                wFont.Name = font.Name;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Не удалось загрузить шрифт.
Для решения проблемы будет применен шрифт по умолчанию.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                wFont.Name = "Times New Roman";
            }
        }

        public static System.Drawing.Font ToFont(Microsoft.Office.Interop.Word.Font fontW)
        {
            try
            {
                bool isBold = Convert.ToBoolean(fontW.Bold);
                bool isItalic = Convert.ToBoolean(fontW.Italic);
                bool isStrikeout = Convert.ToBoolean(fontW.StrikeThrough);
                bool isUnderline = Convert.ToBoolean(fontW.Underline);

                FontStyle style = FontStyle.Regular;

                if (isBold) style = style | FontStyle.Bold;
                if (isItalic) style = style | FontStyle.Italic;
                if (isStrikeout) style = style | FontStyle.Strikeout;
                if (isUnderline) style = style | FontStyle.Underline;

                return new System.Drawing.Font(fontW.Name, fontW.Size, style, GraphicsUnit.Point, 204);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Не удалось загрузить шрифт.
Для решения проблемы будет применен шрифт по умолчанию.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return new System.Drawing.Font("Times New Roman", 14, FontStyle.Regular);
            }
        }

        public static void DeletePage(Document doc, int i)
        {
            Range rngD = doc.GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToAbsolute, i, Type.Missing);
            rngD.Bookmarks["\\Page"].Range.Delete();
        }

        public static void SaveSeatingMap(string fileName, List<string> names, System.Drawing.Font font)
        {
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            try
            {
                var splittedNames = splitNames(names);
                object missing = Type.Missing;
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

                    ApplyFont(tbl.Range.Font, font);
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
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Не удалось сохранить файл!

Детали ошики:{e.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ((_Document)doc).Close();
                ((_Application)word).Quit();
            }
        }

        public static string GetText(string fName)
        {
            var text = "";
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            object fileName = fName;
            // Define an object to pass to the API for missing parameters
            object missing = Type.Missing;

            try
            {
                doc = word.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

                String read = string.Empty;
                for (int i = 0; i < doc.Paragraphs.Count; i++)
                {
                    var paragraph = doc.Paragraphs[i + 1].Range.Text;
                    if (paragraph != string.Empty)
                        text += $"{paragraph}\n";
                }
                doc.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Не удалось открыть файл!

Детали ошики:{e.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ((_Document)doc).Close();
                ((_Application)word).Quit();
            }
            return text;
        }

        public static void SaveInvitations(string fName, List<string> pages, System.Drawing.Font font)
        {
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            try
            {
                object missing = Type.Missing;
                object gotoNext = WdGoToDirection.wdGoToNext;
                doc = word.Documents.Add();
                doc.PageSetup.LeftMargin = doc.PageSetup.RightMargin;
                doc.PageSetup.BottomMargin = 5;

                ApplyFont(doc.Content.Font, font);

                for (int i = 0; i < pages.Count; i++)
                {
                    var text = pages[i].Split('\n');

                    for (int j = 0; j < text.Length; j++)
                    {
                        Paragraph p = doc.Content.Paragraphs.Add(ref missing);
                        Range r = p.Range;
                        r.Text = text[j];

                        if (j == 0)
                        {
                            r.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                        else
                        {
                            r.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                        }
                    }
                    if (i != pages.Count - 1)
                    {
                        doc.Words.Last.InsertBreak(WdBreakType.wdPageBreak);
                    }
                }

                doc.SaveAs2(fName);
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Не удалось сохранить файл!

Детали ошики:{e.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ((_Document)doc).Close();
                ((_Application)word).Quit();
            }
        }

        public static List<string> GetNames(string fName)
        {
            var names = new List<string>();
            var word = new Microsoft.Office.Interop.Word.Application();
            var doc = new Document();
            object fileName = fName;
            // Define an object to pass to the API for missing parameters
            object missing = Type.Missing;

            try
            {
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
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Не удалось открыть файл!

Детали ошики:{e.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ((_Document)doc).Close();
                ((_Application)word).Quit();
            }
            return names;
        }

        private static List<List<string>> splitNames(List<string> names)
        {
            if ( names == null || names?.Count == 0)
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
