using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using Core.Models.DTOs.Response;

namespace Core.Extensions.Authorizations;

public class TokenHelper
{
    /// <summary>
    /// 颁发 Json Web Token
    /// </summary>
    /// <param name="claims"></param>
    /// <param name="authorizationRequirement"></param>
    /// <returns></returns>
    public static TokenInfoResponse BuildJwtToken(Claim[] claims, AuthorizationRequirement authorizationRequirement)
    {
        var now = DateTime.Now;

        var jwt = new JwtSecurityToken(
            issuer: authorizationRequirement.Issuer,
            audience: authorizationRequirement.Audience,
            claims: claims,
            notBefore: now,
            expires: now.Add(authorizationRequirement.Expiration),
            signingCredentials: authorizationRequirement.SigningCredentials
        );

        var token = new JwtSecurityTokenHandler().WriteToken(jwt);

        var responseJson = new TokenInfoResponse
        {
            Success = true,
            Token = token,
            ExpiresIn = authorizationRequirement.Expiration.TotalSeconds,
            TokenType = "Bearer"
        };

        return responseJson;
    }
}

