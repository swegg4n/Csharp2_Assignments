using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    /// <summary>
    /// Class containing data and helper-methods regarding animal feeding routines
    /// </summary>
    class FoodSchedule
    {
        private List<string> foodDescriptions;

        public int Count { get { return foodDescriptions.Count; } }


        /// <summary>
        /// Constructor
        /// </summary>
        public FoodSchedule()
        {
            foodDescriptions = new List<string>();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        public FoodSchedule(List<string> foodList)
        {
            foodDescriptions = foodList;
        }

        /// <summary>
        /// Constructor for filling the list with <paramref name="items"/>
        /// </summary>
        public FoodSchedule(params string[] items)
        {
            foodDescriptions = new List<string>();

            for (int i = 0; i < items.Length; i++)
                AddFoodScheduleItem(items[i]);
        }

        /// <summary>
        /// Tries to add <paramref name="item"/> to the list
        /// </summary>
        public bool AddFoodScheduleItem(string item)
        {
            if (foodDescriptions != null)
            {
                foodDescriptions.Add(item);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Tries to change the value of the item at index: <paramref name="index"/> to <paramref name="item"/>
        /// </summary>
        public bool ChangeFoodSheduleItem(string item, int index)
        {
            if (ValidateIndex(index))
            {
                foodDescriptions[index] = item;
            }

            return false;
        }

        /// <summary>
        /// Tries to delete the item at index: <paramref name="index"/> from the list
        /// </summary>
        public bool DeleteFoodScheduleItem(int index)
        {
            if (ValidateIndex(index))
            {
                foodDescriptions.RemoveAt(index);
            }

            return false;
        }

        /// <summary>
        /// Returns a string explaining that no feeding is required
        /// Called when there are no items in the list
        /// </summary>
        private string DescribeNoFeedingRequired()
        {
            return "No feeding required.";
        }

        /// <summary>
        /// Tries to return the item at index: <paramref name="index"/> from the list
        /// By convention: All "At" access functions should include validation and exception handeling.
        /// </summary>
        public string GetFoodScheduleAt(int index)
        {
            if (ValidateIndex(index))
            {
                return foodDescriptions[index];
            }

            throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// Prints a string of all items in the food descriptions-list
        /// </summary>
        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (foodDescriptions != null && Count > 0)
            {
                sb.Append($"To be fed {Count} times as follows:\r\n");

                for (int i = 0; i < Count; i++)
                    sb.Append($"({i}) {foodDescriptions[i]}\r\n");

                return sb.ToString();
            }

            return DescribeNoFeedingRequired();
        }

        /// <summary>
        /// Validates if the list is initilaized and index: <paramref name="index"/> lies within the bounds of the list
        /// </summary>
        private bool ValidateIndex(int index)
        {
            return (foodDescriptions != null && index >= 0 && index < Count);
        }
    }

}
