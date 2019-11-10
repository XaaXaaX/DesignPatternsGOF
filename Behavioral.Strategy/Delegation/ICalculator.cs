using System;

namespace Behavioral.Strategy.Delegation
{
    public interface ICalculator
    {
        double Calculate(Invoice invoice);
    }
}
