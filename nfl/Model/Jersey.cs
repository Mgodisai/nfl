using System;
using System.Text;

namespace nfl
{
    public class Jersey : IItemOrderable
    {
        public string Team { get; private set; }
        public string Name { get; private set; }
        public int JerseyNumber { get; private set; }
        public Size Size { get; private set; }
        public int PurchasingPrice { get; set; }
        public int SellingPrice { get; set; }
        public string PictureFileName { get; set; }
        public int MarginPerItem
        {
            get
            {
                return SellingPrice - PurchasingPrice;
            }
        }

        public Jersey(string team, string name, int jerseyNumber, Size size, int purchasingPrice, int sellingPrice, string pictureFileName)
        {
            Team = team;
            Name = name;
            JerseyNumber = jerseyNumber;
            Size = size;
            PurchasingPrice = purchasingPrice;
            SellingPrice = sellingPrice;
            PictureFileName = pictureFileName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Type: Jersey" + Environment.NewLine);
            sb.Append("Team: " + Team + Environment.NewLine);
            sb.Append("Player's name: " + Name + Environment.NewLine);
            sb.Append("Size: " + Size + Environment.NewLine);
            sb.Append("Selling Price: " + SellingPrice + Environment.NewLine);
            return sb.ToString();
        }
    }
}
