using AuthenticationPack.Models;

namespace AuthenticationPack.Contracts;

public interface IUserManagement<T> {

    Task<T> GetByUserNameAsync(string userName);
    Task SaveAndCreateUser(User user);
    Task<T> GetByUserId(string userId);
    Task<IEnumerable<T>> GetAllAsync();
    Task RegisterUser(T user);

}
