using System.Linq;

namespace Behavioral.Strategy.Extensions
{
    public static class InvoiceExtensions
    {
        public static double Calculate(this Invoice invoice, ClientType clientType)
        {
            if (clientType == ClientType.Gold)
            {
                return CalculateGold(invoice);
            }
            return CalculateSilver(invoice);
        }
        static double CalculateSilver(Invoice invoice)
        {
            var t = invoice.TotalPrice();
            if (t > 0)
            {
                return (t - t * 10 / 100);
            }

            return t;
        }

        static double CalculateGold(Invoice invoice)
        {
            double t = 0;
            if (t > 0)
            {
                invoice.orders.ToList().ForEach(o =>
                {
                    if (o.ItemCount > 100)
                        t += o.OrderTotalPrice * (o.OrderTotalPrice * 50 / 100);
                    else
                        t += o.OrderTotalPrice;
                });
            }

            return t;
        }
    }
}
