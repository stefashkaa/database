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

            using (var read = DatabaseService.Select(DbConstants.Contract.title))
            {
                while (read.Read())
                {
                    contracts.Add(
                        new Contract(
                            (string)read.GetValue(read.GetOrdinal(DbConstants.id)),
                            Contract.ToDate(Convert.ToInt64(read.GetValue(read.GetOrdinal(DbConstants.Contract.deliveryDate)))),
                            Convert.ToInt64(read.GetValue(read.GetOrdinal(DbConstants.Contract.summa))),
                            Convert.ToInt32(read.GetValue(read.GetOrdinal(DbConstants.Contract.purchaseId))),
                            (string)read.GetValue(read.GetOrdinal(DbConstants.Contract.fileName))
                        )
                    );
                }
            }
            return contracts;
        }
    }
}
