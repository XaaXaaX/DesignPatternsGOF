using System;
namespace Structural_Façade.Recommanded
{
    internal class ServiceAggregator
    {

        private ServiceAggregator() { }

        private static readonly Lazy<ServiceAggregator> instance =
               new Lazy<ServiceAggregator>(() => new ServiceAggregator());

        public static ServiceAggregator Instance { get { return instance.Value; } }

        public object AggregateService()
        {
            throw new NotImplementedException();
        }
    }
}
