namespace Creational.AbstractFactory.DomainObject.Options
{
    public class Option
    {
        public string OptionCode { get; set; }
        public string OptionCommercialName { get; set; }
        public string OptionName { get; set; }
        public decimal OptionPrice { get; internal set; }
    }
}