using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeWorkshop.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public long FirstSum { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Unfilled,
        Filled
    }
}
