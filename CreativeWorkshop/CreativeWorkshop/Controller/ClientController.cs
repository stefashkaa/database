using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class ClientController
    {
        public static List<PClient> GetAllPClients()
        {
            List<PClient> clients = new List<PClient>();
            using (var read = DatabaseService.Select(DbConstants.PClients.title))
            {
                while (read.Read())
                {
                    clients.Add(new PClient(
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.surname)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.name)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.patronymic)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.address)),
                     (long)read.GetValue(read.GetOrdinal(DbConstants.PClients.mobile)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.email)))
                     );
                }
            }
            return clients;
        }

        public static List<LClient> GetAllLClients()
        {
            List<LClient> clients = new List<LClient>();
            using (var read = DatabaseService.Select(DbConstants.LClients.title))
            {
                while (read.Read())
                {
                    clients.Add(new LClient(
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.name)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.address)),
                     (long)read.GetValue(read.GetOrdinal(DbConstants.PClients.mobile)),
                     (string)read.GetValue(read.GetOrdinal(DbConstants.PClients.email)))
                     );
                }
            }
            return clients;
        }
    }
}
