namespace Structural_Façade.Static
{
    public static class Aggregator
    {

        public static void Aggregate()
        {
            DbAggregator.AggregateDataBase();
            ServiceAggregator.AggregateService();
        }
    }
}
