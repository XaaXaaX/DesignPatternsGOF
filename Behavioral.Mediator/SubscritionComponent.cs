using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Mediator
{
    public class SubscriptionComponent
    {
        private readonly IDashboard dashboard;

        public SubscriptionComponent(IDashboard dashboard)
        {
            this.dashboard = dashboard;
        }

        public void Subscribe(SubscriptionModel subscription)
        {
            // add subscription emited

            OperationModel model = new OperationModel
            {
                Title = "Subscribing ",
                Date = DateTime.Now,
                Details = subscription.ToString()
            };

            dashboard.Update(model);
        }
    }

}
