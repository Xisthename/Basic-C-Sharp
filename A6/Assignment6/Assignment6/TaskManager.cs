using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-11-27
    /// </summary>
    class TaskManager
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private List<Task> taskList = new List<Task>();

        /// <summary>
        /// Adds a new task to the taskList
        /// </summary>
        /// <param name="newTask"></param>
        public void AddTask(Task newTask)
        {
            taskList.Add(newTask);
        }

        /// <summary>
        /// Takes in an index and returns a copy object of the task at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Task GetTask(int index)
        {
            Task otherTask = new Task(taskList[index]);
            return otherTask;
        }

        /// <summary>
        /// Removes all tasks
        /// </summary>
        public void RemoveAllTasks()
        {
            taskList.Clear();
        }

        /// <summary>
        /// Creates an array of items with their values and returns the array
        /// </summary>
        /// <returns></returns>
        public ListViewItem[] GetListViewItems()
        {
            ListViewItem[] tempListViewItems = new ListViewItem[taskList.Count];

            for (int i = 0; i < taskList.Count; i++)
            {
                tempListViewItems[i] = new ListViewItem(GetTask(i).Date);
                tempListViewItems[i].SubItems.Add(GetTask(i).Hour);
                tempListViewItems[i].SubItems.Add(GetTask(i).GetPriorityType());
                tempListViewItems[i].SubItems.Add(GetTask(i).Description);
            }
            return tempListViewItems;
        }
    }
}
