using Retox.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Retox.View
{
    class DrinkControl
    {
        public TableLayoutPanel DrinkPanel { get; private set; }

        public DrinkControl(Panel container, List<Drink> listDrink)
        {
            DrinkPanel = new TableLayoutPanel();
            DrinkPanel.RowCount = 1;
            DrinkPanel.ColumnCount = 3;
            DrinkPanel.Width = container.Width;
            DrinkPanel.Height = container.Height;
            DrinkPanel.Controls.Add(new Label() { Text = "Megnevezés" }, 0, 0);
            DrinkPanel.Controls.Add(new Label() { Text = "Ár" }, 1, 0);
            DrinkPanel.Controls.Add(new Label() { Text = "Mennyiség" }, 2, 0);
            DrinkPanel.AutoScroll = true;

            for (int i = 0; i < DrinkPanel.ColumnCount; i++)
            {
                DrinkPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            }

            foreach (Drink d in listDrink)
            {

                DrinkPanel.Controls.Add(new CheckBox() { Text = d.Name, TextAlign = System.Drawing.ContentAlignment.MiddleLeft }, 0, DrinkPanel.RowCount);
                DrinkPanel.Controls.Add(new Label() { Text = d.UnitPrice.ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 1, DrinkPanel.RowCount);
                DrinkPanel.Controls.Add(new TextBox(), 2, DrinkPanel.RowCount);
                DrinkPanel.RowCount++;
            }

            container.Controls.Add(DrinkPanel);

        }
    }
}
