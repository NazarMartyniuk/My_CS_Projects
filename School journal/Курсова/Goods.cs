namespace Курсова
{
    public abstract class Goods
    {
        public string name { get; set; }
        public string producer { get; set; }
        public int price { get; set; }
        public int quantity { get; set; } //Кількість
        public bool isChanged { get; set; }
    }
}
