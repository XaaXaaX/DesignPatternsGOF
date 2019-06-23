using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    public class Brand : IBrand
    {
        public virtual string BrandCommercialCode { get; set; }
        public virtual  string BrandExternalNetworkID { get; set; }
        public virtual string BrandInternalNetworkID { get; set; }
        public virtual string BrandName { get; set; }
        public bool IsActive { get; set; }
    }
    public interface IBrand
    {
        string BrandName { get; set; }
        string BrandCommercialCode { get; set; }
        string BrandInternalNetworkID { get; set; }
        string BrandExternalNetworkID { get; set; }
        bool IsActive { get; set; }
    }
}
