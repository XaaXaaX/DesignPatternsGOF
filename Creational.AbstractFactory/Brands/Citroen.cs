using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class Citroen : Brand
    {
        public override string BrandExternalNetworkID
        {
            get
            {
                return "Citroen";
            }

            set
            {
                base.BrandExternalNetworkID = value;
            }
        }
        public override string BrandName
        {
            get
            {
                return "Citroen";
            }

            set
            {
                base.BrandName = value;
            }
        }
    }
}
