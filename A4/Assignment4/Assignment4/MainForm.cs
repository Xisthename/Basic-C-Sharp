﻿using System;
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
    /// 2017-10-01
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private const int maxIngredients = 50;
        private const int maxRecipes = 200;
        private Recipe recipe = new Recipe(maxIngredients);
        private RecipeManger recipeManger = new RecipeManger(maxRecipes);
        private IngredientsForm ingredientsForm;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the program starts we set up the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGUI();
        }

        /// <summary>
        /// Sets up the combobox through the enum FoodCategory
        /// </summary>
        private void InitGUI()
        {
            string[] categorys = Enum.GetNames(typeof(FoodCategory));
            newRecpieCategoryComboBox.Items.AddRange(categorys);
            newRecpieCategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Creats a new object of recipe and passes it on to the ingredientsForm through it's constructor
        /// Then we show that form and after a while when the user is done we set our recipe to the recipe from the other class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIngredientsButton_Click(object sender, EventArgs e)
        {
            ingredientsForm = new IngredientsForm(recipe);
            ingredientsForm.ShowDialog();
            recipe = new Recipe(maxIngredients);
            recipe.Ingredients = ingredientsForm.GetRecipe().Ingredients;
        }

        /// <summary>
        /// Tries to add the recipe object to an array in the RecipeManger class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (ReadRecipeInputs())
            {
                if (recipeManger.AddRecipe(recipe))
                {
                    UpdateGUI();
                    recipe = new Recipe(maxIngredients);
                }
                else
                {
                    MessageBox.Show("Too many recipes is already created!");
                }
            }
        }

        /// <summary>
        /// Tries to edit the selected recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (ReadRecipeInputs())
            {
                if (recipeListView.FocusedItem != null)
                {
                    if (recipeManger.ChangeRecipe(recipeListView.FocusedItem.Index, recipe))
                    {
                        UpdateGUI();
                    }
                    else
                    {
                        MessageBox.Show("The selected recipe was not changed!");
                    }
                }
            }
        }

        /// <summary>
        /// Tries to remove the selected recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (recipeListView.FocusedItem != null)
            {
                if (recipeManger.RemoveRecipeAt(recipeListView.FocusedItem.Index))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("The selected recipe was not removed!");
                }
            }
        }

        /// <summary>
        /// Tries to read all inputs needed to making a recipe
        /// If the values are ok we return true otherwise false with an error message to the user
        /// </summary>
        /// <returns></returns>
        private bool ReadRecipeInputs()
        {
            if (recipe != null && recipe.CountIngredients() > 0)
            {
                if (ReadName())
                {
                    if (ReadDescription())
                    {
                        ReadCategory();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("A recipe must contain a description!");
                    }
                }
                else
                {
                    MessageBox.Show("A recipe must have a name!");
                }
            }
            else
            {
                MessageBox.Show("A recipe must contain ingredients!");
            }
            return false;
        }

        /// <summary>
        /// Checks if the name is not blank
        /// If it's not empty we add the name to the recipe object and return true
        /// Otherwise we just return false
        /// </summary>
        /// <returns></returns>
        private bool ReadName()
        {
            if (!String.IsNullOrEmpty(newRecipeNameTextBox.Text))
            {
                recipe.Name = newRecipeNameTextBox.Text;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sets the category of the recipe to the selected category from the combobox
        /// </summary>
        private void ReadCategory()
        {
            recipe.Category = (FoodCategory) newRecpieCategoryComboBox.SelectedIndex;
        }

        /// <summary>
        /// Checks if the description is not blank
        /// If it's not empty we add the description to the recipe object and return true
        /// Otherwise we just return false
        /// </summary>
        private bool ReadDescription()
        {
            if (!String.IsNullOrEmpty(newRecipeDescriptionTextBox.Text))
            {
                recipe.Description = newRecipeDescriptionTextBox.Text;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates the table
        /// </summary>
        private void UpdateGUI()
        {
            recipeListView.Items.Clear();

            for (int i = 0; i < recipeManger.CountRecipes(); i++)
            {
                Recipe tempRecipe = recipeManger.GetRecipeAt(i);
                ListViewItem row = new ListViewItem(tempRecipe.Name);
                row.SubItems.Add(tempRecipe.CountIngredients().ToString());
                row.SubItems.Add(tempRecipe.Category.ToString());
                row.SubItems.Add(tempRecipe.Description);
                recipeListView.Items.Add(row);
            }
        }

        /// <summary>
        /// When the selection of an item changes
        /// First checking if we even have a selected item anymore
        /// If we have a new selected item we locate the selected recipe and takes out the information
        /// We also set our recipe.Ingredients to get the Ingredients of the that selected index from recipeManger
        /// Which dosen't point on the same object but to a string array so we dont overwrite that object later on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (recipeListView.FocusedItem != null && recipeListView.SelectedItems.Count > 0)
            {
                recipe = new Recipe(maxIngredients);
                int selectedIndex = recipeListView.FocusedItem.Index;
                Recipe selectedRecipe = recipeManger.GetRecipeAt(selectedIndex);
                newRecipeNameTextBox.Text = selectedRecipe.Name;
                newRecpieCategoryComboBox.SelectedIndex = (int)selectedRecipe.Category;
                newRecipeDescriptionTextBox.Text = selectedRecipe.Description;
                recipe.Ingredients = recipeManger.GetIngredients(selectedIndex);
            }
        }
    }
}
