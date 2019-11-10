using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behavioral.Strategy
{
    public class Invoice
    {
        public readonly IEnumerable<Order> orders;

        public Invoice(IEnumerable<Order> orders) => this.orders = orders;

        public string PrintInvoice()
        {
            StringBuilder @string = new StringBuilder();

            this.orders.ToList().ForEach(s =>
            {
                @string.Append(s.OrderNumber.ToString().PadRight(100));
                @string.Append(s.OrderDate.ToString().PadRight(100));
                @string.Append(s.OrderTotalPrice.ToString());
                @string.AppendLine();
            });

            return @string.ToString();
        }

        public double TotalPrice()
        {
            double total = 0;
            this.orders.ToList().ForEach(s =>
            {
                total += s.OrderTotalPrice;
            });

            return total;
        }
    }
}