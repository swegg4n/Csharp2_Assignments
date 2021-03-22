namespace Assignment4
{
    /// <summary>
    /// Manager for handeling animals-food item connections
    /// </summary>
    public class FoodManager : ListManager<FoodItem>
    {
        /// <summary>
        /// Tries to create a connection between selected animal and food item
        /// </summary>
        public bool AddConnection(int foodItemID, int animalID)
        {
            return base.Data()[foodItemID].AddConnection(animalID);
        }
    }

}
