using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// The class responsible for creating animals from user inputed data.
    /// </summary>
    class AnimalFactory
    {

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

    }
}
