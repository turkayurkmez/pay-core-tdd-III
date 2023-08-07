using eshop.API.Controllers;
using Microsoft.AspNetCore.Mvc;

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
         * Then -> Ürün adında girdiğim isimdeki ürünler listelenecek.
         * 
         *
         */
        ProductsController productsController;
        public ProductsControllerTests()
        {
            productsController = new ProductsController();
        }

        //[Fact]
        //public void It_Exists()
        //{
        //    var controller = new eshop.API.Controllers.ProductsController();
        //    var response = controller.Search("word");
        //}

        [Fact]
        public void It_Return_Object_Result()
        {
            var response = productsController.Search("name");
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
        }


    }
}