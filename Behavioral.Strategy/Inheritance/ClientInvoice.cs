using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Inheritance
{
    public class ClientInvoice
    {
        private ClientType clientType;
        private readonly Invoice invoice;

        public ClientInvoice(ClientType clientType, Invoice invoice)
        {
            this.clientType = clientType;
            this.invoice = invoice;
        }

        public string FinalizeInvoice()
        {

            ICalculator calculator = new CalculatorSilver();

            if (clientType == ClientType.Gold)
            {
                calculator = new CalculatorGold();
            }

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
