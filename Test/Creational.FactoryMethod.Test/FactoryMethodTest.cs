using Xunit;
namespace Creational.FactoryMethod.Test
{
    public class FactoryMethodTest
    {
        [Fact, Trait("Category", "Factory Method")]
        public void Manager_Returns_Television()
        {
            Manager manager = new Manager();

            var actual = manager.CreateProduct(ProductCategory.LivingRoom);

            Assert.NotNull(actual);
            Assert.IsType<Television>(actual);
            Assert.Equal(1000, actual.GetStock());
        }

        [Fact, Trait("Category", "Factory Method")]
        public void Manager_Returns_Null()
        {
            Manager manager = new Manager();

            var actual = manager.CreateProduct(ProductCategory.BathRoom);

            Assert.Null(actual);
        }

        [Fact, Trait("Category", "Factory Method")]
        public void Manager_Returns_Refrigerator()
        {
            Manager manager = new Manager();

            var actual = manager.CreateProduct(ProductCategory.Kitchen);

            Assert.NotNull(actual);
            Assert.IsType<Refrigerator>(actual);
            Assert.Equal(200, actual.GetStock());
        }

    }
}
