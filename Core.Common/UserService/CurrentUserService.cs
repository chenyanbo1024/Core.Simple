using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace Core.Common.UserService;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _accessor;
    public CurrentUserService(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public string Name => throw new NotImplementedException();

    public int ID => throw new NotImplementedException();

    public IEnumerable<Claim> GetClaimsIdentity()
    {
        throw new NotImplementedException();
    }

    public List<string> GetClaimValueByType(string ClaimType)
    {
        throw new NotImplementedException();
    }

    public string GetToken()
    {
        throw new NotImplementedException();
    }

    public List<string> GetUserInfoFromToken(string ClaimType)
    {
        throw new NotImplementedException();
    }

    public bool IsAuthenticated()
    {
        throw new NotImplementedException();
    }
}

