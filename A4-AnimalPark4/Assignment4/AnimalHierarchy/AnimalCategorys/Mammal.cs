using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace Assignment4
{
    [System.Serializable]
    [XmlInclude(typeof(Ant))]
    [XmlInclude(typeof(Butterfly))]
    [XmlInclude(typeof(Dog))]
    [XmlInclude(typeof(Monkey))]
    public abstract class Mammal : Animal
    {
        public int NumberOfTeeth { get; set; } = -1;
        public byte[] FurColor { get; set; } = new byte[3] { 0, 0, 0 };


        /// <summary>
        /// Constructor called when creating a mammal
        /// </summary>
        protected Mammal(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor) : base(name, age, gender, image)
        {
            this.NumberOfTeeth = numberOfTeeth;
            this.FurColor = new byte[] { furColor.R, furColor.G, furColor.B };
        }

        internal Mammal() { }


        public override string ToString()
        {
            string text = base.ToString();
            text += ($"Category: Mammal,  ");
            text += ($"Number of teeth: {NumberOfTeeth},  ");
            text += ($"Fur color: <{FurColor[0]}, {FurColor[1]}, {FurColor[2]}>,  ");

            return text;
        }

        /// <summary>
        /// Prints a list of all mammal-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Category:  Mammal");
            text.Add($"Number of teeth:  {NumberOfTeeth}");
            text.Add($"Fur color:  <{FurColor[0]}, {FurColor[1]}, {FurColor[2]}>");

            return text;
        }
    }

}
