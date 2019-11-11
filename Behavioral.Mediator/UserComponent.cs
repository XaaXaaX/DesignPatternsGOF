using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Mediator
{
    public class UserComponent
    {
        private readonly IDashboard dashboard;

        public UserComponent(IDashboard dashboard)
        {
            this.dashboard = dashboard;
        }

        public void AddUser(UserModel user)
        {
            // add user emited

            OperationModel model = new OperationModel
            {
                Title = "Adding User",
                Date = DateTime.Now,
                Details = user.ToString()
            };

            dashboard.Update(model);
        }
    }
}
