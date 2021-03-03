using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Class for handeling all GUI and user I/O
    /// </summary>
    public partial class Form1 : Form
    {
        AnimalManager animalManager;
        AnimalFactory animalFactory;

        Image loadedImage = null;

        private Dictionary<Categorys, Species[]> speciesMapping;

        private Dictionary<Categorys, Control[]> categoryControlsMapping;
        private Dictionary<Species, Control[]> speciesControlsMapping;

        FoodForm foodForm;
        FoodManager foodManager;
        FeedingScheduleForm feedingScheduleForm;
        FeedingScheduleManager feedingScheduleManager;


        /// <summary>
        /// Constructor - Initializes the animalManager, animalFactory and the mappings. Also resets the displayed controls.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
            animalFactory = new AnimalFactory();
            foodManager = new FoodManager();
            feedingScheduleManager = new FeedingScheduleManager();

            AddCategoryItems();
            AddGenderItems();
            AddSortingMethods();

            speciesMapping = new Dictionary<Categorys, Species[]>   //Creates a mapping of how the species are related to the categorys, for use in dropdown lists
            {
                { Categorys.Insect, new Species[]{ Species.Ant, Species.Butterfly } },
                { Categorys.Mamal, new Species[]{ Species.Dog, Species.Monkey } },
            };

            categoryControlsMapping = new Dictionary<Categorys, Control[]>  //Maps controls to the Categorys
            {
                { Categorys.Insect, new Control[]{ Category_noLegs_label ,Category_noLegs_input, Categoty_canFly_label, Category_canFly_input } },
                { Categorys.Mamal, new Control[]{ Category_noteeth_label ,Category_noteeth_input, Category_furColor_label, Category_furColor_input } }
            };
            speciesControlsMapping = new Dictionary<Species, Control[]>     //Maps controls to the Species
            {
                { Species.Ant, new Control[] {  Species_isQueen_label, Species_isQueen_input } },
                { Species.Butterfly, new Control[] {  Species_wingColor_label, Species_wingColor_input } },
                { Species.Dog, new Control[] {  Species_breed_label, Species_breed_input } },
                { Species.Monkey, new Control[] {  Species_tailLength_label, Species_tailLength_input } },
            };

            ChangeCategoryView(null);     //Resets the category to not show be shown or selected
            ChangeSpeciesView(null);      //Resets the species to not show be shown or selected

            Animal_remove_input.Enabled = false;
        }


        /// <summary>
        /// Add animal button - Tries to create an animal and adds it to the list of animals.
        /// </summary>
        private void Animal_add_input_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (AssertAll(ref errorMsg))
            {
                //optional to choose image
                if (loadedImage != null || (loadedImage == null && MessageBox.Show($"No image chosen, continue anyways?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    Animal animal = animalFactory.CreateAnimal(this, loadedImage, animalManager, (Categorys)GetSelectedCategory(), (Species)GetSelectedSpecies());
                    animalManager.AddAnimal(animal);
                    FillAnimalsListView(Animals_list);
                    List_sort_input.SelectedIndex = -1;
                    MessageBox.Show("Animal successfully created!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(errorMsg, "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add random animal button - Creates a random animal and adds it to the list of animals
        /// </summary>
        private void Animal_addRandom_input_Click(object sender, EventArgs e)
        {
            Animal animal = animalFactory.CreateRandomAnimal(animalManager);
            animalManager.AddAnimal(animal);

            FillAnimalsListView(Animals_list);
            List_sort_input.SelectedIndex = -1;
        }

        private void Animal_change_input_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (AssertAll(ref errorMsg) && AssertAnimalSelected())
            {
                int selectedIndex = Animals_list.SelectedIndices[0];

                Animal animal = animalFactory.CreateAnimal(this, loadedImage, animalManager, (Categorys)GetSelectedCategory(), (Species)GetSelectedSpecies());
                animal.ID = animalManager.GetAt(selectedIndex).ID;
                animalManager.ChangeAt(animal, selectedIndex);

                FillAnimalsListView(Animals_list);
                List_sort_input.SelectedIndex = -1;
                MessageBox.Show("Animal successfully changed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMsg, "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove animal button
        /// Removes the selected animal from the animals-list
        /// </summary>
        private void Animal_remove_input_Click(object sender, EventArgs e)
        {
            Animal_remove_input.Enabled = false;
            animalManager.RemoveAt(Animals_list.SelectedIndices[0]);

            FillAnimalsListView(Animals_list);
            List_sort_input.SelectedIndex = -1;
        }


        /// <summary>
        /// Method responsible for checking if all user-inputs are correctly filled
        /// </summary>
        /// <param name="errorMsg">The message displayed in case of error</param>
        /// <returns>Returns if the tests passed or not</returns>
        private bool AssertAll(ref string errorMsg)
        {
            Categorys? selectedCategory = GetSelectedCategory();
            Species? selectedSpecies = GetSelectedSpecies();

            if (selectedCategory != null && selectedSpecies != null)
            {
                if (!AssertManager.AssertEmpty(Animal_name_input.Text, "Name", ref errorMsg))    //make sure the name is not empty
                    return false;
                if (!AssertManager.AssertParse(Animal_age_input.Text, "Age", ref errorMsg))    //make sure the age is not empty and a number
                    return false;
                if (!AssertManager.AssertDropdown(Animal_gender_input.SelectedIndex, "Gender", ref errorMsg))       //make sure the gender is selected
                    return false;

                switch (selectedCategory)
                {
                    case Categorys.Insect:
                        {
                            if (!AssertManager.AssertParse(Category_noLegs_input.Text, "No. legs", ref errorMsg))    //make sure the #legs is not empty and a number
                                return false;
                        }
                        break;

                    case Categorys.Mamal:
                        {
                            if (!AssertManager.AssertParse(Category_noteeth_input.Text, "No. teeth", ref errorMsg))       //make sure the #teeth is not empty and a number
                                return false;

                            switch (selectedSpecies)
                            {
                                case Species.Dog:
                                    {
                                        if (!AssertManager.AssertEmpty(Species_breed_input.Text, "Breed", ref errorMsg))     //make sure the breed is not empty
                                            return false;
                                    }
                                    break;

                                case Species.Monkey:
                                    {
                                        if (!AssertManager.AssertParse(Species_tailLength_input.Text, "Tail length", ref errorMsg))       //make sure the tail length is not empty and a number
                                            return false;

                                    }
                                    break;
                            }
                        }
                        break;
                }
                return true;
            }
            else
            {
                errorMsg = "No species and/or category selected!";
                return false;
            }

        }

        /// <summary>
        /// Checks if an animal is selected or not
        /// </summary>
        private bool AssertAnimalSelected()
        {
            if (Animals_list.SelectedIndices != null && Animals_list.SelectedIndices.Count > 0 && Animals_list.SelectedIndices[0] != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No animal selected", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Clears and fills <paramref name="listView"/> with the animals from the animal-list
        /// </summary>
        public void FillAnimalsListView(ListView listView)
        {
            listView.Items.Clear();
            int columns = listView.Columns.Count;

            for (int i = 0; i < animalManager.Count; i++)
            {
                List<string> animalData = animalManager.GetAt(i).ToString();

                for (int c = columns; c < animalData.Count; c++)
                    listView.Columns.Add("");   //Adds new columns if necessary

                listView.Items.Add(new ListViewItem(animalData.ToArray()));    //Adds a new entry to the list of created animals

                for (int c = 0; c < animalData.Count; c++)
                    listView.Columns[c].Width = -2;     //Auto-resizes the columns to fit the data
            }
        }


        /// <summary>
        /// Updates which controls are displayed when the selected category is changed. Also updates the species dropdown with the species included in the selected category.
        /// </summary>
        private void Category_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ListAllAnimals_input.Checked)
                AddSpeciesItems();

            ChangeCategoryView(GetSelectedCategory());     //Changes to view the correct category controls
        }

        /// <summary>
        /// Updates which controls are displayed when the selected species is changed.
        /// If "list all animals" is checked it also updates the selected category to the category the species is part of.
        /// </summary>
        private void Species_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListAllAnimals_input.Checked)
            {
                Categorys? category = GetCategoryFromSelectedSpecies();
                if (category != null)
                {
                    SetCategory(category);
                    ChangeCategoryView(category);
                }
            }

            ChangeSpeciesView(GetSelectedSpecies());      //Changes to view the correct species controls
        }


        /// <summary>
        /// Creates a relative path to the folder of images and opens the file dialog.
        /// </summary>
        private void Animal_image_input_Click(object sender, EventArgs e)
        {
#if DEBUG
            int trimcount = 10;
#else
            int trimcount = 12;
#endif
            //Creates a relative path to a prederermined folder with images
            string startupPath = Application.StartupPath;
            openFileDialog1.InitialDirectory = startupPath.Substring(0, startupPath.Length - trimcount) + "\\Images";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedImage = new Bitmap(openFileDialog1.FileName);    //Set loadedImage to the image found at the chosen file location
            }
        }

        /// <summary>
        /// Button call for opening the color picker and setting the color.
        /// </summary>
        private void Category_furColor_input_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Category_furColor_input.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Button call for opening the color picker and setting the color.
        /// </summary>
        private void Species_wingColor_input_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Species_wingColor_input.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Called when a list-item is selected/deselected. Displays more information about the animal/clears the displayed information.
        /// </summary>
        private void Animals_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Animals_list.SelectedIndices != null && Animals_list.SelectedIndices.Count > 0 && Animals_list.SelectedIndices[0] != -1)
            {
                Animal_remove_input.Enabled = true;
            }
            else
            {
                Animal_remove_input.Enabled = false;
            }
        }


        /// <summary>
        /// Action called when checking/unchecking "list all animals". Resets the displayed controls and adds all species the the dropdown list.
        /// </summary>
        private void ListAllAnimals_input_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCategoryView(null);     //Resets the category to not show be shown or selected
            ChangeSpeciesView(null);      //Resets the species to not show be shown or selected

            AddSpeciesItemsAll();
        }

        /// <summary>
        /// Gets the category chosen from the category-dropdown list.
        /// </summary>
        /// <returns>The chosen category</returns>
        private Categorys? GetSelectedCategory()
        {
            if (Category_input.SelectedIndex != -1)
            {
                return (Categorys)Category_input.SelectedIndex;
            }
            return null;
        }

        /// <summary>
        /// Tries to manually set the chosen category. Used to update the category when species is picked first.
        /// </summary>
        private void SetCategory(Categorys? category)
        {
            if (category != null)
            {
                Category_input.SelectedIndex = (int)category;
            }
        }

        /// <summary>
        /// Tries to get species chosen from the species-dropdown list.
        /// </summary>
        /// <returns>The chosen species</returns>
        private Species? GetSelectedSpecies()
        {
            Species selectedSpecies;
            if (Enum.TryParse<Species>(Species_input.Text, out selectedSpecies))
            {
                return selectedSpecies;
            }
            return null;
        }

        /// <summary>
        /// Adds all available categorys to the dropdown list
        /// </summary>
        private void AddCategoryItems()
        {
            Category_input.Items.AddRange(Enum.GetNames(typeof(Categorys)));
        }

        /// <summary>
        /// Adds all species of the selected category to the dropdown list
        /// </summary>
        public void AddSpeciesItems()
        {
            Categorys? selectedCategory = GetSelectedCategory();

            if (selectedCategory != null)
            {
                Species_input.Items.Clear();

                foreach (Species s in speciesMapping[(Categorys)selectedCategory])   //Adds the name of all species from the selected category to the species-dropdown list
                {
                    Species_input.Items.Add(Enum.GetName(typeof(Species), s));
                }
            }
        }

        /// <summary>
        /// Adds all species to the dropdown list. Used to enable free selection of animals without having to choose category.
        /// </summary>
        public void AddSpeciesItemsAll()
        {
            Species_input.Items.Clear();

            foreach (string s in Enum.GetNames(typeof(Species)))   //Adds the name of all species from the selected category to the species-dropdown list
            {
                Species_input.Items.Add(s);
            }
        }

        /// <summary>
        /// Adds all types of genders to the dropdown list
        /// </summary>
        private void AddGenderItems()
        {
            Animal_gender_input.Items.AddRange(Enum.GetNames(typeof(Genders)));
        }

        /// <summary>
        /// Adds all sorting methods to the dropdown list
        /// </summary>
        private void AddSortingMethods()
        {
            List_sort_input.Items.AddRange(Enum.GetNames(typeof(SortMethods)));
        }

        /// <summary>
        /// Hides all controls but the controls relevant to <paramref name="category"/>
        /// </summary>
        private void ChangeCategoryView(Categorys? category)
        {
            ChangeSpeciesView(null);
            Category_furColor_input.BackColor = Color.LightGray;

            foreach (KeyValuePair<Categorys, Control[]> kv_pair in categoryControlsMapping)
            {
                foreach (Control c in kv_pair.Value)    //Loop though all controls in this category
                {
                    if (category == null)
                    {
                        c.Hide();
                    }
                    else if (category == kv_pair.Key)   //If this control is part of the category we want to display: show the control
                    {
                        c.Show();
                    }
                    else                                //else: hide the control
                    {
                        c.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Hides all controls but the controls relevant to <paramref name="species"/>
        /// </summary>
        private void ChangeSpeciesView(Species? species)
        {
            Species_wingColor_input.BackColor = Color.LightGray;
            foreach (KeyValuePair<Species, Control[]> kv_pair in speciesControlsMapping)
            {
                foreach (Control c in kv_pair.Value)
                {
                    if (species == null)
                    {
                        c.Hide();
                    }
                    else if (species == kv_pair.Key)    //If this control is part of the species we want to display: show the control
                    {
                        c.Show();
                    }
                    else                                //else: hide the control
                    {
                        c.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Gets which category the selected species is part of. Used when species is picked first.
        /// </summary>
        /// <returns></returns>
        private Categorys? GetCategoryFromSelectedSpecies()
        {
            Species? selectedSpecies = GetSelectedSpecies();

            if (selectedSpecies != null)
            {
                foreach (KeyValuePair<Categorys, Species[]> kv_pair in speciesMapping)
                {
                    foreach (Species s in kv_pair.Value)
                    {
                        if (s == (Species)selectedSpecies)
                        {
                            return kv_pair.Key;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Tries to change how the animals list is sorted
        /// </summary>
        private void List_sort_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_sort_input.SelectedIndex != -1)
            {
                animalManager.SortAnimals((SortMethods)List_sort_input.SelectedIndex);
                FillAnimalsListView(Animals_list);
            }
        }

        /// <summary>
        /// Button click event for adding a new food item
        /// </summary>
        private void Animal_foodItems_input_Click(object sender, EventArgs e)
        {
            if (foodForm != null)
                foodForm.Close();

            foodForm = new FoodForm();
            if (foodForm.ShowDialog() == DialogResult.OK)
            {
                foodManager.foodItems.Add(foodForm.FoodItem);
                string[] foodItem = foodForm.FoodItem.ToStringArray();
                FoodItems_list.Items.Add(new ListViewItem(foodItem));

                for (int c = 0; c < foodItem.Length; c++)
                    FoodItems_list.Columns[c].Width = -2;     //Auto-resizes the columns to fit the data
            }
        }
        /// <summary>
        /// Button click event for adding a new feeding schedule
        /// </summary>
        private void FoodSchedule_NewSchedule_input_Click(object sender, EventArgs e)
        {
            if (feedingScheduleForm != null)
                feedingScheduleForm.Close();

            feedingScheduleForm = new FeedingScheduleForm();
            if (feedingScheduleForm.ShowDialog() == DialogResult.OK)
            {
                feedingScheduleManager.feedingSchedules.Add(feedingScheduleForm.FeedingSchedule);
                string[] feedingSchedule = feedingScheduleForm.FeedingSchedule.ToStringArray();
                FeedingSchedule_list.Items.Add(new ListViewItem(feedingSchedule));

                for (int c = 0; c < feedingSchedule.Length; c++)
                    FoodItems_list.Columns[c].Width = -2;     //Auto-resizes the columns to fit the data
            }
        }

        /// <summary>
        /// Button click event for connecting selected animal to selected food item
        /// </summary>
        private void FoodItems_ConnectAnimal_input_Click(object sender, EventArgs e)
        {
            int? selectedFoodItemIndex = null;
            int? selectedAnimalID = null;

            try { selectedFoodItemIndex = FoodItems_list.SelectedIndices[0]; }
            catch (Exception) { }
            try { selectedAnimalID = animalManager.GetAt(Animals_list.SelectedIndices[0]).ID; }
            catch (Exception) { }

            if (selectedFoodItemIndex == null)
            {
                MessageBox.Show("No FoodItem Selected!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedAnimalID == null)
            {
                MessageBox.Show("No Animal Selected!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foodManager.AddConnection((int)selectedFoodItemIndex, (int)selectedAnimalID);

            string[] foodItem = foodManager.ToStringArray((int)selectedFoodItemIndex);
            FoodItems_list.Items[(int)selectedFoodItemIndex] = new ListViewItem(foodItem);
        }
        /// <summary>
        /// Button click event for connecting selected animal to selected food item
        /// </summary>
        private void FeedingSchedule_ConnectAnimal_input_Click(object sender, EventArgs e)
        {
            int? selectedFeedingSchedule = null;
            int? selectedAnimalID = null;

            try { selectedFeedingSchedule = FeedingSchedule_list.SelectedIndices[0]; }
            catch (Exception) { }
            try { selectedAnimalID = animalManager.GetAt(Animals_list.SelectedIndices[0]).ID; }
            catch (Exception) { }

            if (selectedFeedingSchedule == null)
            {
                MessageBox.Show("No Feeding Schedule Selected!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedAnimalID == null)
            {
                MessageBox.Show("No Animal Selected!", "Assert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            feedingScheduleManager.AddConnection((int)selectedFeedingSchedule, (int)selectedAnimalID);

            string[] feedingSchedule = feedingScheduleManager.ToStringArray((int)selectedFeedingSchedule);
            FeedingSchedule_list.Items[(int)selectedFeedingSchedule] = new ListViewItem(feedingSchedule);
        }
    }

}
