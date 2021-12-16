using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Filters;

namespace Core.Extensions.ServiceCollectionExtensions;

public static class SwaggerService
{
    /// <summary>
    /// Swagger 配置服务
    /// </summary>
    /// <param name="services"></param>
    public static void AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen(x =>
        {
            x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Version = "v1",
                Title = "CORE SIMPLE 接口文档",
            });
            x.OrderActionsBy(x => x.RelativePath);

            var basePath = AppContext.BaseDirectory;

            var xmlApiPath = Path.Combine(basePath, "Core.API.xml");
            var xmlModelPath = Path.Combine(basePath, "Core.Models.xml");

            x.IncludeXmlComments(xmlApiPath, true);
            x.IncludeXmlComments(xmlModelPath, true);
            
            // 开启加权小锁
            x.OperationFilter<AddResponseHeadersFilter>();
            x.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

            // header 中添加 token
            x.OperationFilter<SecurityRequirementsOperationFilter>();

            // 将 token 验证添加至 Swagger 中
            x.AddSecurityDefinition("oauth2", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Description = "输入 Bearer <token>; 例如：Bearer XXXXX",
                Name = "Authorization",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
            });
        });
    }
}
