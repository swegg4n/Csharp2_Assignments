using System.Collections.Generic;
using System.Drawing;

namespace Assignment4
{
    [System.Serializable]
    public class Dog : Mammal
    {
        public string Breed { get; set; } = "";


        /// <summary>
        /// Constructor called when creating a dog
        /// </summary>
        public Dog(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor, string breed) : base(name, age, gender, image, numberOfTeeth, furColor)
        {
            this.Breed = breed;
        }

        internal Dog() { }


        public override string ToString()
        {
            string text = base.ToString();
            text += ($"Breed: {Breed}");

            return text;
        }

        /// <summary>
        /// Prints a list of all dog-attributes
        /// </summary>
        public override List<string> ToStringList()
        {
            List<string> text = base.ToStringList();
            text.Add($"Breed:  {Breed}");

            return text;
        }


        /// <summary>
        /// Returns this animal's species-name
        /// </summary>
        public override string GetSpecies()
        {
            return "Dog";
        }
    }

}
