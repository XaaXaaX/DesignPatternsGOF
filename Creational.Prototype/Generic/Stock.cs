using System;

namespace Creational.Prototype.Generic
{
    [Serializable]
    public class Stock
    {
        public string Name { get; set; }

        public IEmployee Manager { get; set; }
    }
}