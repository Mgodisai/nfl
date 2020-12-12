using System.Text;

namespace nfl
{
    public class ItemOrdered<T> where T : IItemOrderable
    {
        public T Item { get; private set; }
        public int QuantityOfItem { get; private set; }

        public int OrderSellingValue
        {
            get
            {
                return QuantityOfItem * Item.SellingPrice;
            }
        }

        public int OrderPurchasingValue
        {
            get
            {
                return QuantityOfItem * Item.PurchasingPrice;
            }
        }

        public ItemOrdered(T item, int quantity)
        {
            this.Item = item;
            this.QuantityOfItem = quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Item.ToString());
            sb.Append("quantity: " + QuantityOfItem + " pc(s)");
            return sb.ToString();
        }
    }
}
