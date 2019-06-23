using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Builder
{
    public class Validator
    {
        public String Validate(IEquipment equipment)
        {
            return string.Join(",\n", equipment.GetConstructionStatus());
        }
    }
}
