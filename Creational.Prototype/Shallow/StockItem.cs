namespace Creational.Prototype.Shallow
{
    public abstract class StockItem
    {
        public uint Quantity { get; set; }

        public uint Worthiness { get; set; }

        public Stock Stock { get; set; }

        public abstract StockItem Clone();
    }
}
