using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    /// <summary>
    /// Manager for handeling animals-feeding schedule connections
    /// </summary>
    class FeedingScheduleManager : ListManager<FeedingSchedule>
    {
        /// <summary>
        /// Tries to create a connection between selected animal and feeding schedule
        /// </summary>
        public void AddConnection(int feedingScheduleID, int animalID)
        {
            base.m_list[feedingScheduleID].AddConnection(animalID);
        }
    }

}
