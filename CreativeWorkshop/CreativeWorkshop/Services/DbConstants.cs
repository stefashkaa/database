namespace CreativeWorkshop.Services
{
    public static class DbConstants
    {
        public static readonly string id = "id";

        public class Authorization
        {
            public static readonly string title = "authorization";
            public static readonly string username = "username";
            public static readonly string password = "password";
            public static readonly string role = "role";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS authorization ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
username char(30) NOT NULL, 
password char(30) NOT NULL, 
role INTEGER NOT NULL, 
CONSTRAINT name_unique UNIQUE(username));";
            public static readonly string Insert = @"INSERT INTO authorization( 
username, password, role) 
VALUES(@username , @password , @role)";
            public static readonly string Delete = @"DELETE FROM authorization WHERE username = @username";
            public static readonly string Update = @"UPDATE authorization set username = @username, 
password = @password, role = @role WHERE username = @username1";
        }

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

        public class Clients
        {
            public static readonly string title = "clients";
            public static readonly string address = "address";
            public static readonly string mobile = "mobile";
            public static readonly string email = "email";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS clients ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
address char(100) NOT NULL, 
mobile INTEGER NOT NULL, 
email char(100) NOT NULL);";
        }

        public class PClients
        {
            public static readonly string title = "phys_clients";
            public static readonly string surname = "surname";
            public static readonly string name = "name";
            public static readonly string patronymic = "patronymic";
            public static readonly string clientID = "client_id";

            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS phys_clients ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
surname char(100) NOT NULL, 
name char(100) NOT NULL, 
patronymic char(100) NOT NULL, 
client_id INTEGER NOT NULL, 
FOREIGN KEY(client_id) REFERENCES clients(id), 
CONSTRAINT name_unique UNIQUE(surname, name, patronymic));";
            public static readonly string Insert = @"INSERT INTO clients( 
address, mobile, email) VALUES(@address , @mobile , @email); 
INSERT INTO phys_clients(surname, name, patronymic, client_id) 
VALUES(@surname , @name , @patronymic , (SELECT MAX(id) from clients));";
            public static readonly string Delete = @"DELETE FROM clients WHERE id = 
(SELECT client_id FROM phys_clients WHERE surname = @surname 
AND name = @name AND patronymic = @patronymic); 
DELETE FROM phys_clients WHERE surname = @surname 
AND name = @name AND patronymic = @patronymic";
            public static readonly string Update = @"UPDATE clients set 
address = @address, mobile = @mobile, email = @email WHERE id = 
(SELECT client_id FROM phys_clients WHERE surname = @surname1 
AND name = @name1 AND patronymic = @patronymic1); 
UPDATE phys_clients set surname = @surname, 
name = @name, patronymic = @patronymic WHERE surname = @surname1 
AND name = @name1 AND patronymic = @patronymic1";
        }

        public class LClients
        {
            public static readonly string title = "legal_clients";
            public static readonly string name = "name";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS legal_clients ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
name char(100) NOT NULL, 
client_id INTEGER NOT NULL, 
FOREIGN KEY(client_id) REFERENCES clients(id), 
CONSTRAINT name_unique UNIQUE(name));";
            public static readonly string Insert = @"INSERT INTO clients( 
address, mobile, email) VALUES(@address , @mobile , @email); 
INSERT INTO legal_clients(name, client_id) 
VALUES(@name, (SELECT MAX(id) from clients));";
            public static readonly string Delete = @"DELETE FROM clients WHERE id = 
(SELECT client_id FROM legal_clients WHERE name = @name); 
DELETE FROM legal_clients WHERE name = @name";
            public static readonly string Update = @"UPDATE clients set 
address = @address, mobile = @mobile, email = @email WHERE id = 
(SELECT client_id FROM legal_clients WHERE name = @name1); 
UPDATE legal_clients set name = @name WHERE name = @name1";
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

        public class Order
        {
            public static readonly string title = "order";
            public static readonly string employeeId = "employee_id";
            public static readonly string clientId = "client_id";
            public static readonly string firstSum = "first_sum";
            public static readonly string firstDate = "first_date";
            public static readonly string lastDate = "last_date";
            public static readonly string status = "status";
            public static readonly string Create = @"CREATE TABLE IF NOT EXISTS order ( 
id INTEGER PRIMARY KEY AUTOINCREMENT, 
employee_id INTEGER NOT NULL, 
client_id INTEGER NOT NULL, 
first_sum INTEGER NOT NULL, 
first_date INTEGER NOT NULL, 
last_date INTEGER NOT NULL, 
status INTEGER NOT NULL, 
FOREIGN KEY(client_id) REFERENCES clients(id), 
FOREIGN KEY(employee_id) REFERENCES employee(id));";
            public static readonly string Insert = @"INSERT INTO service_types( 
employee_id, client_id, first_sum, first_date, last_date, status) 
VALUES(@employee_id , @client_id, @first_sum, @first_date, @last_date, @status)";
            public static readonly string Delete = @"DELETE FROM order WHERE id = @id";
        }
    }
}
