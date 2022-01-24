using CleanArchitecture.Application.Services.PetrolPrices;
using CleanArchitecture.Infrastructure.PetrolPrices.Mappings;
using CleanArchitecture.Infrastructure.PetrolPrices.Services;
using JamaicaOpenData.SharedLibrary.Common.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Extensions
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
                config.AddProfile<PetrolPriceDtoMappingProfile>();
            });
            return services;
        }
    }
}
