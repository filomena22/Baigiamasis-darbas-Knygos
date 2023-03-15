using Framework;
using NUnit.Framework;
using Framework.Pages;
using System;
using System.Security.AccessControl;

namespace Tests
{
    internal class CopyCodeTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://www.knygos.lt/");

        }

        [Test]
        public void CopyCodeFromDiscount()
        {
            string expectedResult = "LIUKS10";
        

            CopyCode.ClickButtonNuolaiduKuponai();
            CopyCode.ClickButtonKopijuotiKoda();
            CopyCode.ClickEnterCode();
            Assert.AreEqual(expectedResult, CopyCode.Liuks10());

        }
    }
}


