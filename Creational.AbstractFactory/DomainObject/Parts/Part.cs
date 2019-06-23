using Creational.AbstractFactory.DomainObject.Equipments;
using System.Collections.Generic;

namespace Creational.AbstractFactory.DomainObject.Parts
{
    public class Part
    {
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public List<Equipment> EquipmentList { get; set; }

    }
}