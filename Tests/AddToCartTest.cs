using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Knygos.lt dovanų kuponas (atsispausdink pats)";

            Home.OpenVisosKnygosMeniu();
            Home.VisosKnygosMeniu.ClickDovanuKuponaiButton();
            AddToCart.Click10Button();
            AddToCart.ClickIKrepseliButton();

            Assert.AreEqual(expectedResult, AddToCart.CartMessage());
        }
    }
}