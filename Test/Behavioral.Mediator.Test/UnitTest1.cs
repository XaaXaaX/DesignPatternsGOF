using System;
using System.Linq;
using Xunit;

namespace Behavioral.Mediator.Test
{
    public class MediatorTest
    {
        [Fact]
        public void User_Add_shall_be_notified_to_dashboard()
        {
            IDashboard dashboard = new Dashboard();

            UserComponent user = new UserComponent(dashboard);
            user.AddUser(new UserModel { Name = "MyName", LastName = "MyLastName", BirthDate = new DateTime(1982, 03, 11) });


            Assert.Contains("Adding User", dashboard.RecentOperations.Last());
            Assert.Contains("MyLastName", dashboard.RecentOperations.Last());

        }
    }
}
