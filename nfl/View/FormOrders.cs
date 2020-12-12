using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nfl
{
    public partial class FormOrders : Form
    {
        const int DEFAULT_PIC_WIDTH = 100;
        static IFormatProvider formatProvider = new System.Globalization.CultureInfo("en-US");

        // rendelhető tételek
        private ItemStorage<Jersey> storage;

        // kontrollgyűjtemény lista
        private List<OrderControl> controlList = new List<OrderControl>();

        // leadott rendelések listája
        List<Order<ItemOrdered<IItemOrderable>>> listOfAllOrders;

        public FormOrders(ItemStorage<Jersey> storage, List<Order<ItemOrdered<IItemOrderable>>> listOfAllOrders)
        {
            InitializeComponent();
            labelSumOfOrders.Text = string.Format(formatProvider, "{0:C2}",0);
            this.storage = storage;
            this.listOfAllOrders = listOfAllOrders;
        }

        private void CreateDynamicFormContent()
        {
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Width = panelItemList.Width;
            tlp.Height = panelItemList.Height;
            tlp.AutoScroll = true;
            tlp.Top = 0;
            tlp.Left = 0;
            tlp.RowCount = 1;
            tlp.ColumnCount = 9;

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, DEFAULT_PIC_WIDTH));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));

            int actualRow = 0;
            foreach (Jersey j in storage)
            {
                CreateControlsOfItem(j, tlp, actualRow++);
            }
            panelItemList.Controls.Add(tlp);
        }

        private void CreateControlsOfItem(Jersey jersey, TableLayoutPanel tableLayoutPanel, int row)
        {
            PictureBox pictureBox = new PictureBox();
            Image image = Image.FromFile("..\\..\\Images\\" + jersey.PictureFileName);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = DEFAULT_PIC_WIDTH;
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.MouseHover += new System.EventHandler(ItemMouseHoverEffect);

            Label teamName = new Label();
            teamName.Text = jersey.Team;
            teamName.Anchor = AnchorStyles.None;

            Label playerName = new Label();
            playerName.Text = jersey.Name;
            playerName.Anchor = AnchorStyles.None;

            Label jerseyNumber = new Label();
            jerseyNumber.Text = "#" + jersey.JerseyNumber.ToString();
            jerseyNumber.Anchor = AnchorStyles.Left;

            Label size = new Label();
            size.Text = jersey.Size.ToString();
            size.Anchor = AnchorStyles.Left;

            Label sellingPrice = new Label();
            sellingPrice.Text = String.Format(formatProvider, "{0:C2}", jersey.SellingPrice);
            sellingPrice.Anchor = AnchorStyles.Left;

            CheckBox isSelectedItem = new CheckBox();
            isSelectedItem.CheckAlign = ContentAlignment.MiddleCenter;
            isSelectedItem.Anchor = AnchorStyles.Left;
            isSelectedItem.CheckedChanged += new System.EventHandler(InputChange);

            NumberTextBox quantity = new NumberTextBox();
            quantity.Width = 40;
            quantity.Anchor = AnchorStyles.Left;
            quantity.TextChanged += new System.EventHandler(InputChange);

            Label unit = new Label();
            unit.Text = "pc";
            unit.Anchor = AnchorStyles.Left;

            tableLayoutPanel.Controls.Add(pictureBox, 0, row);
            tableLayoutPanel.Controls.Add(teamName, 1, row);
            tableLayoutPanel.Controls.Add(playerName, 2, row);
            tableLayoutPanel.Controls.Add(jerseyNumber, 3, row);
            tableLayoutPanel.Controls.Add(size, 4, row);
            tableLayoutPanel.Controls.Add(sellingPrice, 5, row);
            tableLayoutPanel.Controls.Add(isSelectedItem, 6, row);
            tableLayoutPanel.Controls.Add(quantity, 7, row);
            tableLayoutPanel.Controls.Add(unit, 8, row);

            controlList.Add(new OrderControl(jersey, pictureBox, teamName, playerName, jerseyNumber, size, sellingPrice, isSelectedItem, quantity, unit));
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            CreateDynamicFormContent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (!CheckOrder())
            {
                if (MessageBox.Show("Are you sure to order? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    string resultMessage;
                    int itemNumber = ConfirmOrders();
                    if (itemNumber == 0)
                    {
                        resultMessage = "Order not registered, none of the item was selected!";
                    } else
                    {
                        resultMessage = String.Format("Order registered with {0} kind of item", itemNumber); 
                    }
                    MessageBox.Show(resultMessage, "Iformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
        }

        private bool CheckOrder()
        {
            bool hasError = false;
            StringBuilder sb = new StringBuilder();
            foreach (OrderControl c in controlList)
            {
                if (c.HasError && c.IsItemSelected)
                {
                    sb.Append(String.Format("Error in line {0}, TextBox contains invalid data: {1}", controlList.IndexOf(c)+1, c.TextBoxText));
                    sb.Append(Environment.NewLine);
                    hasError = true;
                } 
            }

            if (hasError)
            {
                MessageBox.Show(sb.ToString(), "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hasError;

        }

        private int ConfirmOrders()
        {

        Order<ItemOrdered<IItemOrderable>> orderList = new Order<ItemOrdered<IItemOrderable>>();
        ItemOrdered<IItemOrderable> tempItem;

            if (!CheckOrder())
            {
                foreach (OrderControl c in controlList)
                {
                    if(c.IsItemSelected)
                    {
                        tempItem = new ItemOrdered<IItemOrderable>(c.Jersey, c.OrderedQuantity);
                        orderList.Add(tempItem);
                    }
                }

                if (orderList.Count>0)
                {
                    listOfAllOrders.Add(orderList);
                }
                
            }
            return orderList.Count;
        }

        public void InputChange(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (OrderControl c in controlList)
            {
                if (!c.HasError && c.IsItemSelected)
                {
                    sum += c.OrderedQuantity * c.Jersey.SellingPrice;
                }
            }
            labelSumOfOrders.Text = string.Format(formatProvider, "{0:C2}", sum);
        }

        public void ClearForm()
        {
            foreach (OrderControl c in controlList)
            {
                c.Reset();
            }
            labelSumOfOrders.Text = string.Format(formatProvider, "{0:C2}", 0);
        }

        public void ItemMouseHoverEffect(object sender, EventArgs e)
        {
            PictureBox tempPictureBox = (PictureBox)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tempPictureBox, FindOrderControlByPictureBox(tempPictureBox).Jersey.ToString());
          
        }

        public OrderControl FindOrderControlByPictureBox(PictureBox image) 
        {
            foreach (OrderControl c in controlList)
            {
                if (c.Equals(new OrderControl(image)))
                {
                    return c;
                }
            }
            return null;
        }
    }
}
