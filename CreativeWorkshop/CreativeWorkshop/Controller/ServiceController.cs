using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class ServiceController
    {
        public static List<Service> GetServices(int purchaseId)
        {
            var services = new List<Service>();
            using (var read = DatabaseService.Where(DbConstants.Service.title, $"purchase_id = {purchaseId}"))
            {
                while (read.Read())
                {
                    var employeeId = read.GetValue(read.GetOrdinal(DbConstants.Service.employeeId));
                    services.Add(new Service(
                        purchaseId,
                        (string)read.GetValue(read.GetOrdinal(DbConstants.Service.serviceTypeName)),
                        Convert.ToInt32(read.GetValue(read.GetOrdinal(DbConstants.Service.count))),
                        Convert.ToInt32((employeeId != DBNull.Value) ? employeeId : -1)));
                }
            }
            return services;
        }
    }
}
