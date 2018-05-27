using System;

namespace CreativeWorkshop.Model
{
    public class ExecutedPurchaseReport
    {
        public string ClientName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Finished { get; set; }
        public long Summa { get; set; }

        public ExecutedPurchaseReport(string clientName, DateTime created, DateTime finished, long summa)
        {
            ClientName = clientName;
            Created = created;
            Finished = finished;
            Summa = summa;
        }
    }
}
