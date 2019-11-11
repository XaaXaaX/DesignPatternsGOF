using System;

namespace Behavioral.Mediator
{
    public class UserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Details { get; private set; }

        public override string ToString()
        {
            return $"{Name} {LastName} \n {Details}";
        }
    }
}