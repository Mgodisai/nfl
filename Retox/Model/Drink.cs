namespace Retox.Model
{
    class Drink
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public Drink(string name, double unitPrice)
        {

            this.Name = name;
            this.UnitPrice = unitPrice;

        }



    }

}
