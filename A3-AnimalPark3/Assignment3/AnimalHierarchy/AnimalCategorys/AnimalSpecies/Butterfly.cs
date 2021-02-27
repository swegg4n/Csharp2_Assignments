using System.Collections.Generic;
using System.Drawing;

namespace Assignment3
{
    class Butterfly : Insect
    {
        public Color MainWingColor { get; private set; }


        /// <summary>
        /// Constructor called when creating a butterfly
        /// </summary>
        public Butterfly(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly, Color mainWingColor) : base(name, age, gender, image, numberOfLegs, canFly)
        {
            this.MainWingColor = mainWingColor;
        }


        /// <summary>
        /// Prints a list of all butterfly-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
            text.Add($"Main wing color:  ({ MainWingColor.R},{ MainWingColor.G},{ MainWingColor.B})");

            return text;
        }


        /// <summary>
        /// Returns this animal's EaterType
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        /// <summary>
        /// Returns this animal's FoodSchedules
        /// </summary>
        public override FoodSchedule GetFoodSchedule()
        {
            return new FoodSchedule();  //no feeding schedule
        }

        /// <summary>
        /// Returns this animal's species-name
        /// </summary>
        public override string GetSpecies()
        {
            return "Butterfly";
        }
    }

}
