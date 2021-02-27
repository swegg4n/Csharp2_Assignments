using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class FoodForm : Form
    {
        public FoodItem FoodItem { get; private set; } = new FoodItem();


        public FoodForm()
        {
            InitializeComponent();

            AddFood_add_input.Enabled = false;
            AddFood_change_input.Enabled = false;
            AddFood_delete_input.Enabled = false;
        }

        private void AddFood_name_input_TextChanged(object sender, EventArgs e)
        {
            FoodItem.Name = AddFood_name_input.Text;
        }
        private void AddFood_ingredient_input_TextChanged(object sender, EventArgs e)
        {
            AddFood_add_input.Enabled = AddFood_ingredient_input.Text != "";
            AddFood_ingredients_collection_SelectedIndexChanged(sender, e);
        }

        private void AddFood_ingredients_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddFood_ingredients_collection.SelectedIndices != null && AddFood_ingredients_collection.SelectedIndices.Count > 0)
            {
                bool selected = AddFood_ingredients_collection.SelectedIndices[0] != -1;
                AddFood_change_input.Enabled = selected && AddFood_ingredient_input.Text != "";
                AddFood_delete_input.Enabled = selected;
            }
        }



        private void AddFood_add_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.Add(AddFood_ingredient_input.Text);
            AddFood_ingredients_collection.Items.Add(AddFood_ingredient_input.Text);
            AddFood_ingredient_input.Text = "";
        }
        private void AddFood_change_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.ChangeAt(AddFood_ingredient_input.Text, AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_ingredients_collection.SelectedItems[0].Text = AddFood_ingredient_input.Text;
            AddFood_ingredient_input.Text = "";
        }
        private void AddFood_delete_input_Click(object sender, EventArgs e)
        {
            FoodItem.Ingredients.RemoveAt(AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_ingredients_collection.Items.RemoveAt(AddFood_ingredients_collection.SelectedIndices[0]);
            AddFood_delete_input.Enabled = false;
        }


        private void AddFood_ok_Click(object sender, EventArgs e)
        {
            if (AssertAll())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void AddFood_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



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
