using System.Collections.Generic;
using System.Drawing;

namespace Assignment3
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
            text.Add($"Breed:  {Breed}");

            return text;
        }


        /// <summary>
        /// Returns this animal's EaterType
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Omnivorous;
        }

        /// <summary>
        /// Returns this animal's FoodSchedules
        /// </summary>
        public override FoodSchedule GetFoodSchedule()
        {
            return new FoodSchedule("Morning: 4 cups dog food (pork)", "Lunch: 3 cups dog food (plant based)", "Evening: 4 cups dog food (beef)");
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
