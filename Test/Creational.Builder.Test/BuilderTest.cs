using Creational.Builder;
using System;
using Xunit;

namespace Creational.Builder.Test
{
    public class BuilderTest
    {
        [Fact,Trait("Category","Builder")]
        public void Builder_Validate_Engin_empty_If_NotValid()
        {
            Validator validator = new Validator();

            IEquipment equipment = new RotaryEquipment();
            equipment.AddValidation(new EngineValidation
            {
                ValidationDate = DateTime.Now,
                InProgress = true
            });

            var result = validator.Validate(equipment);

            Assert.NotNull(result);
            Assert.Empty(result);
        }
        [Fact, Trait("Category", "Builder")]
        public void Builder_Validate_Engine_If_Valid()
        {
            Validator validator = new Validator();

            IEquipment equipment = new RotaryEquipment();
            equipment.AddValidation(new EngineValidation
            {
                ValidationDate = DateTime.Now,
                InProgress = true,
                ValidateByMaster = true,
                ValidatedBySupervisor = true
            });

            var result = validator.Validate(equipment);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

        }

        [Fact, Trait("Category", "Builder")]
        public void Builder_Not_Validate_Engine_If_Master_Not_Valid()
        {
            Validator validator = new Validator();

            IEquipment equipment = new RotaryEquipment();
            equipment.AddValidation(new EngineValidation
            {
                ValidationDate = DateTime.Now,
                InProgress = true,
                ValidatedBySupervisor = true
            });

            var result = validator.Validate(equipment);

            Assert.NotNull(result);
            Assert.Empty(result);

        }

        [Fact, Trait("Category", "Builder")]
        public void Builder_Validate_Foundation_If_Valid()
        {
            Validator validator = new Validator();

            IEquipment equipment = new RotaryEquipment();
            equipment.AddValidation(new FoundationValidation
            {
                ValidationDate = DateTime.Now,
                InProgress = true,
                ValidatedBySupervisor = true
            });

            var result = validator.Validate(equipment);

            Assert.NotNull(result);
            Assert.NotEmpty(result);

        }

    }
}
