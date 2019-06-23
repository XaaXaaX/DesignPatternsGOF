using System;

namespace Creational.Singleton.Lazy
{
    public sealed class EmployeeManager
    {
        private EmployeeManager() { }

        private static readonly Lazy<EmployeeManager> instance =
            new Lazy<EmployeeManager>(() => new EmployeeManager());

        public EmployeeManager Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
