using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class ClientController
    {
        public static List<PClient> GetAllPClients()
        {
            var clients = new List<PClient>();
            using (var read = DatabaseService.Select(DbConstants.PClients.title))
            {
                while (read.Read())
                {
                    clients.Add(new PClient(
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.surname)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.name)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.patronymic)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.Clients.address)),
                     (long)read.GetValue(read.GetOrdinal(DbConstants.Clients.mobile)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.Clients.email)))
                     );
                }
            }
            return clients;
        }

        public static List<LClient> GetAllLClients()
        {
            var clients = new List<LClient>();
            using (var read = DatabaseService.Select(DbConstants.LClients.title))
            {
                while (read.Read())
                {
                    clients.Add(new LClient(
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.name)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.Clients.address)),
                     (long)read.GetValue(read.GetOrdinal(DbConstants.Clients.mobile)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.Clients.email)))
                     );
                }
            }
            return clients;
        }
    }
}
