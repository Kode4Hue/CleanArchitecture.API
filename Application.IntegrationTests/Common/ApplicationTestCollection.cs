using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Application.IntegrationTests.Common
{

    [Collection(TestKeys.OneTimeApplicationSetupAndCleanup)]
    public class ApplicationTestCollection : ICollectionFixture<IntegrationSetupAndCleanupCode>
    {
    }
}
