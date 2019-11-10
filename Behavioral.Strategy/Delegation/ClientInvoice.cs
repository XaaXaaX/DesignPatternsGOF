using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Delegation
{
    public class ClientInvoice
    {
        private readonly CalculatorFactory calculatorFactory;
        private readonly Invoice invoice;

        public ClientInvoice(ClientType clientType, Invoice invoice)
        {
            this.calculatorFactory = new CalculatorFactory(clientType);
            this.invoice = invoice;
        }

        public CalculatorFactory CalculatorFactory
        {
            get => default;
            set
            {
            }
        }

        public string FinalizeInvoice()
        {

            string invoiceResult = invoice.PrintInvoice();

            invoiceResult += string.Concat("Total Price:", invoice.TotalPrice());
            invoiceResult += string.Concat("Promoted Price:", this.calculatorFactory.Calculate(this.invoice));

            return invoiceResult;
        }
    }
}
