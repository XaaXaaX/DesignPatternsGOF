using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Instantiation
{
    public class CalculatorSilver : ICalculator
    {
        public double Calculate(Invoice invoice)
        {
            var t = invoice.TotalPrice();
            if (t > 0)
            {
                return (t - t * 10 / 100);
            }

            return t;
        }
    }
}
