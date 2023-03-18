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
            Common.ClickElement(Locators.RemoveFromCart.button20);
        }

        public static void ClickIKrepseliButton()
        {
            Common.ClickElement(Locators.RemoveFromCart.buttonIKrepseli);
        }

        public static void ClickRecycleButton()
        {
            Common.ClickElement(Locators.RemoveFromCart.buttonRecycle);
        }

        public static string CartMessageEmpty()
        {
            return Common.GetElementText(Locators.RemoveFromCart.cartmessage);

        }
        public static string GetRedirectedUrl()
        {
            return Driver.GetDriver().Url;
        }
    }
}
