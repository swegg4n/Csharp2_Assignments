﻿using System.Collections.Generic;
using System.Drawing;

namespace Assignment2
{
    class Ant : Insect
    {
        public bool IsQueen { get; private set; }


        /// <summary>
        /// Constructor called when creating an ant
        /// </summary>
        public Ant(string name, int age, Genders gender, Image image, int numberOfLegs, bool canFly, bool isQueen) : base(name, age, gender, image, numberOfLegs, canFly)
        {
            this.IsQueen = isQueen;
        }


        /// <summary>
        /// Prints a list of all ant-attributes
        /// </summary>
        public override List<string> ToString()
        {
            List<string> text = base.ToString();
            text.Add($"Is queen?:  {IsQueen}");

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
            return new FoodSchedule("Morning: Leaves", "Lunch: Various fruits", "Evening: Larvae");
        }

        /// <summary>
        /// Returns this animal's species-name
        /// </summary>
        public override string GetSpecies()
        {
            return "Ant";
        }
    }

}
