using AuthenticationPack.Commons;
using AuthenticationPack.Contracts;

namespace AuthenticationPack.Services;

public class AuthManagement : IAuthManagement
{
    private readonly UserManagement _management;
    
    private readonly IAuthContext _context;
    private readonly IJwtTokenGenerator _jwt;
    

    public AuthManagement(
        UserManagement management,
        IAuthContext context,
        IJwtTokenGenerator jwt,
        IMenuManagement menuManagement)
    {
        _management = management;

        _context = context;
        _jwt = jwt;
        
    }

    public virtual async Task<AuthResult?> Login(string username, string password)
    {
        var user = await _management.GetByUserNameAsync(username);

        if (user is not null)
        {

            if (user.Password == SimpleEncode.EncodePassword(password))
            {
                var authResult = new AuthResult
                {
                    EmpCode = user.UserName,
                    EmpName = user.FullName,
                    Token = _jwt.GenerateToken(user),
                };

                return authResult;
            }
        }

        return null;
    }

    public Task<AuthResult?> ValidateThruPortal(string username)
    {
        throw new NotImplementedException();
    }
}
