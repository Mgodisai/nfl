using Retox.Model;
using Retox.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace Retox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            string filePath = null;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files | *.txt";
                dialog.InitialDirectory = Directory.GetCurrentDirectory();
                dialog.FileName = "";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
            }
            DrinkSheetReader reader = new DrinkSheetReader();
            try
            {
                reader.GetDrinkList(filePath, ';');
            }
            catch (IOException)
            {
                MessageBox.Show("Nem található filyen fájl!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba!");
            }

            DrinkSheetForm dsf = new DrinkSheetForm();
            dsf.Show();
            foreach (Control c in dsf.Controls)
            {
                if (c is Panel)
                {
                    DrinkControl dc = new DrinkControl(c as Panel, reader.DrinkList);
                }
            }
            dsf.Show();

        }
    }
}
