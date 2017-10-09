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
    class RecipeManger
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private Recipe[] recipeList;

        /// <summary>
        /// Constructor that takes in how many recipes this class will be able to hold
        /// </summary>
        /// <param name="maxRecipes"></param>
        public RecipeManger(int maxRecipes)
        {
            recipeList = new Recipe[maxRecipes];
        }

        /// <summary>
        /// Tries to add a recipe to the recipeList
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public bool AddRecipe(Recipe recipe)
        {
            if (CountRecipes() < recipeList.Length)
            {
                int foundIndex = FindEmptyIndex();

                if (foundIndex != -1)
                {
                    recipeList[foundIndex] = recipe;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Tries to modify a recipe at the parameter index value
        /// </summary>
        /// <param name="index"></param>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public bool ChangeRecipe(int index, Recipe recipe)
        {
            if (CheckIndex(index) &&  recipe.CountIngredients() > 0)
            {
                recipeList[index] = recipe;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to remove a recipe from a specific index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool RemoveRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                for (int i = index + 1; i < recipeList.Length; i++)
                {
                    recipeList[i - 1] = recipeList[i];
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
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    return i;
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
            if (index >= 0 && index <= recipeList.Length)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Looking for occupied indexs and counting them through the whole array and returning that number
        /// </summary>
        /// <returns></returns>
        public int CountRecipes()
        {
            int count = 0;

            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// returns a recipe from the recipeList with a specific index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
            {
                return recipeList[index];
            }
            return null;
        }

        /// <summary>
        /// Creates a temp object of the recipe at the index from the parameter
        /// Creates a new String array to store tempRecipe's ingredients
        /// Then we just loop through the occupied index and sets the index in the string array to recipes ingredients index
        /// Lastly we return the new array object
        /// 
        /// All this is done to prevent an overwrite of the recipe's ingredients
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public String[] GetIngredients(int index)
        {
            Recipe tempRecipe = GetRecipeAt(index);
            String[] tempArray = new String[tempRecipe.GetMaxIngredients()];

            for (int i = 0; i < tempRecipe.CountIngredients(); i++)
            {
                tempArray[i] = tempRecipe.Ingredients[i];
            }
            return tempArray;
        }
    }
}