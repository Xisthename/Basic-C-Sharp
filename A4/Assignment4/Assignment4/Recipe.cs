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
        /// Tries to find an empty index and add the ingredient to that index
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
        /// Tries to modify an ingredient given with the newText (what the user has written)
        /// And finds the index where it shall modify by help from the oldText (selectedText)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ChangeIngredient(String oldText, String newText)
        {
            int index = FindSelectedIndex(oldText);

            if (CheckIndex(index))
            {
                ingredients[index] = newText;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to remove a index with the text from the parameter
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool RemoveIndex(String text)
        {
            int index = FindSelectedIndex(text);

            if (CheckIndex(index))
            {
                ingredients[index] = null;
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
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (String.IsNullOrEmpty(ingredients[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Tries to find a position of an ingredient that has the same text as the parameter
        /// If we find a position we return that index otherwise we return -1 as a error message
        /// 
        /// We can't take the current index from the listbox because of the following concept
        /// This is the ingredient array and we added 5 ingredients at the following index
        /// 0, 1, 2, 3, 4
        /// 
        /// Now we remove index 2
        /// 0, 1, 3, 4
        /// 
        /// But the listbox has cleared it's array and added the new array which results that the listbox's array is
        /// 0, 1, 2, 3
        /// 
        /// As we can see the two arrays are not in sync anymore 0=0, 1=1 but 3!=2, 4!=3
        /// 
        /// We get this problem because of how i add index and update the listbox
        /// With my method we will always be able to fill the array with indexes because it looks
        /// after an empty index when we are adding a new ingredient instead of just adding at the index (last occupied index + 1)
        /// It would be much easier but if you add 50 ingredients and remove them all you wont have any space left in the array
        /// So this is preventing that which is a much worse problem than we are getting now
        /// Which is that if the user has added the same text and wants to remove or change the last index of those
        /// The first index will be removed instead of the actually selected index
        /// But who writes in the same ingredient twice or more?
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int FindSelectedIndex(String text)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (!String.IsNullOrEmpty(ingredients[i]))
                {
                    MessageBox.Show(ingredients[i].Equals(text) + ingredients[i] + text);
                    if (ingredients[i].Equals(text))
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
        /// This method seem to just be using the method FindEmptyIndex for counting all occupieded index
        /// But it cant because if we delete an index at 2 and we have occupied indexs higher than 2 they wont be counted
        /// Because the method will find an empty slot at index 2 and return 2
        /// 
        /// So this method is looking for occupied indexs and counting them through the whole array and returning that number
        /// </summary>
        /// <returns></returns>
        public int GetCurrentIngredients()
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
