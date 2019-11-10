using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Extensions
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

            string invoiceResult = invoice.PrintInvoice();

            invoiceResult += string.Concat("Total Price:", invoice.TotalPrice());
            invoiceResult += string.Concat("Promoted Price:", invoice.Calculate(this.clientType));

            return invoiceResult;
        }

        public void UpgradeClient()
        {
            int type = ((int)this.clientType);
            this.clientType = (ClientType)(++type);
        }
    }
}
