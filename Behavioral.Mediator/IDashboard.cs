using System;
using System.Collections.Generic;

namespace Behavioral.Mediator
{
    public interface IDashboard
    {
        List<string> RecentOperations { get; }

        void Update(OperationModel operation);
    }
}
