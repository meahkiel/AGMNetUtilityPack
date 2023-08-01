using AuthenticationPack.Contracts;
using AuthenticationPack.Models;

namespace AuthenticationPack.Services
{
    public class UserManagement : IUserManagement<User>
    {
        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task SaveAndCreateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
