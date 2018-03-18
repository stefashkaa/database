using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeWorkshop.Model
{
    public class Purchase
    {
        public Client Client { get; set; }
        public long FirstSum { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public Status Status { get; set; }

        public Purchase(Client client, long firstSum, DateTime first, DateTime last, Status status)
        {
            Client = client;
            FirstSum = firstSum;
            FirstDate = first;
            LastDate = last;
            Status = status;
        }

        public long GetFirstDate()
        {
            return FirstDate.Ticks;
        }

        public long GetLastDate()
        {
            return LastDate.Ticks;
        }

        public static DateTime ToDate(long ticks)
        {
            return new DateTime(ticks);
        }
    }

    public enum Status
    {
        Unfilled,
        Filled
    }
}
