using Core.IServices;
using Core.Services;

using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
        }
    }
}
