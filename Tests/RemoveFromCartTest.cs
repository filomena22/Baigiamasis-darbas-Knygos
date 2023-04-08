﻿using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class RemoveFromCartTest : BaseTest
    {
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