using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;

namespace Tests
{
    internal class AddToCartTest : BaseTest
    {

        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://www.knygos.lt/");

        }

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