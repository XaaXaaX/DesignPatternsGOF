using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Instantiation
{
    public class ClientInvoice
    {
        private ClientType clientType;
        private readonly CalculatorFactory calculatorFactory;
        private readonly Invoice invoice;

        public ClientInvoice(ClientType clientType, Invoice invoice)
        {
            this.clientType = clientType;
            this.calculatorFactory = new CalculatorFactory();
            this.invoice = invoice;
        }

        public string FinalizeInvoice()
        {
            ICalculator calculator = this.calculatorFactory.DiscoverCalculator(this.clientType);

            string invoiceResult = invoice.PrintInvoice();

            invoiceResult += string.Concat("Total Price:", invoice.TotalPrice());
            invoiceResult += string.Concat("Promoted Price:", calculator.Calculate(this.invoice));

            return invoiceResult;
        }

        public void UpgradeClient()
        {
            int type = ((int)this.clientType);
            this.clientType = (ClientType)(++type);
        }
    }
}
