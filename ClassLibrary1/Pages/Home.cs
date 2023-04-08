using Framework.Pages;

namespace ClassLibrary1.Pages
{
    public class Home
    {
        public static void CloseCookies()
        {
            Common.WaitForElementToBeVisible(Locators.Home.buttonRejectCookies);
            Common.ClickElement(Locators.Home.buttonRejectCookies);
        }
    }
}
