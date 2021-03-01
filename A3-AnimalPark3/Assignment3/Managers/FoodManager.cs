using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    /// <summary>
    /// Manager for handeling animals-food item connections
    /// </summary>
    class FoodManager
    {
        public List<FoodItem> foodItems;
        private Dictionary<int, ListManager<int>> foodItemConnections;

        /// <summary>
        /// Constructor
        /// </summary>
        public FoodManager()
        {
            foodItems = new List<FoodItem>();
            foodItemConnections = new Dictionary<int, ListManager<int>>();
        }

        /// <summary>
        /// Tries to create a connection between selected animal and food item
        /// </summary>
        public void AddConnection(int foodItemID, int animalID)
        {
            if (CheckKey(foodItemID) == false)
            {
                foodItemConnections.Add(foodItemID, new ListManager<int> { animalID });
            }
            else if (CheckDuplicates(foodItemID, animalID) == false)
            {
                foodItemConnections[foodItemID].Add(animalID);
            }

        }

        /// <summary>
        /// Returns a specific food item as a string array to be presented in a list view
        /// </summary>
        public string[] ToStringArray(int index)
        {
            List<string> items = foodItems[index].ToStringList();
            items.Add(foodItemConnections[index].ToString());

            return items.ToArray();
        }

        /// <summary>
        /// Checks if the <paramref name="key"/> exists in the connections dictionary or not
        /// </summary>
        private bool CheckKey(int key)
        {
            return foodItemConnections.ContainsKey(key);
        }

        /// <summary>
        /// Checks if the collection at key: <paramref name="key"/> contains value: <paramref name="value"/>
        /// </summary>
        private bool CheckDuplicates(int key, int value)
        {
            return foodItemConnections[key].Contains(value);
        }
    }
}
