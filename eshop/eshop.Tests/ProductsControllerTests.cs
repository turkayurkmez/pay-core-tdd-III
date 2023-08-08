using eshop.API;
using eshop.API.Controllers;
using eshop.API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace eshop.Tests
{
    public class ProductsControllerTests
    {
        /*
         * Bir müşteri olarak
         * Uygun ürünleri aramak istiyorum 
         * Böylece ürünleri görebilir ve sepete ekleyebilirim.
         * 
         * Given -> Bir ürün adı girdiğimde
         * When -> Ürün arama işlemini başlattığımda
         * Then -> Bulunan ürünler listelenecek.
         * 
         *
         */
        ProductsController productsController;
        public ProductsControllerTests()
        {
            //Production'da kullanılacak olan bir dependency objeyi burada kullanmak çok maliyetli. 
            //  ProductService productService = new ProductService();
            //Bunun yerine 'mış gibi' yapan mock obje eklenir:
            Mock<IProductService> mockProductService = new Mock<IProductService>();
            mockProductService.Setup(ps => ps.SearchProductsByName(It.IsAny<string>())).Returns(new List<Product>()
            {
                new(){ Name="Asus laptop"}
            });
            productsController = new ProductsController(mockProductService.Object);
        }

        //[Fact]
        //public void It_Exists()
        //{
        //    var controller = new eshop.API.Controllers.ProductsController();
        //    var response = controller.Search("word");
        //}

        [Fact]
        public void Search_Action_Return_Object_Result()
        {
            var response = productsController.Search("name");
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public void Search_Action_Return_Product_Collection()
        {
            var response = productsController.Search("name") as OkObjectResult;
            Assert.NotNull(response.Value);
            Assert.IsAssignableFrom<IEnumerable<Product>>(response.Value);

        }


        [Fact]
        public void Search_Action_Return_Product_List_Including_Name()
        {

            string laptop = "Laptop";
            var response = (IEnumerable<Product>)(productsController.Search("Laptop") as OkObjectResult).Value;
            Assert.True(response.Count() > 0, "Koleksiyon boş");
            Assert.True(response.First().Name.ToLower().Contains(laptop.ToLower()), "ilk eleman, laptop içermiyor");



        }




    }
}