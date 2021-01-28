using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
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
            animal.ID = animalID++;
            animals.Add(animal);
        }

        /// <summary>
        /// Tries to get the animal at position "<paramref name="index"/>" from the animal-list
        /// </summary>
        public Animal GetAnimalAt(int index)
        {
            if (animals != null && index >= 0 && index < animalsCount)
                return animals[index];

            throw new IndexOutOfRangeException();
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


        /// <summary>
        /// Sorts the animals based on <paramref name="sortMethod"/>
        /// Fills the listview after sort
        /// </summary>
        public void SortAnimals(ListView listView, SortMethods sortMethod)
        {
            Comparer<Animal> comparer = null;

            switch (sortMethod)
            {
                case SortMethods.ID:
                    comparer = new IDComparer();
                    break;

                case SortMethods.Name:
                    comparer = new NameComparer();
                    break;

                case SortMethods.Age:
                    comparer = new AgeComparer();
                    break;

                case SortMethods.Species:
                    comparer = new SpeciesComparer();
                    break;

                default:
                    return;
            }

            animals.Sort(comparer);
            FillAnimalsListView(listView);
        }
    }

}
