using Core.Common;
using Core.Extensions.Authorizations;
using Core.Models.DTOs.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core.API.Controllers;

/// <summary>
/// Home 模块
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class HomeController : BaseController
{
    private readonly AuthorizationRequirement _requirement;
    public HomeController(AuthorizationRequirement requirement)
    {
        _requirement = requirement;
    }

    /// <summary>
    /// 接口授权
    /// </summary>
    /// <param name="request">请求报文</param>
    [HttpPost("auth")]
    public async Task<ApiResult> Auth([FromBody]LoginRequest request)
    {
        if (!request.Name.Equals("admin") || !request.Password.Equals("123456"))
        {
            return INVALID_REQUEST(msg: "用户名或密码错误");
        }

        // 时间戳
        var dateTime1970 = new DateTime(1970, 1, 1).ToLocalTime();
        var timeStamp = (long)(DateTime.Now.AddSeconds(_requirement.Expiration.TotalSeconds) - dateTime1970).TotalMilliseconds;

        var claims = new List<Claim> {
            new Claim(ClaimTypes.Name, request.Name),
            new Claim(JwtRegisteredClaimNames.Jti, "1"),
            new Claim(ClaimTypes.Expiration, timeStamp.ToString()),
            new Claim(ClaimTypes.Role,"Admin"),
        };
        var token = TokenHelper.BuildJwtToken(claims.ToArray(), _requirement);

        return SUCCESS(msg: "登录成功",data: token);
    }
}
