using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class LocationBLL
    {
        private LocationDAO locationDAO = new LocationDAO(); // Create an instance of the LocationDAO

        // Method to get all locations
        public List<LocationDTO> GetAllLocations()
        {
            return locationDAO.GetAllLocations(); // Call the DAO method to get all locations
        }

        // Method to add a new location
        public void AddLocation(string nameLocation, string address, string description, int maxLocationQuantity, bool isActive)
        {
            locationDAO.AddLocation(nameLocation, address, description, maxLocationQuantity, isActive); // Call the DAO method to add a location
        }

        // Method to update an existing location
        public void UpdateLocation(LocationDTO location)
        {
            locationDAO.UpdateLocation(location); // Call the DAO method to update a location
        }

        // Method to delete a location
        public void DeleteLocation(string idLocation)
        {
            locationDAO.DeleteLocation(idLocation); // Call the DAO method to delete a location
        }

        // Method to get a location ID by name
        public string GetLocationIdByName(string nameLocation)
        {
            return locationDAO.GetLocationIdByName(nameLocation); // Call the DAO method to get location ID by name
        }

        // Method to search locations by name
        public List<LocationDTO> SearchLocations(string searchTerm, string property)
        {
            return locationDAO.SearchLocations(searchTerm, property); // Call the DAO method to search locations
        }

        public int CountClassroomsByLocation(string idLocation)
        {
            return locationDAO.CountClassroomsByLocation(idLocation);
        }

        public LocationDTO GetLocationById(string locationId)
        {
            return locationDAO.GetLocationById(locationId);
        }

        public bool IsLocationNameExists(string locationName)
        {
            return locationDAO.IsLocationNameExists(locationName);
        }

        public List<LocationDTO> GetAllNameLocations()
        {
            return locationDAO.GetAllNameLocations();
        }
    }
}