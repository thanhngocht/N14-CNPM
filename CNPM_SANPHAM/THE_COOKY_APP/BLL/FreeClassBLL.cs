using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class FreeClassBLL
    {
        private FreeClassDAO freeClassDAO = new FreeClassDAO(); // Create an instance of the FreeClassDAO

        // Method to get all free classes
        public List<FreeClassDTO> GetAllFreeClasses()
        {
            return freeClassDAO.GetAllFreeClasses(); // Call the DAO method to get all free classes
        }

        // Method to add a new free class
        public void AddFreeClass(FreeClassDTO freeClass)
        {
            freeClassDAO.AddFreeClass(freeClass); // Call the DAO method to add a free class
        }

        // Method to update an existing free class
        public void UpdateFreeClass(FreeClassDTO freeClass)
        {
            freeClassDAO.UpdateFreeClass(freeClass); // Call the DAO method to update a free class
        }

        // Method to delete a free class
        public void DeleteFreeClass(string idClass)
        {
            freeClassDAO.DeleteFreeClass(idClass); // Call the DAO method to delete a free class
        }

        // Method to get a free class by ID
        public FreeClassDTO GetFreeClassById(string idClass)
        {
            return freeClassDAO.GetFreeClassById(idClass); // Call the DAO method to get a free class by ID
        }
    }
}