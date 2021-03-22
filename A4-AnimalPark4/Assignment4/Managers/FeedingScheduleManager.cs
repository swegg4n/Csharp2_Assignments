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
        public bool AddConnection(int feedingScheduleID, int animalID)
        {
            return base.Data()[feedingScheduleID].AddConnection(animalID);
        }
    }

}
