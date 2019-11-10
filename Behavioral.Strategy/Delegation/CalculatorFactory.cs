using System;
using System.Linq;

namespace Behavioral.Strategy.Delegation
{
    public delegate double Calculation(Invoice invoice);

    public class CalculatorFactory: ICalculator
    {
        private readonly ClientType clientType;
        private readonly Calculation calculation;

        public CalculatorFactory(ClientType clientType)
        {
            this.clientType = clientType;
            this.calculation = DiscoverCalculator();
        }
   
        public double Calculate(Invoice invoice)
        {
            return this.calculation(invoice);
        }

        public Calculation DiscoverCalculator()
        {
            switch (this.clientType)
            {
                case ClientType.Silver:
                    return CalculateSilver;
                case ClientType.Gold:
                    return CalculateGold;
                default: throw new ArgumentException("Unexpected Client Type");
            }
        }

        private static double CalculateSilver(Invoice invoice)
        {
            var t = invoice.TotalPrice();
            if (t > 0)
            {
                return (t - t * 10 / 100);
            }

            return t;
        }

        private static double CalculateGold(Invoice invoice)
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
