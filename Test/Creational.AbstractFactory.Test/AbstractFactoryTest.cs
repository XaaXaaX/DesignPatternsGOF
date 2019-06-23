using Creational.AbstractFactory.Context;
using Creational.AbstractFactory.DomainObject.Vehicles;
using Xunit;

namespace Creational.AbstractFactory.Test
{
    public class AbstractFactoryTest
    {
        [Fact, Trait("Category", "Abstract Factory")]
        public void Vehicle_Factory_Create_Vehicle_Of_Brand()
        {
            IVehiculeFactory factory = new VehiculeFactory<BMW>();

            var v = factory.CurrentVehicle;
            
            Assert.IsType<Vehicle<BMW>>(v);
            Assert.Equal("BMW", v.VehicleComercialLable);
            Assert.Equal("BMW", factory.ToString());
        }
    }
}
