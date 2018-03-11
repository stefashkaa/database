using CreativeWorkshop.Model;
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
            if (File.Exists(dbFileName))
            {
                File.Delete(dbFileName);
            }
            openConnection();
            createTablesIfNotExists();
            insertUsersIntoTable(new User("1", "1", Role.Director), 
                                 new User("2", "2", Role.Designer),
                                 new User("director", "pass", Role.Director),
                                 new User("designer1", "pass", Role.Designer));
        }

        private static void insertUsersIntoTable(params User[] users)
        {
            if (GetNextId(DbConstants.Authorization.title) == 1)
            {
                foreach (var user in users)
                {
                    var parameters = new List<SQLiteParameter>()
                    {
                        new SQLiteParameter($"@{DbConstants.Authorization.username}", user.Name),
                        new SQLiteParameter($"@{DbConstants.Authorization.password}", user.Password),
                        new SQLiteParameter($"@{DbConstants.Authorization.role}", (int)user.Role)
                    };
                    Execute(DbConstants.Authorization.Insert, parameters);
                }
                
            }
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
            CreateTable(DbConstants.Authorization.Create);
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

        public static int GetIdByName(string title, string nameExpression, List<SQLiteParameter> parameters)
        {
            var command = select(title, DbConstants.id, $"WHERE {nameExpression}");
            try
            {
                using (var read = ExecuteAndReturn(command.CommandText, parameters))
                {
                    while (read.Read())
                    {
                        return read.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return 0;
        }

        public static SQLiteDataReader Select(string title)
        {
            var command = select(title);
            return command.ExecuteReader();
        }

        public static SQLiteDataReader Where(string title, string condition)
        {
            var command = select(title, null, condition);
            return command.ExecuteReader();
        }

        private static SQLiteCommand select(string title, string what = null, string condition = null)
        {
            var command = new SQLiteCommand(connection)
            {
                CommandText = $@"SELECT {what ?? "*"} FROM {title}",
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

        public static SQLiteDataReader ExecuteAndReturn(string commandText, List<SQLiteParameter> parameters)
        {
            try
            {
                var command = new SQLiteCommand(connection)
                {
                    CommandText = commandText,
                    CommandType = CommandType.Text
                };
                command.Parameters.AddRange(parameters.ToArray());
                return command.ExecuteReader();
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
                return null;
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
