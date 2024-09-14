using Email.Interfaces;
using Email.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Email.Startup
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEmailEncryption(this IServiceCollection services)
        {
            services.AddScoped<IDataSecurerHelper, Base64DataSecurerHelper>();
            services.AddScoped<SendEmail>();
            return services;
        }
    }
}
