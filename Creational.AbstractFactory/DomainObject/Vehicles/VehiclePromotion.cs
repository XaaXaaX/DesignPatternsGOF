using Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.DomainObject.Vehicles
{
    public class VehiclePromotion<T> : Vehicle<T> , IVehiclePromotion
        where T : IBrand , new() 
    {
        IBrand vehicleBrand;
        public VehiclePromotion()
        { vehicleBrand = new T(); }

        public override decimal CalculatePrice()
        {
            return (base.CalculatePrice() - Promotion);
        }

        public override decimal OptionPrice()
        {
            return base.OptionPrice();
        }
        public decimal Promotion { get; set; }
    }
}
