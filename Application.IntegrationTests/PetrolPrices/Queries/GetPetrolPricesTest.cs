using Application.IntegrationTests.Common;
using Application.Services.PetrolPrices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Application.IntegrationTests.PetrolPrices.Queries
{

    [Collection(TestKeys.OneTimeApplicationSetupAndCleanup)]
    public class GetPetrolPricesTest: IClassFixture<IntegrationSetupAndCleanupCode>
    {
        private IPetrolPriceService _petrolPriceService;

        public GetPetrolPricesTest(IntegrationSetupAndCleanupCode fixture)
        {
            var _setup = fixture ?? throw new ArgumentNullException(nameof(fixture));
            _petrolPriceService = _setup._webApplicationFactory.Services.GetRequiredService<IPetrolPriceService>();
        }

        [Fact]
        public async Task ShouldGetPetrolPricesAsync()
        {
            //Arrange

            //Act
            var result = await _petrolPriceService.GetPetrolPrices(10, 1);

            //Assert
            Assert.True(result.TotalCount > 0);
            //Cleanup
        }
    }
}
