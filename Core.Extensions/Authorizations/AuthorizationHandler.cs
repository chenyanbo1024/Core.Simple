using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using System.Net.Http;
using System.Security.Claims;

namespace Core.Extensions.Authorizations;

public class AuthorizationHandler : AuthorizationHandler<AuthorizationRequirement>
{
    public IAuthenticationSchemeProvider Schemes { get; set; }
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthorizationHandler(
        IAuthenticationSchemeProvider schmes,
        IHttpContextAccessor httpContextAccessor)
    {
        Schemes = schmes;
        _httpContextAccessor = httpContextAccessor;
    }

    protected async override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizationRequirement requirement)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext == null)
        {
            context.Fail();
            return;
        }
        //请求Url
        var requestUrl = httpContext.Request.Path.Value?.ToLower() ?? "";
        //判断请求是否停止
        var handlers = httpContext.RequestServices.GetRequiredService<IAuthenticationHandlerProvider>();

        foreach (var scheme in await Schemes.GetRequestHandlerSchemesAsync())
        {
            if (await handlers.GetHandlerAsync(httpContext, scheme.Name) is IAuthenticationRequestHandler handler
                && await handler.HandleRequestAsync())
            {
                context.Fail();
                return;
            }
        }

        //判断请求是否拥有凭据，即有没有登录
        var defaultAuthenticate = await Schemes.GetDefaultAuthenticateSchemeAsync();
        if (defaultAuthenticate != null)
        {
            var result = await httpContext.AuthenticateAsync(defaultAuthenticate.Name);
            //result?.Principal不为空即登录成功
            if (result?.Principal != null)
            {
                httpContext.User = result.Principal;

                // token 是否仍有效校验
                var expirationTime = Convert.ToDateTime(httpContext.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Expiration)?.Value);
                if (expirationTime < DateTime.Now)
                {
                    context.Fail();
                    return;
                }

                // 权限校验：从数据库中获取权限与当前请求进行校验
                // coding
                if (false)
                {
                    context.Fail();
                    return;
                }
            }
        }

        //判断没有登录时，是否访问登录的url，并且是POST请求，并且是form表单提交类型，否则为失败
        if (!requestUrl.Equals(requirement.LoginPath.ToLower(), StringComparison.Ordinal)
            && (!httpContext.Request.Method.Equals("POST")
            || !httpContext.Request.HasFormContentType))
        {
            context.Fail();
            return;
        }
        context.Succeed(requirement);
        return;
    }
}
