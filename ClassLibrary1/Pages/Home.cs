namespace Framework.Pages
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
