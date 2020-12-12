using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kozepek
{
    public partial class Form1 : Form
    {
        private static bool isValidInputChar;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (var t in this.Controls)
            {
                if (t is TextBox)
                {
                    TextBox t2 = t as TextBox;
                    t2.Clear();
                    t2.BackColor = default(Color);


                }

            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(tbxX.Text);
            double y = Double.Parse(tbxY.Text);
            tbxSzamtani.Text = ((x + y) / 2).ToString("F5");
            tbxMertani.Text = x * y < 0 ? "Nem számolható" : (Math.Sqrt(x * y)).ToString("F5");
            tbxHarmonikus.Text = (x == 0 || y == 0 || (1 / x + 1 / y == 0)) ? "Nem számolható" : (1 / (1 / x + 1 / y)).ToString("F5");

        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            double x;

            TextBox input = sender as TextBox;

            if (!isValidInputChar && input.TextLength > 0)
            {
                if (!Double.TryParse(input.Text, out x))
                {
                    btnSzamol.Enabled = false;
                    input.BackColor = Color.Crimson;
                }
                else
                {
                    input.BackColor = Color.White;
                }
            }
            if (!IsAnyEmptyInput() && IsCalculateable())
            {
                btnSzamol.Enabled = true;
            }
        }

        private bool IsAnyEmptyInput()
        {
            return tbxX.TextLength == 0 || tbxY.TextLength == 0;
        }

        private bool IsCalculateable()
        {
            return (tbxX.BackColor == Color.White && tbxY.BackColor == Color.White);
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox input = sender as TextBox;

            // handle negative numbers
            if (e.KeyChar == '-' && input.TextLength == 0)
            {
                isValidInputChar = true;
            }
            else
            {
                isValidInputChar = false;
            }

            // space is not allowed here
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }


    }
}
