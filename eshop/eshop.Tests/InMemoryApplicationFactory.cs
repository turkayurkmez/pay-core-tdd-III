using eshop.API;
using eshop.API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace eshop.Tests
{
    public class InMemoryApplicationFactory<T> : WebApplicationFactory<T> where T : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Testing")
                   .ConfigureTestServices(services =>
                   {
                       Mock<IProductService> mockService = new Mock<IProductService>();
                       mockService.Setup(ps => ps.SearchProductsByName(It.IsAny<string>())).Returns(
                           new List<Product>()  {
                              new(){ Name="Asus laptop"},
                              new(){ Name="Dell laptop"},

                           });

                       services.AddScoped(mockService.Object.GetType());


                   });
        }
    }
}
