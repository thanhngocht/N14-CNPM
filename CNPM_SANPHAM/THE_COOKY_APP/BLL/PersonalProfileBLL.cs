using THE_COOKY_APP.DAO;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.BLL
{
    internal class PersonalProfileBLL
    {
        private PersonalProfileDAO personalProfileDAO = new PersonalProfileDAO();

        public PersonalProfileDTO GetProfileById(string profileId)
        {
            return personalProfileDAO.GetProfileById(profileId);
        }

        public void AddProfile(string cccd, DateTime dateOfBirth, string address, string nativePlace, string idAccount, string idChef)
        {
            // Có thể thêm logic kiểm tra trước khi thêm
           personalProfileDAO.AddProfile(cccd, dateOfBirth, address, nativePlace, idAccount, idChef);
        }

        public void UpdateProfile(PersonalProfileDTO profile)
        {
            // Có thể thêm logic kiểm tra trước khi cập nhật
            personalProfileDAO.UpdateProfile(profile);
        }

        public void DeleteProfile(string profileId)
        {
            // Có thể thêm logic kiểm tra trước khi xóa
            personalProfileDAO.DeleteProfile(profileId);
        }

        public PersonalProfileDTO GetProfileByAccountId(string accountId)
        {
            return personalProfileDAO.GetProfileByAccountId(accountId);
        }

        public PersonalProfileDTO GetProfileByChefId(string chefId)
        {
            return personalProfileDAO.GetProfileByChefId(chefId);
        }
    }
}