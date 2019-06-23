using System.Collections.Generic;

namespace Creational.Builder
{
    public interface IEquipment
    {
        void AddValidation(IValidation validation);

        IEnumerable<IValidation> GetValidationStatus();

        IEnumerable<string> GetConstructionStatus();
    }
}