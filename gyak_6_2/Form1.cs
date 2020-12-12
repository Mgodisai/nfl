using System;
using System.Drawing;
using System.Windows.Forms;

namespace gyak_6_2
{
    public partial class formGreetings : Form
    {
        public formGreetings()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            enterInput();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formGreetings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterInput();
            }
        }

        private void enterInput()
        {
            string missingDataMessage = "";
            if (firstName.Text == "")
            {
                missingDataMessage += "First Name is missing" + Environment.NewLine;
                firstName.BackColor = Color.Red;
            }
            else
            {
                firstName.BackColor = Color.White;
            }

            if (lastName.Text == "")
            {
                missingDataMessage += "Last Name is missing" + Environment.NewLine;
                lastName.BackColor = Color.Red;
            }
            else
            {
                lastName.BackColor = Color.White;
            }

            if (phoneNumber.Text.Length < 9)
            {
                missingDataMessage += "Phone Number is missing";
                phoneNumber.BackColor = Color.Red;
            }
            else
            {
                phoneNumber.BackColor = Color.White;
            }

            if (missingDataMessage.Length == 0)
            {
                infoBox.Text = "Üdvözlöm, " + firstName.Text + " " + lastName.Text + Environment.NewLine +
                    phoneNumber.Text;
                firstName.ResetText();
                firstName.BackColor = Color.White;
                lastName.BackColor = Color.White;
                phoneNumber.BackColor = Color.White;

                lastName.ResetText();
                phoneNumber.ResetText();
                lastName.Focus();
            }
            else
            {

                MessageBox.Show(missingDataMessage, "Hiányzó adatok");

            }
        }

        private void lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterInput();
            }
        }

        private void firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterInput();
            }
        }

        private void phoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterInput();
            }
        }
    }
}
