using System;
using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// Struct containing all data that can be saved/loaded/exported
    /// </summary>
    [Serializable]
    public struct Data
    {
        public List<Animal> AnimalsList { get; set; }
        public List<FoodItem> FoodItems { get; set; }
        public List<FeedingSchedule> FeedingSchedules { get; set; }
    }
}
