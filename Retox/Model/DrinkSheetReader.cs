using System;
using System.Collections.Generic;
using System.IO;

namespace Retox.Model
{
    class DrinkSheetReader
    {
        public List<Drink> DrinkList { get; private set; }

        public DrinkSheetReader()
        {
            this.DrinkList = new List<Drink>();
        }

        public string[] ReadSheetFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public void GetDrinkList(string filePath, char delimiter)
        {
            string[] lines = ReadSheetFromFile(filePath);
            string[] drinkLine;
            Drink tempDrink;
            foreach (string s in lines)
            {
                drinkLine = s.Split(delimiter);
                tempDrink = new Drink(drinkLine[0], Double.Parse(drinkLine[1]));
                DrinkList.Add(tempDrink);
            }

        }



    }
}
