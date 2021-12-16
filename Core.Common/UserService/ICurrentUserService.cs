using System.Security.Claims;

namespace Core.Common.UserService;

public interface ICurrentUserService
{
    string Name { get; }

    int ID { get; }

    bool IsAuthenticated();

    IEnumerable<Claim> GetClaimsIdentity();

    List<string> GetClaimValueByType(string ClaimType);

    string GetToken();

    List<string> GetUserInfoFromToken(string ClaimType);
}

