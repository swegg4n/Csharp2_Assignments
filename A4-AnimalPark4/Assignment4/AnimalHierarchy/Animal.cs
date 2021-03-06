using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace Assignment4
{
    [Serializable]
    [XmlInclude(typeof(Insect))]
    [XmlInclude(typeof(Mammal))]
    //[XmlInclude(typeof(Bitmap))]
    public abstract class Animal : IAnimal
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "";
        public int Age { get; set; } = -1;
        public Genders Gender { get; set; } = Genders.Unknown;


        [XmlIgnore] public Image Image { get; set; } = null;  //An image showing the animal



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

        internal Animal() { }


        public virtual new string ToString()
        {
            string text = "";
            text += ($"ID: {ID},  ");
            text += ($"Name: {Name},  ");
            text += ($"Age: {Age}, ");
            text += ($"Gender: {Gender},  ");
            text += ($"Species: {GetSpecies()},  ");

            return text;
        }

        /// <summary>
        /// Prints a list of all animal-attributes
        /// </summary>
        public virtual List<string> ToStringList()
        {
            List<string> text = new List<string>();
            text.Add($"ID:  {ID}");
            text.Add($"Name:  {Name}");
            text.Add($"Age:  {Age} years");
            text.Add($"Gender:  {Gender}");
            text.Add($"Species: {GetSpecies()}");

            return text;
        }


        public abstract string GetSpecies();
    }

}
