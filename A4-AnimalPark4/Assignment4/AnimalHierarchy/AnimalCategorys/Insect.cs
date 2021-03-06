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
    public abstract class Insect : Animal
    {
        public int NumberOfLegs { get; set; } = -1;
        public bool CanFly { get; set; } = false;


        /// <summary>
        /// Constructor called when creating an insect
        /// </summary>
        protected Insect(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly) : base(name, age, gender, image)
        {
            this.NumberOfLegs = numberOfLegs;
            this.CanFly = canFly;
        }

        internal Insect() { }


        public override string ToString()
        {
            string text = base.ToString();
            text+=($"Category: Insect,  ");
            text+=($"Number of legs: {NumberOfLegs},  ");
            text+=($"Can fly?: {CanFly},  ");

            return text;
        }

        /// <summary>
        /// Prints a list of all insect-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Category:  Insect");
            text.Add($"Number of legs:  {NumberOfLegs}");
            text.Add($"Can fly?:  {CanFly}");

            return text;
        }

    }

}
