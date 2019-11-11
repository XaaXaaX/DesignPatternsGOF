using System.Collections.Generic;

namespace Behavioral.Mediator
{
    public class Dashboard : IDashboard
    {
        public List<string> RecentOperations { get; private set; } = new List<string>();
        
        public void Update(OperationModel operation)
        {
            RecentOperations.Add(operation.ToString());
        }
    }
}
