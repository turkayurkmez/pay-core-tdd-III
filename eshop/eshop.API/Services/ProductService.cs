namespace eshop.API.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();
            products.Add(new Product { Name = "Dell Laptop" });
            products.Add(new Product { Name = "Kulaklık" });
        }
        public IEnumerable<Product> SearchProductsByName(string productName)
        {


            return products.Where(p => p.Name.Contains(productName, StringComparison.OrdinalIgnoreCase));

        }
    }
}
