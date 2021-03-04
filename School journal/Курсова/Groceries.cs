using System;

namespace Курсова
{
    public class Groceries : Goods
    {
        public int weight { get; }
        public DateTime dateCreation { get; }
        public DateTime dateExpiration { get; }
        public Groceries(string name, string producer, int price, int quantity, int weight, DateTime dateCreation, DateTime dateExpiration)
        {
            this.name = name;
            this.producer = producer;
            this.price = price;
            this.quantity = quantity;
            this.weight = weight;
            this.dateCreation = dateCreation;
            this.dateExpiration = dateExpiration;
            isChanged = false;
        }
        public static bool operator ==(Groceries obj1, Groceries obj2)
        {
            if (obj1.name == obj2.name && obj1.producer == obj2.producer && obj1.price == obj2.price
                && obj1.weight == obj2.weight && obj1.dateCreation == obj2.dateCreation
                && obj1.dateExpiration == obj2.dateExpiration)
                return true;
            else
                return false;
        }
        public static bool operator !=(Groceries obj1, Groceries obj2) => !(obj1 == obj2);
    }

}
