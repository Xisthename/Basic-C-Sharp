using System;
using System.Collections.Generic;
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
    class ItemManger
    {
        /// <summary>
        /// Delecering necessary instance variable
        /// </summary>
        private List<Item> itemList = new List<Item>();

        /// <summary>
        /// Takes in an item that gets added to the itemList
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        /// <summary>
        /// Takes in an index and returns the item at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Item GetItem(int index)
        {
            Item otherItem = new Item(itemList[index]);
            return otherItem;
        }

        /// <summary>
        /// Returns how many items the itemList have
        /// </summary>
        /// <returns></returns>
        public int CountItems()
        {
            return itemList.Count;
        }

        /// <summary>
        /// Takes in an index and an item
        /// Tries to modify the item's value (found in itemList at that index) to changedItem's values 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="changedItem"></param>
        /// <returns></returns>
        public bool ChangeItem(int index, Item changedItem)
        {
            if (CheckIndex(index))
            {
                itemList[index] = changedItem;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Takes in an index and tries to remove the item at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool RemoveItem(int index)
        {
            if (CheckIndex(index))
            {
                itemList.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Takes in an index and checks if an item exist in itemList at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index <= CountItems())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Creates an array of items with their values and returns the array
        /// </summary>
        /// <returns></returns>
        public ListViewItem[] GetListViewItems()
        {
            ListViewItem[] tempListViewItem = new ListViewItem[CountItems()];

            for (int i = 0; i < CountItems(); i++)
            {
                tempListViewItem[i] = new ListViewItem(GetItem(i).Description);
                tempListViewItem[i].SubItems.Add(GetItem(i).Amount.ToString());
                tempListViewItem[i].SubItems.Add(GetItem(i).UnitType.ToString());
            }
            return tempListViewItem;
        }
    }
}
