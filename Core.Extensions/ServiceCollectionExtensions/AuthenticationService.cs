using Core.Common;
using Core.Common.Helper;
using Core.Extensions.Authorizations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Core.Extensions.ServiceCollectionExtensions;

public static class AuthenticationService
{
    /// <summary>
    /// 授权认证服务
    /// </summary>
    public static void AddAuthenticationService(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        //读取配置文件
        var secret = Appsettings.GetValue(new string[] { "TokenManagement", "Secret" });
        var issuer = Appsettings.GetValue(new string[] { "TokenManagement", "Issuer" });
        var audience = Appsettings.GetValue(new string[] { "TokenManagement", "Audience" });
        var accessExpiration = Appsettings.GetValue(new string[] { "TokenManagement", "AccessExpiration" });

        var issuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));

        // 令牌验证参数
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,        // 是否验证发行人的签名密钥
            IssuerSigningKey = issuerSigningKey,    // 发行人签名密钥

            ValidateIssuer = true,                  // 是否验证发行人
            ValidIssuer = issuer,                   // 发行人

            ValidateAudience = true,                // 是否验证订阅人
            ValidAudience = audience,               // 订阅人

            ValidateLifetime = true,                // 是否验证生命周期
            ClockSkew = TimeSpan.Zero,              // 过期的缓存时间

            RequireExpirationTime = true,           // 是否要求过期
        };

        var signingCredentials = new SigningCredentials(issuerSigningKey, SecurityAlgorithms.HmacSha256);
        // 角色与接口的权限要求参数
        var authorizationRequirement = new AuthorizationRequirement(
            "/api/denied",                  // 拒绝授权的跳转地址
            new List<AuthorizationItem>(),  // 角色-Uri 信息凭据
            ClaimTypes.Role,                // 基于角色的授权
            issuer,                         // 发行人
            audience,                       // 订阅人
            signingCredentials,             // 签名凭据
            expiration: TimeSpan.FromSeconds(double.Parse(accessExpiration)));

        services
            .AddAuthorization(x =>
            {
#if (simpleAuthorization)
#elif (roleBased)

                // [Authorize(Role = "Admin")] 或者 [Authorize(Policy = "AdminRole")],都代表 Admin 这个角色有权限
                 x.AddPolicy("AdminRole", policy => policy.RequireRole("Admin"));

                // 通过 [Authorize(Policy = "AdminAndUser")],则代表 Admin、User 这两个角色都有权限 Call
                // x.AddPolicy("AdminAndUser", policy => policy.RequireRole("Admin", "User"));

#elif (policyBased)
                // 通过 [Authorize(Policy = "Permission")], 则代表使用自定义策略，权限校验在 AuthorizationHandler 中进行
                x.AddPolicy("Permission", policy => policy.Requirements.Add(authorizationRequirement));
#endif
            })
            .AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = tokenValidationParameters;

                var jsonSerializerOptions = new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                x.Events = new JwtBearerEvents
                {
                    OnChallenge = context =>
                    {
                        context.HandleResponse();

                        var result = new ApiResult( status: (int)ApiStatus.UNAUTHORIZED, code: (int)ApiCode.UNAUTHORIZED, msg: "未授权或无效令牌");
                        var payload = JsonSerializer.Serialize(result, jsonSerializerOptions);

                        context.Response.ContentType = "application/json";
                        context.Response.StatusCode = StatusCodes.Status200OK;
                        context.Response.WriteAsync(payload);

                        return Task.FromResult(0);
                    },
                    OnForbidden = context =>
                    {
                        var result = new ApiResult(status: (int)ApiStatus.FORBIDDEN, code: (int)ApiCode.FORBIDDEN, msg: "无权限");
                        var payload = JsonSerializer.Serialize(result, jsonSerializerOptions);
                        context.Response.ContentType = "application/json";
                        context.Response.StatusCode = StatusCodes.Status200OK;
                        context.Response.WriteAsync(payload);

                        return Task.FromResult(0);
                    }
                };
            });

#if (policyBased)
        services.AddScoped<IAuthorizationHandler, AuthorizationHandler>();
#endif

        services.AddSingleton(authorizationRequirement);
    }
}
