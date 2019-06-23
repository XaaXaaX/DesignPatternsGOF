using System;

namespace Creational.Prototype.Deep
{
    [Serializable]
    public class Stock
    {
        public string Name { get; set; }

        public IEmployee Manager { get; set; }
    }
}