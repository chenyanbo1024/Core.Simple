using Core.API.Filter;
using Core.Common.Helper;
using Core.Extensions;
using Core.Extensions.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddFilter("System", LogLevel.Error)
               .AddFilter("Microsoft", LogLevel.Error);

builder.Services.AddLogging(x =>
{
    x.AddLog4Net();
});

# region configure services

IConfiguration configuration = builder.Configuration;
builder.Services.AddSingleton(new Appsettings(configuration));

builder.Services.AddControllers(x =>
{
    x.Filters.Add(typeof(GlobalExceptionsFilter));
});
builder.Services.AddEndpointsApiExplorer();

# region 自定义扩展服务
builder.Services.AddAuthenticationService();
builder.Services.AddSwaggerService();
builder.Services.AddEFCoreDbContextService();
builder.Services.AddHttpContextService();
#endregion

DependencyInjection.RegisterServices(builder.Services);

#endregion configure services

var app = builder.Build();

#region configure

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion configure