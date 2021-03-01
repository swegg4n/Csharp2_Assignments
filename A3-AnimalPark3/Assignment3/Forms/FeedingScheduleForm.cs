using System;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Form for adding a new feeding schedule
    /// </summary>
    public partial class FeedingScheduleForm : Form
    {
        public FeedingSchedule FeedingSchedule { get; private set; } = new FeedingSchedule();

        /// <summary>
        /// Constructor
        /// Disables all list-options
        /// </summary>
        public FeedingScheduleForm()
        {
            InitializeComponent();

            AddSchedule_add_input.Enabled = false;
            AddSchedule_change_input.Enabled = false;
            AddSchedule_delete_input.Enabled = false;
        }

        /// <summary>
        /// Text-cahanged event
        /// Updates the diet name field
        /// </summary>
        private void AddSchedule_diet_input_TextChanged(object sender, EventArgs e)
        {
            FeedingSchedule.Diet = AddSchedule_diet_input.Text;
        }

        /// <summary>
        /// Text-cahanged event
        /// Updates the description-item name field
        /// </summary>
        private void AddSchedule_description_input_TextChanged(object sender, EventArgs e)
        {
            AddSchedule_add_input.Enabled = AddSchedule_description_input.Text != "";
            AddSchedule_description_collection_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Selected index changed event
        /// Updates the list-options
        /// </summary>
        private void AddSchedule_description_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddSchedule_description_collection.SelectedIndices != null && AddSchedule_description_collection.SelectedIndices.Count > 0)
            {
                bool selected = AddSchedule_description_collection.SelectedIndices[0] != -1;
                AddSchedule_change_input.Enabled = selected && AddSchedule_description_input.Text != "";
                AddSchedule_delete_input.Enabled = selected;
            }
        }


        /// <summary>
        /// Add description button
        /// Adds the inputted description to the descriptions list
        /// </summary>
        private void AddSchedule_add_input_Click(object sender, EventArgs e)
        {
            FeedingSchedule.FoodDescriptions.Add(AddSchedule_description_input.Text);
            AddSchedule_description_collection.Items.Add(AddSchedule_description_input.Text);
            AddSchedule_description_input.Text = "";
        }
        /// <summary>
        /// Change description button
        /// Changes the selected description to the inputted description
        /// </summary>
        private void AddSchedule_change_input_Click(object sender, EventArgs e)
        {
            FeedingSchedule.FoodDescriptions.ChangeAt(AddSchedule_description_input.Text, AddSchedule_description_collection.SelectedIndices[0]);
            AddSchedule_description_collection.SelectedItems[0].Text = AddSchedule_description_input.Text;
            AddSchedule_description_input.Text = "";
        }
        /// <summary>
        /// Delete description button
        /// Removes the selected description from the descriptions list
        /// </summary>
        private void AddSchedule_delete_input_Click(object sender, EventArgs e)
        {
            FeedingSchedule.FoodDescriptions.RemoveAt(AddSchedule_description_collection.SelectedIndices[0]);
            AddSchedule_description_collection.Items.RemoveAt(AddSchedule_description_collection.SelectedIndices[0]);
            AddSchedule_delete_input.Enabled = false;
        }

        /// <summary>
        /// OK button for the form
        /// Validates the inputs and closes the form
        /// </summary>
        private void AddSchedule_ok_Click(object sender, EventArgs e)
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
        private void AddSchedule_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Validates so all inputs are correctly filled in
        /// </summary>
        private bool AssertAll()
        {
            if (FeedingSchedule.Diet == null || FeedingSchedule.Diet == "")
            {
                MessageBox.Show("Diet name can not be empty!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (FeedingSchedule.FoodDescriptions.Count <= 0)
            {
                MessageBox.Show("Description list can not be empty", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }

}
