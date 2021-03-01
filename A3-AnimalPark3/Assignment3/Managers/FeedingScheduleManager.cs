using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    /// <summary>
    /// Manager for handeling animals-feeding schedule connections
    /// </summary>
    class FeedingScheduleManager
    {
        public List<FeedingSchedule> feedingSchedules;
        private Dictionary<int, ListManager<int>> feedingScheduleConnections;

        /// <summary>
        /// Constructor
        /// </summary>
        public FeedingScheduleManager()
        {
            feedingSchedules = new List<FeedingSchedule>();
            feedingScheduleConnections = new Dictionary<int, ListManager<int>>();
        }

        /// <summary>
        /// Tries to create a connection between selected animal and feeding schedule
        /// </summary>
        public void AddConnection(int feedingScheduleID, int animalID)
        {
            if (CheckKey(feedingScheduleID) == false)
            {
                feedingScheduleConnections.Add(feedingScheduleID, new ListManager<int> { animalID });
            }
            else if (CheckDuplicates(feedingScheduleID, animalID) == false)
            {
                feedingScheduleConnections[feedingScheduleID].Add(animalID);
            }
        }

        /// <summary>
        /// Returns a specific feeding schedule as a string array to be presented in a list view
        /// </summary>
        public string[] ToStringArray(int index)
        {
            List<string> items = feedingSchedules[index].ToStringList();
            items.Add(feedingScheduleConnections[index].ToString());

            return items.ToArray();
        }

        /// <summary>
        /// Checks if the <paramref name="key"/> exists in the connections dictionary or not
        /// </summary>
        private bool CheckKey(int key)
        {
            return feedingScheduleConnections.ContainsKey(key);
        }

        /// <summary>
        /// Checks if the collection at key: <paramref name="key"/> contains value: <paramref name="value"/>
        /// </summary>
        private bool CheckDuplicates(int key, int value)
        {
            return feedingScheduleConnections[key].Contains(value);
        }
    }
}
