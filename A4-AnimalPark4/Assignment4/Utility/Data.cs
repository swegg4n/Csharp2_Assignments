using System;
using System.Collections.Generic;

namespace Assignment4
{
    [Serializable]
    public struct Data
    {
        public List<Animal> AnimalsList { get; set; }
        public List<FoodItem> FoodItems { get; set; }
        public List<FeedingSchedule> FeedingSchedules { get; set; }
    }
}
