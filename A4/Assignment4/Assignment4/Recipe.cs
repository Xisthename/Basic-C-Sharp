using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-10-02
    /// </summary>

    /// <summary>
    /// Used to set what category a recipe is
    /// </summary>
    public enum FoodCategory
    {
        Meat,
        Vegeterian,
        Fish,
        Seafood
    }

    public class Recipe
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private String name;
        private String[] ingredients;
        private String description;
        private FoodCategory category;

        /// <summary>
        /// Constructor that takes in how many ingredients this class will be able to hold 
        /// </summary>
        /// <param name="maxIngredients"></param>
        public Recipe(int maxIngredients)
        {
            ingredients = new string[maxIngredients];
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Simple setter and getter method
        /// </summary>
        public String[] Ingredients
        {
            set
            {
                ingredients = value;
            }
            get
            {
                return ingredients;
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
        /// Simple setter and getter method
        /// </summary>
        public FoodCategory Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }

        /// <summary>
        /// Tries to find an empty index and adds the ingredient to that index
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddIngredient(String text)
        {
            int foundIndex = FindEmptyIndex();

            if (foundIndex != -1)
            {
                if (CheckIndex(foundIndex))
                {
                    ingredients[foundIndex] = text;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Tries to modify an ingredient at the index value and with the newText value
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newText"></param>
        /// <returns></returns>
        public bool ChangeIngredient(int index, String newText)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = newText;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to remove an ingredient with the index from the parameter
        /// We rezise the array so the ingredients array will always be synced with the listbox array
        /// By swapping the index down in the array we automatically 'remove' the index becuase it gets a new value
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool RemoveIngredient(int index)
        {
            if (CheckIndex(index))
            {
                for (int i = index + 1; i < ingredients.Length; i++)
                {
                    ingredients[i - 1] = ingredients[i];
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to find an index that's null or empty
        /// Returns the first found index and if no index was found -1 will be returned
        /// </summary>
        /// <returns></returns>
        public int FindEmptyIndex()
        {
            if (ingredients != null)
            { 
                for (int i = 0; i < ingredients.Length; i++)
                {
                    if (String.IsNullOrEmpty(ingredients[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Checks the given index is inside of the max range and returns true or false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index <= GetMaxIngredients())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Looking for occupied indexs and counting them through the whole array and returning that counted number
        /// </summary>
        /// <returns></returns>
        public int CountIngredients()
        {
            int count = 0;

            if (ingredients != null)
            {
                for (int i = 0; i < ingredients.Length; i++)
                {
                    if (!String.IsNullOrEmpty(ingredients[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Returns how many index the array ingredients can hold
        /// </summary>
        /// <returns></returns>
        public int GetMaxIngredients()
        {
            return ingredients.Length;
        }
    }
}
