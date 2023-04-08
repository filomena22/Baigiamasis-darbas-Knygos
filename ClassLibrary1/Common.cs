using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework
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

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void ScrollBy(int x, int y)
        {
            Driver.GetDriver().ExecuteJavaScript($"window.scrollBy({x}, {y})");
        }

        internal static void ScrollAndClickElement(string locator)
        {
            int maxTries = 10;
            int currentTry = 0;

            while (currentTry < maxTries)
            {
                try
                {
                    ClickElement(locator);
                    break;
                }
                catch (ElementClickInterceptedException)
                {
                    ScrollBy(0, 50);
                    currentTry++;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        internal static string GetCurrentWindowHandle()
        {
            return Driver.GetDriver().CurrentWindowHandle;
        }

        internal static void SwitchToNewTabFromParentTab(string parentWindowHandle)
        {
            List<string> windowHandles = Driver.GetDriver().WindowHandles.ToList();

            foreach (string windowHandle in windowHandles)
            {
                if (windowHandle != parentWindowHandle)
                {
                    Driver.GetDriver().SwitchTo().Window(windowHandle);
                }
            }
        }
    }
}