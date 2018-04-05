using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class UserController
    {
        public static List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var read = DatabaseService.Select(DbConstants.Authorization.title))
            {
                while (read.Read())
                {
                    users.Add(
                        new User(
                            (string)read.GetValue(read.GetOrdinal(DbConstants.Authorization.username)),
                            (string)read.GetValue(read.GetOrdinal(DbConstants.Authorization.password)),
                            (Role)Convert.ToInt32(read.GetValue(read.GetOrdinal(DbConstants.Authorization.role)))
                        )
                    );
                }
            }
            return users;
        }
    }
}
