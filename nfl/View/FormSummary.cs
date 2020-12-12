using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfl
{
    public partial class FormSummary : Form
    {
        static IFormatProvider formatProvider = new System.Globalization.CultureInfo("en-US");
        List<Order<ItemOrdered<IItemOrderable>>> listOfAllOrders;

        public double TotalNumberOfOrders { get; private set; }
        public double TotalPurchasingValue { get; private set; }
        public double TotalSellingValue { get; private set; }
        public double TotalMargin { get; private set; }

        public FormSummary(List<Order<ItemOrdered<IItemOrderable>>> listOfAllOrders)
        {
            InitializeComponent();
            this.listOfAllOrders = listOfAllOrders;

            Accounting();
            labelValueMargin.Text = String.Format(formatProvider, "{0:C}", TotalMargin);
            labelValueNumberOfOrders.Text = String.Format("{0} db", TotalNumberOfOrders);
            labelValueSellingPrice.Text = String.Format(formatProvider, "{0:C}", TotalSellingValue);
            labelValuePurchasingPrice.Text = String.Format(formatProvider, "{0:C}", TotalPurchasingValue);
            

        }

        private void Accounting()
        {
            if ( (TotalNumberOfOrders=listOfAllOrders.Count)!=0)
            {
                foreach (Order<ItemOrdered<IItemOrderable>> order in listOfAllOrders)
                {
                    TotalSellingValue += order.SellingValue;
                    TotalPurchasingValue += order.PurchasingValue;
                    
                }
                TotalMargin =  TotalSellingValue-TotalPurchasingValue;
            }
        }
    }
}
