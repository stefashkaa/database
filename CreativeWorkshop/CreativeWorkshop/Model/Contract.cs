﻿using System;
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
        public string FileName { get; set; }


        public Contract(string id, DateTime date, long sum, int orderId, string fileName)
        {
            Id = id;
            Date = date;
            Sum = sum;
            OrderId = orderId;
            FileName = fileName;
        }

        public bool IsPhClient()
        {
            return Id.ToLower().Contains("ph");
        }

        public int GetNumId()
        {
            return IsPhClient() ? Convert.ToInt32(Id.Remove(0, 2)) : Convert.ToInt32(Id.Remove(0, 1));
        }

        public long GetDate()
        {
            return Date.Ticks;
        }

        public static DateTime ToDate(long ticks)
        {
            return new DateTime(ticks);
        }

        public static string ToDateString(long ticks)
        {
            return ToDate(ticks).ToShortDateString();
        }

        public static bool IsPhClient(string id)
        {
            return id.ToLower().Contains("ph");
        }
    }
}
