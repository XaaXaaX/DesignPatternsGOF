using Creational.AbstractFactory.DomainObject;
using Creational.AbstractFactory.DomainObject.Vehicles;

namespace Creational.AbstractFactory.Context
{
    public class VehiculeFactory<T> : IVehiculeFactory where T : Brand, new()
    {
        public VehiculeFactory()
        {
            CurrentVehicle = new Vehicle<T>();
        }

        public IVehicle CurrentVehicle { get; }

        public override string ToString()
        {
            return CurrentVehicle.VehicleComercialLable;
        }
    }

    public interface IVehiculeFactory
    {
        IVehicle CurrentVehicle { get; }
    }
}
