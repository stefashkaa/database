﻿using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class ServiceTypeController
    {
        public static List<ServiceType> GetAllTypes()
        {
            var types = new List<ServiceType>();

            using (var read = DatabaseService.Select(Db.ServiceTypes.title))
            {
                while (read.Read())
                {
                    types.Add(
                        new ServiceType(
                            (string)read.GetValue(read.GetOrdinal(Db.ServiceTypes.name)),
                            Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.ServiceTypes.price)))
                        )
                    );
                }
            }
            return types;
        }
    }
}
