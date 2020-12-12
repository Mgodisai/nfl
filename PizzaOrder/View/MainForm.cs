using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class FormStarter : Form
    {
        public FormStarter()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            ButtonImportData.Visible = true;
        }


        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonImportData_Click(object sender, EventArgs e)
        {
            string[] pizzaData = GetPizzaDataFromFile();
            if (pizzaData is null)
            {
                MessageBox.Show("Nem találtunk pizzaadatot!");
            }
            else
            {
                MessageBox.Show("Adatok beolvasva!");

                ShowAllControls();
                PopulatePizzaPanel(pizzaData);

            }

        }

        private void ShowAllControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = true;
            }
            ButtonImportData.Visible = false;
            this.BackgroundImage = null;
        }

        private void PopulatePizzaPanel(string[] pizzaData)
        {

            for (int i = 0; i < pizzaData.Length; i++)
            {
                int height = 30;
                int tempX = 10;
                int tempY = 10 + height * i;

                string[] innerData = pizzaData[i].Split(';');

                Panel tempPanel = new Panel()
                {
                    Name = "PanelPizza" + i,
                    Location = new Point(tempX, tempY)
                };
                tempPanel.Height = height;
                tempPanel.Width = PanelMain.Width;



                CheckBox tempCheckBox = new CheckBox()
                {
                    Name = "CheckBoxPizza" + i,
                    Text = innerData[0],
                    Location = new Point(0, 0)
                };

                RadioButton rb1 = new RadioButton();
                RadioButton rb2 = new RadioButton();
                rb1.Text = innerData[1];
                rb2.Text = innerData[2];
                rb1.Checked = true;

                rb1.Location = new Point(150, 0);
                rb2.Location = new Point(300, 0);

                TextBox tb1 = new TextBox();
                tb1.Width = 25;
                tb1.Location = new Point(450, 0);

                tempPanel.Controls.Add(tempCheckBox);
                tempPanel.Controls.Add(rb1);
                tempPanel.Controls.Add(rb2);
                tempPanel.Controls.Add(tb1);


                PanelMain.Controls.Add(tempPanel);
            }
        }

        private string[] GetPizzaDataFromFile()
        {
            string[] pizzaData = null;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Directory.GetCurrentDirectory();
                dialog.FileName = "";
                dialog.Filter = "txt files|*.txt";
                dialog.Title = "Pizza adatok beolvasása";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        pizzaData = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    }
                }
            }
            return pizzaData;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in PanelMain.Controls)
            {
                foreach (Control d in c.Controls)
                {
                    if (d is CheckBox) ((CheckBox)d).Checked = false;
                    if (d is TextBox) d.ResetText();
                    if (d is RadioButton) ((RadioButton)d).Checked = false;
                }

            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int part = 0;
            int tempNumber;
            foreach (Control c in PanelMain.Controls)
            {
                part = 1;
                foreach (Control d in c.Controls)
                {

                    if (d is CheckBox) part *= ((CheckBox)d).Checked ? 1 : 0;
                    if (d is TextBox) part *= int.TryParse(d.Text, out tempNumber) ? int.Parse(d.Text) : 0;
                    if (d is RadioButton) part *= ((RadioButton)d).Checked ? int.Parse(d.Text) : 1;
                }
                sum += part;

            }
            TextBoxSum.Text = sum.ToString();
        }
    }
}
