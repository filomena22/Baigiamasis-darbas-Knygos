using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Dovanu kuponas";

            AddToCart.ClickDovanuKuponaiButton();
            AddToCart.Click10Button();
            AddToCart.ClickIKrepseliButton();

            Assert.AreEqual(expectedResult, AddToCart.CartMessage());
        }
    }
}