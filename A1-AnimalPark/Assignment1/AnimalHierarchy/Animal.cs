using System.Collections.Generic;
using System.Drawing;

namespace Assignment1
{

    abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Genders Gender { get; private set; }

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
            text.Add($"ID:  {Id}");
            text.Add($"Name:  {Name}");
            text.Add($"Age:  {Age} years");
            text.Add($"Gender:  {Gender}");

            return text;
        }
    }

}
