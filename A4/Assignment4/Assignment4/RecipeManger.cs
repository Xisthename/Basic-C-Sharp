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
    }
}
