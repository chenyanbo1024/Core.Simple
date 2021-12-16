using Core.Common.Helper;
using Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions.ServiceCollectionExtensions
{
    public static class EFCoreService
    {
        public static void AddEFCoreDbContextService(this IServiceCollection services)
        {
            var connetionString = string.Empty;
#if (MySQL)
            connetionString = Appsettings.GetValue(new string[] { "ConnectionStrings", "MySql" });
#elif (SQLServer)
            connetionString = Appsettings.GetValue(new string[] { "ConnectionStrings", "SqlServer" });
#endif
            if (string.IsNullOrEmpty(connetionString))
            {
                throw new ArgumentNullException(
                    paramName: "ConnectionStrings:Default", 
                    message: "appsettings.json can not read connection string,please check the config file");
            }
#if (MySQL)
            services.AddDbContext<CoreContext>(
                options => options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString)));
#elif (SQLServer)
            services.AddDbContext<CoreContext>(
                options => options.UseSqlServer(connetionString, sqlServerOptionsAction: null));
#endif
        }
    }
}