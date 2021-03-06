using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    [System.Serializable]
    public class Butterfly : Insect
    {
        public byte[] MainWingColor { get; set; } = new byte[] { 0, 0, 0 };


        /// <summary>
        /// Constructor called when creating a butterfly
        /// </summary>
        public Butterfly(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly, Color mainWingColor) : base(name, age, gender, image, numberOfLegs, canFly)
        {
            this.MainWingColor = new byte[] { mainWingColor.R, mainWingColor.G, mainWingColor.B };
        }

        internal Butterfly() { }


        public override string ToString()
        {
            string text = base.ToString();
            text += ($"Main wing color: <{MainWingColor[0]}, {MainWingColor[1]}, {MainWingColor[2]}>");

            return text;
        }

        /// <summary>
        /// Prints a list of all butterfly-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Main wing color:  <{MainWingColor[0]}, {MainWingColor[1]}, {MainWingColor[2]}>");

            return text;
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
