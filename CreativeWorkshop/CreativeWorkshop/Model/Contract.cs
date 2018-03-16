using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeWorkshop.Model
{
    public class Contract
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public long Sum { get; set; }
        public int OrderId { get; set; }

        public Contract(DateTime date, long sum, int orderId)
        {
            Date = date;
            Sum = sum;
            OrderId = orderId;
        }

        public bool IsPhClient()
        {
            return Id.ToLower().Contains("ph");
        }

        public int GetNumId()
        {
            return IsPhClient() ? Convert.ToInt32(Id.Remove(0, 2)) : Convert.ToInt32(Id.Remove(0, 1));
        }
    }
}
