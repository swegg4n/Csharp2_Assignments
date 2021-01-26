using System.Collections.Generic;
using System.Drawing;

namespace Assignment1
{
    class Dog : Mammal
    {
        public string Breed { get; private set; }


        /// <summary>
        /// Constructor called when creating a dog
        /// </summary>
        public Dog(string name, int age, Genders gender, Image image, int numberOfTeeth, Color furColor, string breed) : base(name, age, gender, image, numberOfTeeth, furColor)
        {
            this.Breed = breed;
        }


        /// <summary>
        /// Prints a list of all dog-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
            text.Add($"Species:  Dog");
            text.Add($"Breed:  {Breed}");

            return text;
        }
    }

}
