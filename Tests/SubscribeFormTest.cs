﻿using NUnit.Framework;
using Framework.Pages;

namespace Tests
{
    internal class SubscribeFormTest : BaseTest
    {
        [Test]
        public void SubscribeFormWithValidData()
        {
            string expectedText = "Beveik baigta...";
            string valueElPastoAdresas = "testerknygos@gmail.com";

            SubscribeForm.InputElPastoAdresas(valueElPastoAdresas);
            SubscribeForm.ClickButtonCheckBox1();
            SubscribeForm.ClickButtonCheckBox2();
            string parentWindowHandle = SubscribeForm.ClickButtonPrenumeruoti();

            Assert.AreEqual(expectedText, SubscribeForm.SubscribeMessage(parentWindowHandle));
        }
    }
}