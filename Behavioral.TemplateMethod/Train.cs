using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.TemplateMethod
{
    public class Train : Booking, ITransport

    {
        private int Seats = 320;

        public void Book()
        {
            Seats--;
            Console.WriteLine("Train booked");
        }

        protected override AVailabilityStatus CheckAvailability()
        {
            if (Seats > 40)
            {
                return AVailabilityStatus.Available;
            }
            else if (Seats > 0)
            {
                return AVailabilityStatus.AvailableInAgency;
            }
            return AVailabilityStatus.Full;
        }
    }
}
