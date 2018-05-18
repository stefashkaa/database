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
            #region For tests; in release mod comment these lines!
            //if (File.Exists(dbFileName))
            //{
            //    File.Delete(dbFileName);
            //}
            #endregion
            openConnection();
            activateFK();
            createTablesIfNotExists();
            insertUsersIntoTable(new User("1", "1", Role.Director), 
                                 new User("2", "2", Role.Designer),
                                 new User("Olga", "EfimBrabara", Role.Director),
                                 new User("Marina", "qwaszx1", Role.Designer));
        }

        private static void activateFK()
        {
            try
            {
                Execute(Db.FK_ON);
            }
            catch (Exception)
            {
                MessageBox.Show("FK не включены по техническим причинам! Проверьте соединение с БД!", "Критическая ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void insertUsersIntoTable(params User[] users)
        {
            if (GetNextId(Db.Authorization.title) == 1)
            {
                foreach (var user in users)
                {
                    var parameters = new List<SQLiteParameter>()
                    {
                        new SQLiteParameter($"@{Db.Authorization.username}", user.Name),
                        new SQLiteParameter($"@{Db.Authorization.password}", user.Password),
                        new SQLiteParameter($"@{Db.Authorization.role}", (int)user.Role)
                    };
                    Execute(Db.Authorization.Insert, parameters);
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
            CreateTable(Db.Employees.Create);
            CreateTable(Db.Authorization.Create);
            CreateTable(Db.Clients.Create);
            CreateTable(Db.PClients.Create);
            CreateTable(Db.LClients.Create);
            CreateTable(Db.ServiceTypes.Create);
            CreateTable(Db.Purchase.Create);
            CreateTable(Db.Contract.Create);
            CreateTable(Db.Service.Create);
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

        public static int GetIdByName(string title, string nameExpression, List<SQLiteParameter> parameters, string id = "id")
        {
            var command = select(title, id, $"WHERE {nameExpression}");
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
            var command = select(title, null, $"WHERE {condition}");
            return command.ExecuteReader();
        }

        private static SQLiteCommand select(string title, string what = null, string condition = null)
        {
            var command = new SQLiteCommand(connection) { CommandType = CommandType.Text };
            var text = "";
            if ((title == Db.LClients.title || title == Db.PClients.title) && (condition == null) )
            {
                text = $@"SELECT {what ?? "*"} FROM {title} b INNER JOIN clients c ON b.client_id = c.id";
            }
            else
            {
                text = $@"SELECT {what ?? "*"} FROM {title}";
            }
            command.CommandText = (condition == null)
                ? text
                : $@"{text} {condition}";
            return command;
        }

        public static void Execute(string commandText, List<SQLiteParameter> parameters = null)
        {
            try
            {
                var command = new SQLiteCommand(connection)
                {
                    CommandText = commandText,
                    CommandType = CommandType.Text
                };
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }
                command.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Utils.CheckDbMessage(e);
            }
        }

        public static SQLiteDataReader ExecuteAndReturn(string commandText, List<SQLiteParameter> parameters = null)
        {
            try
            {
                var command = new SQLiteCommand(connection)
                {
                    CommandText = commandText,
                    CommandType = CommandType.Text
                };
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }
                return command.ExecuteReader();
            }
            catch (SQLiteException e)
            {
                Utils.CheckDbMessage(e);
                return null;
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
