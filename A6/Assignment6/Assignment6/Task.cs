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
    class Task
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private String date;
        private String hour;
        private String sec;
        private String description;
        private PriorityTypes priorityType;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Task()
        {
        }

        /// <summary>
        /// Used to create a new object of an existing task by calling constructor 3
        /// </summary>
        /// <param name="otherTask"></param>
        public Task(Task otherTask) : this(otherTask.date, otherTask.hour, otherTask.sec, otherTask.description, otherTask.priorityType)
        {
        }

        /// <summary>
        /// Constructor 3
        /// </summary>
        public Task(String year, String hour, String sec, String description, PriorityTypes priorityType)
        {
            this.date = year;
            this.hour = hour;
            this.sec = sec;
            this.description = description;
            this.priorityType = priorityType;
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String Hour
        {
            set
            {
                hour = value;
            }
            get
            {
                return hour;
            }
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String Sec
        {
            set
            {
                sec = value;
            }
            get
            {
                return sec;
            }
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }

        /// <summary>
        /// Simple set method
        /// </summary>
        public void SetPriorityType(PriorityTypes priorityType)
        {
            this.priorityType = priorityType;
        }

        /// <summary>
        /// Simple get method
        /// </summary>
        public String GetPriorityType()
        {
            return priorityType.ToString().Replace("_", " ");
        }
    }
}
