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


        public string[] ToStringArray()
        {
            return new string[] {
                this.Name,
                this.Ingredients.ToString(),
            };
        }

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
