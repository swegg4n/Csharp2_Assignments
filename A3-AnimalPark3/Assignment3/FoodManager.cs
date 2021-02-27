using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    class FoodManager
    {
        public List<FoodItem> foodItems;
        private Dictionary<int, ListManager<int>> foodItemConnections;


        public FoodManager()
        {
            foodItems = new List<FoodItem>();
            foodItemConnections = new Dictionary<int, ListManager<int>>();
        }


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


        public string[] ToStringArray(int index)
        {
            List<string> items = foodItems[index].ToStringList();
            items.Add(foodItemConnections[index].ToString());

            return items.ToArray();
        }


        private bool CheckKey(int key)
        {
            return foodItemConnections.ContainsKey(key);
        }

        private bool CheckDuplicates(int key, int value)
        {
            return foodItemConnections[key].Contains(value);
        }
    }
}
