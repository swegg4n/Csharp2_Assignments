using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    [System.Serializable]
    public class Monkey : Mammal
    {
        public float TailLength { get; set; } = -1;  //measured in centimeters (cm)


        /// <summary>
        /// Constructor called when creating a monkey
        /// </summary>
        public Monkey(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor, float tailLength) : base(name, age, gender, image, numberOfTeeth, furColor)
        {
            this.TailLength = tailLength;
        }

        internal Monkey() { }


        public override string ToString()
        {
            string text = base.ToString();
            text += ($"Tail length: {TailLength} cm");

            return text;
        }

        /// <summary>
        /// Prints a list of all monkey-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Tail length:  {TailLength} cm");

            return text;
        }


        /// <summary>
        /// Returns this animal's species-name
        /// </summary>
        public override string GetSpecies()
        {
            return "Monkey";
        }
    }

}
