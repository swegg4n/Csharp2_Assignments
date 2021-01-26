using System.Collections.Generic;
using System.Drawing;

namespace Assignment1
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
            text.Add($"Species:  Butterfly");
            text.Add($"Main wing color:  ({ MainWingColor.R},{ MainWingColor.G},{ MainWingColor.B})");

            return text;
        }
    }

}
