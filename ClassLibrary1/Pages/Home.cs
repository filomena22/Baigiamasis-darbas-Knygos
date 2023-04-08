namespace Framework.Pages
{
    public class Home
    {
        public static void CloseCookies()
        {
            Common.WaitForElementToBeVisible(Locators.Home.buttonRejectCookies);
            Common.ClickElement(Locators.Home.buttonRejectCookies);
        }

        public static void OpenVisosKnygosMeniu()
        {
            Common.ClickElement(Locators.Home.buttonVisosKnygosMeniu);
        }

        public static class VisosKnygosMeniu
        {
            public static void ClickDovanuKuponaiButton()
            {
                Common.ClickElement(Locators.Home.VisosKnygosMeniu.buttonDovanuKuponai);
            }
        }
    }
}
