using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;

namespace Tests
{
    internal class AddToCart : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://www.knygos.lt/");
            
        }

        [Test]
        public void AddProductToCart()
        {
            string expectedResult = "Iš viso 10";

            AddToCart.ClickDovanuKuponaiButton();
            AddToCart.Click10Button();
            AddToCart.ClickIKrepseliButton();
            
           


        }

        private static void ClickIKrepseliButton()
        {
            throw new NotImplementedException();
        }

        private static void Click10Button()
        {
            throw new NotImplementedException();
        }

        private static void ClickDovanuKuponaiButton()
        {
            throw new NotImplementedException();
        }
    }
}