using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO;

namespace THE_COOKY_APP.BLL
{
    internal class ChefBLL
    {
        private ChefDAO chefDAO = new ChefDAO(); // Create an instance of the ChefDAO

        // Method to get all chefs
        public List<ChefDTO> GetAllChefs()
        {
            return chefDAO.GetAllChefs(); // Call the DAO method to get all chefs
        }

        // Method to add a new chef
        public void AddChef(string phoneNumber, string fullName, DateTime startDate, string gmail, bool isActive)
        {
            chefDAO.AddChef(phoneNumber, fullName, startDate, gmail, isActive); // Call the DAO method to add a chef
        }

        // Method to update an existing chef
        public void UpdateChef(ChefDTO chef)
        {
            chefDAO.UpdateChef(chef); // Call the DAO method to update a chef
        }

        // Method to delete a chef
        public void DeleteChef(string chefId)
        {
            chefDAO.DeleteChef(chefId); // Call the DAO method to delete a chef
        }

        // Method to get chef ID by full name

        public string GetChefIdByName(string fullName)
        {
            return chefDAO.GetChefIdByName(fullName); // Call the DAO method to get chef ID by name
        }

        // Method to search chefs by full name
        public List<ChefDTO> SearchChefs(string searchTerm, string property)
        {
            return chefDAO.SearchChefs(searchTerm, property); // Call the DAO method to search chefs
        }

        public ChefDTO GetChefById(string idChef)
        {
            return chefDAO.GetChefById(idChef);
        }

        public ChefDTO FindChef(string phoneNumber, string fullName, DateTime startDate, string gmailChef, bool isActive)
        {
            return chefDAO.FindChef(phoneNumber, fullName, startDate, gmailChef, isActive);
        }
    }
}