using Framework;
using NUnit.Framework;
using Framework.Pages;
using System;
using System.Security.AccessControl;

namespace Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void LoginFormWithValidData()
        {
            string expectedResult = "https://www.knygos.lt/";
            string valueElPastoAdresas = "testerknygos@gmail.com";
            string valueSlaptazodis = "tester@22";

            Login.ClickButtonPrisijungtiRegistruotis();
            Login.InputElPastoAdresas(valueElPastoAdresas);
            Login.InputSlaptazodis(valueSlaptazodis);
            Login.ClickButtonPrisijungti();
            Assert.AreEqual(expectedResult, Login.GetRedirectedUrl());
        }
    }
}

