using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Creational.Prototype.Generic
{
    public class Prototype<T> : ICloneable
    {
        public object Clone()
        {
            return (T)this.MemberwiseClone();
        }

        public object DeepClone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;

        }
    }
}
