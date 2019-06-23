using System;

namespace Creational.Prototype.Generic
{
    [Serializable]
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
