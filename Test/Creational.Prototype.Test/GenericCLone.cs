using Creational.Prototype.Cloneable;
using System;
using Xunit;

namespace Creational.Prototype.Test
{
    public class GenericTest
    {
        [Fact, Trait("Category", "Prototype")]
        public void Generic_Shallow_Returns_Copy()
        {
            var tv = GetTelevision();

            Television tvClone = tv.Clone() as Television;

            Assert.NotNull(tvClone);
            Assert.Equal(tv.Quantity, tvClone.Quantity);
            Assert.Equal(tv.Worthiness, tvClone.Worthiness);
            Assert.Equal(tv.Stock.Name, tvClone.Stock.Name);
            Assert.Equal(tv.Stock.Manager.FirstName, tvClone.Stock.Manager.FirstName);
            Assert.Equal(tv.Stock.Manager.LastName, tvClone.Stock.Manager.LastName);
        }
        [Fact, Trait("Category", "Prototype")]
        public void Generic_Deep_Keep_Origin_Copy_If_Changed()
        {
            var tv = GetTelevision();

            Television tvClone = tv.DeepClone() as Television;

            tvClone.Stock.Manager.LastName = "ModifiedLastName";
            tv.Stock.Name = "ModifiedName";
            tv.Quantity--;

            Assert.NotNull(tvClone);
            Assert.NotEqual(tv.Quantity, tvClone.Quantity);
            Assert.Equal(tv.Worthiness, tvClone.Worthiness);
            Assert.NotEqual(tv.Stock.Name, tvClone.Stock.Name);
            Assert.Equal(tv.Stock.Manager.FirstName, tvClone.Stock.Manager.FirstName);
            Assert.NotEqual(tv.Stock.Manager.LastName, tvClone.Stock.Manager.LastName);
        }
        [Fact, Trait("Category", "Prototype")]
        public void Generic_Shallow_Does_Not_Keep_Origin_Copy_If_Changed()
        {
            var tv = GetTelevision();

            Television tvClone = tv.Clone() as Television;

            tvClone.Stock.Manager.LastName = "ModifiedLastName";
            tv.Stock.Name = "ModifiedName";
            tv.Quantity--;

            Assert.NotNull(tvClone);
            Assert.NotEqual(tv.Quantity, tvClone.Quantity);
            Assert.Equal(tv.Worthiness, tvClone.Worthiness);
            Assert.Equal(tv.Stock.Name, tvClone.Stock.Name);
            Assert.Equal(tv.Stock.Manager.FirstName, tvClone.Stock.Manager.FirstName);
            Assert.Equal(tv.Stock.Manager.LastName, tvClone.Stock.Manager.LastName);
        }
        private static Television GetTelevision()
        {
            Television television = new Television();
            television.Quantity = 120;
            television.Worthiness = 10;
            television.Stock = new Stock
            {
                Manager = new Employee
                {
                    LastName = "TestManager",
                    FirstName = "Test"
                },
                Name = "TestStock"
            };
            return television;
        }
    }
}
