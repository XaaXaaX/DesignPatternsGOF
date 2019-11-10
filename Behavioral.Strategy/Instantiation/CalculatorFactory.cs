using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Instantiation
{
    public class CalculatorFactory
    {
        public ICalculator DiscoverCalculator(ClientType clientType)
        {
            if (clientType == ClientType.Gold)
            {
                return new CalculatorGold();
            }
            return new CalculatorSilver();
        }
    }
}
