using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class BMW: Brand
    {
        public override string BrandName
        {
            get
            {
                return "BMW" ;
            }

            set
            {
                base.BrandName = value;
            }
        }
    }
}
