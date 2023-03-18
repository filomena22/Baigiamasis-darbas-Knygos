using Framework;
using NUnit.Framework;
using Framework.Pages;
using System;
using System.Security.AccessControl;

namespace Tests
{
    internal class RemoveFromCartTest : BaseTest
    {

        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://www.knygos.lt/");

        }

        [Test]
        public void RemoveFromCartItem()
        {
            string expectedText = "Jūsų prekių krepšelis tuščias";

            RemoveFromCart.ClickDovanuKuponaiButton();
            RemoveFromCart.Click20Button();
            RemoveFromCart.ClickIKrepseliButton();
            RemoveFromCart.ClickRecycleButton();

            Assert.AreEqual(expectedText, RemoveFromCart.CartMessageEmpty());
        }
    }
}