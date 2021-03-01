using System;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Form for adding a new food item
    /// </summary>
    public partial class FoodForm : Form
    {
        public FoodItem FoodItem { get; private set; } = new FoodItem();

        /// <summary>
        /// Constructor
        /// Disables all list-options
        /// </summary>
        public FoodForm()
        {
            InitializeComponent();

            AddFood_add_input.Enabled = false;
            AddFood_change_input.Enabled = false;
            AddFood_delete_input.Enabled = false;
        }

        /// <summary>
        /// Text-cahanged event
        /// Updates the name field
        /// </summary>
        private void AddFood_name_input_TextChanged(object sender, EventArgs e)
        {
            FoodItem.Name = AddFood_name_input.Text;
        }

        /// <summary>
        /// Text-cahanged event
        /// Updates the ingredient-item name field
        /// </summary>
        private void AddFood_ingredient_input_TextChanged(object sender, EventArgs e)
        {
            AddFood_add_input.Enabled = AddFood_ingredient_input.Text != "";
            AddFood_ingredients_collection_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Selected index changed event
        /// Updates the list-options
        /// </summary>
        private void AddFood_ingredients_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddFood_ingredients_collection.SelectedIndices != null && AddFood_ingredients_collection.SelectedIndices.Count > 0)
            {
                bool selected = AddFood_ingredients_collection.SelectedIndices[0] != -1;
                AddFood_change_input.Enabled = selected && AddFood_ingredient_input.Text != "";
                AddFood_delete_input.Enabled = selected;
            }
        }


        /// <summary>
        /// Add ingredient button
        /// Adds the inputted ingredient to the ingredients list
        /// </summary>
        private void AddFood_add_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.Add(AddFood_ingredient_input.Text);
            AddFood_ingredients_collection.Items.Add(AddFood_ingredient_input.Text);
            AddFood_ingredient_input.Text = "";
        }
        /// <summary>
        /// Change ingredient button
        /// Changes the selected ingredient to the inputted ingredient
        /// </summary>
        private void AddFood_change_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.ChangeAt(AddFood_ingredient_input.Text, AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_ingredients_collection.SelectedItems[0].Text = AddFood_ingredient_input.Text;
            AddFood_ingredient_input.Text = "";
        }
        /// <summary>
        /// Delete ingredient button
        /// Removes the selected ingredient from the ingredients list
        /// </summary>
        private void AddFood_delete_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.RemoveAt(AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_ingredients_collection.Items.RemoveAt(AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_delete_input.Enabled = false;
        }

        /// <summary>
        /// OK button for the form
        /// Validates the inputs and closes the form
        /// </summary>
        private void AddFood_ok_Click(object sender, EventArgs e)
        {
            if (AssertAll())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /// <summary>
        /// Cancel button from the form
        /// Closes the form without notifying the main form
        /// </summary>
        private void AddFood_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Validates so all inputs are correctly filled in
        /// </summary>
        private bool AssertAll()
        {
            if (FoodItem.Name == null || FoodItem.Name == "")
            {
                MessageBox.Show("Name can not be empty!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (FoodItem.Ingredients.Count <= 0)
            {
                MessageBox.Show("Ingredients list can not be empty", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
