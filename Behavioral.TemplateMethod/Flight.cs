using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.TemplateMethod
{
    public class Flight : Booking, ITransport
    {
        private int Seats = 80;

        public void Book()
        {
            Seats--;
            Console.WriteLine("Flight booked");
        }

        protected override AVailabilityStatus CheckAvailability()
        {
            if (Seats > 0)
            {
                return AVailabilityStatus.Available;
            }
            return AVailabilityStatus.Full;
        }
    }
}
