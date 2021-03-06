using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    [System.Serializable]
    public class Ant : Insect
    {
        public bool IsQueen { get; set; } = false;


        /// <summary>
        /// Constructor called when creating an ant
        /// </summary>
        public Ant(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly, bool isQueen) : base(name, age, gender, image, numberOfLegs, canFly)
        {
            this.IsQueen = isQueen;
        }

        internal Ant() { }


        public override string ToString()
        {
            string text = base.ToString();
            text += ($"Is queen?: {IsQueen}");

            return text;
        }

        /// <summary>
        /// Prints a list of all ant-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Is queen?:  {IsQueen}");

            return text;
        }

        /// <summary>
        /// Returns this animal's species-name
        /// </summary>
        public override string GetSpecies()
        {
            return "Ant";
        }
    }

}
