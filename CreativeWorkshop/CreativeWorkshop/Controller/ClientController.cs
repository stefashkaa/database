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

            using (var read = DatabaseService.Select(Db.PClients.title))
            {
                while (read.Read())
                {
                    clients.Add(
                        new PClient(
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.surname)),
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.name)),
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.patronymic)),
                            (string)read.GetValue(read.GetOrdinal(Db.Clients.address)),
                            (long)read.GetValue(read.GetOrdinal(Db.Clients.mobile)),
                            (string)read.GetValue(read.GetOrdinal(Db.Clients.email))
                        )
                    );
                }
            }
            return clients;
        }

        public static List<LClient> GetAllLClients()
        {
            var clients = new List<LClient>();

            using (var read = DatabaseService.Select(Db.LClients.title))
            {
                while (read.Read())
                {
                    clients.Add(
                        new LClient(
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.name)),
                            (string)read.GetValue(read.GetOrdinal(Db.Clients.address)),
                            (long)read.GetValue(read.GetOrdinal(Db.Clients.mobile)),
                            (string)read.GetValue(read.GetOrdinal(Db.Clients.email))
                        )
                    );
                }
            }
            return clients;
        }
    }
}
