using System.Collections.Generic;

namespace Assignment3
{
    public class FoodItem
    {
        public string Name { get; set; }
        public ListManager<string> Ingredients { get; set; }


        public FoodItem()
        {
            Ingredients = new ListManager<string>();
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
            };
        }
    }

}
