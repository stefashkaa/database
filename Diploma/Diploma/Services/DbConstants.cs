namespace Diploma.Services
{
    public static class DbConstants
    {
        public static readonly string id = "id";
        public class Employees
        {
            public static readonly string title = "employees";
            public static readonly string surname = "surname";
            public static readonly string name = "name";
            public static readonly string patronymic = "patronymic";
            public static readonly string position = "position";
            public static readonly string mobile = "mobile";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS employees ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
surname char(100) NOT NULL, 
name char(100) NOT NULL, 
patronymic char(100) NOT NULL, 
position char(100) NOT NULL, 
mobile integer NOT NULL, 
CONSTRAINT name_unique UNIQUE(surname, name, patronymic));";
            public static readonly string Insert = @"INSERT INTO employees( 
surname, name, patronymic, position, mobile) 
VALUES(@surname , @name , @patronymic , @position , @mobile)";
            public static readonly string Delete = @"DELETE FROM employees WHERE surname = @surname 
AND name = @name AND patronymic = @patronymic";
            public static readonly string Update = @"UPDATE employees set surname = @surname, 
name = @name, patronymic = @patronymic, 
position = @position, mobile = @mobile WHERE surname = @surname1 
AND name = @name1 AND patronymic = @patronymic1";
        }

        public class PClients
        {
            public static readonly string title = "phys_clients";
            public static readonly string surname = "surname";
            public static readonly string name = "name";
            public static readonly string patronymic = "patronymic";
            public static readonly string address = "address";
            public static readonly string mobile = "mobile";
            public static readonly string email = "email";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS phys_clients ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
surname char(100) NOT NULL, 
name char(100) NOT NULL, 
patronymic char(100) NOT NULL, 
address char(100) NOT NULL, 
mobile INTEGER NOT NULL, 
email char(100) NOT NULL, 
CONSTRAINT name_unique UNIQUE(surname, name, patronymic));";
            public static readonly string Insert = @"INSERT INTO phys_clients( 
surname, name, patronymic, address, mobile, email) 
VALUES(@surname , @name , @patronymic , @address , @mobile , @email)";
            public static readonly string Delete = @"DELETE FROM phys_clients WHERE surname = @surname 
AND name = @name AND patronymic = @patronymic";
            public static readonly string Update = @"UPDATE phys_clients set surname = @surname, 
name = @name, patronymic = @patronymic, 
address = @address, mobile = @mobile, email = @email WHERE surname = @surname1 
AND name = @name1 AND patronymic = @patronymic1";
        }

        public class LClients
        {
            public static readonly string title = "legal_clients";
            public static readonly string name = "name";
            public static readonly string address = "address";
            public static readonly string mobile = "mobile";
            public static readonly string email = "email";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS legal_clients ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
name char(100) NOT NULL, 
address char(100) NOT NULL, 
mobile INTEGER NOT NULL, 
email char(100) NOT NULL, 
CONSTRAINT name_unique UNIQUE(name));";
            public static readonly string Insert = @"INSERT INTO legal_clients( 
name, address, mobile, email) 
VALUES(@name , @address , @mobile , @email)";
            public static readonly string Delete = @"DELETE FROM legal_clients WHERE name = @name";
            public static readonly string Update = @"UPDATE legal_clients set name = @name, 
address = @address, mobile = @mobile, email = @email WHERE name = @name1";
        }

        public class ServiceTypes
        {
            public static readonly string title = "service_types";
            public static readonly string name = "name";
            public static readonly string price = "price";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS service_types ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
name char(100) NOT NULL, 
price INTEGER NOT NULL, 
CONSTRAINT name_unique UNIQUE(name));";
            public static readonly string Insert = @"INSERT INTO service_types( 
name, price) 
VALUES(@name , @price)";
            public static readonly string Delete = @"DELETE FROM service_types WHERE name = @name";
            public static readonly string Update = @"UPDATE service_types set name = @name, 
price = @price WHERE name = @name1";
        }
    }
}
