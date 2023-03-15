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
        public void RegisterFormWithValidData()
        {
            string expectedResult = "https://www.knygos.lt/";
            string valueElPastoAdresas = "testerknygos@gmail.com";
            string valueSlaptazodis = "tester@22";

            RemoveFromCart.ClickDovanuKuponaiButton();
            RemoveFromCart.Click20Button();
            RemoveFromCart.ClickIKrepseliButton();
            RemoveFromCart.ClickRecycleButton();

            Assert.AreEqual(expectedResult, Login.GetRedirectedUrl());
        }
    }
}