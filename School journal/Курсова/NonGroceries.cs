namespace Курсова
{
    public class NonGroceries : Goods
    {
        public Dimensions dimensions { get; set; }
        public DestinationGroup group { get; set; }
        public NonGroceries(string name, string producer, int price, int quantity, Dimensions dimensions, DestinationGroup group)
        {
            this.name = name;
            this.producer = producer;
            this.price = price;
            this.quantity = quantity;
            this.dimensions = dimensions;
            this.group = group;
            isChanged = false;
        }
        public static bool operator ==(NonGroceries obj1, NonGroceries obj2)
        {
            if (obj1.name == obj2.name && obj1.producer == obj2.producer && obj1.price == obj2.price
                && obj1.dimensions == obj2.dimensions && obj1.group == obj2.group)
                return true;
            else
                return false;
        }
        public static bool operator !=(NonGroceries obj1, NonGroceries obj2) => !(obj1 == obj2);
    }
}
