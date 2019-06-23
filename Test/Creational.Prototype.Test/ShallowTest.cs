using Creational.Prototype.Shallow;
using System;
using Xunit;

namespace Creational.Prototype.Test
{
    public class ShallowTest
    {
        [Fact, Trait("Category", "Prototype")]
        public void Shallow_Return_Top_Level_Copy()
        {
            var tv = GetTelevision();

            Television tvClone = tv.Clone() as Television;

            Assert.NotNull(tvClone);
            Assert.Equal(tv.Quantity, tvClone.Quantity);
            Assert.Equal(tv.Worthiness, tvClone.Worthiness);
            Assert.Equal(tv.Stock.Name, tvClone.Stock.Name);
            Assert.Equal(tv.Stock.Manager.FirstName, tvClone.Stock.Manager.FirstName);
        }
        [Fact, Trait("Category", "Prototype")]
        public void Shallow_Modifies_Copy_If_Changed()
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
