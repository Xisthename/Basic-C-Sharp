using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-10-28
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private ItemManger itemManger = new ItemManger();
        private Item tempItem;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the program starts we set up the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGUI();
        }

        /// <summary>
        /// Sets up the combobox through the enum UnitTypes
        /// </summary>
        private void InitGUI()
        {
            string[] unitTypes = Enum.GetNames(typeof(UnitTypes));
            UnitTypesComboBox.Items.AddRange(unitTypes);
            UnitTypesComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Creates a new item that are ready to be filled in
        /// Calls on ReadItemInputs that tries to read all inputs
        /// If it returns true we pass the item to itemManger then we update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            tempItem = new Item();

            if (ReadItemInputs())
            {
                itemManger.AddItem(tempItem);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Tries to change the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            int index = GetSelectedItemIndex();

            if (index != -1)
            {
                tempItem = new Item();

                if (ReadItemInputs())
                {
                    if (itemManger.ChangeItem(index, tempItem))
                    {
                        UpdateGUI();
                    }
                }
            }
        }

        /// <summary>
        /// Tries to remove the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = GetSelectedItemIndex();

            if (index != -1)
            {
                if (itemManger.RemoveItem(index))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Could not remove the item at " + index);
                }
            }
        }

        /// <summary>
        /// Tries to find the selected index and returns it
        /// If it cant find an index it will return -1
        /// </summary>
        /// <returns></returns>
        private int GetSelectedItemIndex()
        {
            if (itemListView.FocusedItem != null)
            {
                return itemListView.FocusedItem.Index;
            }
            else
            {
                MessageBox.Show("Please select an item");
                return -1;
            }
        }


        /// <summary>
        /// Reads the input from the user to make an item
        /// If the description text is validated by ReadDescription
        /// we read in the amount and unitType too and return true
        /// 
        /// If the description text is not validated by ReadDescription
        /// we tell the user and return false
        /// </summary>
        /// <returns></returns>
        private bool ReadItemInputs()
        {
            if (ReadDescription())
            {
                ReadAmount();
                ReadUnitType();
                return true;
            }
            else
            {
                MessageBox.Show("An item must have a description!");
            }
            return false;
        }

        /// <summary>
        /// If the input text is not empty nor null
        /// We access the item object and set it's Description to the text
        /// Otherwise return false
        /// </summary>
        /// <returns></returns>
        private bool ReadDescription()
        {
            if (!String.IsNullOrEmpty(descriptionTextBox.Text))
            {
                tempItem.Description = descriptionTextBox.Text;
                return true;
            }
            return false;
        }

        /// <summary>
        /// We access the item object and set it's Amount to amountNumericUpDown's current value
        /// </summary>
        private void ReadAmount()
        {
            tempItem.Amount = (float) amountNumericUpDown.Value;
        }

        /// <summary>
        /// We access the item object and set it's UnitType to the UnitType that's selected in the combox
        /// </summary>
        private void ReadUnitType()
        {
            tempItem.UnitType = (UnitTypes)UnitTypesComboBox.SelectedIndex;
        }

        /// <summary>
        /// Updates the table with all item's info
        /// </summary>
        private void UpdateGUI()
        {
            itemListView.Items.Clear();
            itemListView.Items.AddRange(itemManger.GetListViewItems());
        }
    }
}
