using System;

namespace Behavioral.Strategy.Instantiation
{
    public interface ICalculator
    {
        double Calculate(Invoice invoice);
    }
}
