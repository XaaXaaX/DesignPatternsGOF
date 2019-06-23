using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Creational.Prototype.Deep
{
    [Serializable]
    public class Television : StockItem
    {
        public override StockItem Clone()
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
