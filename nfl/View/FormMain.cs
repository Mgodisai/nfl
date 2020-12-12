using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace nfl
{
    public partial class FormMain : Form
    {
        private ItemStorage<Jersey> storage;
        private List<Order<ItemOrdered<IItemOrderable>>> listOfAllOrders;

        public FormMain()
        {
            storage = new ItemStorage<Jersey>();
            listOfAllOrders = new List<Order<ItemOrdered<IItemOrderable>>>();

            InitializeComponent();
            orderToolStripMenuItem.Enabled = false;
            accountToolStripMenuItem.Enabled = false;
        }

        private void PopulateStorageFromFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files (*.txt) | *.txt";
            fd.InitialDirectory = Directory.GetCurrentDirectory();
            fd.Title = "Read item data from file";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    storage.LoadFromFile(fd.FileName, ';', new JerseyParser());
                }
                catch (Exception ex)
                {
                    string message = String.Format("Hiba történt a fájl olvasása közben! {0}{1}", Environment.NewLine, ex.Message);
                    string caption = "Figyelem";
                    MessageBox.Show(
                        text: message, 
                        caption: caption, 
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                }
            }
           
        }

        private void EnableUI()
        {
            bool isStorageEmpty = (storage.Count == 0);

            if (!isStorageEmpty)
            {
                FormOrders jerseyOrderForm = new FormOrders(storage, listOfAllOrders);
                jerseyOrderForm.ShowDialog();
            }
        }

        #region Menu event handlers
        private void névjegyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string message = "2020.12.11" + Environment.NewLine + "ue6li3";
            string caption = "Névjegy";

            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Biztos ki akar lépni?";
            string caption = "Figyelem";
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PopulateStorageFromFile();

            bool isStorageEmpty = (storage.Count == 0);

            if (!isStorageEmpty)
            {
                orderToolStripMenuItem.Enabled = true;
                accountToolStripMenuItem.Enabled = true;
            }
        }

        private void rendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableUI();
        }

        

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSummary formSummary = new FormSummary(listOfAllOrders);
            formSummary.ShowDialog();
        }

        #endregion
    }
}
