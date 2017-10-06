using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class IngredientsForm : Form
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private Recipe recipe;

        /// <summary>
        /// Constructor that takes in a recipe object to declare the instance variable recipe
        /// We also update the GUI which may seem strange but if a user has added ingredients before and 
        /// comes back we have to display them
        /// </summary>
        /// <param name="recipe"></param>
        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            UpdateGUI();
        }

        /// <summary>
        /// Tries to add a new ingredient and if added we update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            String ingredient = ingredientTextBox.Text;

            if (!String.IsNullOrEmpty(ingredient))
            {
                if (recipe.AddIngredient(ingredient))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Can't add anymore ingredients!");
                }
            }
            else
            {
                MessageBox.Show("An ingredient can't be added as blank!");
            }
        }

        /// <summary>
        /// Tries to change an ingredient and if changed we update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ingredientsListBox.SelectedIndex;
            String newText = ingredientTextBox.Text;

            if (!String.IsNullOrEmpty(newText))
            {
                if (recipe.ChangeIngredient(selectedIndex, newText))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Could not change the index " + selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("An ingredient can't be edit to blank!");
            }
        }

        /// <summary>
        /// Tries to delete an ingredient and if deleted we update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ingredientsListBox.SelectedIndex;

            if (recipe.RemoveIngredient(selectedIndex))
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Unkown error! Could not delete the index " + selectedIndex);
            }
        }

        /// <summary>
        /// When the user presses cancel we set all ingredients value to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < recipe.GetMaxIngredients(); i++)
            {
                recipe.Ingredients[i] = null;
            }
        }

        /// <summary>
        /// Updates how many ingredients that exist and clears the listbox and adds all the ingredients that exist into it
        /// </summary>
        private void UpdateGUI()
        {
            ingredientsLabel.Text = "Number of ingredients: " + recipe.countIngredients();
            ingredientsListBox.Items.Clear();

            for (int i = 0; i < recipe.GetMaxIngredients(); i++)
            {
                if (!String.IsNullOrEmpty(recipe.Ingredients[i]))
                {
                    ingredientsListBox.Items.Add(recipe.Ingredients[i]);
                }
            }
        }

        /// <summary>
        /// Returns the object recipe
        /// </summary>
        /// <returns></returns>
        public Recipe GetRecipe()
        {
            return recipe;
        }
    }
}
