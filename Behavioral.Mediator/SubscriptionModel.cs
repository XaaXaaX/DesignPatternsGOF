using System;

namespace Behavioral.Mediator
{
    public class SubscriptionModel
    {
        public string Details { get; set; }

        public string SubscriptionId { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{SubscriptionType} with {SubscriptionId} at {Date} \n {Details}";
        }

    }
}