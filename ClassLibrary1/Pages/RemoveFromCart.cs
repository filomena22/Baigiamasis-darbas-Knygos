namespace Framework.Pages
{
    public class RemoveFromCart
    {
        
        public static void ClickDovanuKuponaiButton()
        {
            Common.ClickElement(Locators.RemoveFromCart.DovanuKuponaiButton);
        }

        public static void Click20Button()
        {
            Common.ClickElement(Locators.RemoveFromCart.buttonPrisijungti);
        }

        public static void ClickIKrepseliButton()
        {
            Common.ClickElement(Locators.RemoveFromCart.buttonPrisijungti);
        }

        public static void ClickRecycleButton()
        {
            Common.ClickElement(Locators.RemoveFromCart.buttonPrisijungti);
        }
        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
