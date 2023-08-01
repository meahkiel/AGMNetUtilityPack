using AuthenticationPack.Models;

namespace AuthenticationPack.Contracts;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
