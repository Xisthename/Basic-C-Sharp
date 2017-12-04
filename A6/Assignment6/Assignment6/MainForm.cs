using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private TaskManager taskManager = new TaskManager();
        private Task tempTask;
        private Stopwatch watch = new Stopwatch();
        private TimeSpan ts;
        private bool altF4Pressed = false;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the program starts we call upon "InitGUI"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            watch.Start();
            InitGUI();
            toolTip.SetToolTip(dateTimePicker, "Click to open calender for date, write in time here");
        }

        /// <summary>
        /// Starts the watch
        /// Sets the current date
        /// Sets up the combobox through the enum PriorityTypes
        /// </summary>
        private void InitGUI()
        {
            toDoTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            string[] priorityTypes = Enum.GetNames(typeof(PriorityTypes));

            for (int i = 0; i < priorityTypes.Length; i++)
            {
                priorityTypes[i] = priorityTypes[i].Replace("_", " ");
            }
            priorityComboBox.Items.AddRange(priorityTypes);
            priorityComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Every second we update the time spent in the program to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            ts = watch.Elapsed;
            string elapsedTime = String.Format("Time spent: {0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds);
            TimeInfo.Text = elapsedTime;
        }

        /// <summary>
        /// Tries to add a new task
        /// Updates the table if the task was added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            tempTask = new Task();

            if (ReadInputs())
            {
                taskManager.AddTask(tempTask);
                UpdateTable();
            }
        }

        /// <summary>
        /// Reads in all inputs needed to make a task
        /// </summary>
        /// <returns></returns>
        private bool ReadInputs()
        {
            if (ReadDescription())
            {
                tempTask.Date = dateTimePicker.Value.ToShortDateString().ToString();
                tempTask.Hour = dateTimePicker.Value.ToShortTimeString();
                tempTask.Sec = dateTimePicker.Value.Second.ToString();
                tempTask.SetPriorityType((PriorityTypes)priorityComboBox.SelectedIndex);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to read the description
        /// </summary>
        /// <returns></returns>
        private bool ReadDescription()
        {
            if (!String.IsNullOrEmpty(toDoTextBox.Text))
            {
                tempTask.Description = toDoTextBox.Text;
                return true;
            }
            else
            {
                MessageBox.Show("A task must have a description!");
            }
            return false;
        }

        /// <summary>
        /// Updates the table with all task's info
        /// </summary>
        private void UpdateTable()
        {
            taskListView.Items.Clear();
            taskListView.Items.AddRange(taskManager.GetListViewItems());
        }

        /// <summary>
        /// Clears all current data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Clears all data
        /// </summary>
        private void Reset()
        {
            priorityComboBox.Items.Clear();
            taskManager.RemoveAllTasks();
            InitGUI();
            UpdateTable();
        }

        /// <summary>
        /// Handles the key events (Ctrl + N) and (Alt + F4)
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                Reset();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.F4))
            {
                altF4Pressed = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Ask the user if they really want to exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        /// <summary>
        /// When the form is about to close we make sure that it's not from Alt + F4
        /// If it's we chancel the closing part and ask the user if they really want to exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altF4Pressed)
            {
                altF4Pressed = false;
                e.Cancel = true;
                ExitProgramOrNot();
            }
        }

        /// <summary>
        /// Asks the user if they really want to exit the program
        /// </summary>
        private void ExitProgramOrNot()
        {
            DialogResult result = MessageBox.Show("Sure to exit program?", "Think twice", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        /// <summary>
        /// Brings up a form that tells the user what the program is for and who made it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }
    }
}
