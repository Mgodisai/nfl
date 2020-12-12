using System;
using System.Collections.Generic;
using System.IO;

namespace nfl
{
    class JerseyParser : IItemParser<Jersey>
    {
        public List<Jersey> ParseFile(string fileName, char delimiter)
        {
            List<Jersey> jerseys = new List<Jersey>();
            string[] fullText = ReadFullTextFromFile(fileName);

            string[] dataItems;
            Jersey tempItem;
            foreach (string s in fullText)
            {
                dataItems = s.Split(delimiter);

                tempItem = new Jersey(
                    team: dataItems[0],
                    name: dataItems[1],
                    jerseyNumber: int.Parse(dataItems[2]),
                    size: (Size)Enum.Parse(typeof(Size), dataItems[3], true),
                    purchasingPrice: int.Parse(dataItems[4]),
                    sellingPrice: int.Parse(dataItems[5]),
                    pictureFileName: dataItems[6]);

                jerseys.Add(tempItem);

            }
            return jerseys;


        }

        private string[] ReadFullTextFromFile(string fileName)
        {
            string[] fullText;
            using (StreamReader reader = new StreamReader(fileName))
            {
                fullText = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            return fullText;
        }
    }
}
