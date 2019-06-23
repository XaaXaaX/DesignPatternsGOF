using System;

namespace Creational.Prototype.Cloneable
{
    [Serializable]
    public class Stock
    {
        public string Name { get; set; }

        public IEmployee Manager { get; set; }
    }
}