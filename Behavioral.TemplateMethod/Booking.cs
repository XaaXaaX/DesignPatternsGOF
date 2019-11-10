using System;

namespace Behavioral.TemplateMethod
{
    public abstract class Booking
    {
        public void Book(ITransport transport)
        {
            if (CheckAvailability() == AVailabilityStatus.Available)
            {
                transport.Book();
                Payement();
            }
        }

        private void Payement()
        {
            Console.WriteLine("Payment process terminated successfully");
        }

        protected abstract AVailabilityStatus CheckAvailability();

    }
}
