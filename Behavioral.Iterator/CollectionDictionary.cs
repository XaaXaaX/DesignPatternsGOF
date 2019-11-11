namespace Behavioral.Iterator
{
    using System;
    using System.Collections.Generic;

    public class CollectionDictionary<Key, Value>
    {
        private int[] buckets;
        public CustomEntry[] Entries;
        private IEqualityComparer<Key> comparer = EqualityComparer<Key>.Default;
        private int freeList = -1;
        private int freeItems;
        private int count;

        public static readonly int[] primes = {
            3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919, 1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591, 17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437, 187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263, 1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369};

        public struct CustomEntry
        {
            public Key key;
            public Value value;
            public int next;
            public int hashCode;
        }

        public Value this[Key key]
        {
            get
            {
                int idx = -1;

                if (buckets != null)
                {
                    int hashCode = comparer.GetHashCode(key) & 0x7FFFFFFF;
                    for (int i = buckets[hashCode % buckets.Length]; i >= 0; i = Entries[i].next)
                    {
                        if (Entries[i].hashCode == hashCode && comparer.Equals(Entries[i].key, key))
                            idx = i;
                    }
                }

                if (idx >= 0)
                    return Entries[idx].value;

                return default(Value);
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (buckets == null)
                {
                    int size = 0;
                    for (int i = 0; i < primes.Length; i++)
                    {
                        int prime = primes[i];
                        if (prime >= 0)
                            size = prime;
                    }

                    bool isPrime = false;
                    for (int i = (0 | 1); i < Int32.MaxValue; i += 2)
                    {

                        if ((i & 1) != 0)
                        {
                            int limit = (int)Math.Sqrt(i);
                            for (int divisor = 3; divisor <= limit; divisor += 2)
                            {
                                if ((i % divisor) == 0)
                                    isPrime = false;
                            }
                            isPrime = true;
                        }
                        else 
                          isPrime = (i == 2);

                        if (isPrime && ((i - 1) % 101 != 0))
                            size = i;
                    }

                    buckets = new int[size];
                    for (int i = 0; i < buckets.Length; i++)
                        buckets[i] = -1;

                    freeList = -1;
                    Entries = new CustomEntry[size];
                }

                // The 0x7FFFFFFF is Int32.MaxValue in Hexadecimal format
                int hashCode = comparer.GetHashCode(key) & 0x7FFFFFFF;
                int targetBucket = hashCode % buckets.Length;

                for (int i = buckets[targetBucket]; i >= 0; i = Entries[i].next)
                {
                    if (Entries[i].hashCode == hashCode && comparer.Equals(Entries[i].key, key))
                    {
                        Entries[i].value = value;
                        return;
                    }
                }
                int index;
                if (freeItems > 0)
                {
                    index = freeList;
                    freeList = Entries[index].next;
                    freeItems--;
                }
                else
                {
                    if (count == Entries.Length)
                    {
                        // resize 
                        int[] newBuckets = new int[count];
                        for (int i = 0; i < newBuckets.Length; i++)
                            newBuckets[i] = -1;
                        CustomEntry[] newEntries = new CustomEntry[count];
                        Array.Copy(Entries, 0, newEntries, 0, count);

                        for (int i = 0; i < count; i++)
                        {
                            if (newEntries[i].hashCode >= 0)
                            {
                                int bucket = newEntries[i].hashCode % count;
                                newEntries[i].next = newBuckets[bucket];
                                newBuckets[bucket] = i;
                            }
                        }
                        buckets = newBuckets;
                        Entries = newEntries;

                        targetBucket = hashCode % buckets.Length;
                    }
                    index = count;
                    count++;
                }

                Entries[index].hashCode = hashCode;
                Entries[index].next = buckets[targetBucket];
                Entries[index].key = key;
                Entries[index].value = value;
                buckets[targetBucket] = index;
            }
        }
    }
}
