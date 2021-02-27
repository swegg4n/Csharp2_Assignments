using System.Collections.Generic;
using System.Drawing;

namespace Assignment3
{
    abstract class Mammal : Animal
    {
        public int NumberOfTeeth { get; private set; }
        public Color FurColor { get; private set; }


        /// <summary>
        /// Constructor called when creating a mammal
        /// </summary>
        protected Mammal(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor) : base(name, age, gender, image)
        {
            this.NumberOfTeeth = numberOfTeeth;
            this.FurColor = furColor;
        }


        /// <summary>
        /// Prints a list of all mammal-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
            text.Add($"Category:  Mammal");
            text.Add($"Number of teeth:  {NumberOfTeeth}");
            text.Add($"Fur color:  ({FurColor.R},{FurColor.G},{FurColor.B})");

            return text;
        }
    }

}
