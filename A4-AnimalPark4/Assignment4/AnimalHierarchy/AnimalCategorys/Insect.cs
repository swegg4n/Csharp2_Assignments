using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    abstract class Insect : Animal
    {
        public int NumberOfLegs { get; private set; }
        public bool CanFly { get; private set; }


        /// <summary>
        /// Constructor called when creating an insect
        /// </summary>
        protected Insect(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly) : base(name, age, gender, image)
        {
            this.NumberOfLegs = numberOfLegs;
            this.CanFly = canFly;
        }


        /// <summary>
        /// Prints a list of all insect-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
            text.Add($"Category:  Insect");
            text.Add($"Number of legs:  {NumberOfLegs}");
            text.Add($"Can fly?:  {CanFly}");

            return text;
        }

    }

}
