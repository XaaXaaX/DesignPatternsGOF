using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class Peugeot : Brand
    {
        public override string BrandName
        {
            get
            {
                return "Peugeot";
            }

            set
            {
                base.BrandName = value;
            }
        }
    }
}
