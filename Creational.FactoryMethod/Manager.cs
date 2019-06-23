namespace Creational.FactoryMethod
{
    public class Manager
    {
        public IProduct CreateProduct(ProductCategory category)
        {
            switch (category)
            {
                case ProductCategory.LivingRoom:
                    return new Television();
                case ProductCategory.Kitchen:
                    return new Refrigerator();
                default:
                    return null;
            }
        }
    }
}
