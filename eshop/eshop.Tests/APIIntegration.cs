using eshop.API;
using System.Net;
using System.Net.Http.Json;

namespace eshop.Tests
{
    public class APIIntegration : IClassFixture<InMemoryApplicationFactory<Program>>
    {
        private readonly InMemoryApplicationFactory<Program> _applicationFactory;

        public APIIntegration(InMemoryApplicationFactory<Program> applicationFactory)
        {
            _applicationFactory = applicationFactory;
        }
        [Fact]
        public async Task Search_Products()
        {
            var client = _applicationFactory.CreateClient();
            var response = await client.GetAsync("api/products/laptop");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);


        }

        [Fact]
        public async Task Create_Product()
        {
            var client = _applicationFactory.CreateClient();
            Product product = new Product() { Name = "Test" };
            var response = await client.PostAsJsonAsync("api/products", product);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);


        }
    }
}
