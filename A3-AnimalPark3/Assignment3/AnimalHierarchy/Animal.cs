using System.Collections.Generic;
using System.Drawing;

namespace Assignment3
{

    abstract class Animal : IAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }


        public Image Image { get; private set; }   //An image showing the animal



        /// <summary>
        /// Constructor called when creating an animal
        /// </summary>
        protected Animal(string name, int age, Genders gender, Image image)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Image = image;
        }


        /// <summary>
        /// Prints a list of all animal-attributes
        /// </summary>
        public virtual new List<string> ToString()
        {
            List<string> text = new List<string>();
            text.Add($"ID:  {ID}");
            text.Add($"Name:  {Name}");
            text.Add($"Age:  {Age} years");
            text.Add($"Gender:  {Gender}");
            text.Add($"Species: {GetSpecies()}");

            return text;
        }


        public abstract EaterType GetEaterType();

        public abstract FoodSchedule GetFoodSchedule();

        public abstract string GetSpecies();
    }

}
