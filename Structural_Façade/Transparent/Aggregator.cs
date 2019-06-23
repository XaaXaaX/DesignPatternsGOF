namespace Structural_Façade.Transparent
{
    public class Aggregator : IAggregator
    {
        DbAggregator dbAgg = new DbAggregator();
        ServiceAggregator srvAgg = new ServiceAggregator();

        public void Aggregate()
        {
            dbAgg.AggregateDataBase();
            srvAgg.AggregateService();
        }
    }
}
