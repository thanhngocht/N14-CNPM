using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO; // Ensure you have the correct namespace for your DAO

namespace THE_COOKY_APP.BLL
{
    internal class RoleBLL
    {
        private RoleDAO roleDAO = new RoleDAO(); // Create an instance of the RoleDAO

        // Method to get all roles
        public List<RoleDTO> GetAllRoles()
        {
            return roleDAO.GetAllRoles(); // Call the DAO method to get all roles
        }

        // Method to add a new role
        public void AddRole(RoleDTO role)
        {
            roleDAO.AddRole(role); // Call the DAO method to add a role
        }

        // Method to update an existing role
        public void UpdateRole(RoleDTO role)
        {
            roleDAO.UpdateRole(role); // Call the DAO method to update a role
        }

        // Method to delete a role
        public void DeleteRole(string idRole)
        {
            roleDAO.DeleteRole(idRole); // Call the DAO method to delete a role
        }

        // Method to get a role by ID
        public RoleDTO GetRoleById(string idRole)
        {
            return roleDAO.GetRoleById(idRole); // Call the DAO method to get a role by ID
        }

        public RoleDTO GetRoleByNameRole(string nameRole)
        {
            return roleDAO.GetRoleByNameRole(nameRole);
        }
    }
}