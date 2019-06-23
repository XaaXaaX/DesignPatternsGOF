using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Creational.Prototype.Cloneable
{
    [Serializable]
    public class StockItem : ICloneable
    {
        protected StockItem() { }

        public uint Quantity { get; set; }

        public uint Worthiness { get; set; }

        public Stock Stock { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone() as StockItem;
        }

        public object DeepClone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            StockItem copy = (StockItem)formatter.Deserialize(stream);
            stream.Close();
            return copy;

        }
    }
}
