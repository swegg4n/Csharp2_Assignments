﻿namespace Assignment3
{
    /// <summary>
    /// Interface implemented by Animal
    /// </summary>
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        Genders Gender { get; set; }


        string GetSpecies();
    }

}
