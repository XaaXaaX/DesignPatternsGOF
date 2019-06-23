namespace Creational.Prototype.Shallow
{
    public class Television : StockItem
    {
        public override StockItem Clone()
        {
            return this.MemberwiseClone() as StockItem;
        }
    }
}
