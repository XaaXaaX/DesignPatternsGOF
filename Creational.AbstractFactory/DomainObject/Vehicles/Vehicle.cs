using System.Collections.Generic;
using Creational.AbstractFactory.DomainObject.Options;
using Creational.AbstractFactory.DomainObject.Parts;
using System.Linq;

namespace Creational.AbstractFactory.DomainObject.Vehicles
{
    public class Vehicle<T> : IVehicle where T : IBrand, new()
    {
        IBrand vehicleBrand;

        public Vehicle()
        { vehicleBrand = new T(); }

        public string ModelLabel { get; set; }
        public string BodyStyle { get; set; }
        public string ColorCode { get; set; }
        public string EngineCode { get; set; }
        public string FinitionCode { get; set; }
        public List<Option> OptionList { get; set; }
        public List<Part> PartsList { get; set; }
        public string TrimCode { get; set; }
        public decimal Price { get; set; }
        public virtual decimal CalculatePrice()
        {
            return 0;
        }
        public virtual decimal OptionPrice()
        {
            return OptionList.Sum(p => p.OptionPrice);
        }

        public virtual string VehicleComercialLable
        {
            get
            {
                return vehicleBrand.BrandName;
            }
        }

        public virtual string VehicleNetworkLabel
        {
            get
            {
                return vehicleBrand.BrandExternalNetworkID;
            }
        }
    }
}
