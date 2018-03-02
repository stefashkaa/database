using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CreativeWorkshop.Services
{
    public class DatabaseService
    {
        private static readonly string dbFileName = "db.sqlite";
        private static readonly SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
        private static readonly SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection();

        static DatabaseService()
        {
            //for tests
            //if (File.Exists(dbFileName))
            //{
            //    File.Delete(dbFileName);
            //}
            openConnection();
            createTablesIfNotExists();
        }

        private static void openConnection()
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }
            connection.ConnectionString = $"Data Source = {dbFileName}";
            connection.Open();
        }

        private static void createTablesIfNotExists()
        {
            CreateTable(DbConstants.Employees.Create);
            CreateTable(DbConstants.PClients.Create);
            CreateTable(DbConstants.LClients.Create);
            CreateTable(DbConstants.ServiceTypes.Create);
        }

        public static void Init() { /*for creating database*/ }

        public static void CreateTable(string commandText)
        {
            var command = new SQLiteCommand(connection)
            {
                CommandText = commandText,
                CommandType = CommandType.Text
            };
            command.ExecuteNonQuery();
        }

        public static int GetNextId(string title)
        {
            int id = 0;
            var command = new SQLiteCommand(connection)
            {
                CommandText = @"SELECT MAX(id) FROM " + title,
                CommandType = CommandType.Text
            };
            try
            {
                using (var read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        id = read.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                return 1;
            }
            if (id == 0)
                return 1;
            return ++id;
        }

        public static SQLiteDataReader Select(string title)
        {
            var command = select(title);
            return command.ExecuteReader();
        }

        public static SQLiteDataReader Where(string title, string condition)
        {
            var command = select(title, condition);
            return command.ExecuteReader();
        }

        private static SQLiteCommand select(string title, string condition = null)
        {
            var command = new SQLiteCommand(connection)
            {
                CommandText = $@"SELECT * FROM {title}",
                CommandType = CommandType.Text
            };
            command.CommandText = (condition == null)
                ? command.CommandText
                : $@"{command.CommandText} {condition}";
            return command;
        }

        public static void Execute(string commandText, List<SQLiteParameter> parameters)
        {
            try
            {
                var command = new SQLiteCommand(connection)
                {
                    CommandText = commandText,
                    CommandType = CommandType.Text
                };
                command.Parameters.AddRange(parameters.ToArray());
                command.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                if (e.Message.ToLower().Contains("unique"))
                {
                    MessageBox.Show("Такая сущность уже содержится в базе данных!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
