using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO;

namespace THE_COOKY_APP.BLL
{
    internal class AccountBLL
    {
        private AccountDAO accountDAO = new AccountDAO(); 

        // Method to get all accounts
        public List<AccountDTO> GetAllAccounts()
        {
            return accountDAO.GetAllAccounts(); // Call the DAL method to get all accounts
        }

        // Method to add a new account
        public void AddAccount(string gmail, string phoneNumber, string fullName, string username, string password)
        {
            accountDAO.AddAccount(gmail, phoneNumber, fullName, username, password);
        }

        // Method to update an existing account
        public void UpdateAccount(AccountDTO account)
        {
            accountDAO.UpdateAccount(account); // Call the DAL method to update an account
        }

        // Method to delete an account
        public void DeleteAccount(string idAccount)
        {
            accountDAO.DeleteAccount(idAccount); // Call the DAL method to delete an account
        }

        // Method to get account ID by full name
        public int? GetAccountIdByName(string fullName)
        {
            return accountDAO.GetAccountIdByName(fullName); // Call the DAL method to get account ID by name
        }

        // Method to search accounts by full name
        public List<AccountDTO> SearchAccounts(string searchTerm, string property)
        {
            return accountDAO.SearchAccounts(searchTerm, property); // Call the DAL method to search accounts
        }

        // Method to get an account by ID
        public AccountDTO GetAccountById(string idAccount)
        {
            return accountDAO.GetAccountById(idAccount); // Call the DAL method to get an account by ID
        }

        public AccountDTO FindAccount(string username, string password)
        {
            return accountDAO.FindAccount(username, password);
        }

        public void LockAccount(string username)
        {
            accountDAO.LockAccount(username);
        }


        public string Login(string username, string password)
        {
            string accountId = accountDAO.Login(username, password);

            return accountId;


        }
        public int LoadFailedAttempts(string username)
        {
            int attempts = accountDAO.LoadFailedAttempts(username);
            return attempts;
        }

        public bool IsUsernameExists(string username)
        {
            return accountDAO.IsUsernameExists(username);
        }

        public bool CheckIsLoggedIn(string username)
        {
            return accountDAO.CheckIsLoggedIn(username);
        }

        public AccountDTO GetAccountByEmail(string username, string email)
        {
            return accountDAO.GetAccountByEmail(username, email);
        }

        public void Logout(string username)
        {
            accountDAO.Logout(username);
        }

        public void SetIsLoggedIn(string username, bool status)
        {
            accountDAO.SetIsLoggedIn(username, status);
        }
    }
}
