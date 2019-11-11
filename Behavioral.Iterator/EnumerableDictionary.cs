using System;
using System.Collections;
using System.Collections.Generic;

namespace Behavioral.Iterator
{

    public class EnumerableDictionary<Key, Value> : IEnumerable
    {
        public CollectionDictionary<Key, Value> Collection
        {
            get;
            private set;
        }

        public EnumerableDictionary(CollectionDictionary<Key, Value> collection)
        {
            this.Collection = collection;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.Collection.Entries)
                yield 
                    return new KeyValuePair<Key, Value>(item.key, item.value);
        }
    }
}