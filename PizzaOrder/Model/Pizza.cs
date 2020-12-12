namespace PizzaOrder.Model
{
    class Pizza
    {
        public string Name { get; set; }
        public int SmallPrice { get; private set; }
        public int HugePrice { get; private set; }

        public Pizza(string name, int sPrice, int hPrice)
        {
            this.Name = name;
            this.SmallPrice = sPrice;
            this.HugePrice = hPrice;
        }
    }


}
