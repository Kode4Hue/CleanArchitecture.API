using Application.Services.PetrolPrices;
using Infrastructure.PetrolPrices.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.IO;

namespace Application.IntegrationTests.Common
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {

        // private static IServiceScopeFactory _scopeFactory;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddEnvironmentVariables()
                    .Build();

                builder.UseConfiguration(configuration);

                services.AddSingleton(Mock.Of<IWebHostEnvironment>(w =>
                    w.EnvironmentName == "Development" &&
                    w.ApplicationName == "API.Presentation"));

                services.AddLogging();
                services.AddTransient<IPetrolPriceService, PetrolPriceService>();

                var serviceProvider = services.BuildServiceProvider();

                using (var scope = serviceProvider.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;

                    //database creation, migration, etc
                }
            });
        }
    }
}
