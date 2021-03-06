using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// The class responsible for managing the animals created.
    /// </summary>
    class AnimalManager : ListManager<Animal>
    {
        private int animalID;

        /// <summary>
        /// Constructor - Initializes the id and animal list.
        /// </summary>
        public AnimalManager()
        {
            //animals = new ListManager<Animal>();
            animalID = 0;
        }

        /// <summary>
        /// Adds <paramref name="animal"/> to the list of animals and increments the id.
        /// </summary>
        public void AddAnimal(Animal animal)
        {
            animal.ID = animalID++;
            Add(animal);
        }

        public void SetStartID()
        {
            int largestID = int.MinValue;

            foreach (Animal a in base.m_list)
                largestID = a.ID > largestID ? a.ID : largestID;

            animalID = largestID + 1;
        }



        //Sort methods, specific to the animal manager
        Dictionary<SortMethods, Comparer<Animal>> comparers = new Dictionary<SortMethods, Comparer<Animal>>
        {
            { SortMethods.ID, new IDComparer() },
            { SortMethods.Name, new NameComparer() },
            { SortMethods.Age, new AgeComparer() },
            { SortMethods.Species, new SpeciesComparer() }
        };

        /// <summary>
        /// Sorts the animals based on <paramref name="sortMethod"/>
        /// Fills the listview after sort
        /// </summary>
        public void SortAnimals(SortMethods sortMethod)
        {
            Comparer<Animal> comparer = comparers[sortMethod];
            Sort(comparer);
        }
    }

}
