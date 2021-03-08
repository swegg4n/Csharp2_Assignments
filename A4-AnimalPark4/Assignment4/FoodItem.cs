using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    [System.Serializable]
    public class FoodItem
    {
        public string Name { get; set; }
        public ListManager<string> Ingredients { get; set; } = new ListManager<string>();
        public ListManager<int> Connections { get; private set; } = new ListManager<int>();



        /// <summary>
        /// Adds entry: <paramref name="animalID"/> to the list if the entry is unique
        /// </summary>
        /// <returns>Returns if the entry was added (true), or not (false)</returns>
        public bool AddConnection(int animalID)
        {
            if (Connections.Contains(animalID) == false)
            {
                Connections.Add(animalID);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Returns the food item data as a string
        /// </summary>
        public new string ToString()
        {
            return $"Name: {this.Name},  Ingredients: {this.Ingredients.ToString()},  Connections: {this.Connections.ToString()}";
        }

        /// <summary>
        /// Returns the food item data as a string array
        /// </summary>
        public string[] ToStringArray()
        {
            return new string[]
            {
                this.Name,
                this.Ingredients.ToString(),
                this.Connections.ToString(),
            };
        }

        /// <summary>
        /// Returns the food item data as a string list
        /// </summary>
        public List<string> ToStringList()
        {
            return new List<string>()
            {
                this.Name,
                this.Ingredients.ToString(),
                this.Connections.ToString(),
            };
        }
    }

}
