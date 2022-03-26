using Application.Services.PetrolPrices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Application.IntegrationTests.Common
{
    public class IntegrationSetupAndCleanupCode : IDisposable
    {
        public readonly CustomWebApplicationFactory<Program> _webApplicationFactory;
        public IntegrationSetupAndCleanupCode()
        {
            _webApplicationFactory = new CustomWebApplicationFactory<Program>();
        }

        public void Dispose()
        {
            _webApplicationFactory.Dispose();
        }
    }
}
