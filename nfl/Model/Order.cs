using System.Collections.Generic;

namespace nfl
{
    public class Order<T> where T : ItemOrdered<IItemOrderable>
    {
        private List<T> listOfOrderedItem;

        public Order()
        {
            this.listOfOrderedItem = new List<T>();
        }

        public int Count
        {
            get
            {
                return listOfOrderedItem.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return listOfOrderedItem[index];
            }
        }

        public void Add(T item)
        {
            listOfOrderedItem.Add(item);
        }

        public double SellingValue
        {
            get
            {
                int sum = 0;
                for (int i = 0; i< Count;i++)
                {
                    sum += listOfOrderedItem[i].OrderSellingValue;
                }
                return sum;
            }
        }

        public double PurchasingValue
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Count; i++)
                {
                    sum += listOfOrderedItem[i].OrderPurchasingValue;
                }
                return sum;
            }
        }



    }
}
