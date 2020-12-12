using System.Collections.Generic;
using System.Windows.Forms;

namespace nfl
{
    public class OrderControl
    {
        public Jersey Jersey { get; private set; }

        private PictureBox pictureBoxPicture;
        private Label labelTeamName;
        private Label labelPlayerName;
        private Label labelJerseyNumber;
        private Label labelSize;
        private Label labelSellingPrice;
        private CheckBox checkBoxIsItemSelected;
        private NumberTextBox textBoxOrderQuantity;
        private Label labelUnit;

        public bool HasError
        {
            get
            {
                return textBoxOrderQuantity.HasError;
            }
        }

        public bool IsItemSelected
        {
            get
            {
                return checkBoxIsItemSelected.Checked;
            }
        }

        public int OrderedQuantity
        {
            get
            {
                if (!this.textBoxOrderQuantity.HasError && this.IsItemSelected && !string.IsNullOrWhiteSpace(TextBoxText))
                {
                    return int.Parse(textBoxOrderQuantity.Text);
                }
                else return 0;
                
            }
        }

        public string TextBoxText
        {
            get
            {
                return textBoxOrderQuantity.Text;
            }
        }

        public OrderControl(Jersey jersey, PictureBox pictureBoxPicture, Label labelTeamName, Label labelPlayerName, Label labelJerseyNumber, Label labelSize, Label labelSellingPrice, CheckBox checkBoxIsItemSelected, NumberTextBox textBoxOrderQuantity, Label labelUnit)
        {
            Jersey = jersey;
            this.pictureBoxPicture = pictureBoxPicture;
            this.labelTeamName = labelTeamName;
            this.labelPlayerName = labelPlayerName;
            this.labelJerseyNumber = labelJerseyNumber;
            this.labelSize = labelSize;
            this.labelSellingPrice = labelSellingPrice;
            this.checkBoxIsItemSelected = checkBoxIsItemSelected;
            this.textBoxOrderQuantity = textBoxOrderQuantity;
            this.labelUnit = labelUnit;

        }

        public OrderControl(PictureBox pictureBoxPicture)
        {
            this.pictureBoxPicture = pictureBoxPicture;
        }
        public void Reset()
        {
            checkBoxIsItemSelected.Checked = false;
            textBoxOrderQuantity.Clear();
        }

        public override bool Equals(object obj)
        {
            return obj is OrderControl control &&
                   EqualityComparer<PictureBox>.Default.Equals(pictureBoxPicture, control.pictureBoxPicture);
        }
    }
}
