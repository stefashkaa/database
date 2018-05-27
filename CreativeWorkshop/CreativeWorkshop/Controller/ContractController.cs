using CreativeWorkshop.Model;
using CreativeWorkshop.Services;
using System;
using System.Collections.Generic;

namespace CreativeWorkshop.Controller
{
    public class ContractController
    {
        public static List<Contract> GetAllContracts()
        {
            var contracts = new List<Contract>();

            using (var read = DatabaseService.Select(Db.Contract.title))
            {
                while (read.Read())
                {
                    contracts.Add(
                        new Contract(
                            (string)read.GetValue(read.GetOrdinal(Db.id)),
                            Contract.ToDate(Convert.ToInt64(read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate)))),
                            Convert.ToInt64(read.GetValue(read.GetOrdinal(Db.Contract.summa))),
                            Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Contract.purchaseId))),
                            (string)read.GetValue(read.GetOrdinal(Db.Contract.fileName))
                        )
                    );
                }
            }
            return contracts;
        }

        public static string GetClientName(Contract contract)
        {
            string query = $@"WHERE {Db.Purchase.clientId} = (SELECT {Db.Purchase.clientId} FROM {Db.Purchase.title} 
WHERE {Db.id} = {contract.OrderId});";

            if (contract.IsPhClient())
            {
                query = $"SELECT * FROM {Db.PClients.title} {query}";
                using (var read = DatabaseService.ExecuteAndReturn(query))
                {
                    if (read.Read())
                    {
                        var pClient = new PClient(
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.surname)),
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.name)),
                            (string)read.GetValue(read.GetOrdinal(Db.PClients.patronymic)),
                            null,
                            0,
                            null);
                        return pClient.GetShortName();
                    }
                }
            }
            else
            {
                query = $"SELECT * FROM {Db.LClients.title} {query}";
                using (var read = DatabaseService.ExecuteAndReturn(query))
                {
                    if (read.Read())
                    {
                        return (string)read.GetValue(read.GetOrdinal(Db.LClients.name));
                    }
                }
            }

            return null;
        }

        public static string GetClientName(string id)
        {
            return GetClientName(GetContract(id));
        }

        public static Contract GetContract(string id)
        {
            using (var read = DatabaseService.Where(Db.Contract.title, $"{Db.id} = {id}"))
            {
                if (read.Read())
                {
                    return new Contract(
                        (string)read.GetValue(read.GetOrdinal(Db.id)),
                        Contract.ToDate(Convert.ToInt64(read.GetValue(read.GetOrdinal(Db.Contract.deliveryDate)))),
                        Convert.ToInt64(read.GetValue(read.GetOrdinal(Db.Contract.summa))),
                        Convert.ToInt32(read.GetValue(read.GetOrdinal(Db.Contract.purchaseId))),
                        (string)read.GetValue(read.GetOrdinal(Db.Contract.fileName))
                    );
                }
            }
            return null;
        }
    }
}
