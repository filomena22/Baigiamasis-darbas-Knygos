using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(object inputSlaptazodis, string valueSlaptazodis)
        {
            throw new NotImplementedException();
        }

        internal static void ClickElement(object buttonPrisijungti)
        {
            throw new NotImplementedException();
        }

        internal static void ClickElement(object buttonCheckBox1)
        {
            throw new NotImplementedException();
        }

        internal static void ClickElement(object dovanuKuponaiButton)
        {
            throw new NotImplementedException();
        }
    }

}
