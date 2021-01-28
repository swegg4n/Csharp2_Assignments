using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// The class responsible for creating animals from user inputed data.
    /// </summary>
    class AnimalFactory
    {
        private static Random random = new Random();


        /// <summary>
        /// Tries to create an animal from user inputed data.
        /// </summary>
        /// <param name="form">UI with all input-data needed to create the animal</param>
        /// <param name="loadedImage">The image picked from the folder</param>
        /// <param name="animalManager">The manager where the animal will be stored</param>
        /// <param name="selectedCategory">The category of animals chosen. Used together with <paramref name="selectedSpecies"/> to determine which animal to create</param>
        /// <param name="selectedSpecies">The species of animals chosen. Used together with <paramref name="selectedCategory"/> to determine which animal to create</param>
        public void CreateAnimal(Form1 form, Image loadedImage, AnimalManager animalManager, Categorys selectedCategory, Species selectedSpecies)
        {
            Animal animal = null;

            string name = form.Animal_name_input.Text;
            int age = Int32.Parse(form.Animal_age_input.Text);
            Genders gender = (Genders)form.Animal_gender_input.SelectedIndex;


            if (selectedCategory == Categorys.Insect)
            {
                int numberOfLegs = Int32.Parse(form.Category_noLegs_input.Text);
                bool canFly = form.Category_canFly_input.Checked;


                switch (selectedSpecies)
                {
                    case Species.Ant:
                        {
                            bool isQueen = form.Species_isQueen_input.Checked;

                            animal = new Ant(name, age, gender, loadedImage, numberOfLegs, canFly, isQueen);     //Creates an ant
                        }
                        break;

                    case Species.Butterfly:
                        {
                            Color mainWingColor = form.Species_wingColor_input.BackColor;

                            animal = new Butterfly(name, age, gender, loadedImage, numberOfLegs, canFly, mainWingColor);    //Creates a butterfly
                        }
                        break;
                }
            }
            else if (selectedCategory == Categorys.Mamal)
            {
                int numberOfTeeth = Int32.Parse(form.Category_noteeth_input.Text);
                Color furColor = form.Category_furColor_input.BackColor;


                switch (selectedSpecies)
                {
                    case Species.Dog:
                        {
                            string breed = form.Species_breed_input.Text;

                            animal = new Dog(name, age, gender, loadedImage, numberOfTeeth, furColor, breed);   //Creates a dog
                        }
                        break;

                    case Species.Monkey:
                        {
                            int tailLength = Int32.Parse(form.Species_tailLength_input.Text);

                            animal = new Monkey(name, age, gender, loadedImage, numberOfTeeth, furColor, tailLength);     //Creates a monkey
                        }
                        break;
                }
            }

            animalManager.AddAnimal(animal);
        }


        /// <summary>
        /// Creates a random animal with random properties
        /// </summary>
        /// <param name="animalManager"></param>
        public void CreateRandomAnimal(AnimalManager animalManager)
        {
            Animal animal = null;

            string name = RandomString(3, 8, true);
            int age = random.Next(0, 99);
            Genders gender = RandomEnum<Genders>();

            Categorys category = RandomEnum<Categorys>();
            Species species = RandomEnum<Species>(category);

            Console.WriteLine(category);
            Console.WriteLine(species);

            switch (category)
            {
                case Categorys.Insect:
                    {
                        int numberOfLegs = random.Next(2, 8);
                        bool canFly = Convert.ToBoolean(random.Next(0, 2));

                        switch (species)
                        {
                            case Species.Ant:
                                {
                                    bool isQueen = Convert.ToBoolean(random.Next(0, 2));

                                    animal = new Ant(name, age, gender, null, numberOfLegs, canFly, isQueen);     //Creates an ant
                                }
                                break;

                            case Species.Butterfly:
                                {
                                    Color mainWingColor = RandomColor();

                                    animal = new Butterfly(name, age, gender, null, numberOfLegs, canFly, mainWingColor);    //Creates a butterfly
                                }
                                break;
                        }
                    }
                    break;

                case Categorys.Mamal:
                    {
                        int numberOfTeeth = random.Next(0, 30);
                        Color furColor = RandomColor();

                        switch (species)
                        {
                            case Species.Dog:
                                {
                                    string breed = RandomString(4, 12, true);

                                    animal = new Dog(name, age, gender, null, numberOfTeeth, furColor, breed);   //Creates a dog
                                }
                                break;

                            case Species.Monkey:
                                {
                                    int tailLength = random.Next(0, 200);

                                    animal = new Monkey(name, age, gender, null, numberOfTeeth, furColor, tailLength);     //Creates a monkey
                                }
                                break;
                        }
                    }
                    break;
            }

            animalManager.AddAnimal(animal);
        }

        /// <summary>
        /// Returns a random string of characters
        /// </summary>
        private string RandomString(int minLength, int maxLength, bool firstUpper)
        {
            StringBuilder sb = new StringBuilder();

            int length = random.Next(minLength, maxLength);
            char first = 'a';
            int charCount = 26;

            for (int i = 0; i < length; i++)
            {
                char c = (char)random.Next(first, first + charCount);
                sb.Append(c);
            }

            if (firstUpper) { sb[0] = char.ToUpper(sb[0]); }

            return sb.ToString();
        }

        /// <summary>
        /// Returns a random value from enum of type T
        /// </summary>
        private T RandomEnum<T>()
        {
            if (typeof(T).IsEnum)
            {
                int i = random.Next(0, Enum.GetValues(typeof(T)).Length);
                return (T)(object)i;
            }
            throw new ArgumentException("T must be an enumerated type");
        }

        /// <summary>
        /// Returns a random value from enum of type T
        /// </summary>
        private T RandomEnum<T>(Categorys fromCategory)
        {
            if (typeof(T).IsEnum)
            {
                int i = random.Next(0, 2) + (int)fromCategory * 2;
                return (T)(object)i;
            }
            throw new ArgumentException("T must be an enumerated type");
        }

        /// <summary>
        /// Retruns a random color
        /// </summary>
        private Color RandomColor()
        {
            int r, g, b;
            r = random.Next(0, 256);
            g = random.Next(0, 256);
            b = random.Next(0, 256);

            return Color.FromArgb(r, g, b);
        }
    }
}
