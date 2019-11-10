using System;

namespace Behavioral.Strategy
{
    public class Order
    {
        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public int ItemCount { get; set; }

        public double OrderTotalPrice { get; set; }
    }
}