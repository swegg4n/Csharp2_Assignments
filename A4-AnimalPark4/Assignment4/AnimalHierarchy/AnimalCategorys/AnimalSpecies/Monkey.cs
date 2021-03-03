using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    class Monkey : Mammal
    {
        public float TailLength { get; private set; }   //measured in centimeters (cm)


        /// <summary>
        /// Constructor called when creating a monkey
        /// </summary>
        public Monkey(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor, float tailLength) : base(name, age, gender, image, numberOfTeeth, furColor)
        {
            this.TailLength = tailLength;
        }


        /// <summary>
        /// Prints a list of all monkey-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
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
