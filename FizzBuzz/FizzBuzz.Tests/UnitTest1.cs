using FizzBuzz.Game;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        /*
         *  BDD Kuralı
         * 
         *  As a [Role]
         *  I want [Request]
         *  So that [Reason]
         *  
         *  Bir kullanıcı olarak
         *  Ürün aramak istiyorum
         *  Böylece alışveriş yapabilirim
         *  
         *  Given [Context]
         *  When [Action]
         *  Then [Result]
         *  
         *  Given ben bir oyuncu olarak
         *  Given 16GB ramli laptop ihtiyacım olduğunda
         *  When ürün aradığımda
         *  Then Bulunan ürünler listelenir
         *  Then Alışverişe devam edebilirim.
         *  
         *  Ben bir oyuncu olarak
         *  3 Sayısını girdiğimde
         *  Fizz değerini almak istiyorum.
         *  
         * 
         */
        //1. İhtiyaç duyduğunuz nesne ve fonksiyonlar var mı?
        //[Fact]
        //public void It_Exists()
        //{
        //    var board = new FizzBuzz.Game.GameBoard();
        //    string response = board.GetWordOrNumber(6);

        //}

        /*
         *  Ben bir oyuncu olarak
         *  3 Sayısını girdiğimde
         *  Fizz değerini almak istiyorum.
         *  
         */
        [Fact]
        public void Given_3_Then_Fizz()
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();
            var number = 3;
            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("Fizz", response);

        }

        [Fact]
        public void Given_5_Then_Buzz()
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();
            var number = 5;
            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("Buzz", response);

        }

        [Fact]
        public void Given_15_Then_Buzz()
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();
            var number = 15;
            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("FizzBuzz", response);

        }

        [Fact]
        public void Given_Number_Then_String_of_number()
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();
            var number = 4;
            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("4", response);

        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Given_Multiply_3_Then_Fizz(int number)
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();

            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("Fizz", response);

        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void Given_Multiply_5_Then_Buzz(int number)
        {
            /*AAA*/
            //Arrange: Test edeceğiniz nesneyi ve bu fonksiyon parametrelerini hazırlayın:
            var board = new GameBoard();

            //Act: fonksiyonunuzu çağırın:
            var response = board.GetWordOrNumber(number);
            //Assert:
            Assert.Equal("Buzz", response);

        }
    }
}