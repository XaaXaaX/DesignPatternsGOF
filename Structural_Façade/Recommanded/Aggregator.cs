using System;

namespace Structural_Façade.Recommanded
{
    public class Aggregator : IAggregator
    {
        private Aggregator() { }

        private static readonly Lazy<Aggregator> instance =
               new Lazy<Aggregator>(() => new Aggregator());

        public static Aggregator Instance { get { return instance.Value; } }

        public void Aggregate()
        {
            DbAggregator.Instance.AggregateDataBase();
            ServiceAggregator.Instance.AggregateService();
        }
    }
}
