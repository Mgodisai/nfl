using System;
using System.Windows.Forms;

namespace gyak_6_3
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = "Keresztnév";
            lblLastName.Text = "Vezetéknév";
            lblInput.Text = "Kérem a nevet:";
            lblLength.Text = "A név hossza:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Üdvözlet, " + firstUpperCaseString(tbxFirstName.Text) + "!";
        }

        private void txbInput_Leave(object sender, EventArgs e)
        {
            nameSlicer();
        }

        private void nameSlicer()
        {
            string[] splittedNameArray = tbxInput.Text.Split(' ');
            if (splittedNameArray.Length > 1)
            {
                tbxFirstName.Text = splittedNameArray[splittedNameArray.Length - 1].ToLower();
                tbxLastName.Text = splittedNameArray[splittedNameArray.Length - 2].ToUpper();
                tbxLength.Text = tbxInput.Text.Length.ToString();
            }
            else
            {
                tbxLastName.Text = tbxInput.Text;
            }

        }

        private string firstUpperCaseString(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);

        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameSlicer();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text.Split(' ').Length < 3)
            {
                tbxInput.Text = "Dr. " + tbxInput.Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.ResetText();
                }

            }
        }
    }
}
