using AuthenticationPack.Commons;

namespace AuthenticationPack.Contracts
{
    public interface IAuthManagement {
        Task<AuthResult?> Login(string username, string password);
        Task<AuthResult?> ValidateThruPortal(string username);
    }
}
