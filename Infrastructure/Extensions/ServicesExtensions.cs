using Application.Services.PetrolPrices;
using Infrastructure.PetrolPrices.Services;
using JamaicaOpenData.SharedLibrary.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddMappingProfiles();
            services.RegisterJamaicaOpenDataServices();
            services.AddTransient<IPetrolPriceService, PetrolPriceService>();
            return services;
        }

        private static IServiceCollection AddMappingProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.AddMaps(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
