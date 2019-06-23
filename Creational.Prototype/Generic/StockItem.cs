using System;

namespace Creational.Prototype.Generic
{
    [Serializable]
    public class StockItem : Prototype<StockItem>
    {
        protected StockItem() { }

        public uint Quantity { get; set; }

        public uint Worthiness { get; set; }

        public Stock Stock { get; set; }
    }
}
