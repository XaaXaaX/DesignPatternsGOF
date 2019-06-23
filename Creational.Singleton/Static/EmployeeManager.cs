using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton.Static
{
    public sealed class EmployeeManager
    {
        private EmployeeManager() { }

        private readonly static EmployeeManager instance = new EmployeeManager();

        public EmployeeManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
