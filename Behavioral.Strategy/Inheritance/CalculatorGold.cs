using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behavioral.Strategy.Inheritance
{
    public class CalculatorGold : CalculatorSilver, ICalculator
    {
        public override double Calculate(Invoice invoice)
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
