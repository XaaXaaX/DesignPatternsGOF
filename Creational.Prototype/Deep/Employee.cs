using System;

namespace Creational.Prototype.Deep
{

    [Serializable]
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
