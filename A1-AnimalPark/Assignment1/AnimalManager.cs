using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment1
{
    public enum Genders { Male, Female, Unknown };
    public enum Categorys { Insect, Mamal }
    public enum Species { Ant, Butterfly, Dog, Monkey }


    /// <summary>
    /// The class responsible for managing the animals created.
    /// </summary>
    class AnimalManager
    {
        private int animalID;
        private List<Animal> animals;   //The list of all created animals
        public int animalsCount { get { return animals.Count; } }


        /// <summary>
        /// Constructor - Initializes the id and animal list.
        /// </summary>
        public AnimalManager()
        {
            animalID = 0;
            animals = new List<Animal>();
        }

        /// <summary>
        /// Adds <paramref name="animal"/> to the list of animals and increments the id.
        /// </summary>
        public void AddAnimal(Animal animal)
        {
            animal.Id = animalID++;
            animals.Add(animal);
        }

        /// <summary>
        /// Fetches the animal at position "<paramref name="index"/>" in the animal-list
        /// </summary>
        public Animal GetAnimalAt(int index)
        {
            return animals[index];
        }

        /// <summary>
        /// Clears and fills <paramref name="listView"/> with the animals from the animal-list
        /// </summary>
        public void FillAnimalsListView(ListView listView)
        {
            listView.Items.Clear();
            int columns = listView.Columns.Count;

            for (int i = 0; i < animalsCount; i++)
            {
                List<string> animalData = GetAnimalAt(i).ToString();

                for (int c = columns; c < animalData.Count; c++)
                    listView.Columns.Add("");   //Adds new columns if necessary

                listView.Items.Add(new ListViewItem(animalData.ToArray()));    //Adds a new entry to the list of created animals

                for (int c = 0; c < animalData.Count; c++)
                    listView.Columns[c].Width = -2;     //Auto-resizes the columns to fit the data
            }
        }
    }

}
