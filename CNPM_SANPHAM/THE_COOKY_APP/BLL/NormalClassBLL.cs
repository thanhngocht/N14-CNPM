using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class NormalClassBLL
    {
        private NormalClassDAO normalClassDAO = new NormalClassDAO(); // Create an instance of the NormalClassDAO

        // Method to get all normal classes
        public List<NormalClassDTO> GetAllNormalClasses()
        {
            return normalClassDAO.GetAllNormalClasses(); // Call the DAO method to get all normal classes
        }

        // Method to add a new normal class
        public void AddNormalClass(NormalClassDTO normalClass)
        {
            normalClassDAO.AddNormalClass(normalClass); // Call the DAO method to add a normal class
        }

        // Method to update an existing normal class
        public void UpdateNormalClass(NormalClassDTO normalClass)
        {
            normalClassDAO.UpdateNormalClass(normalClass); // Call the DAO method to update a normal class
        }

        // Method to delete a normal class
        public void DeleteNormalClass(string idClass)
        {
            normalClassDAO.DeleteNormalClass(idClass); // Call the DAO method to delete a normal class
        }

        // Method to get a normal class by ID
        public NormalClassDTO GetNormalClassById(string idClass)
        {
            return normalClassDAO.GetNormalClassById(idClass); // Call the DAO method to get a normal class by ID
        }
    }
}