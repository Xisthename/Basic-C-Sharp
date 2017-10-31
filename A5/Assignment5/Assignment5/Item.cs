using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-10-28
    /// </summary>
    class Item
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private String description;
        private float amount;
        private UnitTypes type;

        /// <summary>
        /// Used to create a new object of an existing item by calling Constructor 3
        /// </summary>
        /// <param name="otherItem"></param>
        public Item(Item otherItem) : this(otherItem.Description, otherItem.Amount, otherItem.UnitType)
        {
        }

        /// <summary>
        /// Constructor 1 is empty
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Constructor 2 will call upon Constructor 3 when executed
        /// </summary>
        /// <param name="description"></param>
        public Item(String description) : this(description, 0, UnitTypes.ft)
        {
        }

        /// <summary>
        /// Constructor 3 takes in parameters and set the instance variables to their value
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="type"></param>
        public Item(String description, float amount, UnitTypes type)
        {
            this.description = description;
            this.amount = amount;
            this.type = type;
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
        /// Simple setter and getter method
        /// </summary>
        public float Amount
        {
            set
            {
                amount = value;
            }
            get
            {
                return amount;
            }
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public UnitTypes UnitType
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }
    }
}
