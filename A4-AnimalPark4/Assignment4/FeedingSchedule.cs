using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// Class containing data and helper-methods regarding animal feeding routines
    /// </summary>
    [System.Serializable]
    public class FeedingSchedule
    {
        public string Diet { get; set; }
        public ListManager<string> FoodDescriptions { get; set; } = new ListManager<string>();
        public ListManager<int> Connections { get; private set; } = new ListManager<int>();

        public int Count { get { return FoodDescriptions.Count; } }



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
        /// Returns the feeding schedule data as a string
        /// </summary>
        public new string ToString()
        {
            return $"Diet: {this.Diet},  FoodDescriptions: {this.FoodDescriptions.ToString()},  Connections: {this.Connections.ToString()}";
        }

        /// <summary>
        /// Prints a string array of all items in the food descriptions-list
        /// </summary>
        public string[] ToStringArray()
        {
            return new string[]
            {
                this.Diet,
                this.FoodDescriptions.ToString(),
                this.Connections.ToString(),
            };
        }

        /// <summary>
        /// Prints a string list of all items in the food descriptions-list
        /// </summary>
        public List<string> ToStringList()
        {
            return new List<string>()
            {
                this.Diet,
                this.FoodDescriptions.ToString(),
                this.Connections.ToString(),
            };
        }
    }

}
