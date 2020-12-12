using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfl
{
    public class NumberTextBox : TextBox
    {
        public bool HasError { get; set; }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                NumberCheck();
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Text = base.Text;
            base.OnTextChanged(e);
        }
        private void NumberCheck()
        {
            Regex rg = new Regex("^\\d+$");
            Match match = rg.Match(this.Text);

            if (!match.Success && !this.Text.Equals(String.Empty))
            {
                this.BackColor = Color.Salmon;
                HasError = true;
            }
            else
            {
                this.BackColor = Color.White;
                HasError = false;
            }
        }
    }
    
}
