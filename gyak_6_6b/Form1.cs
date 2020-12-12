using System;
using System.Windows.Forms;

namespace gyak_6_6b
{

    public partial class frmSplitText : Form
    {
        const char DELIMITER = ' ';
        const int SCROLLBAR_LINE_NUMBER = 10;
        public frmSplitText()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outSplittedText(string input)
        {
            tbxOutput.ScrollBars = ScrollBars.None;
            string[] splittedString = input.Split(DELIMITER);
            tbxOutput.ResetText();
            rtbOutput.ResetText();
            foreach (string str in splittedString)
            {
                tbxOutput.Text += str + Environment.NewLine;
                rtbOutput.Text += str + Environment.NewLine;
            }
            if (splittedString.Length > SCROLLBAR_LINE_NUMBER)
            {
                tbxOutput.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            outSplittedText(tbxInput.Text);
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                outSplittedText(tbxInput.Text);
            }

        }
    }
}
