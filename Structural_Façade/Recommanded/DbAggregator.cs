namespace Structural_Façade.Recommanded
{
    using System;
    internal class DbAggregator
    {
        private DbAggregator() { }

        private static readonly Lazy<DbAggregator> instance =
                new Lazy<DbAggregator>(() => new DbAggregator());

        public static DbAggregator Instance { get { return instance.Value; } }

        public object AggregateDataBase()
        {
            throw new NotImplementedException();
        }
    }
}
